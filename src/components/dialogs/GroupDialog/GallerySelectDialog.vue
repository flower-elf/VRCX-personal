<template>
    <safe-dialog
        class="x-dialog"
        :visible.sync="gallerySelectDialog.visible"
        :title="t('dialog.gallery_select.header')"
        width="100%"
        append-to-body>
        <div>
            <span>{{ t('dialog.gallery_select.gallery') }}</span>
            <span style="color: #909399; font-size: 12px; margin-left: 5px">{{ galleryTable.length }}/64</span>
            <br />
            <input
                id="GalleryUploadButton"
                type="file"
                accept="image/*"
                style="display: none"
                @change="onFileChangeGallery" />
            <el-button-group>
                <el-button type="default" size="small" icon="el-icon-close" @click="selectImageGallerySelect('', '')">{{
                    t('dialog.gallery_select.none')
                }}</el-button>
                <el-button type="default" size="small" icon="el-icon-refresh" @click="refreshGalleryTable">{{
                    t('dialog.gallery_select.refresh')
                }}</el-button>
                <el-button
                    type="default"
                    size="small"
                    icon="el-icon-upload2"
                    :disabled="!currentUser.$isVRCPlus"
                    @click="displayGalleryUpload"
                    >{{ t('dialog.gallery_select.upload') }}</el-button
                >
            </el-button-group>
            <br />
            <div
                v-for="image in galleryTable"
                :key="image.id"
                class="x-friend-item"
                style="display: inline-block; margin-top: 10px; width: unset; cursor: default">
                <template v-if="image.versions && image.versions.length > 0">
                    <div
                        v-if="image.versions[image.versions.length - 1].file.url"
                        class="vrcplus-icon"
                        @click="selectImageGallerySelect(image.versions[image.versions.length - 1].file.url, image.id)">
                        <img v-lazy="image.versions[image.versions.length - 1].file.url" class="avatar" /></div
                ></template>
            </div>
        </div>
    </safe-dialog>
</template>

<script setup>
    import { storeToRefs } from 'pinia';
    import { getCurrentInstance } from 'vue';
    import { useI18n } from 'vue-i18n-bridge';
    import { vrcPlusImageRequest } from '../../../api';
    import { useGalleryStore, useUserStore } from '../../../stores';

    const { t } = useI18n();

    const { proxy } = getCurrentInstance();
    const { $message } = proxy;
    const { galleryTable } = storeToRefs(useGalleryStore());
    const { refreshGalleryTable, handleGalleryImageAdd } = useGalleryStore();
    const { currentUser } = storeToRefs(useUserStore());

    const props = defineProps({
        gallerySelectDialog: {
            type: Object,
            required: true
        }
    });

    function selectImageGallerySelect(imageUrl, fileId) {
        const D = props.gallerySelectDialog;
        D.selectedFileId = fileId;
        D.selectedImageUrl = imageUrl;
        D.visible = false;
    }

    function displayGalleryUpload() {
        document.getElementById('GalleryUploadButton').click();
    }

    function onFileChangeGallery(e) {
        const clearFile = function () {
            const fileInput = /** @type{HTMLInputElement} */ (document.querySelector('#GalleryUploadButton'));
            if (fileInput) {
                fileInput.value = '';
            }
        };
        const files = e.target.files || e.dataTransfer.files;
        if (!files.length) {
            return;
        }
        if (files[0].size >= 100000000) {
            // 100MB
            $message({
                message: t('message.file.too_large'),
                type: 'error'
            });
            clearFile();
            return;
        }
        if (!files[0].type.match(/image.*/)) {
            $message({
                message: t('message.file.not_image'),
                type: 'error'
            });
            clearFile();
            return;
        }
        const r = new FileReader();
        r.onload = function () {
            const base64Body = btoa(r.result.toString());
            vrcPlusImageRequest.uploadGalleryImage(base64Body).then((args) => {
                handleGalleryImageAdd(args);
                $message({
                    message: t('message.gallery.uploaded'),
                    type: 'success'
                });
                if (Object.keys(galleryTable.value).length !== 0) {
                    galleryTable.value.unshift(args.json);
                }
                return args;
            });
        };
        r.readAsBinaryString(files[0]);
        clearFile();
    }
</script>
