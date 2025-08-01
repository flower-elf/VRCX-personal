<template>
    <div>
        <div style="display: flex; align-items: center; justify-content: space-between">
            <div>
                <el-button size="small" @click="showAvatarExportDialog">
                    {{ t('view.favorite.export') }}
                </el-button>
                <el-button size="small" style="margin-left: 5px" @click="showAvatarImportDialog">
                    {{ t('view.favorite.import') }}
                </el-button>
            </div>
            <div style="display: flex; align-items: center; font-size: 13px; margin-right: 10px">
                <span class="name" style="margin-right: 5px; line-height: 10px">
                    {{ t('view.favorite.sort_by') }}
                </span>
                <el-radio-group v-model="sortFav" style="margin-right: 12px" @change="saveSortFavoritesOption">
                    <el-radio :label="false">
                        {{ t('view.settings.appearance.appearance.sort_favorite_by_name') }}
                    </el-radio>
                    <el-radio :label="true">
                        {{ t('view.settings.appearance.appearance.sort_favorite_by_date') }}
                    </el-radio>
                </el-radio-group>
                <el-input
                    v-model="avatarFavoriteSearch"
                    clearable
                    size="mini"
                    :placeholder="t('view.favorite.avatars.search')"
                    style="width: 200px"
                    @input="searchAvatarFavorites" />
            </div>
        </div>
        <div class="x-friend-list" style="margin-top: 10px">
            <div
                v-for="favorite in avatarFavoriteSearchResults"
                :key="favorite.id"
                style="display: inline-block; width: 300px; margin-right: 15px"
                @click="showAvatarDialog(favorite.id)">
                <div class="x-friend-item">
                    <template v-if="favorite.name">
                        <div class="avatar">
                            <img v-lazy="favorite.thumbnailImageUrl" />
                        </div>
                        <div class="detail">
                            <span class="name" v-text="favorite.name" />
                            <span class="extra" v-text="favorite.authorName" />
                        </div>
                    </template>
                    <template v-else>
                        <div class="avatar"></div>
                        <div class="detail">
                            <span class="name" v-text="favorite.id" />
                        </div>
                    </template>
                </div>
            </div>
        </div>
        <span style="display: block; margin-top: 20px">
            {{ t('view.favorite.avatars.vrchat_favorites') }}
        </span>
        <el-collapse style="border: 0">
            <el-collapse-item v-for="group in favoriteAvatarGroups" :key="group.name">
                <template slot="title">
                    <span style="font-weight: bold; font-size: 14px; margin-left: 10px" v-text="group.displayName" />
                    <span style="color: #909399; font-size: 12px; margin-left: 10px">
                        {{ group.count }}/{{ group.capacity }}
                    </span>
                    <el-tooltip placement="top" :content="t('view.favorite.rename_tooltip')" :disabled="hideTooltips">
                        <el-button
                            size="mini"
                            icon="el-icon-edit"
                            circle
                            style="margin-left: 10px"
                            @click.stop="changeFavoriteGroupName(group)" />
                    </el-tooltip>
                    <el-tooltip placement="right" :content="t('view.favorite.clear_tooltip')" :disabled="hideTooltips">
                        <el-button
                            size="mini"
                            icon="el-icon-delete"
                            circle
                            style="margin-left: 5px"
                            @click.stop="clearFavoriteGroup(group)" />
                    </el-tooltip>
                </template>
                <div v-if="group.count" class="x-friend-list" style="margin-top: 10px">
                    <FavoritesAvatarItem
                        v-for="favorite in groupedByGroupKeyFavoriteAvatars[group.key]"
                        :key="favorite.id"
                        :favorite="favorite"
                        :group="group"
                        :hide-tooltips="hideTooltips"
                        :edit-favorites-mode="editFavoritesMode"
                        style="display: inline-block; width: 300px; margin-right: 15px"
                        @handle-select="favorite.$selected = $event"
                        @click="showAvatarDialog(favorite.id)" />
                </div>
                <div
                    v-else
                    style="
                        padding-top: 25px;
                        width: 100%;
                        display: flex;
                        align-items: center;
                        justify-content: center;
                        color: rgb(144, 147, 153);
                    ">
                    <span>No Data</span>
                </div>
            </el-collapse-item>
            <el-collapse-item>
                <template slot="title">
                    <span style="font-weight: bold; font-size: 14px; margin-left: 10px">Local History</span>
                    <span style="color: #909399; font-size: 12px; margin-left: 10px"
                        >{{ avatarHistoryArray.length }}/100</span
                    >
                    <el-tooltip placement="right" content="Clear" :disabled="hideTooltips">
                        <el-button
                            size="mini"
                            icon="el-icon-delete"
                            circle
                            style="margin-left: 5px"
                            @click.stop="promptClearAvatarHistory"></el-button>
                    </el-tooltip>
                </template>
                <div v-if="avatarHistoryArray.length" class="x-friend-list" style="margin-top: 10px">
                    <FavoritesAvatarLocalHistoryItem
                        v-for="favorite in avatarHistoryArray"
                        :key="favorite.id"
                        style="display: inline-block; width: 300px; margin-right: 15px"
                        :favorite="favorite"
                        :hide-tooltips="hideTooltips"
                        @click="showAvatarDialog(favorite.id)" />
                </div>
                <div
                    v-else
                    style="
                        padding-top: 25px;
                        width: 100%;
                        display: flex;
                        align-items: center;
                        justify-content: center;
                        color: rgb(144, 147, 153);
                    ">
                    <span>No Data</span>
                </div>
            </el-collapse-item>
            <span style="display: block; margin-top: 20px">{{ t('view.favorite.avatars.local_favorites') }}</span>
            <br />
            <el-button size="small" :disabled="!isLocalUserVrcplusSupporter" @click="promptNewLocalAvatarFavoriteGroup">
                {{ t('view.favorite.avatars.new_group') }}
            </el-button>
            <el-button
                v-if="!refreshingLocalFavorites"
                size="small"
                style="margin-left: 5px"
                @click="refreshLocalAvatarFavorites">
                {{ t('view.favorite.avatars.refresh') }}
            </el-button>
            <el-button v-else size="small" style="margin-left: 5px" @click="refreshingLocalFavorites = false">
                <i class="el-icon-loading" style="margin-right: 5px"></i>
                <span>{{ t('view.favorite.avatars.cancel_refresh') }}</span>
            </el-button>
            <el-collapse-item
                v-for="group in localAvatarFavoriteGroups"
                v-if="localAvatarFavorites[group]"
                :key="group">
                <template slot="title">
                    <span :style="{ fontWeight: 'bold', fontSize: '14px', marginLeft: '10px' }">{{ group }}</span>
                    <span :style="{ color: '#909399', fontSize: '12px', marginLeft: '10px' }">{{
                        getLocalAvatarFavoriteGroupLength(group)
                    }}</span>
                    <el-tooltip placement="top" :content="t('view.favorite.rename_tooltip')" :disabled="hideTooltips">
                        <el-button
                            size="mini"
                            icon="el-icon-edit"
                            circle
                            :style="{ marginLeft: '5px' }"
                            @click.stop="promptLocalAvatarFavoriteGroupRename(group)"></el-button>
                    </el-tooltip>
                    <el-tooltip placement="right" :content="t('view.favorite.delete_tooltip')" :disabled="hideTooltips">
                        <el-button
                            size="mini"
                            icon="el-icon-delete"
                            circle
                            :style="{ marginLeft: '5px' }"
                            @click.stop="promptLocalAvatarFavoriteGroupDelete(group)"></el-button>
                    </el-tooltip>
                </template>
                <div v-if="localAvatarFavorites[group].length" class="x-friend-list" :style="{ marginTop: '10px' }">
                    <FavoritesAvatarItem
                        v-for="favorite in localAvatarFavorites[group]"
                        :key="favorite.id"
                        is-local-favorite
                        :style="{ display: 'inline-block', width: '300px', marginRight: '15px' }"
                        :favorite="favorite"
                        :group="group"
                        :hide-tooltips="hideTooltips"
                        :edit-favorites-mode="editFavoritesMode"
                        @handle-select="favorite.$selected = $event"
                        @click="showAvatarDialog(favorite.id)" />
                </div>
                <div
                    v-else
                    :style="{
                        paddingTop: '25px',
                        width: '100%',
                        display: 'flex',
                        alignItems: 'center',
                        justifyContent: 'center',
                        color: 'rgb(144, 147, 153)'
                    }">
                    <span>No Data</span>
                </div>
            </el-collapse-item>
        </el-collapse>
        <AvatarExportDialog :avatar-export-dialog-visible.sync="avatarExportDialogVisible" />
    </div>
</template>

<script setup>
    import { ref, computed, getCurrentInstance } from 'vue';
    import { storeToRefs } from 'pinia';
    import { useI18n } from 'vue-i18n-bridge';
    import { favoriteRequest } from '../../../api';
    import { useAppearanceSettingsStore, useAvatarStore, useFavoriteStore, useUserStore } from '../../../stores';
    import AvatarExportDialog from '../dialogs/AvatarExportDialog.vue';
    import FavoritesAvatarItem from './FavoritesAvatarItem.vue';
    import FavoritesAvatarLocalHistoryItem from './FavoritesAvatarLocalHistoryItem.vue';

    defineProps({
        editFavoritesMode: {
            type: Boolean,
            default: false
        },
        refreshingLocalFavorites: {
            type: Boolean,
            default: false
        }
    });

    const { proxy } = getCurrentInstance();
    const emit = defineEmits(['change-favorite-group-name', 'refresh-local-avatar-favorites']);

    const { hideTooltips, sortFavorites } = storeToRefs(useAppearanceSettingsStore());
    const { setSortFavorites } = useAppearanceSettingsStore();
    const { favoriteAvatars, favoriteAvatarGroups, localAvatarFavorites, localAvatarFavoriteGroups } =
        storeToRefs(useFavoriteStore());
    const {
        showAvatarImportDialog,
        getLocalAvatarFavoriteGroupLength,
        deleteLocalAvatarFavoriteGroup,
        renameLocalAvatarFavoriteGroup,
        newLocalAvatarFavoriteGroup,
        saveSortFavoritesOption
    } = useFavoriteStore();
    const { avatarHistoryArray } = storeToRefs(useAvatarStore());
    const { promptClearAvatarHistory, showAvatarDialog } = useAvatarStore();
    const { currentUser } = storeToRefs(useUserStore());
    const { t } = useI18n();

    const avatarExportDialogVisible = ref(false);
    const avatarFavoriteSearch = ref('');
    const avatarFavoriteSearchResults = ref([]);

    const sortFav = computed({
        get() {
            return sortFavorites.value;
        },
        set() {
            setSortFavorites();
        }
    });

    const groupedByGroupKeyFavoriteAvatars = computed(() => {
        const groupedByGroupKeyFavoriteAvatars = {};
        favoriteAvatars.value.forEach((avatar) => {
            if (avatar.groupKey) {
                if (!groupedByGroupKeyFavoriteAvatars[avatar.groupKey]) {
                    groupedByGroupKeyFavoriteAvatars[avatar.groupKey] = [];
                }
                groupedByGroupKeyFavoriteAvatars[avatar.groupKey].push(avatar);
            }
        });

        return groupedByGroupKeyFavoriteAvatars;
    });

    const isLocalUserVrcplusSupporter = computed(() => currentUser.value.$isVRCPlus);

    function searchAvatarFavorites() {
        let ref = null;
        const search = avatarFavoriteSearch.value.toLowerCase();
        if (search.length < 3) {
            avatarFavoriteSearchResults.value = [];
            return;
        }

        const results = [];
        for (let i = 0; i < localAvatarFavoriteGroups.value.length; ++i) {
            const group = localAvatarFavoriteGroups.value[i];
            if (!localAvatarFavorites.value[group]) {
                continue;
            }
            for (let j = 0; j < localAvatarFavorites.value[group].length; ++j) {
                ref = localAvatarFavorites.value[group][j];
                if (
                    !ref ||
                    typeof ref.id === 'undefined' ||
                    typeof ref.name === 'undefined' ||
                    typeof ref.authorName === 'undefined'
                ) {
                    continue;
                }
                if (ref.name.toLowerCase().includes(search) || ref.authorName.toLowerCase().includes(search)) {
                    if (!results.some((r) => r.id === ref.id)) {
                        results.push(ref);
                    }
                }
            }
        }

        for (let i = 0; i < favoriteAvatars.value.length; ++i) {
            ref = favoriteAvatars.value[i].ref;
            if (
                !ref ||
                typeof ref.id === 'undefined' ||
                typeof ref.name === 'undefined' ||
                typeof ref.authorName === 'undefined'
            ) {
                continue;
            }
            if (ref.name.toLowerCase().includes(search) || ref.authorName.toLowerCase().includes(search)) {
                if (!results.some((r) => r.id === ref.id)) {
                    results.push(ref);
                }
            }
        }

        avatarFavoriteSearchResults.value = results;
    }

    function clearFavoriteGroup(ctx) {
        proxy.$confirm('Continue? Clear Group', 'Confirm', {
            confirmButtonText: 'Confirm',
            cancelButtonText: 'Cancel',
            type: 'info',
            callback: (action) => {
                if (action === 'confirm') {
                    favoriteRequest.clearFavoriteGroup({
                        type: ctx.type,
                        group: ctx.name
                    });
                }
            }
        });
    }

    function showAvatarExportDialog() {
        avatarExportDialogVisible.value = true;
    }

    function changeFavoriteGroupName(group) {
        emit('change-favorite-group-name', group);
    }

    function promptNewLocalAvatarFavoriteGroup() {
        proxy.$prompt(t('prompt.new_local_favorite_group.description'), t('prompt.new_local_favorite_group.header'), {
            distinguishCancelAndClose: true,
            confirmButtonText: t('prompt.new_local_favorite_group.ok'),
            cancelButtonText: t('prompt.new_local_favorite_group.cancel'),
            inputPattern: /\S+/,
            inputErrorMessage: t('prompt.new_local_favorite_group.input_error'),
            callback: (action, instance) => {
                if (action === 'confirm' && instance.inputValue) {
                    newLocalAvatarFavoriteGroup(instance.inputValue);
                }
            }
        });
    }

    function refreshLocalAvatarFavorites() {
        emit('refresh-local-avatar-favorites');
    }

    function promptLocalAvatarFavoriteGroupRename(group) {
        proxy.$prompt(
            t('prompt.local_favorite_group_rename.description'),
            t('prompt.local_favorite_group_rename.header'),
            {
                distinguishCancelAndClose: true,
                confirmButtonText: t('prompt.local_favorite_group_rename.save'),
                cancelButtonText: t('prompt.local_favorite_group_rename.cancel'),
                inputPattern: /\S+/,
                inputErrorMessage: t('prompt.local_favorite_group_rename.input_error'),
                inputValue: group,
                callback: (action, instance) => {
                    if (action === 'confirm' && instance.inputValue) {
                        renameLocalAvatarFavoriteGroup(instance.inputValue, group);
                    }
                }
            }
        );
    }

    function promptLocalAvatarFavoriteGroupDelete(group) {
        proxy.$confirm(`Delete Group? ${group}`, 'Confirm', {
            confirmButtonText: 'Confirm',
            cancelButtonText: 'Cancel',
            type: 'info',
            callback: (action) => {
                if (action === 'confirm') {
                    deleteLocalAvatarFavoriteGroup(group);
                }
            }
        });
    }
</script>
