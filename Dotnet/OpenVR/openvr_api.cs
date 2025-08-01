//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: This file contains C#/managed code bindings for the OpenVR interfaces
// This file is auto-generated, do not edit it.
//
//=============================================================================
#if !OPENVR_XR_API

using System;
using System.Runtime.InteropServices;
using Valve.VR;

#if UNITY_5_3_OR_NEWER
using UnityEngine;
#endif

namespace Valve.VR
{

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRSystem
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRecommendedRenderTargetSize GetRecommendedRenderTargetSize;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix44_t _GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetProjectionMatrix GetProjectionMatrix;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetProjectionRaw GetProjectionRaw;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ComputeDistortion ComputeDistortion;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetEyeToHeadTransform(EVREye eEye);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetEyeToHeadTransform GetEyeToHeadTransform;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTimeSinceLastVsync GetTimeSinceLastVsync;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int _GetD3D9AdapterIndex();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetD3D9AdapterIndex GetD3D9AdapterIndex;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDXGIOutputInfo GetDXGIOutputInfo;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOutputDevice GetOutputDevice;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsDisplayOnDesktop();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsDisplayOnDesktop IsDisplayOnDesktop;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _SetDisplayVisibility([MarshalAs(UnmanagedType.I1)] bool bIsVisibleOnDesktop);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetDisplayVisibility SetDisplayVisibility;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, [In, Out] TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetSeatedZeroPoseToStandingAbsoluteTrackingPose();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSeatedZeroPoseToStandingAbsoluteTrackingPose GetSeatedZeroPoseToStandingAbsoluteTrackingPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetRawZeroPoseToStandingAbsoluteTrackingPose();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRawZeroPoseToStandingAbsoluteTrackingPose GetRawZeroPoseToStandingAbsoluteTrackingPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, [In, Out] uint[] punTrackedDeviceIndexArray, uint unTrackedDeviceIndexArrayCount, uint unRelativeToTrackedDeviceIndex);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSortedTrackedDeviceIndicesOfClass GetSortedTrackedDeviceIndicesOfClass;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EDeviceActivityLevel _GetTrackedDeviceActivityLevel(uint unDeviceId);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTrackedDeviceActivityLevel GetTrackedDeviceActivityLevel;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ApplyTransform ApplyTransform;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTrackedDeviceIndexForControllerRole GetTrackedDeviceIndexForControllerRole;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedControllerRole _GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetControllerRoleForTrackedDeviceIndex GetControllerRoleForTrackedDeviceIndex;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedDeviceClass _GetTrackedDeviceClass(uint unDeviceIndex);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTrackedDeviceClass GetTrackedDeviceClass;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsTrackedDeviceConnected(uint unDeviceIndex);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsTrackedDeviceConnected IsTrackedDeviceConnected;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetBoolTrackedDeviceProperty GetBoolTrackedDeviceProperty;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetFloatTrackedDeviceProperty GetFloatTrackedDeviceProperty;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int _GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetInt32TrackedDeviceProperty GetInt32TrackedDeviceProperty;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetUint64TrackedDeviceProperty GetUint64TrackedDeviceProperty;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetMatrix34TrackedDeviceProperty GetMatrix34TrackedDeviceProperty;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetArrayTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetArrayTrackedDeviceProperty GetArrayTrackedDeviceProperty;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, System.Text.StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetStringTrackedDeviceProperty GetStringTrackedDeviceProperty;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PollNextEvent PollNextEvent;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PollNextEventWithPose PollNextEventWithPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetEventTypeNameFromEnum(EVREventType eType);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetEventTypeNameFromEnum GetEventTypeNameFromEnum;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HiddenAreaMesh_t _GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHiddenAreaMesh GetHiddenAreaMesh;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetControllerState GetControllerState;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetControllerStateWithPose GetControllerStateWithPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, ushort usDurationMicroSec);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _TriggerHapticPulse TriggerHapticPulse;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetButtonIdNameFromEnum(EVRButtonId eButtonId);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetButtonIdNameFromEnum GetButtonIdNameFromEnum;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetControllerAxisTypeNameFromEnum GetControllerAxisTypeNameFromEnum;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsInputAvailable();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsInputAvailable IsInputAvailable;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsSteamVRDrawingControllers();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsSteamVRDrawingControllers IsSteamVRDrawingControllers;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _ShouldApplicationPause();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShouldApplicationPause ShouldApplicationPause;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _ShouldApplicationReduceRenderingWork();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShouldApplicationReduceRenderingWork ShouldApplicationReduceRenderingWork;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRFirmwareError _PerformFirmwareUpdate(uint unDeviceIndex);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PerformFirmwareUpdate PerformFirmwareUpdate;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _AcknowledgeQuit_Exiting();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetAppContainerFilePaths(System.Text.StringBuilder pchBuffer, uint unBufferSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetAppContainerFilePaths GetAppContainerFilePaths;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetRuntimeVersion();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRuntimeVersion GetRuntimeVersion;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRExtendedDisplay
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWindowBounds GetWindowBounds;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetEyeOutputViewport GetEyeOutputViewport;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDXGIOutputInfo GetDXGIOutputInfo;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRTrackedCamera
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCameraErrorNameFromEnum GetCameraErrorNameFromEnum;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _HasCamera(uint nDeviceIndex, [MarshalAs(UnmanagedType.I1)] ref bool pHasCamera);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HasCamera HasCamera;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCameraFrameSize GetCameraFrameSize;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetCameraIntrinsics(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCameraIntrinsics GetCameraIntrinsics;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetCameraProjection(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCameraProjection GetCameraProjection;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AcquireVideoStreamingService AcquireVideoStreamingService;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamingService(ulong hTrackedCamera);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseVideoStreamingService ReleaseVideoStreamingService;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetVideoStreamFrameBuffer GetVideoStreamFrameBuffer;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetVideoStreamTextureSize GetVideoStreamTextureSize;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetVideoStreamTextureD3D11 GetVideoStreamTextureD3D11;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetVideoStreamTextureGL GetVideoStreamTextureGL;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseVideoStreamTextureGL ReleaseVideoStreamTextureGL;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetCameraTrackingSpace(ETrackingUniverseOrigin eUniverse);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetCameraTrackingSpace SetCameraTrackingSpace;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackingUniverseOrigin _GetCameraTrackingSpace();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCameraTrackingSpace GetCameraTrackingSpace;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRApplications
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _AddApplicationManifest(IntPtr pchApplicationManifestFullPath, [MarshalAs(UnmanagedType.I1)] bool bTemporary);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AddApplicationManifest AddApplicationManifest;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _RemoveApplicationManifest(IntPtr pchApplicationManifestFullPath);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RemoveApplicationManifest RemoveApplicationManifest;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsApplicationInstalled(IntPtr pchAppKey);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsApplicationInstalled IsApplicationInstalled;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationCount();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationCount GetApplicationCount;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _GetApplicationKeyByIndex(uint unApplicationIndex, System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationKeyByIndex GetApplicationKeyByIndex;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _GetApplicationKeyByProcessId(uint unProcessId, System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationKeyByProcessId GetApplicationKeyByProcessId;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchApplication(IntPtr pchAppKey);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LaunchApplication LaunchApplication;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchTemplateApplication(IntPtr pchTemplateAppKey, IntPtr pchNewAppKey, [In, Out] AppOverrideKeys_t[] pKeys, uint unKeys);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LaunchTemplateApplication LaunchTemplateApplication;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchApplicationFromMimeType(IntPtr pchMimeType, IntPtr pchArgs);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LaunchApplicationFromMimeType LaunchApplicationFromMimeType;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchDashboardOverlay(IntPtr pchAppKey);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LaunchDashboardOverlay LaunchDashboardOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _CancelApplicationLaunch(IntPtr pchAppKey);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CancelApplicationLaunch CancelApplicationLaunch;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _IdentifyApplication(uint unProcessId, IntPtr pchAppKey);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IdentifyApplication IdentifyApplication;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationProcessId(IntPtr pchAppKey);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationProcessId GetApplicationProcessId;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetApplicationsErrorNameFromEnum(EVRApplicationError error);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationPropertyString(IntPtr pchAppKey, EVRApplicationProperty eProperty, System.Text.StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationPropertyString GetApplicationPropertyString;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetApplicationPropertyBool(IntPtr pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationPropertyBool GetApplicationPropertyBool;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetApplicationPropertyUint64(IntPtr pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationPropertyUint64 GetApplicationPropertyUint64;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _SetApplicationAutoLaunch(IntPtr pchAppKey, [MarshalAs(UnmanagedType.I1)] bool bAutoLaunch);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetApplicationAutoLaunch SetApplicationAutoLaunch;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetApplicationAutoLaunch(IntPtr pchAppKey);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationAutoLaunch GetApplicationAutoLaunch;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _SetDefaultApplicationForMimeType(IntPtr pchAppKey, IntPtr pchMimeType);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetDefaultApplicationForMimeType SetDefaultApplicationForMimeType;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetDefaultApplicationForMimeType(IntPtr pchMimeType, System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDefaultApplicationForMimeType GetDefaultApplicationForMimeType;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetApplicationSupportedMimeTypes(IntPtr pchAppKey, System.Text.StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationSupportedMimeTypes GetApplicationSupportedMimeTypes;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationsThatSupportMimeType(IntPtr pchMimeType, System.Text.StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationsThatSupportMimeType GetApplicationsThatSupportMimeType;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationLaunchArguments(uint unHandle, System.Text.StringBuilder pchArgs, uint unArgs);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetApplicationLaunchArguments GetApplicationLaunchArguments;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _GetStartingApplication(System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetStartingApplication GetStartingApplication;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRSceneApplicationState _GetSceneApplicationState();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSceneApplicationState GetSceneApplicationState;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _PerformApplicationPrelaunchCheck(IntPtr pchAppKey);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetSceneApplicationStateNameFromEnum(EVRSceneApplicationState state);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSceneApplicationStateNameFromEnum GetSceneApplicationStateNameFromEnum;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchInternalProcess(IntPtr pchBinaryPath, IntPtr pchArguments, IntPtr pchWorkingDirectory);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LaunchInternalProcess LaunchInternalProcess;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetCurrentSceneProcessId();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCurrentSceneProcessId GetCurrentSceneProcessId;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRChaperone
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ChaperoneCalibrationState _GetCalibrationState();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCalibrationState GetCalibrationState;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetPlayAreaSize(ref float pSizeX, ref float pSizeZ);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPlayAreaSize GetPlayAreaSize;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetPlayAreaRect(ref HmdQuad_t rect);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPlayAreaRect GetPlayAreaRect;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ReloadInfo();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReloadInfo ReloadInfo;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetSceneColor(HmdColor_t color);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetSceneColor SetSceneColor;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetBoundsColor GetBoundsColor;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _AreBoundsVisible();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AreBoundsVisible AreBoundsVisible;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ForceBoundsVisible([MarshalAs(UnmanagedType.I1)] bool bForce);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ForceBoundsVisible ForceBoundsVisible;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ResetZeroPose(ETrackingUniverseOrigin eTrackingUniverseOrigin);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ResetZeroPose ResetZeroPose;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRChaperoneSetup
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _CommitWorkingCopy(EChaperoneConfigFile configFile);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CommitWorkingCopy CommitWorkingCopy;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _RevertWorkingCopy();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RevertWorkingCopy RevertWorkingCopy;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWorkingPlayAreaSize GetWorkingPlayAreaSize;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetWorkingPlayAreaRect(ref HmdQuad_t rect);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWorkingPlayAreaRect GetWorkingPlayAreaRect;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetLiveCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingPlayAreaSize(float sizeX, float sizeZ);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetWorkingPlayAreaSize SetWorkingPlayAreaSize;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingPerimeter([In, Out] HmdVector2_t[] pPointBuffer, uint unPointCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetWorkingPerimeter SetWorkingPerimeter;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ReloadFromDisk(EChaperoneConfigFile configFile);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReloadFromDisk ReloadFromDisk;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _ExportLiveToBuffer(System.Text.StringBuilder pBuffer, ref uint pnBufferLength);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ExportLiveToBuffer ExportLiveToBuffer;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _ImportFromBufferToWorking(IntPtr pBuffer, uint nImportFlags);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ImportFromBufferToWorking ImportFromBufferToWorking;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ShowWorkingSetPreview();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowWorkingSetPreview ShowWorkingSetPreview;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _HideWorkingSetPreview();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HideWorkingSetPreview HideWorkingSetPreview;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _RoomSetupStarting();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RoomSetupStarting RoomSetupStarting;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRCompositor
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetTrackingSpace(ETrackingUniverseOrigin eOrigin);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetTrackingSpace SetTrackingSpace;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackingUniverseOrigin _GetTrackingSpace();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTrackingSpace GetTrackingSpace;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _WaitGetPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _WaitGetPoses WaitGetPoses;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetLastPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLastPoses GetLastPoses;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Submit Submit;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _SubmitWithArrayIndex(EVREye eEye, ref Texture_t pTexture, uint unTextureArrayIndex, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SubmitWithArrayIndex SubmitWithArrayIndex;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ClearLastSubmittedFrame();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ClearLastSubmittedFrame ClearLastSubmittedFrame;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _PostPresentHandoff();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PostPresentHandoff PostPresentHandoff;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetFrameTiming GetFrameTiming;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetFrameTimings([In, Out] Compositor_FrameTiming[] pTiming, uint nFrames);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetFrameTimings GetFrameTimings;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetFrameTimeRemaining();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetFrameTimeRemaining GetFrameTimeRemaining;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCumulativeStats GetCumulativeStats;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, [MarshalAs(UnmanagedType.I1)] bool bBackground);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FadeToColor FadeToColor;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdColor_t _GetCurrentFadeColor([MarshalAs(UnmanagedType.I1)] bool bBackground);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCurrentFadeColor GetCurrentFadeColor;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FadeGrid(float fSeconds, [MarshalAs(UnmanagedType.I1)] bool bFadeGridIn);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FadeGrid FadeGrid;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetCurrentGridAlpha();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCurrentGridAlpha GetCurrentGridAlpha;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _SetSkyboxOverride([In, Out] Texture_t[] pTextures, uint unTextureCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetSkyboxOverride SetSkyboxOverride;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ClearSkyboxOverride();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ClearSkyboxOverride ClearSkyboxOverride;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorBringToFront();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CompositorBringToFront CompositorBringToFront;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorGoToBack();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CompositorGoToBack CompositorGoToBack;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorQuit();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CompositorQuit CompositorQuit;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsFullscreen();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsFullscreen IsFullscreen;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetCurrentSceneFocusProcess();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetLastFrameRenderer();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLastFrameRenderer GetLastFrameRenderer;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _CanRenderScene();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CanRenderScene CanRenderScene;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ShowMirrorWindow();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowMirrorWindow ShowMirrorWindow;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _HideMirrorWindow();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HideMirrorWindow HideMirrorWindow;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsMirrorWindowVisible();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsMirrorWindowVisible IsMirrorWindowVisible;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorDumpImages();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CompositorDumpImages CompositorDumpImages;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _ShouldAppRenderWithLowResources();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ForceInterleavedReprojectionOn([MarshalAs(UnmanagedType.I1)] bool bOverride);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ForceReconnectProcess();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ForceReconnectProcess ForceReconnectProcess;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SuspendRendering([MarshalAs(UnmanagedType.I1)] bool bSuspend);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SuspendRendering SuspendRendering;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetMirrorTextureD3D11 GetMirrorTextureD3D11;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseMirrorTextureD3D11 ReleaseMirrorTextureD3D11;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetMirrorTextureGL GetMirrorTextureGL;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseSharedGLTexture ReleaseSharedGLTexture;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LockGLSharedTextureForAccess LockGLSharedTextureForAccess;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _UnlockGLSharedTextureForAccess UnlockGLSharedTextureForAccess;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetVulkanInstanceExtensionsRequired(System.Text.StringBuilder pchValue, uint unBufferSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetVulkanInstanceExtensionsRequired GetVulkanInstanceExtensionsRequired;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, System.Text.StringBuilder pchValue, uint unBufferSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetVulkanDeviceExtensionsRequired GetVulkanDeviceExtensionsRequired;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetExplicitTimingMode(EVRCompositorTimingMode eTimingMode);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetExplicitTimingMode SetExplicitTimingMode;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _SubmitExplicitTimingData();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SubmitExplicitTimingData SubmitExplicitTimingData;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsMotionSmoothingEnabled();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsMotionSmoothingEnabled IsMotionSmoothingEnabled;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsMotionSmoothingSupported();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsMotionSmoothingSupported IsMotionSmoothingSupported;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsCurrentSceneFocusAppLoading();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsCurrentSceneFocusAppLoading IsCurrentSceneFocusAppLoading;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _SetStageOverride_Async(IntPtr pchRenderModelPath, ref HmdMatrix34_t pTransform, ref Compositor_StageRenderSettings pRenderSettings, uint nSizeOfRenderSettings);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetStageOverride_Async SetStageOverride_Async;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ClearStageOverride();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ClearStageOverride ClearStageOverride;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetCompositorBenchmarkResults(ref Compositor_BenchmarkResults pBenchmarkResults, uint nSizeOfBenchmarkResults);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetCompositorBenchmarkResults GetCompositorBenchmarkResults;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetLastPosePredictionIDs(ref uint pRenderPosePredictionID, ref uint pGamePosePredictionID);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetLastPosePredictionIDs GetLastPosePredictionIDs;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetPosesForFrame(uint unPosePredictionID, [In, Out] TrackedDevicePose_t[] pPoseArray, uint unPoseArrayCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPosesForFrame GetPosesForFrame;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVROverlay
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _FindOverlay(IntPtr pchOverlayKey, ref ulong pOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FindOverlay FindOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _CreateOverlay(IntPtr pchOverlayKey, IntPtr pchOverlayName, ref ulong pOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CreateOverlay CreateOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _CreateSubviewOverlay(ulong parentOverlayHandle, IntPtr pchSubviewOverlayKey, IntPtr pchSubviewOverlayName, ref ulong pSubviewOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CreateSubviewOverlay CreateSubviewOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _DestroyOverlay(ulong ulOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _DestroyOverlay DestroyOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetOverlayKey(ulong ulOverlayHandle, System.Text.StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayKey GetOverlayKey;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetOverlayName(ulong ulOverlayHandle, System.Text.StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayName GetOverlayName;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayName(ulong ulOverlayHandle, IntPtr pchName);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayName SetOverlayName;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayImageData GetOverlayImageData;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetOverlayErrorNameFromEnum(EVROverlayError error);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayRenderingPid SetOverlayRenderingPid;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetOverlayRenderingPid(ulong ulOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayRenderingPid GetOverlayRenderingPid;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, [MarshalAs(UnmanagedType.I1)] bool bEnabled);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayFlag SetOverlayFlag;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, [MarshalAs(UnmanagedType.I1)] ref bool pbEnabled);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayFlag GetOverlayFlag;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayFlags GetOverlayFlags;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayColor SetOverlayColor;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayColor GetOverlayColor;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayAlpha SetOverlayAlpha;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayAlpha GetOverlayAlpha;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTexelAspect SetOverlayTexelAspect;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTexelAspect GetOverlayTexelAspect;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlaySortOrder SetOverlaySortOrder;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlaySortOrder GetOverlaySortOrder;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayWidthInMeters SetOverlayWidthInMeters;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayWidthInMeters GetOverlayWidthInMeters;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayCurvature(ulong ulOverlayHandle, float fCurvature);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayCurvature SetOverlayCurvature;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayCurvature(ulong ulOverlayHandle, ref float pfCurvature);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayCurvature GetOverlayCurvature;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayPreCurvePitch(ulong ulOverlayHandle, float fRadians);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayPreCurvePitch SetOverlayPreCurvePitch;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayPreCurvePitch(ulong ulOverlayHandle, ref float pfRadians);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayPreCurvePitch GetOverlayPreCurvePitch;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTextureColorSpace SetOverlayTextureColorSpace;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTextureColorSpace GetOverlayTextureColorSpace;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTextureBounds SetOverlayTextureBounds;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTextureBounds GetOverlayTextureBounds;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTransformType GetOverlayTransformType;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTransformAbsolute SetOverlayTransformAbsolute;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTransformAbsolute GetOverlayTransformAbsolute;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, IntPtr pchComponentName);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, System.Text.StringBuilder pchComponentName, uint unComponentNameSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformCursor(ulong ulCursorOverlayHandle, ref HmdVector2_t pvHotspot);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTransformCursor SetOverlayTransformCursor;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformCursor(ulong ulOverlayHandle, ref HmdVector2_t pvHotspot);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTransformCursor GetOverlayTransformCursor;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformProjection(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform, ref VROverlayProjection_t pProjection, EVREye eEye);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTransformProjection SetOverlayTransformProjection;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetSubviewPosition(ulong ulOverlayHandle, float fX, float fY);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetSubviewPosition SetSubviewPosition;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ShowOverlay(ulong ulOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowOverlay ShowOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _HideOverlay(ulong ulOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HideOverlay HideOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsOverlayVisible(ulong ulOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsOverlayVisible IsOverlayVisible;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _WaitFrameSync(uint nTimeoutMs);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _WaitFrameSync WaitFrameSync;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PollNextOverlayEvent PollNextOverlayEvent;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayInputMethod GetOverlayInputMethod;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayInputMethod SetOverlayInputMethod;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayMouseScale GetOverlayMouseScale;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayMouseScale SetOverlayMouseScale;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ComputeOverlayIntersection ComputeOverlayIntersection;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsHoverTargetOverlay(ulong ulOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsHoverTargetOverlay IsHoverTargetOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayIntersectionMask SetOverlayIntersectionMask;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _TriggerLaserMouseHapticVibration(ulong ulOverlayHandle, float fDurationSeconds, float fFrequency, float fAmplitude);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _TriggerLaserMouseHapticVibration TriggerLaserMouseHapticVibration;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayCursor(ulong ulOverlayHandle, ulong ulCursorHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayCursor SetOverlayCursor;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayCursorPositionOverride(ulong ulOverlayHandle, ref HmdVector2_t pvCursor);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayCursorPositionOverride SetOverlayCursorPositionOverride;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ClearOverlayCursorPositionOverride(ulong ulOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ClearOverlayCursorPositionOverride ClearOverlayCursorPositionOverride;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayTexture SetOverlayTexture;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ClearOverlayTexture(ulong ulOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ClearOverlayTexture ClearOverlayTexture;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unBytesPerPixel);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayRaw SetOverlayRaw;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayFromFile(ulong ulOverlayHandle, IntPtr pchFilePath);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetOverlayFromFile SetOverlayFromFile;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTexture GetOverlayTexture;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseNativeOverlayHandle ReleaseNativeOverlayHandle;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOverlayTextureSize GetOverlayTextureSize;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _CreateDashboardOverlay(IntPtr pchOverlayKey, IntPtr pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CreateDashboardOverlay CreateDashboardOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsDashboardVisible();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsDashboardVisible IsDashboardVisible;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsActiveDashboardOverlay(ulong ulOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsActiveDashboardOverlay IsActiveDashboardOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ShowDashboard(IntPtr pchOverlayToShow);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowDashboard ShowDashboard;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetPrimaryDashboardDevice();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPrimaryDashboardDevice GetPrimaryDashboardDevice;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ShowKeyboard(int eInputMode, int eLineInputMode, uint unFlags, IntPtr pchDescription, uint unCharMax, IntPtr pchExistingText, ulong uUserValue);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowKeyboard ShowKeyboard;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, uint unFlags, IntPtr pchDescription, uint unCharMax, IntPtr pchExistingText, ulong uUserValue);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowKeyboardForOverlay ShowKeyboardForOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetKeyboardText(System.Text.StringBuilder pchText, uint cchText);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetKeyboardText GetKeyboardText;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _HideKeyboard();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HideKeyboard HideKeyboard;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate VRMessageOverlayResponse _ShowMessageOverlay(IntPtr pchText, IntPtr pchCaption, IntPtr pchButton0Text, IntPtr pchButton1Text, IntPtr pchButton2Text, IntPtr pchButton3Text);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowMessageOverlay ShowMessageOverlay;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CloseMessageOverlay();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CloseMessageOverlay CloseMessageOverlay;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVROverlayView
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _AcquireOverlayView(ulong ulOverlayHandle, ref VRNativeDevice_t pNativeDevice, ref VROverlayView_t pOverlayView, uint unOverlayViewSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AcquireOverlayView AcquireOverlayView;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ReleaseOverlayView(ref VROverlayView_t pOverlayView);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseOverlayView ReleaseOverlayView;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _PostOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pvrEvent);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PostOverlayEvent PostOverlayEvent;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsViewingPermitted(ulong ulOverlayHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsViewingPermitted IsViewingPermitted;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRHeadsetView
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetHeadsetViewSize(uint nWidth, uint nHeight);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetHeadsetViewSize SetHeadsetViewSize;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetHeadsetViewSize(ref uint pnWidth, ref uint pnHeight);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHeadsetViewSize GetHeadsetViewSize;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetHeadsetViewMode(uint eHeadsetViewMode);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetHeadsetViewMode SetHeadsetViewMode;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetHeadsetViewMode();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHeadsetViewMode GetHeadsetViewMode;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetHeadsetViewCropped([MarshalAs(UnmanagedType.I1)] bool bCropped);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetHeadsetViewCropped SetHeadsetViewCropped;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetHeadsetViewCropped();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHeadsetViewCropped GetHeadsetViewCropped;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetHeadsetViewAspectRatio();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHeadsetViewAspectRatio GetHeadsetViewAspectRatio;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetHeadsetViewBlendRange(float flStartPct, float flEndPct);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetHeadsetViewBlendRange SetHeadsetViewBlendRange;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetHeadsetViewBlendRange(ref float pStartPct, ref float pEndPct);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHeadsetViewBlendRange GetHeadsetViewBlendRange;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRRenderModels
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadRenderModel_Async(IntPtr pchRenderModelName, ref IntPtr ppRenderModel);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LoadRenderModel_Async LoadRenderModel_Async;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FreeRenderModel(IntPtr pRenderModel);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FreeRenderModel FreeRenderModel;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadTexture_Async(int textureId, ref IntPtr ppTexture);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LoadTexture_Async LoadTexture_Async;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FreeTexture(IntPtr pTexture);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FreeTexture FreeTexture;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LoadTextureD3D11_Async LoadTextureD3D11_Async;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LoadIntoTextureD3D11_Async LoadIntoTextureD3D11_Async;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FreeTextureD3D11(IntPtr pD3D11Texture2D);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FreeTextureD3D11 FreeTextureD3D11;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetRenderModelName(uint unRenderModelIndex, System.Text.StringBuilder pchRenderModelName, uint unRenderModelNameLen);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRenderModelName GetRenderModelName;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetRenderModelCount();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRenderModelCount GetRenderModelCount;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetComponentCount(IntPtr pchRenderModelName);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentCount GetComponentCount;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetComponentName(IntPtr pchRenderModelName, uint unComponentIndex, System.Text.StringBuilder pchComponentName, uint unComponentNameLen);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentName GetComponentName;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetComponentButtonMask(IntPtr pchRenderModelName, IntPtr pchComponentName);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentButtonMask GetComponentButtonMask;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetComponentRenderModelName(IntPtr pchRenderModelName, IntPtr pchComponentName, System.Text.StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentRenderModelName GetComponentRenderModelName;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetComponentStateForDevicePath(IntPtr pchRenderModelName, IntPtr pchComponentName, ulong devicePath, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentStateForDevicePath GetComponentStateForDevicePath;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetComponentState(IntPtr pchRenderModelName, IntPtr pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentState GetComponentState;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _RenderModelHasComponent(IntPtr pchRenderModelName, IntPtr pchComponentName);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RenderModelHasComponent RenderModelHasComponent;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetRenderModelThumbnailURL(IntPtr pchRenderModelName, System.Text.StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRenderModelThumbnailURL GetRenderModelThumbnailURL;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetRenderModelOriginalPath(IntPtr pchRenderModelName, System.Text.StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRenderModelOriginalPath GetRenderModelOriginalPath;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetRenderModelErrorNameFromEnum(EVRRenderModelError error);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetRenderModelErrorNameFromEnum GetRenderModelErrorNameFromEnum;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRNotifications
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, IntPtr pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CreateNotification CreateNotification;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRNotificationError _RemoveNotification(uint notificationId);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RemoveNotification RemoveNotification;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRSettings
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetSettingsErrorNameFromEnum(EVRSettingsError eError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetBool(IntPtr pchSection, IntPtr pchSettingsKey, [MarshalAs(UnmanagedType.I1)] bool bValue, ref EVRSettingsError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetBool SetBool;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetInt32(IntPtr pchSection, IntPtr pchSettingsKey, int nValue, ref EVRSettingsError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetInt32 SetInt32;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetFloat(IntPtr pchSection, IntPtr pchSettingsKey, float flValue, ref EVRSettingsError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetFloat SetFloat;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetString(IntPtr pchSection, IntPtr pchSettingsKey, IntPtr pchValue, ref EVRSettingsError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetString SetString;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetBool(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetBool GetBool;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int _GetInt32(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetInt32 GetInt32;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetFloat(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetFloat GetFloat;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetString(IntPtr pchSection, IntPtr pchSettingsKey, System.Text.StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetString GetString;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _RemoveSection(IntPtr pchSection, ref EVRSettingsError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RemoveSection RemoveSection;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _RemoveKeyInSection(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RemoveKeyInSection RemoveKeyInSection;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRScreenshots
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotError _RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, IntPtr pchPreviewFilename, IntPtr pchVRFilename);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RequestScreenshot RequestScreenshot;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotError _HookScreenshot([In, Out] EVRScreenshotType[] pSupportedTypes, int numTypes);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HookScreenshot HookScreenshot;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotType _GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetScreenshotPropertyType GetScreenshotPropertyType;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, System.Text.StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetScreenshotPropertyFilename GetScreenshotPropertyFilename;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotError _UpdateScreenshotProgress(uint screenshotHandle, float flProgress);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _UpdateScreenshotProgress UpdateScreenshotProgress;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotError _TakeStereoScreenshot(ref uint pOutScreenshotHandle, IntPtr pchPreviewFilename, IntPtr pchVRFilename);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _TakeStereoScreenshot TakeStereoScreenshot;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotError _SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, IntPtr pchSourcePreviewFilename, IntPtr pchSourceVRFilename);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SubmitScreenshot SubmitScreenshot;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRResources
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _LoadSharedResource(IntPtr pchResourceName, string pchBuffer, uint unBufferLen);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _LoadSharedResource LoadSharedResource;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetResourceFullPath(IntPtr pchResourceName, IntPtr pchResourceTypeDirectory, System.Text.StringBuilder pchPathBuffer, uint unBufferLen);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetResourceFullPath GetResourceFullPath;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRDriverManager
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetDriverCount();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDriverCount GetDriverCount;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetDriverName(uint nDriver, System.Text.StringBuilder pchValue, uint unBufferSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDriverName GetDriverName;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetDriverHandle(IntPtr pchDriverName);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDriverHandle GetDriverHandle;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsEnabled(uint nDriver);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsEnabled IsEnabled;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRInput
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _SetActionManifestPath(IntPtr pchActionManifestPath);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetActionManifestPath SetActionManifestPath;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetActionSetHandle(IntPtr pchActionSetName, ref ulong pHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetActionSetHandle GetActionSetHandle;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetActionHandle(IntPtr pchActionName, ref ulong pHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetActionHandle GetActionHandle;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetInputSourceHandle(IntPtr pchInputSourcePath, ref ulong pHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetInputSourceHandle GetInputSourceHandle;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _UpdateActionState([In, Out] VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _UpdateActionState UpdateActionState;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetDigitalActionData(ulong action, ref InputDigitalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDigitalActionData GetDigitalActionData;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetAnalogActionData(ulong action, ref InputAnalogActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetAnalogActionData GetAnalogActionData;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetPoseActionDataRelativeToNow(ulong action, ETrackingUniverseOrigin eOrigin, float fPredictedSecondsFromNow, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPoseActionDataRelativeToNow GetPoseActionDataRelativeToNow;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetPoseActionDataForNextFrame(ulong action, ETrackingUniverseOrigin eOrigin, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPoseActionDataForNextFrame GetPoseActionDataForNextFrame;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetSkeletalActionData(ulong action, ref InputSkeletalActionData_t pActionData, uint unActionDataSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSkeletalActionData GetSkeletalActionData;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetDominantHand(ref ETrackedControllerRole peDominantHand);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDominantHand GetDominantHand;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _SetDominantHand(ETrackedControllerRole eDominantHand);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetDominantHand SetDominantHand;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetBoneCount(ulong action, ref uint pBoneCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetBoneCount GetBoneCount;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetBoneHierarchy(ulong action, [In, Out] int[] pParentIndices, uint unIndexArayCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetBoneHierarchy GetBoneHierarchy;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetBoneName(ulong action, int nBoneIndex, System.Text.StringBuilder pchBoneName, uint unNameBufferSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetBoneName GetBoneName;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetSkeletalReferenceTransforms(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalReferencePose eReferencePose, [In, Out] VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSkeletalReferenceTransforms GetSkeletalReferenceTransforms;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetSkeletalTrackingLevel(ulong action, ref EVRSkeletalTrackingLevel pSkeletalTrackingLevel);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSkeletalTrackingLevel GetSkeletalTrackingLevel;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetSkeletalBoneData(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, [In, Out] VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSkeletalBoneData GetSkeletalBoneData;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetSkeletalSummaryData(ulong action, EVRSummaryType eSummaryType, ref VRSkeletalSummaryData_t pSkeletalSummaryData);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSkeletalSummaryData GetSkeletalSummaryData;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetSkeletalBoneDataCompressed(ulong action, EVRSkeletalMotionRange eMotionRange, IntPtr pvCompressedData, uint unCompressedSize, ref uint punRequiredCompressedSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSkeletalBoneDataCompressed GetSkeletalBoneDataCompressed;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _DecompressSkeletalBoneData(IntPtr pvCompressedBuffer, uint unCompressedBufferSize, EVRSkeletalTransformSpace eTransformSpace, [In, Out] VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _DecompressSkeletalBoneData DecompressSkeletalBoneData;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _TriggerHapticVibrationAction(ulong action, float fStartSecondsFromNow, float fDurationSeconds, float fFrequency, float fAmplitude, ulong ulRestrictToDevice);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _TriggerHapticVibrationAction TriggerHapticVibrationAction;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetActionOrigins(ulong actionSetHandle, ulong digitalActionHandle, [In, Out] ulong[] originsOut, uint originOutCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetActionOrigins GetActionOrigins;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetOriginLocalizedName(ulong origin, System.Text.StringBuilder pchNameArray, uint unNameArraySize, int unStringSectionsToInclude);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOriginLocalizedName GetOriginLocalizedName;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetOriginTrackedDeviceInfo(ulong origin, ref InputOriginInfo_t pOriginInfo, uint unOriginInfoSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetOriginTrackedDeviceInfo GetOriginTrackedDeviceInfo;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetActionBindingInfo(ulong action, [In, Out] InputBindingInfo_t[] pOriginInfo, uint unBindingInfoSize, uint unBindingInfoCount, ref uint punReturnedBindingInfoCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetActionBindingInfo GetActionBindingInfo;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _ShowActionOrigins(ulong actionSetHandle, ulong ulActionHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowActionOrigins ShowActionOrigins;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _ShowBindingsForActionSet([In, Out] VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount, ulong originToHighlight);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ShowBindingsForActionSet ShowBindingsForActionSet;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetComponentStateForBinding(IntPtr pchRenderModelName, IntPtr pchComponentName, ref InputBindingInfo_t pOriginInfo, uint unBindingInfoSize, uint unBindingInfoCount, ref RenderModel_ComponentState_t pComponentState);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetComponentStateForBinding GetComponentStateForBinding;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _IsUsingLegacyInput();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _IsUsingLegacyInput IsUsingLegacyInput;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _OpenBindingUI(IntPtr pchAppKey, ulong ulActionSetHandle, ulong ulDeviceHandle, [MarshalAs(UnmanagedType.I1)] bool bShowOnDesktop);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _OpenBindingUI OpenBindingUI;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetBindingVariant(ulong ulDevicePath, System.Text.StringBuilder pchVariantArray, uint unVariantArraySize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetBindingVariant GetBindingVariant;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRIOBuffer
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EIOBufferError _Open(IntPtr pchPath, EIOBufferMode mode, uint unElementSize, uint unElements, ref ulong pulBuffer);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Open Open;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EIOBufferError _Close(ulong ulBuffer);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Close Close;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EIOBufferError _Read(ulong ulBuffer, IntPtr pDst, uint unBytes, ref uint punRead);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Read Read;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EIOBufferError _Write(ulong ulBuffer, IntPtr pSrc, uint unBytes);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Write Write;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _PropertyContainer(ulong ulBuffer);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _PropertyContainer PropertyContainer;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _HasReaders(ulong ulBuffer);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HasReaders HasReaders;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRSpatialAnchors
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRSpatialAnchorError _CreateSpatialAnchorFromDescriptor(IntPtr pchDescriptor, ref uint pHandleOut);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CreateSpatialAnchorFromDescriptor CreateSpatialAnchorFromDescriptor;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRSpatialAnchorError _CreateSpatialAnchorFromPose(uint unDeviceIndex, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPose, ref uint pHandleOut);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CreateSpatialAnchorFromPose CreateSpatialAnchorFromPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRSpatialAnchorError _GetSpatialAnchorPose(uint unHandle, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPoseOut);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSpatialAnchorPose GetSpatialAnchorPose;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRSpatialAnchorError _GetSpatialAnchorDescriptor(uint unHandle, System.Text.StringBuilder pchDescriptorOut, ref uint punDescriptorBufferLenInOut);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetSpatialAnchorDescriptor GetSpatialAnchorDescriptor;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRDebug
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRDebugError _EmitVrProfilerEvent(IntPtr pchMessage);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _EmitVrProfilerEvent EmitVrProfilerEvent;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRDebugError _BeginVrProfilerEvent(ref ulong pHandleOut);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _BeginVrProfilerEvent BeginVrProfilerEvent;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRDebugError _FinishVrProfilerEvent(ulong hHandle, IntPtr pchMessage);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _FinishVrProfilerEvent FinishVrProfilerEvent;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _DriverDebugRequest(uint unDeviceIndex, IntPtr pchRequest, System.Text.StringBuilder pchResponseBuffer, uint unResponseBufferSize);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _DriverDebugRequest DriverDebugRequest;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRIPCResourceManagerClient
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _NewSharedVulkanImage(uint nImageFormat, uint nWidth, uint nHeight, [MarshalAs(UnmanagedType.I1)] bool bRenderable, [MarshalAs(UnmanagedType.I1)] bool bMappable, [MarshalAs(UnmanagedType.I1)] bool bComputeAccess, uint unMipLevels, uint unArrayLayerCount, ref ulong pSharedHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _NewSharedVulkanImage NewSharedVulkanImage;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _NewSharedVulkanBuffer(uint nSize, uint nUsageFlags, ref ulong pSharedHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _NewSharedVulkanBuffer NewSharedVulkanBuffer;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _NewSharedVulkanSemaphore(ref ulong pSharedHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _NewSharedVulkanSemaphore NewSharedVulkanSemaphore;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _RefResource(ulong hSharedHandle, ref ulong pNewIpcHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RefResource RefResource;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _UnrefResource(ulong hSharedHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _UnrefResource UnrefResource;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetDmabufFormats(ref uint pOutFormatCount, ref uint pOutFormats);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDmabufFormats GetDmabufFormats;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _GetDmabufModifiers(EVRApplicationType eApplicationType, uint unDRMFormat, ref uint pOutModifierCount, ref ulong pOutModifiers);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDmabufModifiers GetDmabufModifiers;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _ImportDmabuf(EVRApplicationType eApplicationType, ref DmabufAttributes_t pDmabufAttributes, ref ulong pSharedHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ImportDmabuf ImportDmabuf;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool _ReceiveSharedFd(ulong ulIpcHandle, ref int pOutFd);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReceiveSharedFd ReceiveSharedFd;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _DestructIVRIPCResourceManagerClient();
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _DestructIVRIPCResourceManagerClient DestructIVRIPCResourceManagerClient;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRProperties
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedPropertyError _ReadPropertyBatch(ulong ulContainerHandle, ref PropertyRead_t pBatch, uint unBatchEntryCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReadPropertyBatch ReadPropertyBatch;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedPropertyError _WritePropertyBatch(ulong ulContainerHandle, ref PropertyWrite_t pBatch, uint unBatchEntryCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _WritePropertyBatch WritePropertyBatch;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _TrackedDeviceToPropertyContainer(uint nDevice);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _TrackedDeviceToPropertyContainer TrackedDeviceToPropertyContainer;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRPaths
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedPropertyError _ReadPathBatch(ulong ulRootHandle, ref PathRead_t pBatch, uint unBatchEntryCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReadPathBatch ReadPathBatch;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedPropertyError _WritePathBatch(ulong ulRootHandle, ref PathWrite_t pBatch, uint unBatchEntryCount);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _WritePathBatch WritePathBatch;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedPropertyError _StringToHandle(ref ulong pHandle, IntPtr pchPath);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _StringToHandle StringToHandle;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedPropertyError _HandleToString(ulong pHandle, string pchBuffer, uint unBufferSize, ref uint punBufferSizeUsed);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _HandleToString HandleToString;

	}

	[StructLayout(LayoutKind.Sequential)]
	public struct IVRBlockQueue
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _Create(ref ulong pulQueueHandle, IntPtr pchPath, uint unBlockDataSize, uint unBlockHeaderSize, uint unBlockCount, uint unFlags);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Create Create;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _Connect(ref ulong pulQueueHandle, IntPtr pchPath);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Connect Connect;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _Destroy(ulong ulQueueHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Destroy Destroy;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _AcquireWriteOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AcquireWriteOnlyBlock AcquireWriteOnlyBlock;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _ReleaseWriteOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseWriteOnlyBlock ReleaseWriteOnlyBlock;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _WaitAndAcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType, uint unTimeoutMs);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _WaitAndAcquireReadOnlyBlock WaitAndAcquireReadOnlyBlock;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _AcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AcquireReadOnlyBlock AcquireReadOnlyBlock;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _ReleaseReadOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseReadOnlyBlock ReleaseReadOnlyBlock;

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _QueueHasReader(ulong ulQueueHandle, [MarshalAs(UnmanagedType.I1)] ref bool pbHasReaders);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _QueueHasReader QueueHasReader;

	}


	public class Utils
	{
		public static IntPtr ToUtf8(string managedString)
		{
			if (managedString == null)
			{
				return IntPtr.Zero;
			}

			int size = System.Text.Encoding.UTF8.GetByteCount(managedString) + 1;
			if (buffer.Length < size) buffer = new byte[size];
			int written = System.Text.Encoding.UTF8.GetBytes(managedString, 0, managedString.Length, buffer, 0);
			buffer[written] = 0x00; // null terminate
			IntPtr nativeUtf8 = Marshal.AllocHGlobal(written + 1);
			Marshal.Copy(buffer, 0, nativeUtf8, written + 1);
			return nativeUtf8;
		}
		private static byte[] buffer = new byte[1024];
	}

	public class CVRSystem
	{
		IVRSystem FnTable;
		internal CVRSystem(IntPtr pInterface)
		{
			FnTable = (IVRSystem)Marshal.PtrToStructure(pInterface, typeof(IVRSystem));
		}
		public void GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight)
		{
			pnWidth = 0;
			pnHeight = 0;
			FnTable.GetRecommendedRenderTargetSize(ref pnWidth, ref pnHeight);
		}
		public HmdMatrix44_t GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ)
		{
			HmdMatrix44_t result = FnTable.GetProjectionMatrix(eEye, fNearZ, fFarZ);
			return result;
		}
		public void GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom)
		{
			pfLeft = 0;
			pfRight = 0;
			pfTop = 0;
			pfBottom = 0;
			FnTable.GetProjectionRaw(eEye, ref pfLeft, ref pfRight, ref pfTop, ref pfBottom);
		}
		public bool ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates)
		{
			bool result = FnTable.ComputeDistortion(eEye, fU, fV, ref pDistortionCoordinates);
			return result;
		}
		public HmdMatrix34_t GetEyeToHeadTransform(EVREye eEye)
		{
			HmdMatrix34_t result = FnTable.GetEyeToHeadTransform(eEye);
			return result;
		}
		public bool GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter)
		{
			pfSecondsSinceLastVsync = 0;
			pulFrameCounter = 0;
			bool result = FnTable.GetTimeSinceLastVsync(ref pfSecondsSinceLastVsync, ref pulFrameCounter);
			return result;
		}
		public int GetD3D9AdapterIndex()
		{
			int result = FnTable.GetD3D9AdapterIndex();
			return result;
		}
		public void GetDXGIOutputInfo(ref int pnAdapterIndex)
		{
			pnAdapterIndex = 0;
			FnTable.GetDXGIOutputInfo(ref pnAdapterIndex);
		}
		public void GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance)
		{
			pnDevice = 0;
			FnTable.GetOutputDevice(ref pnDevice, textureType, pInstance);
		}
		public bool IsDisplayOnDesktop()
		{
			bool result = FnTable.IsDisplayOnDesktop();
			return result;
		}
		public bool SetDisplayVisibility(bool bIsVisibleOnDesktop)
		{
			bool result = FnTable.SetDisplayVisibility(bIsVisibleOnDesktop);
			return result;
		}
		public void GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, TrackedDevicePose_t[] pTrackedDevicePoseArray)
		{
			FnTable.GetDeviceToAbsoluteTrackingPose(eOrigin, fPredictedSecondsToPhotonsFromNow, pTrackedDevicePoseArray, (uint)pTrackedDevicePoseArray.Length);
		}
		public HmdMatrix34_t GetSeatedZeroPoseToStandingAbsoluteTrackingPose()
		{
			HmdMatrix34_t result = FnTable.GetSeatedZeroPoseToStandingAbsoluteTrackingPose();
			return result;
		}
		public HmdMatrix34_t GetRawZeroPoseToStandingAbsoluteTrackingPose()
		{
			HmdMatrix34_t result = FnTable.GetRawZeroPoseToStandingAbsoluteTrackingPose();
			return result;
		}
		public uint GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, uint[] punTrackedDeviceIndexArray, uint unRelativeToTrackedDeviceIndex)
		{
			uint result = FnTable.GetSortedTrackedDeviceIndicesOfClass(eTrackedDeviceClass, punTrackedDeviceIndexArray, (uint)punTrackedDeviceIndexArray.Length, unRelativeToTrackedDeviceIndex);
			return result;
		}
		public EDeviceActivityLevel GetTrackedDeviceActivityLevel(uint unDeviceId)
		{
			EDeviceActivityLevel result = FnTable.GetTrackedDeviceActivityLevel(unDeviceId);
			return result;
		}
		public void ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform)
		{
			FnTable.ApplyTransform(ref pOutputPose, ref pTrackedDevicePose, ref pTransform);
		}
		public uint GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType)
		{
			uint result = FnTable.GetTrackedDeviceIndexForControllerRole(unDeviceType);
			return result;
		}
		public ETrackedControllerRole GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex)
		{
			ETrackedControllerRole result = FnTable.GetControllerRoleForTrackedDeviceIndex(unDeviceIndex);
			return result;
		}
		public ETrackedDeviceClass GetTrackedDeviceClass(uint unDeviceIndex)
		{
			ETrackedDeviceClass result = FnTable.GetTrackedDeviceClass(unDeviceIndex);
			return result;
		}
		public bool IsTrackedDeviceConnected(uint unDeviceIndex)
		{
			bool result = FnTable.IsTrackedDeviceConnected(unDeviceIndex);
			return result;
		}
		public bool GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			bool result = FnTable.GetBoolTrackedDeviceProperty(unDeviceIndex, prop, ref pError);
			return result;
		}
		public float GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			float result = FnTable.GetFloatTrackedDeviceProperty(unDeviceIndex, prop, ref pError);
			return result;
		}
		public int GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			int result = FnTable.GetInt32TrackedDeviceProperty(unDeviceIndex, prop, ref pError);
			return result;
		}
		public ulong GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			ulong result = FnTable.GetUint64TrackedDeviceProperty(unDeviceIndex, prop, ref pError);
			return result;
		}
		public HmdMatrix34_t GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			HmdMatrix34_t result = FnTable.GetMatrix34TrackedDeviceProperty(unDeviceIndex, prop, ref pError);
			return result;
		}
		public uint GetArrayTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError)
		{
			uint result = FnTable.GetArrayTrackedDeviceProperty(unDeviceIndex, prop, propType, pBuffer, unBufferSize, ref pError);
			return result;
		}
		public uint GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, System.Text.StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError)
		{
			uint result = FnTable.GetStringTrackedDeviceProperty(unDeviceIndex, prop, pchValue, unBufferSize, ref pError);
			return result;
		}
		public string GetPropErrorNameFromEnum(ETrackedPropertyError error)
		{
			IntPtr result = FnTable.GetPropErrorNameFromEnum(error);
			return Marshal.PtrToStringAnsi(result);
		}
		// This is a terrible hack to workaround the fact that VRControllerState_t and VREvent_t were
		// originally mis-compiled with the wrong packing for Linux and OSX.
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PollNextEventPacked(ref VREvent_t_Packed pEvent, uint uncbVREvent);
		[StructLayout(LayoutKind.Explicit)]
		struct PollNextEventUnion
		{
			[FieldOffset(0)]
			public IVRSystem._PollNextEvent pPollNextEvent;
			[FieldOffset(0)]
			public _PollNextEventPacked pPollNextEventPacked;
		}
		public bool PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent)
		{
#if !UNITY_METRO
			if ((System.Environment.OSVersion.Platform == System.PlatformID.MacOSX) ||
					(System.Environment.OSVersion.Platform == System.PlatformID.Unix))
			{
				PollNextEventUnion u;
				VREvent_t_Packed event_packed = new VREvent_t_Packed();
				u.pPollNextEventPacked = null;
				u.pPollNextEvent = FnTable.PollNextEvent;
				bool packed_result = u.pPollNextEventPacked(ref event_packed, (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(VREvent_t_Packed)));

				event_packed.Unpack(ref pEvent);
				return packed_result;
			}
#endif
			bool result = FnTable.PollNextEvent(ref pEvent, uncbVREvent);
			return result;
		}
		public bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose)
		{
			bool result = FnTable.PollNextEventWithPose(eOrigin, ref pEvent, uncbVREvent, ref pTrackedDevicePose);
			return result;
		}
		public string GetEventTypeNameFromEnum(EVREventType eType)
		{
			IntPtr result = FnTable.GetEventTypeNameFromEnum(eType);
			return Marshal.PtrToStringAnsi(result);
		}
		public HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type)
		{
			HiddenAreaMesh_t result = FnTable.GetHiddenAreaMesh(eEye, type);
			return result;
		}
		// This is a terrible hack to workaround the fact that VRControllerState_t and VREvent_t were
		// originally mis-compiled with the wrong packing for Linux and OSX.
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetControllerStatePacked(uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize);
		[StructLayout(LayoutKind.Explicit)]
		struct GetControllerStateUnion
		{
			[FieldOffset(0)]
			public IVRSystem._GetControllerState pGetControllerState;
			[FieldOffset(0)]
			public _GetControllerStatePacked pGetControllerStatePacked;
		}
		public bool GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize)
		{
#if !UNITY_METRO
			if ((System.Environment.OSVersion.Platform == System.PlatformID.MacOSX) ||
					(System.Environment.OSVersion.Platform == System.PlatformID.Unix))
			{
				GetControllerStateUnion u;
				VRControllerState_t_Packed state_packed = new VRControllerState_t_Packed(pControllerState);
				u.pGetControllerStatePacked = null;
				u.pGetControllerState = FnTable.GetControllerState;
				bool packed_result = u.pGetControllerStatePacked(unControllerDeviceIndex, ref state_packed, (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(VRControllerState_t_Packed)));

				state_packed.Unpack(ref pControllerState);
				return packed_result;
			}
#endif
			bool result = FnTable.GetControllerState(unControllerDeviceIndex, ref pControllerState, unControllerStateSize);
			return result;
		}
		// This is a terrible hack to workaround the fact that VRControllerState_t and VREvent_t were
		// originally mis-compiled with the wrong packing for Linux and OSX.
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetControllerStateWithPosePacked(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose);
		[StructLayout(LayoutKind.Explicit)]
		struct GetControllerStateWithPoseUnion
		{
			[FieldOffset(0)]
			public IVRSystem._GetControllerStateWithPose pGetControllerStateWithPose;
			[FieldOffset(0)]
			public _GetControllerStateWithPosePacked pGetControllerStateWithPosePacked;
		}
		public bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose)
		{
#if !UNITY_METRO
			if ((System.Environment.OSVersion.Platform == System.PlatformID.MacOSX) ||
					(System.Environment.OSVersion.Platform == System.PlatformID.Unix))
			{
				GetControllerStateWithPoseUnion u;
				VRControllerState_t_Packed state_packed = new VRControllerState_t_Packed(pControllerState);
				u.pGetControllerStateWithPosePacked = null;
				u.pGetControllerStateWithPose = FnTable.GetControllerStateWithPose;
				bool packed_result = u.pGetControllerStateWithPosePacked(eOrigin, unControllerDeviceIndex, ref state_packed, (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(VRControllerState_t_Packed)), ref pTrackedDevicePose);

				state_packed.Unpack(ref pControllerState);
				return packed_result;
			}
#endif
			bool result = FnTable.GetControllerStateWithPose(eOrigin, unControllerDeviceIndex, ref pControllerState, unControllerStateSize, ref pTrackedDevicePose);
			return result;
		}
		public void TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, ushort usDurationMicroSec)
		{
			FnTable.TriggerHapticPulse(unControllerDeviceIndex, unAxisId, usDurationMicroSec);
		}
		public string GetButtonIdNameFromEnum(EVRButtonId eButtonId)
		{
			IntPtr result = FnTable.GetButtonIdNameFromEnum(eButtonId);
			return Marshal.PtrToStringAnsi(result);
		}
		public string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType)
		{
			IntPtr result = FnTable.GetControllerAxisTypeNameFromEnum(eAxisType);
			return Marshal.PtrToStringAnsi(result);
		}
		public bool IsInputAvailable()
		{
			bool result = FnTable.IsInputAvailable();
			return result;
		}
		public bool IsSteamVRDrawingControllers()
		{
			bool result = FnTable.IsSteamVRDrawingControllers();
			return result;
		}
		public bool ShouldApplicationPause()
		{
			bool result = FnTable.ShouldApplicationPause();
			return result;
		}
		public bool ShouldApplicationReduceRenderingWork()
		{
			bool result = FnTable.ShouldApplicationReduceRenderingWork();
			return result;
		}
		public EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex)
		{
			EVRFirmwareError result = FnTable.PerformFirmwareUpdate(unDeviceIndex);
			return result;
		}
		public void AcknowledgeQuit_Exiting()
		{
			FnTable.AcknowledgeQuit_Exiting();
		}
		public uint GetAppContainerFilePaths(System.Text.StringBuilder pchBuffer, uint unBufferSize)
		{
			uint result = FnTable.GetAppContainerFilePaths(pchBuffer, unBufferSize);
			return result;
		}
		public string GetRuntimeVersion()
		{
			IntPtr result = FnTable.GetRuntimeVersion();
			return Marshal.PtrToStringAnsi(result);
		}
	}


	public class CVRExtendedDisplay
	{
		IVRExtendedDisplay FnTable;
		internal CVRExtendedDisplay(IntPtr pInterface)
		{
			FnTable = (IVRExtendedDisplay)Marshal.PtrToStructure(pInterface, typeof(IVRExtendedDisplay));
		}
		public void GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight)
		{
			pnX = 0;
			pnY = 0;
			pnWidth = 0;
			pnHeight = 0;
			FnTable.GetWindowBounds(ref pnX, ref pnY, ref pnWidth, ref pnHeight);
		}
		public void GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight)
		{
			pnX = 0;
			pnY = 0;
			pnWidth = 0;
			pnHeight = 0;
			FnTable.GetEyeOutputViewport(eEye, ref pnX, ref pnY, ref pnWidth, ref pnHeight);
		}
		public void GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex)
		{
			pnAdapterIndex = 0;
			pnAdapterOutputIndex = 0;
			FnTable.GetDXGIOutputInfo(ref pnAdapterIndex, ref pnAdapterOutputIndex);
		}
	}


	public class CVRTrackedCamera
	{
		IVRTrackedCamera FnTable;
		internal CVRTrackedCamera(IntPtr pInterface)
		{
			FnTable = (IVRTrackedCamera)Marshal.PtrToStructure(pInterface, typeof(IVRTrackedCamera));
		}
		public string GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError)
		{
			IntPtr result = FnTable.GetCameraErrorNameFromEnum(eCameraError);
			return Marshal.PtrToStringAnsi(result);
		}
		public EVRTrackedCameraError HasCamera(uint nDeviceIndex, ref bool pHasCamera)
		{
			pHasCamera = false;
			EVRTrackedCameraError result = FnTable.HasCamera(nDeviceIndex, ref pHasCamera);
			return result;
		}
		public EVRTrackedCameraError GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize)
		{
			pnWidth = 0;
			pnHeight = 0;
			pnFrameBufferSize = 0;
			EVRTrackedCameraError result = FnTable.GetCameraFrameSize(nDeviceIndex, eFrameType, ref pnWidth, ref pnHeight, ref pnFrameBufferSize);
			return result;
		}
		public EVRTrackedCameraError GetCameraIntrinsics(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter)
		{
			EVRTrackedCameraError result = FnTable.GetCameraIntrinsics(nDeviceIndex, nCameraIndex, eFrameType, ref pFocalLength, ref pCenter);
			return result;
		}
		public EVRTrackedCameraError GetCameraProjection(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection)
		{
			EVRTrackedCameraError result = FnTable.GetCameraProjection(nDeviceIndex, nCameraIndex, eFrameType, flZNear, flZFar, ref pProjection);
			return result;
		}
		public EVRTrackedCameraError AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle)
		{
			pHandle = 0;
			EVRTrackedCameraError result = FnTable.AcquireVideoStreamingService(nDeviceIndex, ref pHandle);
			return result;
		}
		public EVRTrackedCameraError ReleaseVideoStreamingService(ulong hTrackedCamera)
		{
			EVRTrackedCameraError result = FnTable.ReleaseVideoStreamingService(hTrackedCamera);
			return result;
		}
		public EVRTrackedCameraError GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
		{
			EVRTrackedCameraError result = FnTable.GetVideoStreamFrameBuffer(hTrackedCamera, eFrameType, pFrameBuffer, nFrameBufferSize, ref pFrameHeader, nFrameHeaderSize);
			return result;
		}
		public EVRTrackedCameraError GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight)
		{
			pnWidth = 0;
			pnHeight = 0;
			EVRTrackedCameraError result = FnTable.GetVideoStreamTextureSize(nDeviceIndex, eFrameType, ref pTextureBounds, ref pnWidth, ref pnHeight);
			return result;
		}
		public EVRTrackedCameraError GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
		{
			EVRTrackedCameraError result = FnTable.GetVideoStreamTextureD3D11(hTrackedCamera, eFrameType, pD3D11DeviceOrResource, ref ppD3D11ShaderResourceView, ref pFrameHeader, nFrameHeaderSize);
			return result;
		}
		public EVRTrackedCameraError GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
		{
			pglTextureId = 0;
			EVRTrackedCameraError result = FnTable.GetVideoStreamTextureGL(hTrackedCamera, eFrameType, ref pglTextureId, ref pFrameHeader, nFrameHeaderSize);
			return result;
		}
		public EVRTrackedCameraError ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId)
		{
			EVRTrackedCameraError result = FnTable.ReleaseVideoStreamTextureGL(hTrackedCamera, glTextureId);
			return result;
		}
		public void SetCameraTrackingSpace(ETrackingUniverseOrigin eUniverse)
		{
			FnTable.SetCameraTrackingSpace(eUniverse);
		}
		public ETrackingUniverseOrigin GetCameraTrackingSpace()
		{
			ETrackingUniverseOrigin result = FnTable.GetCameraTrackingSpace();
			return result;
		}
	}


	public class CVRApplications
	{
		IVRApplications FnTable;
		internal CVRApplications(IntPtr pInterface)
		{
			FnTable = (IVRApplications)Marshal.PtrToStructure(pInterface, typeof(IVRApplications));
		}
		public EVRApplicationError AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary)
		{
			IntPtr pchApplicationManifestFullPathUtf8 = Utils.ToUtf8(pchApplicationManifestFullPath);
			EVRApplicationError result = FnTable.AddApplicationManifest(pchApplicationManifestFullPathUtf8, bTemporary);
			Marshal.FreeHGlobal(pchApplicationManifestFullPathUtf8);
			return result;
		}
		public EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath)
		{
			IntPtr pchApplicationManifestFullPathUtf8 = Utils.ToUtf8(pchApplicationManifestFullPath);
			EVRApplicationError result = FnTable.RemoveApplicationManifest(pchApplicationManifestFullPathUtf8);
			Marshal.FreeHGlobal(pchApplicationManifestFullPathUtf8);
			return result;
		}
		public bool IsApplicationInstalled(string pchAppKey)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			bool result = FnTable.IsApplicationInstalled(pchAppKeyUtf8);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public uint GetApplicationCount()
		{
			uint result = FnTable.GetApplicationCount();
			return result;
		}
		public EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex, System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			EVRApplicationError result = FnTable.GetApplicationKeyByIndex(unApplicationIndex, pchAppKeyBuffer, unAppKeyBufferLen);
			return result;
		}
		public EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId, System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			EVRApplicationError result = FnTable.GetApplicationKeyByProcessId(unProcessId, pchAppKeyBuffer, unAppKeyBufferLen);
			return result;
		}
		public EVRApplicationError LaunchApplication(string pchAppKey)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			EVRApplicationError result = FnTable.LaunchApplication(pchAppKeyUtf8);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public EVRApplicationError LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, AppOverrideKeys_t[] pKeys)
		{
			IntPtr pchTemplateAppKeyUtf8 = Utils.ToUtf8(pchTemplateAppKey);
			IntPtr pchNewAppKeyUtf8 = Utils.ToUtf8(pchNewAppKey);
			EVRApplicationError result = FnTable.LaunchTemplateApplication(pchTemplateAppKeyUtf8, pchNewAppKeyUtf8, pKeys, (uint)pKeys.Length);
			Marshal.FreeHGlobal(pchTemplateAppKeyUtf8);
			Marshal.FreeHGlobal(pchNewAppKeyUtf8);
			return result;
		}
		public EVRApplicationError LaunchApplicationFromMimeType(string pchMimeType, string pchArgs)
		{
			IntPtr pchMimeTypeUtf8 = Utils.ToUtf8(pchMimeType);
			IntPtr pchArgsUtf8 = Utils.ToUtf8(pchArgs);
			EVRApplicationError result = FnTable.LaunchApplicationFromMimeType(pchMimeTypeUtf8, pchArgsUtf8);
			Marshal.FreeHGlobal(pchMimeTypeUtf8);
			Marshal.FreeHGlobal(pchArgsUtf8);
			return result;
		}
		public EVRApplicationError LaunchDashboardOverlay(string pchAppKey)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			EVRApplicationError result = FnTable.LaunchDashboardOverlay(pchAppKeyUtf8);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public bool CancelApplicationLaunch(string pchAppKey)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			bool result = FnTable.CancelApplicationLaunch(pchAppKeyUtf8);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public EVRApplicationError IdentifyApplication(uint unProcessId, string pchAppKey)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			EVRApplicationError result = FnTable.IdentifyApplication(unProcessId, pchAppKeyUtf8);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public uint GetApplicationProcessId(string pchAppKey)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			uint result = FnTable.GetApplicationProcessId(pchAppKeyUtf8);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public string GetApplicationsErrorNameFromEnum(EVRApplicationError error)
		{
			IntPtr result = FnTable.GetApplicationsErrorNameFromEnum(error);
			return Marshal.PtrToStringAnsi(result);
		}
		public uint GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, System.Text.StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			uint result = FnTable.GetApplicationPropertyString(pchAppKeyUtf8, eProperty, pchPropertyValueBuffer, unPropertyValueBufferLen, ref peError);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public bool GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			bool result = FnTable.GetApplicationPropertyBool(pchAppKeyUtf8, eProperty, ref peError);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public ulong GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			ulong result = FnTable.GetApplicationPropertyUint64(pchAppKeyUtf8, eProperty, ref peError);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public EVRApplicationError SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			EVRApplicationError result = FnTable.SetApplicationAutoLaunch(pchAppKeyUtf8, bAutoLaunch);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public bool GetApplicationAutoLaunch(string pchAppKey)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			bool result = FnTable.GetApplicationAutoLaunch(pchAppKeyUtf8);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public EVRApplicationError SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			IntPtr pchMimeTypeUtf8 = Utils.ToUtf8(pchMimeType);
			EVRApplicationError result = FnTable.SetDefaultApplicationForMimeType(pchAppKeyUtf8, pchMimeTypeUtf8);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			Marshal.FreeHGlobal(pchMimeTypeUtf8);
			return result;
		}
		public bool GetDefaultApplicationForMimeType(string pchMimeType, System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			IntPtr pchMimeTypeUtf8 = Utils.ToUtf8(pchMimeType);
			bool result = FnTable.GetDefaultApplicationForMimeType(pchMimeTypeUtf8, pchAppKeyBuffer, unAppKeyBufferLen);
			Marshal.FreeHGlobal(pchMimeTypeUtf8);
			return result;
		}
		public bool GetApplicationSupportedMimeTypes(string pchAppKey, System.Text.StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			bool result = FnTable.GetApplicationSupportedMimeTypes(pchAppKeyUtf8, pchMimeTypesBuffer, unMimeTypesBuffer);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public uint GetApplicationsThatSupportMimeType(string pchMimeType, System.Text.StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer)
		{
			IntPtr pchMimeTypeUtf8 = Utils.ToUtf8(pchMimeType);
			uint result = FnTable.GetApplicationsThatSupportMimeType(pchMimeTypeUtf8, pchAppKeysThatSupportBuffer, unAppKeysThatSupportBuffer);
			Marshal.FreeHGlobal(pchMimeTypeUtf8);
			return result;
		}
		public uint GetApplicationLaunchArguments(uint unHandle, System.Text.StringBuilder pchArgs, uint unArgs)
		{
			uint result = FnTable.GetApplicationLaunchArguments(unHandle, pchArgs, unArgs);
			return result;
		}
		public EVRApplicationError GetStartingApplication(System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			EVRApplicationError result = FnTable.GetStartingApplication(pchAppKeyBuffer, unAppKeyBufferLen);
			return result;
		}
		public EVRSceneApplicationState GetSceneApplicationState()
		{
			EVRSceneApplicationState result = FnTable.GetSceneApplicationState();
			return result;
		}
		public EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			EVRApplicationError result = FnTable.PerformApplicationPrelaunchCheck(pchAppKeyUtf8);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public string GetSceneApplicationStateNameFromEnum(EVRSceneApplicationState state)
		{
			IntPtr result = FnTable.GetSceneApplicationStateNameFromEnum(state);
			return Marshal.PtrToStringAnsi(result);
		}
		public EVRApplicationError LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory)
		{
			IntPtr pchBinaryPathUtf8 = Utils.ToUtf8(pchBinaryPath);
			IntPtr pchArgumentsUtf8 = Utils.ToUtf8(pchArguments);
			IntPtr pchWorkingDirectoryUtf8 = Utils.ToUtf8(pchWorkingDirectory);
			EVRApplicationError result = FnTable.LaunchInternalProcess(pchBinaryPathUtf8, pchArgumentsUtf8, pchWorkingDirectoryUtf8);
			Marshal.FreeHGlobal(pchBinaryPathUtf8);
			Marshal.FreeHGlobal(pchArgumentsUtf8);
			Marshal.FreeHGlobal(pchWorkingDirectoryUtf8);
			return result;
		}
		public uint GetCurrentSceneProcessId()
		{
			uint result = FnTable.GetCurrentSceneProcessId();
			return result;
		}
	}


	public class CVRChaperone
	{
		IVRChaperone FnTable;
		internal CVRChaperone(IntPtr pInterface)
		{
			FnTable = (IVRChaperone)Marshal.PtrToStructure(pInterface, typeof(IVRChaperone));
		}
		public ChaperoneCalibrationState GetCalibrationState()
		{
			ChaperoneCalibrationState result = FnTable.GetCalibrationState();
			return result;
		}
		public bool GetPlayAreaSize(ref float pSizeX, ref float pSizeZ)
		{
			pSizeX = 0;
			pSizeZ = 0;
			bool result = FnTable.GetPlayAreaSize(ref pSizeX, ref pSizeZ);
			return result;
		}
		public bool GetPlayAreaRect(ref HmdQuad_t rect)
		{
			bool result = FnTable.GetPlayAreaRect(ref rect);
			return result;
		}
		public void ReloadInfo()
		{
			FnTable.ReloadInfo();
		}
		public void SetSceneColor(HmdColor_t color)
		{
			FnTable.SetSceneColor(color);
		}
		public void GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor)
		{
			FnTable.GetBoundsColor(ref pOutputColorArray, nNumOutputColors, flCollisionBoundsFadeDistance, ref pOutputCameraColor);
		}
		public bool AreBoundsVisible()
		{
			bool result = FnTable.AreBoundsVisible();
			return result;
		}
		public void ForceBoundsVisible(bool bForce)
		{
			FnTable.ForceBoundsVisible(bForce);
		}
		public void ResetZeroPose(ETrackingUniverseOrigin eTrackingUniverseOrigin)
		{
			FnTable.ResetZeroPose(eTrackingUniverseOrigin);
		}
	}


	public class CVRChaperoneSetup
	{
		IVRChaperoneSetup FnTable;
		internal CVRChaperoneSetup(IntPtr pInterface)
		{
			FnTable = (IVRChaperoneSetup)Marshal.PtrToStructure(pInterface, typeof(IVRChaperoneSetup));
		}
		public bool CommitWorkingCopy(EChaperoneConfigFile configFile)
		{
			bool result = FnTable.CommitWorkingCopy(configFile);
			return result;
		}
		public void RevertWorkingCopy()
		{
			FnTable.RevertWorkingCopy();
		}
		public bool GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ)
		{
			pSizeX = 0;
			pSizeZ = 0;
			bool result = FnTable.GetWorkingPlayAreaSize(ref pSizeX, ref pSizeZ);
			return result;
		}
		public bool GetWorkingPlayAreaRect(ref HmdQuad_t rect)
		{
			bool result = FnTable.GetWorkingPlayAreaRect(ref rect);
			return result;
		}
		public bool GetWorkingCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			uint punQuadsCount = 0;
			bool result = FnTable.GetWorkingCollisionBoundsInfo(null, ref punQuadsCount);
			pQuadsBuffer = new HmdQuad_t[punQuadsCount];
			result = FnTable.GetWorkingCollisionBoundsInfo(pQuadsBuffer, ref punQuadsCount);
			return result;
		}
		public bool GetLiveCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			uint punQuadsCount = 0;
			bool result = FnTable.GetLiveCollisionBoundsInfo(null, ref punQuadsCount);
			pQuadsBuffer = new HmdQuad_t[punQuadsCount];
			result = FnTable.GetLiveCollisionBoundsInfo(pQuadsBuffer, ref punQuadsCount);
			return result;
		}
		public bool GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
		{
			bool result = FnTable.GetWorkingSeatedZeroPoseToRawTrackingPose(ref pmatSeatedZeroPoseToRawTrackingPose);
			return result;
		}
		public bool GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose)
		{
			bool result = FnTable.GetWorkingStandingZeroPoseToRawTrackingPose(ref pmatStandingZeroPoseToRawTrackingPose);
			return result;
		}
		public void SetWorkingPlayAreaSize(float sizeX, float sizeZ)
		{
			FnTable.SetWorkingPlayAreaSize(sizeX, sizeZ);
		}
		public void SetWorkingCollisionBoundsInfo(HmdQuad_t[] pQuadsBuffer)
		{
			FnTable.SetWorkingCollisionBoundsInfo(pQuadsBuffer, (uint)pQuadsBuffer.Length);
		}
		public void SetWorkingPerimeter(HmdVector2_t[] pPointBuffer)
		{
			FnTable.SetWorkingPerimeter(pPointBuffer, (uint)pPointBuffer.Length);
		}
		public void SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose)
		{
			FnTable.SetWorkingSeatedZeroPoseToRawTrackingPose(ref pMatSeatedZeroPoseToRawTrackingPose);
		}
		public void SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose)
		{
			FnTable.SetWorkingStandingZeroPoseToRawTrackingPose(ref pMatStandingZeroPoseToRawTrackingPose);
		}
		public void ReloadFromDisk(EChaperoneConfigFile configFile)
		{
			FnTable.ReloadFromDisk(configFile);
		}
		public bool GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
		{
			bool result = FnTable.GetLiveSeatedZeroPoseToRawTrackingPose(ref pmatSeatedZeroPoseToRawTrackingPose);
			return result;
		}
		public bool ExportLiveToBuffer(System.Text.StringBuilder pBuffer, ref uint pnBufferLength)
		{
			pnBufferLength = 0;
			bool result = FnTable.ExportLiveToBuffer(pBuffer, ref pnBufferLength);
			return result;
		}
		public bool ImportFromBufferToWorking(string pBuffer, uint nImportFlags)
		{
			IntPtr pBufferUtf8 = Utils.ToUtf8(pBuffer);
			bool result = FnTable.ImportFromBufferToWorking(pBufferUtf8, nImportFlags);
			Marshal.FreeHGlobal(pBufferUtf8);
			return result;
		}
		public void ShowWorkingSetPreview()
		{
			FnTable.ShowWorkingSetPreview();
		}
		public void HideWorkingSetPreview()
		{
			FnTable.HideWorkingSetPreview();
		}
		public void RoomSetupStarting()
		{
			FnTable.RoomSetupStarting();
		}
	}


	public class CVRCompositor
	{
		IVRCompositor FnTable;
		internal CVRCompositor(IntPtr pInterface)
		{
			FnTable = (IVRCompositor)Marshal.PtrToStructure(pInterface, typeof(IVRCompositor));
		}
		public void SetTrackingSpace(ETrackingUniverseOrigin eOrigin)
		{
			FnTable.SetTrackingSpace(eOrigin);
		}
		public ETrackingUniverseOrigin GetTrackingSpace()
		{
			ETrackingUniverseOrigin result = FnTable.GetTrackingSpace();
			return result;
		}
		public EVRCompositorError WaitGetPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray)
		{
			EVRCompositorError result = FnTable.WaitGetPoses(pRenderPoseArray, (uint)pRenderPoseArray.Length, pGamePoseArray, (uint)pGamePoseArray.Length);
			return result;
		}
		public EVRCompositorError GetLastPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray)
		{
			EVRCompositorError result = FnTable.GetLastPoses(pRenderPoseArray, (uint)pRenderPoseArray.Length, pGamePoseArray, (uint)pGamePoseArray.Length);
			return result;
		}
		public EVRCompositorError GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose)
		{
			EVRCompositorError result = FnTable.GetLastPoseForTrackedDeviceIndex(unDeviceIndex, ref pOutputPose, ref pOutputGamePose);
			return result;
		}
		public EVRCompositorError Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags)
		{
			EVRCompositorError result = FnTable.Submit(eEye, ref pTexture, ref pBounds, nSubmitFlags);
			return result;
		}
		public EVRCompositorError SubmitWithArrayIndex(EVREye eEye, ref Texture_t pTexture, uint unTextureArrayIndex, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags)
		{
			EVRCompositorError result = FnTable.SubmitWithArrayIndex(eEye, ref pTexture, unTextureArrayIndex, ref pBounds, nSubmitFlags);
			return result;
		}
		public void ClearLastSubmittedFrame()
		{
			FnTable.ClearLastSubmittedFrame();
		}
		public void PostPresentHandoff()
		{
			FnTable.PostPresentHandoff();
		}
		public bool GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo)
		{
			bool result = FnTable.GetFrameTiming(ref pTiming, unFramesAgo);
			return result;
		}
		public uint GetFrameTimings(Compositor_FrameTiming[] pTiming)
		{
			uint result = FnTable.GetFrameTimings(pTiming, (uint)pTiming.Length);
			return result;
		}
		public float GetFrameTimeRemaining()
		{
			float result = FnTable.GetFrameTimeRemaining();
			return result;
		}
		public void GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes)
		{
			FnTable.GetCumulativeStats(ref pStats, nStatsSizeInBytes);
		}
		public void FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground)
		{
			FnTable.FadeToColor(fSeconds, fRed, fGreen, fBlue, fAlpha, bBackground);
		}
		public HmdColor_t GetCurrentFadeColor(bool bBackground)
		{
			HmdColor_t result = FnTable.GetCurrentFadeColor(bBackground);
			return result;
		}
		public void FadeGrid(float fSeconds, bool bFadeGridIn)
		{
			FnTable.FadeGrid(fSeconds, bFadeGridIn);
		}
		public float GetCurrentGridAlpha()
		{
			float result = FnTable.GetCurrentGridAlpha();
			return result;
		}
		public EVRCompositorError SetSkyboxOverride(Texture_t[] pTextures)
		{
			EVRCompositorError result = FnTable.SetSkyboxOverride(pTextures, (uint)pTextures.Length);
			return result;
		}
		public void ClearSkyboxOverride()
		{
			FnTable.ClearSkyboxOverride();
		}
		public void CompositorBringToFront()
		{
			FnTable.CompositorBringToFront();
		}
		public void CompositorGoToBack()
		{
			FnTable.CompositorGoToBack();
		}
		public void CompositorQuit()
		{
			FnTable.CompositorQuit();
		}
		public bool IsFullscreen()
		{
			bool result = FnTable.IsFullscreen();
			return result;
		}
		public uint GetCurrentSceneFocusProcess()
		{
			uint result = FnTable.GetCurrentSceneFocusProcess();
			return result;
		}
		public uint GetLastFrameRenderer()
		{
			uint result = FnTable.GetLastFrameRenderer();
			return result;
		}
		public bool CanRenderScene()
		{
			bool result = FnTable.CanRenderScene();
			return result;
		}
		public void ShowMirrorWindow()
		{
			FnTable.ShowMirrorWindow();
		}
		public void HideMirrorWindow()
		{
			FnTable.HideMirrorWindow();
		}
		public bool IsMirrorWindowVisible()
		{
			bool result = FnTable.IsMirrorWindowVisible();
			return result;
		}
		public void CompositorDumpImages()
		{
			FnTable.CompositorDumpImages();
		}
		public bool ShouldAppRenderWithLowResources()
		{
			bool result = FnTable.ShouldAppRenderWithLowResources();
			return result;
		}
		public void ForceInterleavedReprojectionOn(bool bOverride)
		{
			FnTable.ForceInterleavedReprojectionOn(bOverride);
		}
		public void ForceReconnectProcess()
		{
			FnTable.ForceReconnectProcess();
		}
		public void SuspendRendering(bool bSuspend)
		{
			FnTable.SuspendRendering(bSuspend);
		}
		public EVRCompositorError GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView)
		{
			EVRCompositorError result = FnTable.GetMirrorTextureD3D11(eEye, pD3D11DeviceOrResource, ref ppD3D11ShaderResourceView);
			return result;
		}
		public void ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView)
		{
			FnTable.ReleaseMirrorTextureD3D11(pD3D11ShaderResourceView);
		}
		public EVRCompositorError GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle)
		{
			pglTextureId = 0;
			EVRCompositorError result = FnTable.GetMirrorTextureGL(eEye, ref pglTextureId, pglSharedTextureHandle);
			return result;
		}
		public bool ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle)
		{
			bool result = FnTable.ReleaseSharedGLTexture(glTextureId, glSharedTextureHandle);
			return result;
		}
		public void LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
		{
			FnTable.LockGLSharedTextureForAccess(glSharedTextureHandle);
		}
		public void UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
		{
			FnTable.UnlockGLSharedTextureForAccess(glSharedTextureHandle);
		}
		public uint GetVulkanInstanceExtensionsRequired(System.Text.StringBuilder pchValue, uint unBufferSize)
		{
			uint result = FnTable.GetVulkanInstanceExtensionsRequired(pchValue, unBufferSize);
			return result;
		}
		public uint GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, System.Text.StringBuilder pchValue, uint unBufferSize)
		{
			uint result = FnTable.GetVulkanDeviceExtensionsRequired(pPhysicalDevice, pchValue, unBufferSize);
			return result;
		}
		public void SetExplicitTimingMode(EVRCompositorTimingMode eTimingMode)
		{
			FnTable.SetExplicitTimingMode(eTimingMode);
		}
		public EVRCompositorError SubmitExplicitTimingData()
		{
			EVRCompositorError result = FnTable.SubmitExplicitTimingData();
			return result;
		}
		public bool IsMotionSmoothingEnabled()
		{
			bool result = FnTable.IsMotionSmoothingEnabled();
			return result;
		}
		public bool IsMotionSmoothingSupported()
		{
			bool result = FnTable.IsMotionSmoothingSupported();
			return result;
		}
		public bool IsCurrentSceneFocusAppLoading()
		{
			bool result = FnTable.IsCurrentSceneFocusAppLoading();
			return result;
		}
		public EVRCompositorError SetStageOverride_Async(string pchRenderModelPath, ref HmdMatrix34_t pTransform, ref Compositor_StageRenderSettings pRenderSettings, uint nSizeOfRenderSettings)
		{
			IntPtr pchRenderModelPathUtf8 = Utils.ToUtf8(pchRenderModelPath);
			EVRCompositorError result = FnTable.SetStageOverride_Async(pchRenderModelPathUtf8, ref pTransform, ref pRenderSettings, nSizeOfRenderSettings);
			Marshal.FreeHGlobal(pchRenderModelPathUtf8);
			return result;
		}
		public void ClearStageOverride()
		{
			FnTable.ClearStageOverride();
		}
		public bool GetCompositorBenchmarkResults(ref Compositor_BenchmarkResults pBenchmarkResults, uint nSizeOfBenchmarkResults)
		{
			bool result = FnTable.GetCompositorBenchmarkResults(ref pBenchmarkResults, nSizeOfBenchmarkResults);
			return result;
		}
		public EVRCompositorError GetLastPosePredictionIDs(ref uint pRenderPosePredictionID, ref uint pGamePosePredictionID)
		{
			pRenderPosePredictionID = 0;
			pGamePosePredictionID = 0;
			EVRCompositorError result = FnTable.GetLastPosePredictionIDs(ref pRenderPosePredictionID, ref pGamePosePredictionID);
			return result;
		}
		public EVRCompositorError GetPosesForFrame(uint unPosePredictionID, TrackedDevicePose_t[] pPoseArray)
		{
			EVRCompositorError result = FnTable.GetPosesForFrame(unPosePredictionID, pPoseArray, (uint)pPoseArray.Length);
			return result;
		}
	}


	public class CVROverlay
	{
		IVROverlay FnTable;
		internal CVROverlay(IntPtr pInterface)
		{
			FnTable = (IVROverlay)Marshal.PtrToStructure(pInterface, typeof(IVROverlay));
		}
		public EVROverlayError FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle)
		{
			IntPtr pchOverlayKeyUtf8 = Utils.ToUtf8(pchOverlayKey);
			pOverlayHandle = 0;
			EVROverlayError result = FnTable.FindOverlay(pchOverlayKeyUtf8, ref pOverlayHandle);
			Marshal.FreeHGlobal(pchOverlayKeyUtf8);
			return result;
		}
		public EVROverlayError CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle)
		{
			IntPtr pchOverlayKeyUtf8 = Utils.ToUtf8(pchOverlayKey);
			IntPtr pchOverlayNameUtf8 = Utils.ToUtf8(pchOverlayName);
			pOverlayHandle = 0;
			EVROverlayError result = FnTable.CreateOverlay(pchOverlayKeyUtf8, pchOverlayNameUtf8, ref pOverlayHandle);
			Marshal.FreeHGlobal(pchOverlayKeyUtf8);
			Marshal.FreeHGlobal(pchOverlayNameUtf8);
			return result;
		}
		public EVROverlayError CreateSubviewOverlay(ulong parentOverlayHandle, string pchSubviewOverlayKey, string pchSubviewOverlayName, ref ulong pSubviewOverlayHandle)
		{
			IntPtr pchSubviewOverlayKeyUtf8 = Utils.ToUtf8(pchSubviewOverlayKey);
			IntPtr pchSubviewOverlayNameUtf8 = Utils.ToUtf8(pchSubviewOverlayName);
			pSubviewOverlayHandle = 0;
			EVROverlayError result = FnTable.CreateSubviewOverlay(parentOverlayHandle, pchSubviewOverlayKeyUtf8, pchSubviewOverlayNameUtf8, ref pSubviewOverlayHandle);
			Marshal.FreeHGlobal(pchSubviewOverlayKeyUtf8);
			Marshal.FreeHGlobal(pchSubviewOverlayNameUtf8);
			return result;
		}
		public EVROverlayError DestroyOverlay(ulong ulOverlayHandle)
		{
			EVROverlayError result = FnTable.DestroyOverlay(ulOverlayHandle);
			return result;
		}
		public uint GetOverlayKey(ulong ulOverlayHandle, System.Text.StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError)
		{
			uint result = FnTable.GetOverlayKey(ulOverlayHandle, pchValue, unBufferSize, ref pError);
			return result;
		}
		public uint GetOverlayName(ulong ulOverlayHandle, System.Text.StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError)
		{
			uint result = FnTable.GetOverlayName(ulOverlayHandle, pchValue, unBufferSize, ref pError);
			return result;
		}
		public EVROverlayError SetOverlayName(ulong ulOverlayHandle, string pchName)
		{
			IntPtr pchNameUtf8 = Utils.ToUtf8(pchName);
			EVROverlayError result = FnTable.SetOverlayName(ulOverlayHandle, pchNameUtf8);
			Marshal.FreeHGlobal(pchNameUtf8);
			return result;
		}
		public EVROverlayError GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight)
		{
			punWidth = 0;
			punHeight = 0;
			EVROverlayError result = FnTable.GetOverlayImageData(ulOverlayHandle, pvBuffer, unBufferSize, ref punWidth, ref punHeight);
			return result;
		}
		public string GetOverlayErrorNameFromEnum(EVROverlayError error)
		{
			IntPtr result = FnTable.GetOverlayErrorNameFromEnum(error);
			return Marshal.PtrToStringAnsi(result);
		}
		public EVROverlayError SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID)
		{
			EVROverlayError result = FnTable.SetOverlayRenderingPid(ulOverlayHandle, unPID);
			return result;
		}
		public uint GetOverlayRenderingPid(ulong ulOverlayHandle)
		{
			uint result = FnTable.GetOverlayRenderingPid(ulOverlayHandle);
			return result;
		}
		public EVROverlayError SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled)
		{
			EVROverlayError result = FnTable.SetOverlayFlag(ulOverlayHandle, eOverlayFlag, bEnabled);
			return result;
		}
		public EVROverlayError GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled)
		{
			pbEnabled = false;
			EVROverlayError result = FnTable.GetOverlayFlag(ulOverlayHandle, eOverlayFlag, ref pbEnabled);
			return result;
		}
		public EVROverlayError GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags)
		{
			pFlags = 0;
			EVROverlayError result = FnTable.GetOverlayFlags(ulOverlayHandle, ref pFlags);
			return result;
		}
		public EVROverlayError SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue)
		{
			EVROverlayError result = FnTable.SetOverlayColor(ulOverlayHandle, fRed, fGreen, fBlue);
			return result;
		}
		public EVROverlayError GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue)
		{
			pfRed = 0;
			pfGreen = 0;
			pfBlue = 0;
			EVROverlayError result = FnTable.GetOverlayColor(ulOverlayHandle, ref pfRed, ref pfGreen, ref pfBlue);
			return result;
		}
		public EVROverlayError SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha)
		{
			EVROverlayError result = FnTable.SetOverlayAlpha(ulOverlayHandle, fAlpha);
			return result;
		}
		public EVROverlayError GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha)
		{
			pfAlpha = 0;
			EVROverlayError result = FnTable.GetOverlayAlpha(ulOverlayHandle, ref pfAlpha);
			return result;
		}
		public EVROverlayError SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect)
		{
			EVROverlayError result = FnTable.SetOverlayTexelAspect(ulOverlayHandle, fTexelAspect);
			return result;
		}
		public EVROverlayError GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect)
		{
			pfTexelAspect = 0;
			EVROverlayError result = FnTable.GetOverlayTexelAspect(ulOverlayHandle, ref pfTexelAspect);
			return result;
		}
		public EVROverlayError SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder)
		{
			EVROverlayError result = FnTable.SetOverlaySortOrder(ulOverlayHandle, unSortOrder);
			return result;
		}
		public EVROverlayError GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder)
		{
			punSortOrder = 0;
			EVROverlayError result = FnTable.GetOverlaySortOrder(ulOverlayHandle, ref punSortOrder);
			return result;
		}
		public EVROverlayError SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters)
		{
			EVROverlayError result = FnTable.SetOverlayWidthInMeters(ulOverlayHandle, fWidthInMeters);
			return result;
		}
		public EVROverlayError GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters)
		{
			pfWidthInMeters = 0;
			EVROverlayError result = FnTable.GetOverlayWidthInMeters(ulOverlayHandle, ref pfWidthInMeters);
			return result;
		}
		public EVROverlayError SetOverlayCurvature(ulong ulOverlayHandle, float fCurvature)
		{
			EVROverlayError result = FnTable.SetOverlayCurvature(ulOverlayHandle, fCurvature);
			return result;
		}
		public EVROverlayError GetOverlayCurvature(ulong ulOverlayHandle, ref float pfCurvature)
		{
			pfCurvature = 0;
			EVROverlayError result = FnTable.GetOverlayCurvature(ulOverlayHandle, ref pfCurvature);
			return result;
		}
		public EVROverlayError SetOverlayPreCurvePitch(ulong ulOverlayHandle, float fRadians)
		{
			EVROverlayError result = FnTable.SetOverlayPreCurvePitch(ulOverlayHandle, fRadians);
			return result;
		}
		public EVROverlayError GetOverlayPreCurvePitch(ulong ulOverlayHandle, ref float pfRadians)
		{
			pfRadians = 0;
			EVROverlayError result = FnTable.GetOverlayPreCurvePitch(ulOverlayHandle, ref pfRadians);
			return result;
		}
		public EVROverlayError SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace)
		{
			EVROverlayError result = FnTable.SetOverlayTextureColorSpace(ulOverlayHandle, eTextureColorSpace);
			return result;
		}
		public EVROverlayError GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace)
		{
			EVROverlayError result = FnTable.GetOverlayTextureColorSpace(ulOverlayHandle, ref peTextureColorSpace);
			return result;
		}
		public EVROverlayError SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds)
		{
			EVROverlayError result = FnTable.SetOverlayTextureBounds(ulOverlayHandle, ref pOverlayTextureBounds);
			return result;
		}
		public EVROverlayError GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds)
		{
			EVROverlayError result = FnTable.GetOverlayTextureBounds(ulOverlayHandle, ref pOverlayTextureBounds);
			return result;
		}
		public EVROverlayError GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType)
		{
			EVROverlayError result = FnTable.GetOverlayTransformType(ulOverlayHandle, ref peTransformType);
			return result;
		}
		public EVROverlayError SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
		{
			EVROverlayError result = FnTable.SetOverlayTransformAbsolute(ulOverlayHandle, eTrackingOrigin, ref pmatTrackingOriginToOverlayTransform);
			return result;
		}
		public EVROverlayError GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
		{
			EVROverlayError result = FnTable.GetOverlayTransformAbsolute(ulOverlayHandle, ref peTrackingOrigin, ref pmatTrackingOriginToOverlayTransform);
			return result;
		}
		public EVROverlayError SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
		{
			EVROverlayError result = FnTable.SetOverlayTransformTrackedDeviceRelative(ulOverlayHandle, unTrackedDevice, ref pmatTrackedDeviceToOverlayTransform);
			return result;
		}
		public EVROverlayError GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
		{
			punTrackedDevice = 0;
			EVROverlayError result = FnTable.GetOverlayTransformTrackedDeviceRelative(ulOverlayHandle, ref punTrackedDevice, ref pmatTrackedDeviceToOverlayTransform);
			return result;
		}
		public EVROverlayError SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName)
		{
			IntPtr pchComponentNameUtf8 = Utils.ToUtf8(pchComponentName);
			EVROverlayError result = FnTable.SetOverlayTransformTrackedDeviceComponent(ulOverlayHandle, unDeviceIndex, pchComponentNameUtf8);
			Marshal.FreeHGlobal(pchComponentNameUtf8);
			return result;
		}
		public EVROverlayError GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, System.Text.StringBuilder pchComponentName, uint unComponentNameSize)
		{
			punDeviceIndex = 0;
			EVROverlayError result = FnTable.GetOverlayTransformTrackedDeviceComponent(ulOverlayHandle, ref punDeviceIndex, pchComponentName, unComponentNameSize);
			return result;
		}
		public EVROverlayError SetOverlayTransformCursor(ulong ulCursorOverlayHandle, ref HmdVector2_t pvHotspot)
		{
			EVROverlayError result = FnTable.SetOverlayTransformCursor(ulCursorOverlayHandle, ref pvHotspot);
			return result;
		}
		public EVROverlayError GetOverlayTransformCursor(ulong ulOverlayHandle, ref HmdVector2_t pvHotspot)
		{
			EVROverlayError result = FnTable.GetOverlayTransformCursor(ulOverlayHandle, ref pvHotspot);
			return result;
		}
		public EVROverlayError SetOverlayTransformProjection(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform, ref VROverlayProjection_t pProjection, EVREye eEye)
		{
			EVROverlayError result = FnTable.SetOverlayTransformProjection(ulOverlayHandle, eTrackingOrigin, ref pmatTrackingOriginToOverlayTransform, ref pProjection, eEye);
			return result;
		}
		public EVROverlayError SetSubviewPosition(ulong ulOverlayHandle, float fX, float fY)
		{
			EVROverlayError result = FnTable.SetSubviewPosition(ulOverlayHandle, fX, fY);
			return result;
		}
		public EVROverlayError ShowOverlay(ulong ulOverlayHandle)
		{
			EVROverlayError result = FnTable.ShowOverlay(ulOverlayHandle);
			return result;
		}
		public EVROverlayError HideOverlay(ulong ulOverlayHandle)
		{
			EVROverlayError result = FnTable.HideOverlay(ulOverlayHandle);
			return result;
		}
		public bool IsOverlayVisible(ulong ulOverlayHandle)
		{
			bool result = FnTable.IsOverlayVisible(ulOverlayHandle);
			return result;
		}
		public EVROverlayError GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform)
		{
			EVROverlayError result = FnTable.GetTransformForOverlayCoordinates(ulOverlayHandle, eTrackingOrigin, coordinatesInOverlay, ref pmatTransform);
			return result;
		}
		public EVROverlayError WaitFrameSync(uint nTimeoutMs)
		{
			EVROverlayError result = FnTable.WaitFrameSync(nTimeoutMs);
			return result;
		}
		// This is a terrible hack to workaround the fact that VRControllerState_t and VREvent_t were
		// originally mis-compiled with the wrong packing for Linux and OSX.
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PollNextOverlayEventPacked(ulong ulOverlayHandle, ref VREvent_t_Packed pEvent, uint uncbVREvent);
		[StructLayout(LayoutKind.Explicit)]
		struct PollNextOverlayEventUnion
		{
			[FieldOffset(0)]
			public IVROverlay._PollNextOverlayEvent pPollNextOverlayEvent;
			[FieldOffset(0)]
			public _PollNextOverlayEventPacked pPollNextOverlayEventPacked;
		}
		public bool PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent)
		{
#if !UNITY_METRO
			if ((System.Environment.OSVersion.Platform == System.PlatformID.MacOSX) ||
					(System.Environment.OSVersion.Platform == System.PlatformID.Unix))
			{
				PollNextOverlayEventUnion u;
				VREvent_t_Packed event_packed = new VREvent_t_Packed();
				u.pPollNextOverlayEventPacked = null;
				u.pPollNextOverlayEvent = FnTable.PollNextOverlayEvent;
				bool packed_result = u.pPollNextOverlayEventPacked(ulOverlayHandle, ref event_packed, (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(VREvent_t_Packed)));

				event_packed.Unpack(ref pEvent);
				return packed_result;
			}
#endif
			bool result = FnTable.PollNextOverlayEvent(ulOverlayHandle, ref pEvent, uncbVREvent);
			return result;
		}
		public EVROverlayError GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod)
		{
			EVROverlayError result = FnTable.GetOverlayInputMethod(ulOverlayHandle, ref peInputMethod);
			return result;
		}
		public EVROverlayError SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod)
		{
			EVROverlayError result = FnTable.SetOverlayInputMethod(ulOverlayHandle, eInputMethod);
			return result;
		}
		public EVROverlayError GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale)
		{
			EVROverlayError result = FnTable.GetOverlayMouseScale(ulOverlayHandle, ref pvecMouseScale);
			return result;
		}
		public EVROverlayError SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale)
		{
			EVROverlayError result = FnTable.SetOverlayMouseScale(ulOverlayHandle, ref pvecMouseScale);
			return result;
		}
		public bool ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults)
		{
			bool result = FnTable.ComputeOverlayIntersection(ulOverlayHandle, ref pParams, ref pResults);
			return result;
		}
		public bool IsHoverTargetOverlay(ulong ulOverlayHandle)
		{
			bool result = FnTable.IsHoverTargetOverlay(ulOverlayHandle);
			return result;
		}
		public EVROverlayError SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize)
		{
			EVROverlayError result = FnTable.SetOverlayIntersectionMask(ulOverlayHandle, ref pMaskPrimitives, unNumMaskPrimitives, unPrimitiveSize);
			return result;
		}
		public EVROverlayError TriggerLaserMouseHapticVibration(ulong ulOverlayHandle, float fDurationSeconds, float fFrequency, float fAmplitude)
		{
			EVROverlayError result = FnTable.TriggerLaserMouseHapticVibration(ulOverlayHandle, fDurationSeconds, fFrequency, fAmplitude);
			return result;
		}
		public EVROverlayError SetOverlayCursor(ulong ulOverlayHandle, ulong ulCursorHandle)
		{
			EVROverlayError result = FnTable.SetOverlayCursor(ulOverlayHandle, ulCursorHandle);
			return result;
		}
		public EVROverlayError SetOverlayCursorPositionOverride(ulong ulOverlayHandle, ref HmdVector2_t pvCursor)
		{
			EVROverlayError result = FnTable.SetOverlayCursorPositionOverride(ulOverlayHandle, ref pvCursor);
			return result;
		}
		public EVROverlayError ClearOverlayCursorPositionOverride(ulong ulOverlayHandle)
		{
			EVROverlayError result = FnTable.ClearOverlayCursorPositionOverride(ulOverlayHandle);
			return result;
		}
		public EVROverlayError SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture)
		{
			EVROverlayError result = FnTable.SetOverlayTexture(ulOverlayHandle, ref pTexture);
			return result;
		}
		public EVROverlayError ClearOverlayTexture(ulong ulOverlayHandle)
		{
			EVROverlayError result = FnTable.ClearOverlayTexture(ulOverlayHandle);
			return result;
		}
		public EVROverlayError SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unBytesPerPixel)
		{
			EVROverlayError result = FnTable.SetOverlayRaw(ulOverlayHandle, pvBuffer, unWidth, unHeight, unBytesPerPixel);
			return result;
		}
		public EVROverlayError SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath)
		{
			IntPtr pchFilePathUtf8 = Utils.ToUtf8(pchFilePath);
			EVROverlayError result = FnTable.SetOverlayFromFile(ulOverlayHandle, pchFilePathUtf8);
			Marshal.FreeHGlobal(pchFilePathUtf8);
			return result;
		}
		public EVROverlayError GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds)
		{
			pWidth = 0;
			pHeight = 0;
			pNativeFormat = 0;
			EVROverlayError result = FnTable.GetOverlayTexture(ulOverlayHandle, ref pNativeTextureHandle, pNativeTextureRef, ref pWidth, ref pHeight, ref pNativeFormat, ref pAPIType, ref pColorSpace, ref pTextureBounds);
			return result;
		}
		public EVROverlayError ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle)
		{
			EVROverlayError result = FnTable.ReleaseNativeOverlayHandle(ulOverlayHandle, pNativeTextureHandle);
			return result;
		}
		public EVROverlayError GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight)
		{
			pWidth = 0;
			pHeight = 0;
			EVROverlayError result = FnTable.GetOverlayTextureSize(ulOverlayHandle, ref pWidth, ref pHeight);
			return result;
		}
		public EVROverlayError CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle)
		{
			IntPtr pchOverlayKeyUtf8 = Utils.ToUtf8(pchOverlayKey);
			IntPtr pchOverlayFriendlyNameUtf8 = Utils.ToUtf8(pchOverlayFriendlyName);
			pMainHandle = 0;
			pThumbnailHandle = 0;
			EVROverlayError result = FnTable.CreateDashboardOverlay(pchOverlayKeyUtf8, pchOverlayFriendlyNameUtf8, ref pMainHandle, ref pThumbnailHandle);
			Marshal.FreeHGlobal(pchOverlayKeyUtf8);
			Marshal.FreeHGlobal(pchOverlayFriendlyNameUtf8);
			return result;
		}
		public bool IsDashboardVisible()
		{
			bool result = FnTable.IsDashboardVisible();
			return result;
		}
		public bool IsActiveDashboardOverlay(ulong ulOverlayHandle)
		{
			bool result = FnTable.IsActiveDashboardOverlay(ulOverlayHandle);
			return result;
		}
		public EVROverlayError SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId)
		{
			EVROverlayError result = FnTable.SetDashboardOverlaySceneProcess(ulOverlayHandle, unProcessId);
			return result;
		}
		public EVROverlayError GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId)
		{
			punProcessId = 0;
			EVROverlayError result = FnTable.GetDashboardOverlaySceneProcess(ulOverlayHandle, ref punProcessId);
			return result;
		}
		public void ShowDashboard(string pchOverlayToShow)
		{
			IntPtr pchOverlayToShowUtf8 = Utils.ToUtf8(pchOverlayToShow);
			FnTable.ShowDashboard(pchOverlayToShowUtf8);
			Marshal.FreeHGlobal(pchOverlayToShowUtf8);
		}
		public uint GetPrimaryDashboardDevice()
		{
			uint result = FnTable.GetPrimaryDashboardDevice();
			return result;
		}
		public EVROverlayError ShowKeyboard(int eInputMode, int eLineInputMode, uint unFlags, string pchDescription, uint unCharMax, string pchExistingText, ulong uUserValue)
		{
			IntPtr pchDescriptionUtf8 = Utils.ToUtf8(pchDescription);
			IntPtr pchExistingTextUtf8 = Utils.ToUtf8(pchExistingText);
			EVROverlayError result = FnTable.ShowKeyboard(eInputMode, eLineInputMode, unFlags, pchDescriptionUtf8, unCharMax, pchExistingTextUtf8, uUserValue);
			Marshal.FreeHGlobal(pchDescriptionUtf8);
			Marshal.FreeHGlobal(pchExistingTextUtf8);
			return result;
		}
		public EVROverlayError ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, uint unFlags, string pchDescription, uint unCharMax, string pchExistingText, ulong uUserValue)
		{
			IntPtr pchDescriptionUtf8 = Utils.ToUtf8(pchDescription);
			IntPtr pchExistingTextUtf8 = Utils.ToUtf8(pchExistingText);
			EVROverlayError result = FnTable.ShowKeyboardForOverlay(ulOverlayHandle, eInputMode, eLineInputMode, unFlags, pchDescriptionUtf8, unCharMax, pchExistingTextUtf8, uUserValue);
			Marshal.FreeHGlobal(pchDescriptionUtf8);
			Marshal.FreeHGlobal(pchExistingTextUtf8);
			return result;
		}
		public uint GetKeyboardText(System.Text.StringBuilder pchText, uint cchText)
		{
			uint result = FnTable.GetKeyboardText(pchText, cchText);
			return result;
		}
		public void HideKeyboard()
		{
			FnTable.HideKeyboard();
		}
		public void SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform)
		{
			FnTable.SetKeyboardTransformAbsolute(eTrackingOrigin, ref pmatTrackingOriginToKeyboardTransform);
		}
		public void SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect)
		{
			FnTable.SetKeyboardPositionForOverlay(ulOverlayHandle, avoidRect);
		}
		public VRMessageOverlayResponse ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text)
		{
			IntPtr pchTextUtf8 = Utils.ToUtf8(pchText);
			IntPtr pchCaptionUtf8 = Utils.ToUtf8(pchCaption);
			IntPtr pchButton0TextUtf8 = Utils.ToUtf8(pchButton0Text);
			IntPtr pchButton1TextUtf8 = Utils.ToUtf8(pchButton1Text);
			IntPtr pchButton2TextUtf8 = Utils.ToUtf8(pchButton2Text);
			IntPtr pchButton3TextUtf8 = Utils.ToUtf8(pchButton3Text);
			VRMessageOverlayResponse result = FnTable.ShowMessageOverlay(pchTextUtf8, pchCaptionUtf8, pchButton0TextUtf8, pchButton1TextUtf8, pchButton2TextUtf8, pchButton3TextUtf8);
			Marshal.FreeHGlobal(pchTextUtf8);
			Marshal.FreeHGlobal(pchCaptionUtf8);
			Marshal.FreeHGlobal(pchButton0TextUtf8);
			Marshal.FreeHGlobal(pchButton1TextUtf8);
			Marshal.FreeHGlobal(pchButton2TextUtf8);
			Marshal.FreeHGlobal(pchButton3TextUtf8);
			return result;
		}
		public void CloseMessageOverlay()
		{
			FnTable.CloseMessageOverlay();
		}
	}


	public class CVROverlayView
	{
		IVROverlayView FnTable;
		internal CVROverlayView(IntPtr pInterface)
		{
			FnTable = (IVROverlayView)Marshal.PtrToStructure(pInterface, typeof(IVROverlayView));
		}
		public EVROverlayError AcquireOverlayView(ulong ulOverlayHandle, ref VRNativeDevice_t pNativeDevice, ref VROverlayView_t pOverlayView, uint unOverlayViewSize)
		{
			EVROverlayError result = FnTable.AcquireOverlayView(ulOverlayHandle, ref pNativeDevice, ref pOverlayView, unOverlayViewSize);
			return result;
		}
		public EVROverlayError ReleaseOverlayView(ref VROverlayView_t pOverlayView)
		{
			EVROverlayError result = FnTable.ReleaseOverlayView(ref pOverlayView);
			return result;
		}
		public void PostOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pvrEvent)
		{
			FnTable.PostOverlayEvent(ulOverlayHandle, ref pvrEvent);
		}
		public bool IsViewingPermitted(ulong ulOverlayHandle)
		{
			bool result = FnTable.IsViewingPermitted(ulOverlayHandle);
			return result;
		}
	}


	public class CVRHeadsetView
	{
		IVRHeadsetView FnTable;
		internal CVRHeadsetView(IntPtr pInterface)
		{
			FnTable = (IVRHeadsetView)Marshal.PtrToStructure(pInterface, typeof(IVRHeadsetView));
		}
		public void SetHeadsetViewSize(uint nWidth, uint nHeight)
		{
			FnTable.SetHeadsetViewSize(nWidth, nHeight);
		}
		public void GetHeadsetViewSize(ref uint pnWidth, ref uint pnHeight)
		{
			pnWidth = 0;
			pnHeight = 0;
			FnTable.GetHeadsetViewSize(ref pnWidth, ref pnHeight);
		}
		public void SetHeadsetViewMode(uint eHeadsetViewMode)
		{
			FnTable.SetHeadsetViewMode(eHeadsetViewMode);
		}
		public uint GetHeadsetViewMode()
		{
			uint result = FnTable.GetHeadsetViewMode();
			return result;
		}
		public void SetHeadsetViewCropped(bool bCropped)
		{
			FnTable.SetHeadsetViewCropped(bCropped);
		}
		public bool GetHeadsetViewCropped()
		{
			bool result = FnTable.GetHeadsetViewCropped();
			return result;
		}
		public float GetHeadsetViewAspectRatio()
		{
			float result = FnTable.GetHeadsetViewAspectRatio();
			return result;
		}
		public void SetHeadsetViewBlendRange(float flStartPct, float flEndPct)
		{
			FnTable.SetHeadsetViewBlendRange(flStartPct, flEndPct);
		}
		public void GetHeadsetViewBlendRange(ref float pStartPct, ref float pEndPct)
		{
			pStartPct = 0;
			pEndPct = 0;
			FnTable.GetHeadsetViewBlendRange(ref pStartPct, ref pEndPct);
		}
	}


	public class CVRRenderModels
	{
		IVRRenderModels FnTable;
		internal CVRRenderModels(IntPtr pInterface)
		{
			FnTable = (IVRRenderModels)Marshal.PtrToStructure(pInterface, typeof(IVRRenderModels));
		}
		public EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel)
		{
			IntPtr pchRenderModelNameUtf8 = Utils.ToUtf8(pchRenderModelName);
			EVRRenderModelError result = FnTable.LoadRenderModel_Async(pchRenderModelNameUtf8, ref ppRenderModel);
			Marshal.FreeHGlobal(pchRenderModelNameUtf8);
			return result;
		}
		public void FreeRenderModel(IntPtr pRenderModel)
		{
			FnTable.FreeRenderModel(pRenderModel);
		}
		public EVRRenderModelError LoadTexture_Async(int textureId, ref IntPtr ppTexture)
		{
			EVRRenderModelError result = FnTable.LoadTexture_Async(textureId, ref ppTexture);
			return result;
		}
		public void FreeTexture(IntPtr pTexture)
		{
			FnTable.FreeTexture(pTexture);
		}
		public EVRRenderModelError LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D)
		{
			EVRRenderModelError result = FnTable.LoadTextureD3D11_Async(textureId, pD3D11Device, ref ppD3D11Texture2D);
			return result;
		}
		public EVRRenderModelError LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture)
		{
			EVRRenderModelError result = FnTable.LoadIntoTextureD3D11_Async(textureId, pDstTexture);
			return result;
		}
		public void FreeTextureD3D11(IntPtr pD3D11Texture2D)
		{
			FnTable.FreeTextureD3D11(pD3D11Texture2D);
		}
		public uint GetRenderModelName(uint unRenderModelIndex, System.Text.StringBuilder pchRenderModelName, uint unRenderModelNameLen)
		{
			uint result = FnTable.GetRenderModelName(unRenderModelIndex, pchRenderModelName, unRenderModelNameLen);
			return result;
		}
		public uint GetRenderModelCount()
		{
			uint result = FnTable.GetRenderModelCount();
			return result;
		}
		public uint GetComponentCount(string pchRenderModelName)
		{
			IntPtr pchRenderModelNameUtf8 = Utils.ToUtf8(pchRenderModelName);
			uint result = FnTable.GetComponentCount(pchRenderModelNameUtf8);
			Marshal.FreeHGlobal(pchRenderModelNameUtf8);
			return result;
		}
		public uint GetComponentName(string pchRenderModelName, uint unComponentIndex, System.Text.StringBuilder pchComponentName, uint unComponentNameLen)
		{
			IntPtr pchRenderModelNameUtf8 = Utils.ToUtf8(pchRenderModelName);
			uint result = FnTable.GetComponentName(pchRenderModelNameUtf8, unComponentIndex, pchComponentName, unComponentNameLen);
			Marshal.FreeHGlobal(pchRenderModelNameUtf8);
			return result;
		}
		public ulong GetComponentButtonMask(string pchRenderModelName, string pchComponentName)
		{
			IntPtr pchRenderModelNameUtf8 = Utils.ToUtf8(pchRenderModelName);
			IntPtr pchComponentNameUtf8 = Utils.ToUtf8(pchComponentName);
			ulong result = FnTable.GetComponentButtonMask(pchRenderModelNameUtf8, pchComponentNameUtf8);
			Marshal.FreeHGlobal(pchRenderModelNameUtf8);
			Marshal.FreeHGlobal(pchComponentNameUtf8);
			return result;
		}
		public uint GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, System.Text.StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen)
		{
			IntPtr pchRenderModelNameUtf8 = Utils.ToUtf8(pchRenderModelName);
			IntPtr pchComponentNameUtf8 = Utils.ToUtf8(pchComponentName);
			uint result = FnTable.GetComponentRenderModelName(pchRenderModelNameUtf8, pchComponentNameUtf8, pchComponentRenderModelName, unComponentRenderModelNameLen);
			Marshal.FreeHGlobal(pchRenderModelNameUtf8);
			Marshal.FreeHGlobal(pchComponentNameUtf8);
			return result;
		}
		public bool GetComponentStateForDevicePath(string pchRenderModelName, string pchComponentName, ulong devicePath, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState)
		{
			IntPtr pchRenderModelNameUtf8 = Utils.ToUtf8(pchRenderModelName);
			IntPtr pchComponentNameUtf8 = Utils.ToUtf8(pchComponentName);
			bool result = FnTable.GetComponentStateForDevicePath(pchRenderModelNameUtf8, pchComponentNameUtf8, devicePath, ref pState, ref pComponentState);
			Marshal.FreeHGlobal(pchRenderModelNameUtf8);
			Marshal.FreeHGlobal(pchComponentNameUtf8);
			return result;
		}
		// This is a terrible hack to workaround the fact that VRControllerState_t and VREvent_t were
		// originally mis-compiled with the wrong packing for Linux and OSX.
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetComponentStatePacked(IntPtr pchRenderModelName, IntPtr pchComponentName, ref VRControllerState_t_Packed pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);
		[StructLayout(LayoutKind.Explicit)]
		struct GetComponentStateUnion
		{
			[FieldOffset(0)]
			public IVRRenderModels._GetComponentState pGetComponentState;
			[FieldOffset(0)]
			public _GetComponentStatePacked pGetComponentStatePacked;
		}
		public bool GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState)
		{
			IntPtr pchRenderModelNameUtf8 = Utils.ToUtf8(pchRenderModelName);
			IntPtr pchComponentNameUtf8 = Utils.ToUtf8(pchComponentName);
#if !UNITY_METRO
			if ((System.Environment.OSVersion.Platform == System.PlatformID.MacOSX) ||
					(System.Environment.OSVersion.Platform == System.PlatformID.Unix))
			{
				GetComponentStateUnion u;
				VRControllerState_t_Packed state_packed = new VRControllerState_t_Packed(pControllerState);
				u.pGetComponentStatePacked = null;
				u.pGetComponentState = FnTable.GetComponentState;
				bool packed_result = u.pGetComponentStatePacked(pchRenderModelNameUtf8, pchComponentNameUtf8, ref state_packed, ref pState, ref pComponentState);

				state_packed.Unpack(ref pControllerState);
				return packed_result;
			}
#endif
			bool result = FnTable.GetComponentState(pchRenderModelNameUtf8, pchComponentNameUtf8, ref pControllerState, ref pState, ref pComponentState);
			Marshal.FreeHGlobal(pchRenderModelNameUtf8);
			Marshal.FreeHGlobal(pchComponentNameUtf8);
			return result;
		}
		public bool RenderModelHasComponent(string pchRenderModelName, string pchComponentName)
		{
			IntPtr pchRenderModelNameUtf8 = Utils.ToUtf8(pchRenderModelName);
			IntPtr pchComponentNameUtf8 = Utils.ToUtf8(pchComponentName);
			bool result = FnTable.RenderModelHasComponent(pchRenderModelNameUtf8, pchComponentNameUtf8);
			Marshal.FreeHGlobal(pchRenderModelNameUtf8);
			Marshal.FreeHGlobal(pchComponentNameUtf8);
			return result;
		}
		public uint GetRenderModelThumbnailURL(string pchRenderModelName, System.Text.StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError)
		{
			IntPtr pchRenderModelNameUtf8 = Utils.ToUtf8(pchRenderModelName);
			uint result = FnTable.GetRenderModelThumbnailURL(pchRenderModelNameUtf8, pchThumbnailURL, unThumbnailURLLen, ref peError);
			Marshal.FreeHGlobal(pchRenderModelNameUtf8);
			return result;
		}
		public uint GetRenderModelOriginalPath(string pchRenderModelName, System.Text.StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError)
		{
			IntPtr pchRenderModelNameUtf8 = Utils.ToUtf8(pchRenderModelName);
			uint result = FnTable.GetRenderModelOriginalPath(pchRenderModelNameUtf8, pchOriginalPath, unOriginalPathLen, ref peError);
			Marshal.FreeHGlobal(pchRenderModelNameUtf8);
			return result;
		}
		public string GetRenderModelErrorNameFromEnum(EVRRenderModelError error)
		{
			IntPtr result = FnTable.GetRenderModelErrorNameFromEnum(error);
			return Marshal.PtrToStringAnsi(result);
		}
	}


	public class CVRNotifications
	{
		IVRNotifications FnTable;
		internal CVRNotifications(IntPtr pInterface)
		{
			FnTable = (IVRNotifications)Marshal.PtrToStructure(pInterface, typeof(IVRNotifications));
		}
		public EVRNotificationError CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId)
		{
			IntPtr pchTextUtf8 = Utils.ToUtf8(pchText);
			pNotificationId = 0;
			EVRNotificationError result = FnTable.CreateNotification(ulOverlayHandle, ulUserValue, type, pchTextUtf8, style, ref pImage, ref pNotificationId);
			Marshal.FreeHGlobal(pchTextUtf8);
			return result;
		}
		public EVRNotificationError RemoveNotification(uint notificationId)
		{
			EVRNotificationError result = FnTable.RemoveNotification(notificationId);
			return result;
		}
	}


	public class CVRSettings
	{
		IVRSettings FnTable;
		internal CVRSettings(IntPtr pInterface)
		{
			FnTable = (IVRSettings)Marshal.PtrToStructure(pInterface, typeof(IVRSettings));
		}
		public string GetSettingsErrorNameFromEnum(EVRSettingsError eError)
		{
			IntPtr result = FnTable.GetSettingsErrorNameFromEnum(eError);
			return Marshal.PtrToStringAnsi(result);
		}
		public void SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError)
		{
			IntPtr pchSectionUtf8 = Utils.ToUtf8(pchSection);
			IntPtr pchSettingsKeyUtf8 = Utils.ToUtf8(pchSettingsKey);
			FnTable.SetBool(pchSectionUtf8, pchSettingsKeyUtf8, bValue, ref peError);
			Marshal.FreeHGlobal(pchSectionUtf8);
			Marshal.FreeHGlobal(pchSettingsKeyUtf8);
		}
		public void SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError)
		{
			IntPtr pchSectionUtf8 = Utils.ToUtf8(pchSection);
			IntPtr pchSettingsKeyUtf8 = Utils.ToUtf8(pchSettingsKey);
			FnTable.SetInt32(pchSectionUtf8, pchSettingsKeyUtf8, nValue, ref peError);
			Marshal.FreeHGlobal(pchSectionUtf8);
			Marshal.FreeHGlobal(pchSettingsKeyUtf8);
		}
		public void SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError)
		{
			IntPtr pchSectionUtf8 = Utils.ToUtf8(pchSection);
			IntPtr pchSettingsKeyUtf8 = Utils.ToUtf8(pchSettingsKey);
			FnTable.SetFloat(pchSectionUtf8, pchSettingsKeyUtf8, flValue, ref peError);
			Marshal.FreeHGlobal(pchSectionUtf8);
			Marshal.FreeHGlobal(pchSettingsKeyUtf8);
		}
		public void SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError)
		{
			IntPtr pchSectionUtf8 = Utils.ToUtf8(pchSection);
			IntPtr pchSettingsKeyUtf8 = Utils.ToUtf8(pchSettingsKey);
			IntPtr pchValueUtf8 = Utils.ToUtf8(pchValue);
			FnTable.SetString(pchSectionUtf8, pchSettingsKeyUtf8, pchValueUtf8, ref peError);
			Marshal.FreeHGlobal(pchSectionUtf8);
			Marshal.FreeHGlobal(pchSettingsKeyUtf8);
			Marshal.FreeHGlobal(pchValueUtf8);
		}
		public bool GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
			IntPtr pchSectionUtf8 = Utils.ToUtf8(pchSection);
			IntPtr pchSettingsKeyUtf8 = Utils.ToUtf8(pchSettingsKey);
			bool result = FnTable.GetBool(pchSectionUtf8, pchSettingsKeyUtf8, ref peError);
			Marshal.FreeHGlobal(pchSectionUtf8);
			Marshal.FreeHGlobal(pchSettingsKeyUtf8);
			return result;
		}
		public int GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
			IntPtr pchSectionUtf8 = Utils.ToUtf8(pchSection);
			IntPtr pchSettingsKeyUtf8 = Utils.ToUtf8(pchSettingsKey);
			int result = FnTable.GetInt32(pchSectionUtf8, pchSettingsKeyUtf8, ref peError);
			Marshal.FreeHGlobal(pchSectionUtf8);
			Marshal.FreeHGlobal(pchSettingsKeyUtf8);
			return result;
		}
		public float GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
			IntPtr pchSectionUtf8 = Utils.ToUtf8(pchSection);
			IntPtr pchSettingsKeyUtf8 = Utils.ToUtf8(pchSettingsKey);
			float result = FnTable.GetFloat(pchSectionUtf8, pchSettingsKeyUtf8, ref peError);
			Marshal.FreeHGlobal(pchSectionUtf8);
			Marshal.FreeHGlobal(pchSettingsKeyUtf8);
			return result;
		}
		public void GetString(string pchSection, string pchSettingsKey, System.Text.StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError)
		{
			IntPtr pchSectionUtf8 = Utils.ToUtf8(pchSection);
			IntPtr pchSettingsKeyUtf8 = Utils.ToUtf8(pchSettingsKey);
			FnTable.GetString(pchSectionUtf8, pchSettingsKeyUtf8, pchValue, unValueLen, ref peError);
			Marshal.FreeHGlobal(pchSectionUtf8);
			Marshal.FreeHGlobal(pchSettingsKeyUtf8);
		}
		public void RemoveSection(string pchSection, ref EVRSettingsError peError)
		{
			IntPtr pchSectionUtf8 = Utils.ToUtf8(pchSection);
			FnTable.RemoveSection(pchSectionUtf8, ref peError);
			Marshal.FreeHGlobal(pchSectionUtf8);
		}
		public void RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
			IntPtr pchSectionUtf8 = Utils.ToUtf8(pchSection);
			IntPtr pchSettingsKeyUtf8 = Utils.ToUtf8(pchSettingsKey);
			FnTable.RemoveKeyInSection(pchSectionUtf8, pchSettingsKeyUtf8, ref peError);
			Marshal.FreeHGlobal(pchSectionUtf8);
			Marshal.FreeHGlobal(pchSettingsKeyUtf8);
		}
	}


	public class CVRScreenshots
	{
		IVRScreenshots FnTable;
		internal CVRScreenshots(IntPtr pInterface)
		{
			FnTable = (IVRScreenshots)Marshal.PtrToStructure(pInterface, typeof(IVRScreenshots));
		}
		public EVRScreenshotError RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename)
		{
			pOutScreenshotHandle = 0;
			IntPtr pchPreviewFilenameUtf8 = Utils.ToUtf8(pchPreviewFilename);
			IntPtr pchVRFilenameUtf8 = Utils.ToUtf8(pchVRFilename);
			EVRScreenshotError result = FnTable.RequestScreenshot(ref pOutScreenshotHandle, type, pchPreviewFilenameUtf8, pchVRFilenameUtf8);
			Marshal.FreeHGlobal(pchPreviewFilenameUtf8);
			Marshal.FreeHGlobal(pchVRFilenameUtf8);
			return result;
		}
		public EVRScreenshotError HookScreenshot(EVRScreenshotType[] pSupportedTypes)
		{
			EVRScreenshotError result = FnTable.HookScreenshot(pSupportedTypes, (int)pSupportedTypes.Length);
			return result;
		}
		public EVRScreenshotType GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError)
		{
			EVRScreenshotType result = FnTable.GetScreenshotPropertyType(screenshotHandle, ref pError);
			return result;
		}
		public uint GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, System.Text.StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError)
		{
			uint result = FnTable.GetScreenshotPropertyFilename(screenshotHandle, filenameType, pchFilename, cchFilename, ref pError);
			return result;
		}
		public EVRScreenshotError UpdateScreenshotProgress(uint screenshotHandle, float flProgress)
		{
			EVRScreenshotError result = FnTable.UpdateScreenshotProgress(screenshotHandle, flProgress);
			return result;
		}
		public EVRScreenshotError TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename)
		{
			pOutScreenshotHandle = 0;
			IntPtr pchPreviewFilenameUtf8 = Utils.ToUtf8(pchPreviewFilename);
			IntPtr pchVRFilenameUtf8 = Utils.ToUtf8(pchVRFilename);
			EVRScreenshotError result = FnTable.TakeStereoScreenshot(ref pOutScreenshotHandle, pchPreviewFilenameUtf8, pchVRFilenameUtf8);
			Marshal.FreeHGlobal(pchPreviewFilenameUtf8);
			Marshal.FreeHGlobal(pchVRFilenameUtf8);
			return result;
		}
		public EVRScreenshotError SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename)
		{
			IntPtr pchSourcePreviewFilenameUtf8 = Utils.ToUtf8(pchSourcePreviewFilename);
			IntPtr pchSourceVRFilenameUtf8 = Utils.ToUtf8(pchSourceVRFilename);
			EVRScreenshotError result = FnTable.SubmitScreenshot(screenshotHandle, type, pchSourcePreviewFilenameUtf8, pchSourceVRFilenameUtf8);
			Marshal.FreeHGlobal(pchSourcePreviewFilenameUtf8);
			Marshal.FreeHGlobal(pchSourceVRFilenameUtf8);
			return result;
		}
	}


	public class CVRResources
	{
		IVRResources FnTable;
		internal CVRResources(IntPtr pInterface)
		{
			FnTable = (IVRResources)Marshal.PtrToStructure(pInterface, typeof(IVRResources));
		}
		public uint LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen)
		{
			IntPtr pchResourceNameUtf8 = Utils.ToUtf8(pchResourceName);
			uint result = FnTable.LoadSharedResource(pchResourceNameUtf8, pchBuffer, unBufferLen);
			Marshal.FreeHGlobal(pchResourceNameUtf8);
			return result;
		}
		public uint GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, System.Text.StringBuilder pchPathBuffer, uint unBufferLen)
		{
			IntPtr pchResourceNameUtf8 = Utils.ToUtf8(pchResourceName);
			IntPtr pchResourceTypeDirectoryUtf8 = Utils.ToUtf8(pchResourceTypeDirectory);
			uint result = FnTable.GetResourceFullPath(pchResourceNameUtf8, pchResourceTypeDirectoryUtf8, pchPathBuffer, unBufferLen);
			Marshal.FreeHGlobal(pchResourceNameUtf8);
			Marshal.FreeHGlobal(pchResourceTypeDirectoryUtf8);
			return result;
		}
	}


	public class CVRDriverManager
	{
		IVRDriverManager FnTable;
		internal CVRDriverManager(IntPtr pInterface)
		{
			FnTable = (IVRDriverManager)Marshal.PtrToStructure(pInterface, typeof(IVRDriverManager));
		}
		public uint GetDriverCount()
		{
			uint result = FnTable.GetDriverCount();
			return result;
		}
		public uint GetDriverName(uint nDriver, System.Text.StringBuilder pchValue, uint unBufferSize)
		{
			uint result = FnTable.GetDriverName(nDriver, pchValue, unBufferSize);
			return result;
		}
		public ulong GetDriverHandle(string pchDriverName)
		{
			IntPtr pchDriverNameUtf8 = Utils.ToUtf8(pchDriverName);
			ulong result = FnTable.GetDriverHandle(pchDriverNameUtf8);
			Marshal.FreeHGlobal(pchDriverNameUtf8);
			return result;
		}
		public bool IsEnabled(uint nDriver)
		{
			bool result = FnTable.IsEnabled(nDriver);
			return result;
		}
	}


	public class CVRInput
	{
		IVRInput FnTable;
		internal CVRInput(IntPtr pInterface)
		{
			FnTable = (IVRInput)Marshal.PtrToStructure(pInterface, typeof(IVRInput));
		}
		public EVRInputError SetActionManifestPath(string pchActionManifestPath)
		{
			IntPtr pchActionManifestPathUtf8 = Utils.ToUtf8(pchActionManifestPath);
			EVRInputError result = FnTable.SetActionManifestPath(pchActionManifestPathUtf8);
			Marshal.FreeHGlobal(pchActionManifestPathUtf8);
			return result;
		}
		public EVRInputError GetActionSetHandle(string pchActionSetName, ref ulong pHandle)
		{
			IntPtr pchActionSetNameUtf8 = Utils.ToUtf8(pchActionSetName);
			pHandle = 0;
			EVRInputError result = FnTable.GetActionSetHandle(pchActionSetNameUtf8, ref pHandle);
			Marshal.FreeHGlobal(pchActionSetNameUtf8);
			return result;
		}
		public EVRInputError GetActionHandle(string pchActionName, ref ulong pHandle)
		{
			IntPtr pchActionNameUtf8 = Utils.ToUtf8(pchActionName);
			pHandle = 0;
			EVRInputError result = FnTable.GetActionHandle(pchActionNameUtf8, ref pHandle);
			Marshal.FreeHGlobal(pchActionNameUtf8);
			return result;
		}
		public EVRInputError GetInputSourceHandle(string pchInputSourcePath, ref ulong pHandle)
		{
			IntPtr pchInputSourcePathUtf8 = Utils.ToUtf8(pchInputSourcePath);
			pHandle = 0;
			EVRInputError result = FnTable.GetInputSourceHandle(pchInputSourcePathUtf8, ref pHandle);
			Marshal.FreeHGlobal(pchInputSourcePathUtf8);
			return result;
		}
		public EVRInputError UpdateActionState(VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t)
		{
			EVRInputError result = FnTable.UpdateActionState(pSets, unSizeOfVRSelectedActionSet_t, (uint)pSets.Length);
			return result;
		}
		public EVRInputError GetDigitalActionData(ulong action, ref InputDigitalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
		{
			EVRInputError result = FnTable.GetDigitalActionData(action, ref pActionData, unActionDataSize, ulRestrictToDevice);
			return result;
		}
		public EVRInputError GetAnalogActionData(ulong action, ref InputAnalogActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
		{
			EVRInputError result = FnTable.GetAnalogActionData(action, ref pActionData, unActionDataSize, ulRestrictToDevice);
			return result;
		}
		public EVRInputError GetPoseActionDataRelativeToNow(ulong action, ETrackingUniverseOrigin eOrigin, float fPredictedSecondsFromNow, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
		{
			EVRInputError result = FnTable.GetPoseActionDataRelativeToNow(action, eOrigin, fPredictedSecondsFromNow, ref pActionData, unActionDataSize, ulRestrictToDevice);
			return result;
		}
		public EVRInputError GetPoseActionDataForNextFrame(ulong action, ETrackingUniverseOrigin eOrigin, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
		{
			EVRInputError result = FnTable.GetPoseActionDataForNextFrame(action, eOrigin, ref pActionData, unActionDataSize, ulRestrictToDevice);
			return result;
		}
		public EVRInputError GetSkeletalActionData(ulong action, ref InputSkeletalActionData_t pActionData, uint unActionDataSize)
		{
			EVRInputError result = FnTable.GetSkeletalActionData(action, ref pActionData, unActionDataSize);
			return result;
		}
		public EVRInputError GetDominantHand(ref ETrackedControllerRole peDominantHand)
		{
			EVRInputError result = FnTable.GetDominantHand(ref peDominantHand);
			return result;
		}
		public EVRInputError SetDominantHand(ETrackedControllerRole eDominantHand)
		{
			EVRInputError result = FnTable.SetDominantHand(eDominantHand);
			return result;
		}
		public EVRInputError GetBoneCount(ulong action, ref uint pBoneCount)
		{
			pBoneCount = 0;
			EVRInputError result = FnTable.GetBoneCount(action, ref pBoneCount);
			return result;
		}
		public EVRInputError GetBoneHierarchy(ulong action, int[] pParentIndices)
		{
			EVRInputError result = FnTable.GetBoneHierarchy(action, pParentIndices, (uint)pParentIndices.Length);
			return result;
		}
		public EVRInputError GetBoneName(ulong action, int nBoneIndex, System.Text.StringBuilder pchBoneName, uint unNameBufferSize)
		{
			EVRInputError result = FnTable.GetBoneName(action, nBoneIndex, pchBoneName, unNameBufferSize);
			return result;
		}
		public EVRInputError GetSkeletalReferenceTransforms(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalReferencePose eReferencePose, VRBoneTransform_t[] pTransformArray)
		{
			EVRInputError result = FnTable.GetSkeletalReferenceTransforms(action, eTransformSpace, eReferencePose, pTransformArray, (uint)pTransformArray.Length);
			return result;
		}
		public EVRInputError GetSkeletalTrackingLevel(ulong action, ref EVRSkeletalTrackingLevel pSkeletalTrackingLevel)
		{
			EVRInputError result = FnTable.GetSkeletalTrackingLevel(action, ref pSkeletalTrackingLevel);
			return result;
		}
		public EVRInputError GetSkeletalBoneData(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, VRBoneTransform_t[] pTransformArray)
		{
			EVRInputError result = FnTable.GetSkeletalBoneData(action, eTransformSpace, eMotionRange, pTransformArray, (uint)pTransformArray.Length);
			return result;
		}
		public EVRInputError GetSkeletalSummaryData(ulong action, EVRSummaryType eSummaryType, ref VRSkeletalSummaryData_t pSkeletalSummaryData)
		{
			EVRInputError result = FnTable.GetSkeletalSummaryData(action, eSummaryType, ref pSkeletalSummaryData);
			return result;
		}
		public EVRInputError GetSkeletalBoneDataCompressed(ulong action, EVRSkeletalMotionRange eMotionRange, IntPtr pvCompressedData, uint unCompressedSize, ref uint punRequiredCompressedSize)
		{
			punRequiredCompressedSize = 0;
			EVRInputError result = FnTable.GetSkeletalBoneDataCompressed(action, eMotionRange, pvCompressedData, unCompressedSize, ref punRequiredCompressedSize);
			return result;
		}
		public EVRInputError DecompressSkeletalBoneData(IntPtr pvCompressedBuffer, uint unCompressedBufferSize, EVRSkeletalTransformSpace eTransformSpace, VRBoneTransform_t[] pTransformArray)
		{
			EVRInputError result = FnTable.DecompressSkeletalBoneData(pvCompressedBuffer, unCompressedBufferSize, eTransformSpace, pTransformArray, (uint)pTransformArray.Length);
			return result;
		}
		public EVRInputError TriggerHapticVibrationAction(ulong action, float fStartSecondsFromNow, float fDurationSeconds, float fFrequency, float fAmplitude, ulong ulRestrictToDevice)
		{
			EVRInputError result = FnTable.TriggerHapticVibrationAction(action, fStartSecondsFromNow, fDurationSeconds, fFrequency, fAmplitude, ulRestrictToDevice);
			return result;
		}
		public EVRInputError GetActionOrigins(ulong actionSetHandle, ulong digitalActionHandle, ulong[] originsOut)
		{
			EVRInputError result = FnTable.GetActionOrigins(actionSetHandle, digitalActionHandle, originsOut, (uint)originsOut.Length);
			return result;
		}
		public EVRInputError GetOriginLocalizedName(ulong origin, System.Text.StringBuilder pchNameArray, uint unNameArraySize, int unStringSectionsToInclude)
		{
			EVRInputError result = FnTable.GetOriginLocalizedName(origin, pchNameArray, unNameArraySize, unStringSectionsToInclude);
			return result;
		}
		public EVRInputError GetOriginTrackedDeviceInfo(ulong origin, ref InputOriginInfo_t pOriginInfo, uint unOriginInfoSize)
		{
			EVRInputError result = FnTable.GetOriginTrackedDeviceInfo(origin, ref pOriginInfo, unOriginInfoSize);
			return result;
		}
		public EVRInputError GetActionBindingInfo(ulong action, InputBindingInfo_t[] pOriginInfo, uint unBindingInfoSize, ref uint punReturnedBindingInfoCount)
		{
			punReturnedBindingInfoCount = 0;
			EVRInputError result = FnTable.GetActionBindingInfo(action, pOriginInfo, unBindingInfoSize, (uint)pOriginInfo.Length, ref punReturnedBindingInfoCount);
			return result;
		}
		public EVRInputError ShowActionOrigins(ulong actionSetHandle, ulong ulActionHandle)
		{
			EVRInputError result = FnTable.ShowActionOrigins(actionSetHandle, ulActionHandle);
			return result;
		}
		public EVRInputError ShowBindingsForActionSet(VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, ulong originToHighlight)
		{
			EVRInputError result = FnTable.ShowBindingsForActionSet(pSets, unSizeOfVRSelectedActionSet_t, (uint)pSets.Length, originToHighlight);
			return result;
		}
		public EVRInputError GetComponentStateForBinding(string pchRenderModelName, string pchComponentName, ref InputBindingInfo_t pOriginInfo, uint unBindingInfoSize, uint unBindingInfoCount, ref RenderModel_ComponentState_t pComponentState)
		{
			IntPtr pchRenderModelNameUtf8 = Utils.ToUtf8(pchRenderModelName);
			IntPtr pchComponentNameUtf8 = Utils.ToUtf8(pchComponentName);
			EVRInputError result = FnTable.GetComponentStateForBinding(pchRenderModelNameUtf8, pchComponentNameUtf8, ref pOriginInfo, unBindingInfoSize, unBindingInfoCount, ref pComponentState);
			Marshal.FreeHGlobal(pchRenderModelNameUtf8);
			Marshal.FreeHGlobal(pchComponentNameUtf8);
			return result;
		}
		public bool IsUsingLegacyInput()
		{
			bool result = FnTable.IsUsingLegacyInput();
			return result;
		}
		public EVRInputError OpenBindingUI(string pchAppKey, ulong ulActionSetHandle, ulong ulDeviceHandle, bool bShowOnDesktop)
		{
			IntPtr pchAppKeyUtf8 = Utils.ToUtf8(pchAppKey);
			EVRInputError result = FnTable.OpenBindingUI(pchAppKeyUtf8, ulActionSetHandle, ulDeviceHandle, bShowOnDesktop);
			Marshal.FreeHGlobal(pchAppKeyUtf8);
			return result;
		}
		public EVRInputError GetBindingVariant(ulong ulDevicePath, System.Text.StringBuilder pchVariantArray, uint unVariantArraySize)
		{
			EVRInputError result = FnTable.GetBindingVariant(ulDevicePath, pchVariantArray, unVariantArraySize);
			return result;
		}
	}


	public class CVRIOBuffer
	{
		IVRIOBuffer FnTable;
		internal CVRIOBuffer(IntPtr pInterface)
		{
			FnTable = (IVRIOBuffer)Marshal.PtrToStructure(pInterface, typeof(IVRIOBuffer));
		}
		public EIOBufferError Open(string pchPath, EIOBufferMode mode, uint unElementSize, uint unElements, ref ulong pulBuffer)
		{
			IntPtr pchPathUtf8 = Utils.ToUtf8(pchPath);
			pulBuffer = 0;
			EIOBufferError result = FnTable.Open(pchPathUtf8, mode, unElementSize, unElements, ref pulBuffer);
			Marshal.FreeHGlobal(pchPathUtf8);
			return result;
		}
		public EIOBufferError Close(ulong ulBuffer)
		{
			EIOBufferError result = FnTable.Close(ulBuffer);
			return result;
		}
		public EIOBufferError Read(ulong ulBuffer, IntPtr pDst, uint unBytes, ref uint punRead)
		{
			punRead = 0;
			EIOBufferError result = FnTable.Read(ulBuffer, pDst, unBytes, ref punRead);
			return result;
		}
		public EIOBufferError Write(ulong ulBuffer, IntPtr pSrc, uint unBytes)
		{
			EIOBufferError result = FnTable.Write(ulBuffer, pSrc, unBytes);
			return result;
		}
		public ulong PropertyContainer(ulong ulBuffer)
		{
			ulong result = FnTable.PropertyContainer(ulBuffer);
			return result;
		}
		public bool HasReaders(ulong ulBuffer)
		{
			bool result = FnTable.HasReaders(ulBuffer);
			return result;
		}
	}


	public class CVRSpatialAnchors
	{
		IVRSpatialAnchors FnTable;
		internal CVRSpatialAnchors(IntPtr pInterface)
		{
			FnTable = (IVRSpatialAnchors)Marshal.PtrToStructure(pInterface, typeof(IVRSpatialAnchors));
		}
		public EVRSpatialAnchorError CreateSpatialAnchorFromDescriptor(string pchDescriptor, ref uint pHandleOut)
		{
			IntPtr pchDescriptorUtf8 = Utils.ToUtf8(pchDescriptor);
			pHandleOut = 0;
			EVRSpatialAnchorError result = FnTable.CreateSpatialAnchorFromDescriptor(pchDescriptorUtf8, ref pHandleOut);
			Marshal.FreeHGlobal(pchDescriptorUtf8);
			return result;
		}
		public EVRSpatialAnchorError CreateSpatialAnchorFromPose(uint unDeviceIndex, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPose, ref uint pHandleOut)
		{
			pHandleOut = 0;
			EVRSpatialAnchorError result = FnTable.CreateSpatialAnchorFromPose(unDeviceIndex, eOrigin, ref pPose, ref pHandleOut);
			return result;
		}
		public EVRSpatialAnchorError GetSpatialAnchorPose(uint unHandle, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPoseOut)
		{
			EVRSpatialAnchorError result = FnTable.GetSpatialAnchorPose(unHandle, eOrigin, ref pPoseOut);
			return result;
		}
		public EVRSpatialAnchorError GetSpatialAnchorDescriptor(uint unHandle, System.Text.StringBuilder pchDescriptorOut, ref uint punDescriptorBufferLenInOut)
		{
			punDescriptorBufferLenInOut = 0;
			EVRSpatialAnchorError result = FnTable.GetSpatialAnchorDescriptor(unHandle, pchDescriptorOut, ref punDescriptorBufferLenInOut);
			return result;
		}
	}


	public class CVRDebug
	{
		IVRDebug FnTable;
		internal CVRDebug(IntPtr pInterface)
		{
			FnTable = (IVRDebug)Marshal.PtrToStructure(pInterface, typeof(IVRDebug));
		}
		public EVRDebugError EmitVrProfilerEvent(string pchMessage)
		{
			IntPtr pchMessageUtf8 = Utils.ToUtf8(pchMessage);
			EVRDebugError result = FnTable.EmitVrProfilerEvent(pchMessageUtf8);
			Marshal.FreeHGlobal(pchMessageUtf8);
			return result;
		}
		public EVRDebugError BeginVrProfilerEvent(ref ulong pHandleOut)
		{
			pHandleOut = 0;
			EVRDebugError result = FnTable.BeginVrProfilerEvent(ref pHandleOut);
			return result;
		}
		public EVRDebugError FinishVrProfilerEvent(ulong hHandle, string pchMessage)
		{
			IntPtr pchMessageUtf8 = Utils.ToUtf8(pchMessage);
			EVRDebugError result = FnTable.FinishVrProfilerEvent(hHandle, pchMessageUtf8);
			Marshal.FreeHGlobal(pchMessageUtf8);
			return result;
		}
		public uint DriverDebugRequest(uint unDeviceIndex, string pchRequest, System.Text.StringBuilder pchResponseBuffer, uint unResponseBufferSize)
		{
			IntPtr pchRequestUtf8 = Utils.ToUtf8(pchRequest);
			uint result = FnTable.DriverDebugRequest(unDeviceIndex, pchRequestUtf8, pchResponseBuffer, unResponseBufferSize);
			Marshal.FreeHGlobal(pchRequestUtf8);
			return result;
		}
	}


	public class CVRIPCResourceManagerClient
	{
		IVRIPCResourceManagerClient FnTable;
		internal CVRIPCResourceManagerClient(IntPtr pInterface)
		{
			FnTable = (IVRIPCResourceManagerClient)Marshal.PtrToStructure(pInterface, typeof(IVRIPCResourceManagerClient));
		}
		public bool NewSharedVulkanImage(uint nImageFormat, uint nWidth, uint nHeight, bool bRenderable, bool bMappable, bool bComputeAccess, uint unMipLevels, uint unArrayLayerCount, ref ulong pSharedHandle)
		{
			pSharedHandle = 0;
			bool result = FnTable.NewSharedVulkanImage(nImageFormat, nWidth, nHeight, bRenderable, bMappable, bComputeAccess, unMipLevels, unArrayLayerCount, ref pSharedHandle);
			return result;
		}
		public bool NewSharedVulkanBuffer(uint nSize, uint nUsageFlags, ref ulong pSharedHandle)
		{
			pSharedHandle = 0;
			bool result = FnTable.NewSharedVulkanBuffer(nSize, nUsageFlags, ref pSharedHandle);
			return result;
		}
		public bool NewSharedVulkanSemaphore(ref ulong pSharedHandle)
		{
			pSharedHandle = 0;
			bool result = FnTable.NewSharedVulkanSemaphore(ref pSharedHandle);
			return result;
		}
		public bool RefResource(ulong hSharedHandle, ref ulong pNewIpcHandle)
		{
			pNewIpcHandle = 0;
			bool result = FnTable.RefResource(hSharedHandle, ref pNewIpcHandle);
			return result;
		}
		public bool UnrefResource(ulong hSharedHandle)
		{
			bool result = FnTable.UnrefResource(hSharedHandle);
			return result;
		}
		public bool GetDmabufFormats(ref uint pOutFormatCount, ref uint pOutFormats)
		{
			pOutFormatCount = 0;
			pOutFormats = 0;
			bool result = FnTable.GetDmabufFormats(ref pOutFormatCount, ref pOutFormats);
			return result;
		}
		public bool GetDmabufModifiers(EVRApplicationType eApplicationType, uint unDRMFormat, ref uint pOutModifierCount, ref ulong pOutModifiers)
		{
			pOutModifierCount = 0;
			pOutModifiers = 0;
			bool result = FnTable.GetDmabufModifiers(eApplicationType, unDRMFormat, ref pOutModifierCount, ref pOutModifiers);
			return result;
		}
		public bool ImportDmabuf(EVRApplicationType eApplicationType, ref DmabufAttributes_t pDmabufAttributes, ref ulong pSharedHandle)
		{
			pSharedHandle = 0;
			bool result = FnTable.ImportDmabuf(eApplicationType, ref pDmabufAttributes, ref pSharedHandle);
			return result;
		}
		public bool ReceiveSharedFd(ulong ulIpcHandle, ref int pOutFd)
		{
			pOutFd = 0;
			bool result = FnTable.ReceiveSharedFd(ulIpcHandle, ref pOutFd);
			return result;
		}
		public void DestructIVRIPCResourceManagerClient()
		{
			FnTable.DestructIVRIPCResourceManagerClient();
		}
	}


	public class CVRProperties
	{
		IVRProperties FnTable;
		internal CVRProperties(IntPtr pInterface)
		{
			FnTable = (IVRProperties)Marshal.PtrToStructure(pInterface, typeof(IVRProperties));
		}
		public ETrackedPropertyError ReadPropertyBatch(ulong ulContainerHandle, ref PropertyRead_t pBatch, uint unBatchEntryCount)
		{
			ETrackedPropertyError result = FnTable.ReadPropertyBatch(ulContainerHandle, ref pBatch, unBatchEntryCount);
			return result;
		}
		public ETrackedPropertyError WritePropertyBatch(ulong ulContainerHandle, ref PropertyWrite_t pBatch, uint unBatchEntryCount)
		{
			ETrackedPropertyError result = FnTable.WritePropertyBatch(ulContainerHandle, ref pBatch, unBatchEntryCount);
			return result;
		}
		public string GetPropErrorNameFromEnum(ETrackedPropertyError error)
		{
			IntPtr result = FnTable.GetPropErrorNameFromEnum(error);
			return Marshal.PtrToStringAnsi(result);
		}
		public ulong TrackedDeviceToPropertyContainer(uint nDevice)
		{
			ulong result = FnTable.TrackedDeviceToPropertyContainer(nDevice);
			return result;
		}
	}


	public class CVRPaths
	{
		IVRPaths FnTable;
		internal CVRPaths(IntPtr pInterface)
		{
			FnTable = (IVRPaths)Marshal.PtrToStructure(pInterface, typeof(IVRPaths));
		}
		public ETrackedPropertyError ReadPathBatch(ulong ulRootHandle, ref PathRead_t pBatch, uint unBatchEntryCount)
		{
			ETrackedPropertyError result = FnTable.ReadPathBatch(ulRootHandle, ref pBatch, unBatchEntryCount);
			return result;
		}
		public ETrackedPropertyError WritePathBatch(ulong ulRootHandle, ref PathWrite_t pBatch, uint unBatchEntryCount)
		{
			ETrackedPropertyError result = FnTable.WritePathBatch(ulRootHandle, ref pBatch, unBatchEntryCount);
			return result;
		}
		public ETrackedPropertyError StringToHandle(ref ulong pHandle, string pchPath)
		{
			pHandle = 0;
			IntPtr pchPathUtf8 = Utils.ToUtf8(pchPath);
			ETrackedPropertyError result = FnTable.StringToHandle(ref pHandle, pchPathUtf8);
			Marshal.FreeHGlobal(pchPathUtf8);
			return result;
		}
		public ETrackedPropertyError HandleToString(ulong pHandle, string pchBuffer, uint unBufferSize, ref uint punBufferSizeUsed)
		{
			punBufferSizeUsed = 0;
			ETrackedPropertyError result = FnTable.HandleToString(pHandle, pchBuffer, unBufferSize, ref punBufferSizeUsed);
			return result;
		}
	}


	public class CVRBlockQueue
	{
		IVRBlockQueue FnTable;
		internal CVRBlockQueue(IntPtr pInterface)
		{
			FnTable = (IVRBlockQueue)Marshal.PtrToStructure(pInterface, typeof(IVRBlockQueue));
		}
		public EBlockQueueError Create(ref ulong pulQueueHandle, string pchPath, uint unBlockDataSize, uint unBlockHeaderSize, uint unBlockCount, uint unFlags)
		{
			pulQueueHandle = 0;
			IntPtr pchPathUtf8 = Utils.ToUtf8(pchPath);
			EBlockQueueError result = FnTable.Create(ref pulQueueHandle, pchPathUtf8, unBlockDataSize, unBlockHeaderSize, unBlockCount, unFlags);
			Marshal.FreeHGlobal(pchPathUtf8);
			return result;
		}
		public EBlockQueueError Connect(ref ulong pulQueueHandle, string pchPath)
		{
			pulQueueHandle = 0;
			IntPtr pchPathUtf8 = Utils.ToUtf8(pchPath);
			EBlockQueueError result = FnTable.Connect(ref pulQueueHandle, pchPathUtf8);
			Marshal.FreeHGlobal(pchPathUtf8);
			return result;
		}
		public EBlockQueueError Destroy(ulong ulQueueHandle)
		{
			EBlockQueueError result = FnTable.Destroy(ulQueueHandle);
			return result;
		}
		public EBlockQueueError AcquireWriteOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer)
		{
			pulBlockHandle = 0;
			EBlockQueueError result = FnTable.AcquireWriteOnlyBlock(ulQueueHandle, ref pulBlockHandle, ref ppvBuffer);
			return result;
		}
		public EBlockQueueError ReleaseWriteOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle)
		{
			EBlockQueueError result = FnTable.ReleaseWriteOnlyBlock(ulQueueHandle, ulBlockHandle);
			return result;
		}
		public EBlockQueueError WaitAndAcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType, uint unTimeoutMs)
		{
			pulBlockHandle = 0;
			EBlockQueueError result = FnTable.WaitAndAcquireReadOnlyBlock(ulQueueHandle, ref pulBlockHandle, ref ppvBuffer, eReadType, unTimeoutMs);
			return result;
		}
		public EBlockQueueError AcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType)
		{
			pulBlockHandle = 0;
			EBlockQueueError result = FnTable.AcquireReadOnlyBlock(ulQueueHandle, ref pulBlockHandle, ref ppvBuffer, eReadType);
			return result;
		}
		public EBlockQueueError ReleaseReadOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle)
		{
			EBlockQueueError result = FnTable.ReleaseReadOnlyBlock(ulQueueHandle, ulBlockHandle);
			return result;
		}
		public EBlockQueueError QueueHasReader(ulong ulQueueHandle, ref bool pbHasReaders)
		{
			pbHasReaders = false;
			EBlockQueueError result = FnTable.QueueHasReader(ulQueueHandle, ref pbHasReaders);
			return result;
		}
	}


	public class OpenVRInterop
	{
		[DllImportAttribute("openvr_api", EntryPoint = "VR_InitInternal", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType);
		[DllImportAttribute("openvr_api", EntryPoint = "VR_InitInternal2", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint InitInternal2(ref EVRInitError peError, EVRApplicationType eApplicationType, [In, MarshalAs(UnmanagedType.LPStr)] string pStartupInfo);
		[DllImportAttribute("openvr_api", EntryPoint = "VR_ShutdownInternal", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ShutdownInternal();
		[DllImportAttribute("openvr_api", EntryPoint = "VR_IsHmdPresent", CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool IsHmdPresent();
		[DllImportAttribute("openvr_api", EntryPoint = "VR_IsRuntimeInstalled", CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool IsRuntimeInstalled();
		[DllImportAttribute("openvr_api", EntryPoint = "VR_RuntimePath", CallingConvention = CallingConvention.Cdecl)]
		internal static extern string RuntimePath();
		[DllImportAttribute("openvr_api", EntryPoint = "VR_GetRuntimePath", CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool GetRuntimePath(System.Text.StringBuilder pchPathBuffer, uint unBufferSize, ref uint punRequiredBufferSize);
		[DllImportAttribute("openvr_api", EntryPoint = "VR_GetStringForHmdError", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr GetStringForHmdError(EVRInitError error);
		[DllImportAttribute("openvr_api", EntryPoint = "VR_GetGenericInterface", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr GetGenericInterface([In, MarshalAs(UnmanagedType.LPStr)] string pchInterfaceVersion, ref EVRInitError peError);
		[DllImportAttribute("openvr_api", EntryPoint = "VR_IsInterfaceVersionValid", CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool IsInterfaceVersionValid([In, MarshalAs(UnmanagedType.LPStr)] string pchInterfaceVersion);
		[DllImportAttribute("openvr_api", EntryPoint = "VR_GetInitToken", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint GetInitToken();
	}


	public enum EVREye
	{
		Eye_Left = 0,
		Eye_Right = 1,
	}
	public enum ETextureType
	{
		Invalid = -1,
		DirectX = 0,
		OpenGL = 1,
		Vulkan = 2,
		IOSurface = 3,
		DirectX12 = 4,
		DXGISharedHandle = 5,
		Metal = 6,
		Reserved = 7,
		SharedTextureHandle = 8,
	}
	public enum EColorSpace
	{
		Auto = 0,
		Gamma = 1,
		Linear = 2,
	}
	public enum ETrackingResult
	{
		Uninitialized = 1,
		Calibrating_InProgress = 100,
		Calibrating_OutOfRange = 101,
		Running_OK = 200,
		Running_OutOfRange = 201,
		Fallback_RotationOnly = 300,
	}
	public enum ETrackedDeviceClass
	{
		Invalid = 0,
		HMD = 1,
		Controller = 2,
		GenericTracker = 3,
		TrackingReference = 4,
		DisplayRedirect = 5,
		Max = 6,
	}
	public enum ETrackedControllerRole
	{
		Invalid = 0,
		LeftHand = 1,
		RightHand = 2,
		OptOut = 3,
		Treadmill = 4,
		Stylus = 5,
		Max = 5,
	}
	public enum ETrackingUniverseOrigin
	{
		TrackingUniverseSeated = 0,
		TrackingUniverseStanding = 1,
		TrackingUniverseRawAndUncalibrated = 2,
	}
	public enum EAdditionalRadioFeatures
	{
		None = 0,
		HTCLinkBox = 1,
		InternalDongle = 2,
		ExternalDongle = 4,
	}
	public enum ETrackedDeviceProperty
	{
		Prop_Invalid = 0,
		Prop_TrackingSystemName_String = 1000,
		Prop_ModelNumber_String = 1001,
		Prop_SerialNumber_String = 1002,
		Prop_RenderModelName_String = 1003,
		Prop_WillDriftInYaw_Bool = 1004,
		Prop_ManufacturerName_String = 1005,
		Prop_TrackingFirmwareVersion_String = 1006,
		Prop_HardwareRevision_String = 1007,
		Prop_AllWirelessDongleDescriptions_String = 1008,
		Prop_ConnectedWirelessDongle_String = 1009,
		Prop_DeviceIsWireless_Bool = 1010,
		Prop_DeviceIsCharging_Bool = 1011,
		Prop_DeviceBatteryPercentage_Float = 1012,
		Prop_StatusDisplayTransform_Matrix34 = 1013,
		Prop_Firmware_UpdateAvailable_Bool = 1014,
		Prop_Firmware_ManualUpdate_Bool = 1015,
		Prop_Firmware_ManualUpdateURL_String = 1016,
		Prop_HardwareRevision_Uint64 = 1017,
		Prop_FirmwareVersion_Uint64 = 1018,
		Prop_FPGAVersion_Uint64 = 1019,
		Prop_VRCVersion_Uint64 = 1020,
		Prop_RadioVersion_Uint64 = 1021,
		Prop_DongleVersion_Uint64 = 1022,
		Prop_BlockServerShutdown_Bool = 1023,
		Prop_CanUnifyCoordinateSystemWithHmd_Bool = 1024,
		Prop_ContainsProximitySensor_Bool = 1025,
		Prop_DeviceProvidesBatteryStatus_Bool = 1026,
		Prop_DeviceCanPowerOff_Bool = 1027,
		Prop_Firmware_ProgrammingTarget_String = 1028,
		Prop_DeviceClass_Int32 = 1029,
		Prop_HasCamera_Bool = 1030,
		Prop_DriverVersion_String = 1031,
		Prop_Firmware_ForceUpdateRequired_Bool = 1032,
		Prop_ViveSystemButtonFixRequired_Bool = 1033,
		Prop_ParentDriver_Uint64 = 1034,
		Prop_ResourceRoot_String = 1035,
		Prop_RegisteredDeviceType_String = 1036,
		Prop_InputProfilePath_String = 1037,
		Prop_NeverTracked_Bool = 1038,
		Prop_NumCameras_Int32 = 1039,
		Prop_CameraFrameLayout_Int32 = 1040,
		Prop_CameraStreamFormat_Int32 = 1041,
		Prop_AdditionalDeviceSettingsPath_String = 1042,
		Prop_Identifiable_Bool = 1043,
		Prop_BootloaderVersion_Uint64 = 1044,
		Prop_AdditionalSystemReportData_String = 1045,
		Prop_CompositeFirmwareVersion_String = 1046,
		Prop_Firmware_RemindUpdate_Bool = 1047,
		Prop_PeripheralApplicationVersion_Uint64 = 1048,
		Prop_ManufacturerSerialNumber_String = 1049,
		Prop_ComputedSerialNumber_String = 1050,
		Prop_EstimatedDeviceFirstUseTime_Int32 = 1051,
		Prop_DevicePowerUsage_Float = 1052,
		Prop_IgnoreMotionForStandby_Bool = 1053,
		Prop_ActualTrackingSystemName_String = 1054,
		Prop_ReportsTimeSinceVSync_Bool = 2000,
		Prop_SecondsFromVsyncToPhotons_Float = 2001,
		Prop_DisplayFrequency_Float = 2002,
		Prop_UserIpdMeters_Float = 2003,
		Prop_CurrentUniverseId_Uint64 = 2004,
		Prop_PreviousUniverseId_Uint64 = 2005,
		Prop_DisplayFirmwareVersion_Uint64 = 2006,
		Prop_IsOnDesktop_Bool = 2007,
		Prop_DisplayMCType_Int32 = 2008,
		Prop_DisplayMCOffset_Float = 2009,
		Prop_DisplayMCScale_Float = 2010,
		Prop_EdidVendorID_Int32 = 2011,
		Prop_DisplayMCImageLeft_String = 2012,
		Prop_DisplayMCImageRight_String = 2013,
		Prop_DisplayGCBlackClamp_Float = 2014,
		Prop_EdidProductID_Int32 = 2015,
		Prop_CameraToHeadTransform_Matrix34 = 2016,
		Prop_DisplayGCType_Int32 = 2017,
		Prop_DisplayGCOffset_Float = 2018,
		Prop_DisplayGCScale_Float = 2019,
		Prop_DisplayGCPrescale_Float = 2020,
		Prop_DisplayGCImage_String = 2021,
		Prop_LensCenterLeftU_Float = 2022,
		Prop_LensCenterLeftV_Float = 2023,
		Prop_LensCenterRightU_Float = 2024,
		Prop_LensCenterRightV_Float = 2025,
		Prop_UserHeadToEyeDepthMeters_Float = 2026,
		Prop_CameraFirmwareVersion_Uint64 = 2027,
		Prop_CameraFirmwareDescription_String = 2028,
		Prop_DisplayFPGAVersion_Uint64 = 2029,
		Prop_DisplayBootloaderVersion_Uint64 = 2030,
		Prop_DisplayHardwareVersion_Uint64 = 2031,
		Prop_AudioFirmwareVersion_Uint64 = 2032,
		Prop_CameraCompatibilityMode_Int32 = 2033,
		Prop_ScreenshotHorizontalFieldOfViewDegrees_Float = 2034,
		Prop_ScreenshotVerticalFieldOfViewDegrees_Float = 2035,
		Prop_DisplaySuppressed_Bool = 2036,
		Prop_DisplayAllowNightMode_Bool = 2037,
		Prop_DisplayMCImageWidth_Int32 = 2038,
		Prop_DisplayMCImageHeight_Int32 = 2039,
		Prop_DisplayMCImageNumChannels_Int32 = 2040,
		Prop_DisplayMCImageData_Binary = 2041,
		Prop_SecondsFromPhotonsToVblank_Float = 2042,
		Prop_DriverDirectModeSendsVsyncEvents_Bool = 2043,
		Prop_DisplayDebugMode_Bool = 2044,
		Prop_GraphicsAdapterLuid_Uint64 = 2045,
		Prop_DriverProvidedChaperonePath_String = 2048,
		Prop_ExpectedTrackingReferenceCount_Int32 = 2049,
		Prop_ExpectedControllerCount_Int32 = 2050,
		Prop_NamedIconPathControllerLeftDeviceOff_String = 2051,
		Prop_NamedIconPathControllerRightDeviceOff_String = 2052,
		Prop_NamedIconPathTrackingReferenceDeviceOff_String = 2053,
		Prop_DoNotApplyPrediction_Bool = 2054,
		Prop_CameraToHeadTransforms_Matrix34_Array = 2055,
		Prop_DistortionMeshResolution_Int32 = 2056,
		Prop_DriverIsDrawingControllers_Bool = 2057,
		Prop_DriverRequestsApplicationPause_Bool = 2058,
		Prop_DriverRequestsReducedRendering_Bool = 2059,
		Prop_MinimumIpdStepMeters_Float = 2060,
		Prop_AudioBridgeFirmwareVersion_Uint64 = 2061,
		Prop_ImageBridgeFirmwareVersion_Uint64 = 2062,
		Prop_ImuToHeadTransform_Matrix34 = 2063,
		Prop_ImuFactoryGyroBias_Vector3 = 2064,
		Prop_ImuFactoryGyroScale_Vector3 = 2065,
		Prop_ImuFactoryAccelerometerBias_Vector3 = 2066,
		Prop_ImuFactoryAccelerometerScale_Vector3 = 2067,
		Prop_ConfigurationIncludesLighthouse20Features_Bool = 2069,
		Prop_AdditionalRadioFeatures_Uint64 = 2070,
		Prop_CameraWhiteBalance_Vector4_Array = 2071,
		Prop_CameraDistortionFunction_Int32_Array = 2072,
		Prop_CameraDistortionCoefficients_Float_Array = 2073,
		Prop_ExpectedControllerType_String = 2074,
		Prop_HmdTrackingStyle_Int32 = 2075,
		Prop_DriverProvidedChaperoneVisibility_Bool = 2076,
		Prop_HmdColumnCorrectionSettingPrefix_String = 2077,
		Prop_CameraSupportsCompatibilityModes_Bool = 2078,
		Prop_SupportsRoomViewDepthProjection_Bool = 2079,
		Prop_DisplayAvailableFrameRates_Float_Array = 2080,
		Prop_DisplaySupportsMultipleFramerates_Bool = 2081,
		Prop_DisplayColorMultLeft_Vector3 = 2082,
		Prop_DisplayColorMultRight_Vector3 = 2083,
		Prop_DisplaySupportsRuntimeFramerateChange_Bool = 2084,
		Prop_DisplaySupportsAnalogGain_Bool = 2085,
		Prop_DisplayMinAnalogGain_Float = 2086,
		Prop_DisplayMaxAnalogGain_Float = 2087,
		Prop_CameraExposureTime_Float = 2088,
		Prop_CameraGlobalGain_Float = 2089,
		Prop_DashboardScale_Float = 2091,
		Prop_PeerButtonInfo_String = 2092,
		Prop_Hmd_SupportsHDR10_Bool = 2093,
		Prop_Hmd_EnableParallelRenderCameras_Bool = 2094,
		Prop_DriverProvidedChaperoneJson_String = 2095,
		Prop_ForceSystemLayerUseAppPoses_Bool = 2096,
		Prop_IpdUIRangeMinMeters_Float = 2100,
		Prop_IpdUIRangeMaxMeters_Float = 2101,
		Prop_Hmd_SupportsHDCP14LegacyCompat_Bool = 2102,
		Prop_Hmd_SupportsMicMonitoring_Bool = 2103,
		Prop_Hmd_SupportsDisplayPortTrainingMode_Bool = 2104,
		Prop_Hmd_SupportsRoomViewDirect_Bool = 2105,
		Prop_Hmd_SupportsAppThrottling_Bool = 2106,
		Prop_Hmd_SupportsGpuBusMonitoring_Bool = 2107,
		Prop_DriverDisplaysIPDChanges_Bool = 2108,
		Prop_Driver_Reserved_01 = 2109,
		Prop_Driver_Reserved_02 = 2110,
		Prop_DSCVersion_Int32 = 2110,
		Prop_DSCSliceCount_Int32 = 2111,
		Prop_DSCBPPx16_Int32 = 2112,
		Prop_Hmd_MaxDistortedTextureWidth_Int32 = 2113,
		Prop_Hmd_MaxDistortedTextureHeight_Int32 = 2114,
		Prop_Hmd_AllowSupersampleFiltering_Bool = 2115,
		Prop_DriverRequestedMuraCorrectionMode_Int32 = 2200,
		Prop_DriverRequestedMuraFeather_InnerLeft_Int32 = 2201,
		Prop_DriverRequestedMuraFeather_InnerRight_Int32 = 2202,
		Prop_DriverRequestedMuraFeather_InnerTop_Int32 = 2203,
		Prop_DriverRequestedMuraFeather_InnerBottom_Int32 = 2204,
		Prop_DriverRequestedMuraFeather_OuterLeft_Int32 = 2205,
		Prop_DriverRequestedMuraFeather_OuterRight_Int32 = 2206,
		Prop_DriverRequestedMuraFeather_OuterTop_Int32 = 2207,
		Prop_DriverRequestedMuraFeather_OuterBottom_Int32 = 2208,
		Prop_Audio_DefaultPlaybackDeviceId_String = 2300,
		Prop_Audio_DefaultRecordingDeviceId_String = 2301,
		Prop_Audio_DefaultPlaybackDeviceVolume_Float = 2302,
		Prop_Audio_SupportsDualSpeakerAndJackOutput_Bool = 2303,
		Prop_Audio_DriverManagesPlaybackVolumeControl_Bool = 2304,
		Prop_Audio_DriverPlaybackVolume_Float = 2305,
		Prop_Audio_DriverPlaybackMute_Bool = 2306,
		Prop_Audio_DriverManagesRecordingVolumeControl_Bool = 2307,
		Prop_Audio_DriverRecordingVolume_Float = 2308,
		Prop_Audio_DriverRecordingMute_Bool = 2309,
		Prop_AttachedDeviceId_String = 3000,
		Prop_SupportedButtons_Uint64 = 3001,
		Prop_Axis0Type_Int32 = 3002,
		Prop_Axis1Type_Int32 = 3003,
		Prop_Axis2Type_Int32 = 3004,
		Prop_Axis3Type_Int32 = 3005,
		Prop_Axis4Type_Int32 = 3006,
		Prop_ControllerRoleHint_Int32 = 3007,
		Prop_FieldOfViewLeftDegrees_Float = 4000,
		Prop_FieldOfViewRightDegrees_Float = 4001,
		Prop_FieldOfViewTopDegrees_Float = 4002,
		Prop_FieldOfViewBottomDegrees_Float = 4003,
		Prop_TrackingRangeMinimumMeters_Float = 4004,
		Prop_TrackingRangeMaximumMeters_Float = 4005,
		Prop_ModeLabel_String = 4006,
		Prop_CanWirelessIdentify_Bool = 4007,
		Prop_Nonce_Int32 = 4008,
		Prop_IconPathName_String = 5000,
		Prop_NamedIconPathDeviceOff_String = 5001,
		Prop_NamedIconPathDeviceSearching_String = 5002,
		Prop_NamedIconPathDeviceSearchingAlert_String = 5003,
		Prop_NamedIconPathDeviceReady_String = 5004,
		Prop_NamedIconPathDeviceReadyAlert_String = 5005,
		Prop_NamedIconPathDeviceNotReady_String = 5006,
		Prop_NamedIconPathDeviceStandby_String = 5007,
		Prop_NamedIconPathDeviceAlertLow_String = 5008,
		Prop_NamedIconPathDeviceStandbyAlert_String = 5009,
		Prop_DisplayHiddenArea_Binary_Start = 5100,
		Prop_DisplayHiddenArea_Binary_End = 5150,
		Prop_ParentContainer = 5151,
		Prop_OverrideContainer_Uint64 = 5152,
		Prop_UserConfigPath_String = 6000,
		Prop_InstallPath_String = 6001,
		Prop_HasDisplayComponent_Bool = 6002,
		Prop_HasControllerComponent_Bool = 6003,
		Prop_HasCameraComponent_Bool = 6004,
		Prop_HasDriverDirectModeComponent_Bool = 6005,
		Prop_HasVirtualDisplayComponent_Bool = 6006,
		Prop_HasSpatialAnchorsSupport_Bool = 6007,
		Prop_SupportsXrTextureSets_Bool = 6008,
		Prop_ControllerType_String = 7000,
		Prop_ControllerHandSelectionPriority_Int32 = 7002,
		Prop_VendorSpecific_Reserved_Start = 10000,
		Prop_VendorSpecific_Reserved_End = 10999,
		Prop_TrackedDeviceProperty_Max = 1000000,
	}
	public enum ETrackedPropertyError
	{
		TrackedProp_Success = 0,
		TrackedProp_WrongDataType = 1,
		TrackedProp_WrongDeviceClass = 2,
		TrackedProp_BufferTooSmall = 3,
		TrackedProp_UnknownProperty = 4,
		TrackedProp_InvalidDevice = 5,
		TrackedProp_CouldNotContactServer = 6,
		TrackedProp_ValueNotProvidedByDevice = 7,
		TrackedProp_StringExceedsMaximumLength = 8,
		TrackedProp_NotYetAvailable = 9,
		TrackedProp_PermissionDenied = 10,
		TrackedProp_InvalidOperation = 11,
		TrackedProp_CannotWriteToWildcards = 12,
		TrackedProp_IPCReadFailure = 13,
		TrackedProp_OutOfMemory = 14,
		TrackedProp_InvalidContainer = 15,
	}
	public enum EHmdTrackingStyle
	{
		Unknown = 0,
		Lighthouse = 1,
		OutsideInCameras = 2,
		InsideOutCameras = 3,
	}
	public enum EVRSubmitFlags
	{
		Submit_Default = 0,
		Submit_LensDistortionAlreadyApplied = 1,
		Submit_GlRenderBuffer = 2,
		Submit_Reserved = 4,
		Submit_TextureWithPose = 8,
		Submit_TextureWithDepth = 16,
		Submit_FrameDiscontinuity = 32,
		Submit_VulkanTextureWithArrayData = 64,
		Submit_GlArrayTexture = 128,
		Submit_IsEgl = 256,
		Submit_Reserved2 = 32768,
		Submit_Reserved3 = 65536,
	}
	public enum EVRState
	{
		Undefined = -1,
		Off = 0,
		Searching = 1,
		Searching_Alert = 2,
		Ready = 3,
		Ready_Alert = 4,
		NotReady = 5,
		Standby = 6,
		Ready_Alert_Low = 7,
	}
	public enum EVREventType
	{
		VREvent_None = 0,
		VREvent_TrackedDeviceActivated = 100,
		VREvent_TrackedDeviceDeactivated = 101,
		VREvent_TrackedDeviceUpdated = 102,
		VREvent_TrackedDeviceUserInteractionStarted = 103,
		VREvent_TrackedDeviceUserInteractionEnded = 104,
		VREvent_IpdChanged = 105,
		VREvent_EnterStandbyMode = 106,
		VREvent_LeaveStandbyMode = 107,
		VREvent_TrackedDeviceRoleChanged = 108,
		VREvent_WatchdogWakeUpRequested = 109,
		VREvent_LensDistortionChanged = 110,
		VREvent_PropertyChanged = 111,
		VREvent_WirelessDisconnect = 112,
		VREvent_WirelessReconnect = 113,
		VREvent_Reserved_01 = 114,
		VREvent_Reserved_02 = 115,
		VREvent_ButtonPress = 200,
		VREvent_ButtonUnpress = 201,
		VREvent_ButtonTouch = 202,
		VREvent_ButtonUntouch = 203,
		VREvent_Modal_Cancel = 257,
		VREvent_MouseMove = 300,
		VREvent_MouseButtonDown = 301,
		VREvent_MouseButtonUp = 302,
		VREvent_FocusEnter = 303,
		VREvent_FocusLeave = 304,
		VREvent_ScrollDiscrete = 305,
		VREvent_TouchPadMove = 306,
		VREvent_OverlayFocusChanged = 307,
		VREvent_ReloadOverlays = 308,
		VREvent_ScrollSmooth = 309,
		VREvent_LockMousePosition = 310,
		VREvent_UnlockMousePosition = 311,
		VREvent_InputFocusCaptured = 400,
		VREvent_InputFocusReleased = 401,
		VREvent_SceneApplicationChanged = 404,
		VREvent_InputFocusChanged = 406,
		VREvent_SceneApplicationUsingWrongGraphicsAdapter = 408,
		VREvent_ActionBindingReloaded = 409,
		VREvent_HideRenderModels = 410,
		VREvent_ShowRenderModels = 411,
		VREvent_SceneApplicationStateChanged = 412,
		VREvent_SceneAppPipeDisconnected = 413,
		VREvent_ConsoleOpened = 420,
		VREvent_ConsoleClosed = 421,
		VREvent_OverlayShown = 500,
		VREvent_OverlayHidden = 501,
		VREvent_DashboardActivated = 502,
		VREvent_DashboardDeactivated = 503,
		VREvent_DashboardRequested = 505,
		VREvent_ResetDashboard = 506,
		VREvent_ImageLoaded = 508,
		VREvent_ShowKeyboard = 509,
		VREvent_HideKeyboard = 510,
		VREvent_OverlayGamepadFocusGained = 511,
		VREvent_OverlayGamepadFocusLost = 512,
		VREvent_OverlaySharedTextureChanged = 513,
		VREvent_ScreenshotTriggered = 516,
		VREvent_ImageFailed = 517,
		VREvent_DashboardOverlayCreated = 518,
		VREvent_SwitchGamepadFocus = 519,
		VREvent_RequestScreenshot = 520,
		VREvent_ScreenshotTaken = 521,
		VREvent_ScreenshotFailed = 522,
		VREvent_SubmitScreenshotToDashboard = 523,
		VREvent_ScreenshotProgressToDashboard = 524,
		VREvent_PrimaryDashboardDeviceChanged = 525,
		VREvent_RoomViewShown = 526,
		VREvent_RoomViewHidden = 527,
		VREvent_ShowUI = 528,
		VREvent_ShowDevTools = 529,
		VREvent_DesktopViewUpdating = 530,
		VREvent_DesktopViewReady = 531,
		VREvent_StartDashboard = 532,
		VREvent_ElevatePrism = 533,
		VREvent_OverlayClosed = 534,
		VREvent_DashboardThumbChanged = 535,
		VREvent_DesktopMightBeVisible = 536,
		VREvent_DesktopMightBeHidden = 537,
		VREvent_MutualSteamCapabilitiesChanged = 538,
		VREvent_OverlayCreated = 539,
		VREvent_OverlayDestroyed = 540,
		VREvent_Notification_Shown = 600,
		VREvent_Notification_Hidden = 601,
		VREvent_Notification_BeginInteraction = 602,
		VREvent_Notification_Destroyed = 603,
		VREvent_Quit = 700,
		VREvent_ProcessQuit = 701,
		VREvent_QuitAcknowledged = 703,
		VREvent_DriverRequestedQuit = 704,
		VREvent_RestartRequested = 705,
		VREvent_InvalidateSwapTextureSets = 706,
		VREvent_ChaperoneDataHasChanged = 800,
		VREvent_ChaperoneUniverseHasChanged = 801,
		VREvent_ChaperoneTempDataHasChanged = 802,
		VREvent_ChaperoneSettingsHaveChanged = 803,
		VREvent_SeatedZeroPoseReset = 804,
		VREvent_ChaperoneFlushCache = 805,
		VREvent_ChaperoneRoomSetupStarting = 806,
		VREvent_ChaperoneRoomSetupFinished = 807,
		VREvent_StandingZeroPoseReset = 808,
		VREvent_AudioSettingsHaveChanged = 820,
		VREvent_BackgroundSettingHasChanged = 850,
		VREvent_CameraSettingsHaveChanged = 851,
		VREvent_ReprojectionSettingHasChanged = 852,
		VREvent_ModelSkinSettingsHaveChanged = 853,
		VREvent_EnvironmentSettingsHaveChanged = 854,
		VREvent_PowerSettingsHaveChanged = 855,
		VREvent_EnableHomeAppSettingsHaveChanged = 856,
		VREvent_SteamVRSectionSettingChanged = 857,
		VREvent_LighthouseSectionSettingChanged = 858,
		VREvent_NullSectionSettingChanged = 859,
		VREvent_UserInterfaceSectionSettingChanged = 860,
		VREvent_NotificationsSectionSettingChanged = 861,
		VREvent_KeyboardSectionSettingChanged = 862,
		VREvent_PerfSectionSettingChanged = 863,
		VREvent_DashboardSectionSettingChanged = 864,
		VREvent_WebInterfaceSectionSettingChanged = 865,
		VREvent_TrackersSectionSettingChanged = 866,
		VREvent_LastKnownSectionSettingChanged = 867,
		VREvent_DismissedWarningsSectionSettingChanged = 868,
		VREvent_GpuSpeedSectionSettingChanged = 869,
		VREvent_WindowsMRSectionSettingChanged = 870,
		VREvent_OtherSectionSettingChanged = 871,
		VREvent_AnyDriverSettingsChanged = 872,
		VREvent_StatusUpdate = 900,
		VREvent_WebInterface_InstallDriverCompleted = 950,
		VREvent_MCImageUpdated = 1000,
		VREvent_FirmwareUpdateStarted = 1100,
		VREvent_FirmwareUpdateFinished = 1101,
		VREvent_KeyboardClosed = 1200,
		VREvent_KeyboardCharInput = 1201,
		VREvent_KeyboardDone = 1202,
		VREvent_KeyboardOpened_Global = 1203,
		VREvent_KeyboardClosed_Global = 1204,
		VREvent_ApplicationListUpdated = 1303,
		VREvent_ApplicationMimeTypeLoad = 1304,
		VREvent_ProcessConnected = 1306,
		VREvent_ProcessDisconnected = 1307,
		VREvent_Compositor_ChaperoneBoundsShown = 1410,
		VREvent_Compositor_ChaperoneBoundsHidden = 1411,
		VREvent_Compositor_DisplayDisconnected = 1412,
		VREvent_Compositor_DisplayReconnected = 1413,
		VREvent_Compositor_HDCPError = 1414,
		VREvent_Compositor_ApplicationNotResponding = 1415,
		VREvent_Compositor_ApplicationResumed = 1416,
		VREvent_Compositor_OutOfVideoMemory = 1417,
		VREvent_Compositor_DisplayModeNotSupported = 1418,
		VREvent_Compositor_StageOverrideReady = 1419,
		VREvent_Compositor_RequestDisconnectReconnect = 1420,
		VREvent_TrackedCamera_StartVideoStream = 1500,
		VREvent_TrackedCamera_StopVideoStream = 1501,
		VREvent_TrackedCamera_PauseVideoStream = 1502,
		VREvent_TrackedCamera_ResumeVideoStream = 1503,
		VREvent_TrackedCamera_EditingSurface = 1550,
		VREvent_PerformanceTest_EnableCapture = 1600,
		VREvent_PerformanceTest_DisableCapture = 1601,
		VREvent_PerformanceTest_FidelityLevel = 1602,
		VREvent_MessageOverlay_Closed = 1650,
		VREvent_MessageOverlayCloseRequested = 1651,
		VREvent_Input_HapticVibration = 1700,
		VREvent_Input_BindingLoadFailed = 1701,
		VREvent_Input_BindingLoadSuccessful = 1702,
		VREvent_Input_ActionManifestReloaded = 1703,
		VREvent_Input_ActionManifestLoadFailed = 1704,
		VREvent_Input_ProgressUpdate = 1705,
		VREvent_Input_TrackerActivated = 1706,
		VREvent_Input_BindingsUpdated = 1707,
		VREvent_Input_BindingSubscriptionChanged = 1708,
		VREvent_SpatialAnchors_PoseUpdated = 1800,
		VREvent_SpatialAnchors_DescriptorUpdated = 1801,
		VREvent_SpatialAnchors_RequestPoseUpdate = 1802,
		VREvent_SpatialAnchors_RequestDescriptorUpdate = 1803,
		VREvent_SystemReport_Started = 1900,
		VREvent_Monitor_ShowHeadsetView = 2000,
		VREvent_Monitor_HideHeadsetView = 2001,
		VREvent_Audio_SetSpeakersVolume = 2100,
		VREvent_Audio_SetSpeakersMute = 2101,
		VREvent_Audio_SetMicrophoneVolume = 2102,
		VREvent_Audio_SetMicrophoneMute = 2103,
		VREvent_VendorSpecific_Reserved_Start = 10000,
		VREvent_VendorSpecific_Reserved_End = 19999,
	}
	public enum EDeviceActivityLevel
	{
		k_EDeviceActivityLevel_Unknown = -1,
		k_EDeviceActivityLevel_Idle = 0,
		k_EDeviceActivityLevel_UserInteraction = 1,
		k_EDeviceActivityLevel_UserInteraction_Timeout = 2,
		k_EDeviceActivityLevel_Standby = 3,
		k_EDeviceActivityLevel_Idle_Timeout = 4,
	}
	public enum EVRButtonId
	{
		k_EButton_System = 0,
		k_EButton_ApplicationMenu = 1,
		k_EButton_Grip = 2,
		k_EButton_DPad_Left = 3,
		k_EButton_DPad_Up = 4,
		k_EButton_DPad_Right = 5,
		k_EButton_DPad_Down = 6,
		k_EButton_A = 7,
		k_EButton_ProximitySensor = 31,
		k_EButton_Axis0 = 32,
		k_EButton_Axis1 = 33,
		k_EButton_Axis2 = 34,
		k_EButton_Axis3 = 35,
		k_EButton_Axis4 = 36,
		k_EButton_SteamVR_Touchpad = 32,
		k_EButton_SteamVR_Trigger = 33,
		k_EButton_Dashboard_Back = 2,
		k_EButton_IndexController_A = 2,
		k_EButton_IndexController_B = 1,
		k_EButton_IndexController_JoyStick = 35,
		k_EButton_Reserved0 = 50,
		k_EButton_Reserved1 = 51,
		k_EButton_Max = 64,
	}
	public enum EVRMouseButton
	{
		Left = 1,
		Right = 2,
		Middle = 4,
	}
	public enum EShowUIType
	{
		ShowUI_ControllerBinding = 0,
		ShowUI_ManageTrackers = 1,
		ShowUI_Pairing = 3,
		ShowUI_Settings = 4,
		ShowUI_DebugCommands = 5,
		ShowUI_FullControllerBinding = 6,
		ShowUI_ManageDrivers = 7,
	}
	public enum EHDCPError
	{
		None = 0,
		LinkLost = 1,
		Tampered = 2,
		DeviceRevoked = 3,
		Unknown = 4,
	}
	public enum EVRComponentProperty
	{
		IsStatic = 1,
		IsVisible = 2,
		IsTouched = 4,
		IsPressed = 8,
		IsScrolled = 16,
		IsHighlighted = 32,
	}
	public enum EVRInputError
	{
		None = 0,
		NameNotFound = 1,
		WrongType = 2,
		InvalidHandle = 3,
		InvalidParam = 4,
		NoSteam = 5,
		MaxCapacityReached = 6,
		IPCError = 7,
		NoActiveActionSet = 8,
		InvalidDevice = 9,
		InvalidSkeleton = 10,
		InvalidBoneCount = 11,
		InvalidCompressedData = 12,
		NoData = 13,
		BufferTooSmall = 14,
		MismatchedActionManifest = 15,
		MissingSkeletonData = 16,
		InvalidBoneIndex = 17,
		InvalidPriority = 18,
		PermissionDenied = 19,
		InvalidRenderModel = 20,
	}
	public enum EVRSpatialAnchorError
	{
		Success = 0,
		Internal = 1,
		UnknownHandle = 2,
		ArrayTooSmall = 3,
		InvalidDescriptorChar = 4,
		NotYetAvailable = 5,
		NotAvailableInThisUniverse = 6,
		PermanentlyUnavailable = 7,
		WrongDriver = 8,
		DescriptorTooLong = 9,
		Unknown = 10,
		NoRoomCalibration = 11,
		InvalidArgument = 12,
		UnknownDriver = 13,
	}
	public enum EHiddenAreaMeshType
	{
		k_eHiddenAreaMesh_Standard = 0,
		k_eHiddenAreaMesh_Inverse = 1,
		k_eHiddenAreaMesh_LineLoop = 2,
		k_eHiddenAreaMesh_Max = 3,
	}
	public enum EVRControllerAxisType
	{
		k_eControllerAxis_None = 0,
		k_eControllerAxis_TrackPad = 1,
		k_eControllerAxis_Joystick = 2,
		k_eControllerAxis_Trigger = 3,
	}
	public enum EVRControllerEventOutputType
	{
		ControllerEventOutput_OSEvents = 0,
		ControllerEventOutput_VREvents = 1,
	}
	public enum ECollisionBoundsStyle
	{
		COLLISION_BOUNDS_STYLE_BEGINNER = 0,
		COLLISION_BOUNDS_STYLE_INTERMEDIATE = 1,
		COLLISION_BOUNDS_STYLE_SQUARES = 2,
		COLLISION_BOUNDS_STYLE_ADVANCED = 3,
		COLLISION_BOUNDS_STYLE_NONE = 4,
		COLLISION_BOUNDS_STYLE_COUNT = 5,
	}
	public enum EVROverlayError
	{
		None = 0,
		UnknownOverlay = 10,
		InvalidHandle = 11,
		PermissionDenied = 12,
		OverlayLimitExceeded = 13,
		WrongVisibilityType = 14,
		KeyTooLong = 15,
		NameTooLong = 16,
		KeyInUse = 17,
		WrongTransformType = 18,
		InvalidTrackedDevice = 19,
		InvalidParameter = 20,
		ThumbnailCantBeDestroyed = 21,
		ArrayTooSmall = 22,
		RequestFailed = 23,
		InvalidTexture = 24,
		UnableToLoadFile = 25,
		KeyboardAlreadyInUse = 26,
		NoNeighbor = 27,
		TooManyMaskPrimitives = 29,
		BadMaskPrimitive = 30,
		TextureAlreadyLocked = 31,
		TextureLockCapacityReached = 32,
		TextureNotLocked = 33,
		TimedOut = 34,
	}
	public enum EVRApplicationType
	{
		VRApplication_Other = 0,
		VRApplication_Scene = 1,
		VRApplication_Overlay = 2,
		VRApplication_Background = 3,
		VRApplication_Utility = 4,
		VRApplication_VRMonitor = 5,
		VRApplication_SteamWatchdog = 6,
		VRApplication_Bootstrapper = 7,
		VRApplication_WebHelper = 8,
		VRApplication_OpenXRInstance = 9,
		VRApplication_OpenXRScene = 10,
		VRApplication_OpenXROverlay = 11,
		VRApplication_Prism = 12,
		VRApplication_RoomView = 13,
		VRApplication_Max = 14,
	}
	public enum EVRFirmwareError
	{
		None = 0,
		Success = 1,
		Fail = 2,
	}
	public enum EVRNotificationError
	{
		OK = 0,
		InvalidNotificationId = 100,
		NotificationQueueFull = 101,
		InvalidOverlayHandle = 102,
		SystemWithUserValueAlreadyExists = 103,
		ServiceUnavailable = 104,
	}
	public enum EVRSkeletalMotionRange
	{
		WithController = 0,
		WithoutController = 1,
	}
	public enum EVRSkeletalTrackingLevel
	{
		VRSkeletalTracking_Estimated = 0,
		VRSkeletalTracking_Partial = 1,
		VRSkeletalTracking_Full = 2,
		Count = 3,
		Max = 2,
	}
	public enum EVRInitError
	{
		None = 0,
		Unknown = 1,
		Init_InstallationNotFound = 100,
		Init_InstallationCorrupt = 101,
		Init_VRClientDLLNotFound = 102,
		Init_FileNotFound = 103,
		Init_FactoryNotFound = 104,
		Init_InterfaceNotFound = 105,
		Init_InvalidInterface = 106,
		Init_UserConfigDirectoryInvalid = 107,
		Init_HmdNotFound = 108,
		Init_NotInitialized = 109,
		Init_PathRegistryNotFound = 110,
		Init_NoConfigPath = 111,
		Init_NoLogPath = 112,
		Init_PathRegistryNotWritable = 113,
		Init_AppInfoInitFailed = 114,
		Init_Retry = 115,
		Init_InitCanceledByUser = 116,
		Init_AnotherAppLaunching = 117,
		Init_SettingsInitFailed = 118,
		Init_ShuttingDown = 119,
		Init_TooManyObjects = 120,
		Init_NoServerForBackgroundApp = 121,
		Init_NotSupportedWithCompositor = 122,
		Init_NotAvailableToUtilityApps = 123,
		Init_Internal = 124,
		Init_HmdDriverIdIsNone = 125,
		Init_HmdNotFoundPresenceFailed = 126,
		Init_VRMonitorNotFound = 127,
		Init_VRMonitorStartupFailed = 128,
		Init_LowPowerWatchdogNotSupported = 129,
		Init_InvalidApplicationType = 130,
		Init_NotAvailableToWatchdogApps = 131,
		Init_WatchdogDisabledInSettings = 132,
		Init_VRDashboardNotFound = 133,
		Init_VRDashboardStartupFailed = 134,
		Init_VRHomeNotFound = 135,
		Init_VRHomeStartupFailed = 136,
		Init_RebootingBusy = 137,
		Init_FirmwareUpdateBusy = 138,
		Init_FirmwareRecoveryBusy = 139,
		Init_USBServiceBusy = 140,
		Init_VRWebHelperStartupFailed = 141,
		Init_TrackerManagerInitFailed = 142,
		Init_AlreadyRunning = 143,
		Init_FailedForVrMonitor = 144,
		Init_PropertyManagerInitFailed = 145,
		Init_WebServerFailed = 146,
		Init_IllegalTypeTransition = 147,
		Init_MismatchedRuntimes = 148,
		Init_InvalidProcessId = 149,
		Init_VRServiceStartupFailed = 150,
		Init_PrismNeedsNewDrivers = 151,
		Init_PrismStartupTimedOut = 152,
		Init_CouldNotStartPrism = 153,
		Init_PrismClientInitFailed = 154,
		Init_PrismClientStartFailed = 155,
		Init_PrismExitedUnexpectedly = 156,
		Init_BadLuid = 157,
		Init_NoServerForAppContainer = 158,
		Init_DuplicateBootstrapper = 159,
		Init_VRDashboardServicePending = 160,
		Init_VRDashboardServiceTimeout = 161,
		Init_VRDashboardServiceStopped = 162,
		Init_VRDashboardAlreadyStarted = 163,
		Init_VRDashboardCopyFailed = 164,
		Init_VRDashboardTokenFailure = 165,
		Init_VRDashboardEnvironmentFailure = 166,
		Init_VRDashboardPathFailure = 167,
		Driver_Failed = 200,
		Driver_Unknown = 201,
		Driver_HmdUnknown = 202,
		Driver_NotLoaded = 203,
		Driver_RuntimeOutOfDate = 204,
		Driver_HmdInUse = 205,
		Driver_NotCalibrated = 206,
		Driver_CalibrationInvalid = 207,
		Driver_HmdDisplayNotFound = 208,
		Driver_TrackedDeviceInterfaceUnknown = 209,
		Driver_HmdDriverIdOutOfBounds = 211,
		Driver_HmdDisplayMirrored = 212,
		Driver_HmdDisplayNotFoundLaptop = 213,
		Driver_PeerDriverNotInstalled = 214,
		Driver_WirelessHmdNotConnected = 215,
		IPC_ServerInitFailed = 300,
		IPC_ConnectFailed = 301,
		IPC_SharedStateInitFailed = 302,
		IPC_CompositorInitFailed = 303,
		IPC_MutexInitFailed = 304,
		IPC_Failed = 305,
		IPC_CompositorConnectFailed = 306,
		IPC_CompositorInvalidConnectResponse = 307,
		IPC_ConnectFailedAfterMultipleAttempts = 308,
		IPC_ConnectFailedAfterTargetExited = 309,
		IPC_NamespaceUnavailable = 310,
		Compositor_Failed = 400,
		Compositor_D3D11HardwareRequired = 401,
		Compositor_FirmwareRequiresUpdate = 402,
		Compositor_OverlayInitFailed = 403,
		Compositor_ScreenshotsInitFailed = 404,
		Compositor_UnableToCreateDevice = 405,
		Compositor_SharedStateIsNull = 406,
		Compositor_NotificationManagerIsNull = 407,
		Compositor_ResourceManagerClientIsNull = 408,
		Compositor_MessageOverlaySharedStateInitFailure = 409,
		Compositor_PropertiesInterfaceIsNull = 410,
		Compositor_CreateFullscreenWindowFailed = 411,
		Compositor_SettingsInterfaceIsNull = 412,
		Compositor_FailedToShowWindow = 413,
		Compositor_DistortInterfaceIsNull = 414,
		Compositor_DisplayFrequencyFailure = 415,
		Compositor_RendererInitializationFailed = 416,
		Compositor_DXGIFactoryInterfaceIsNull = 417,
		Compositor_DXGIFactoryCreateFailed = 418,
		Compositor_DXGIFactoryQueryFailed = 419,
		Compositor_InvalidAdapterDesktop = 420,
		Compositor_InvalidHmdAttachment = 421,
		Compositor_InvalidOutputDesktop = 422,
		Compositor_InvalidDeviceProvided = 423,
		Compositor_D3D11RendererInitializationFailed = 424,
		Compositor_FailedToFindDisplayMode = 425,
		Compositor_FailedToCreateSwapChain = 426,
		Compositor_FailedToGetBackBuffer = 427,
		Compositor_FailedToCreateRenderTarget = 428,
		Compositor_FailedToCreateDXGI2SwapChain = 429,
		Compositor_FailedtoGetDXGI2BackBuffer = 430,
		Compositor_FailedToCreateDXGI2RenderTarget = 431,
		Compositor_FailedToGetDXGIDeviceInterface = 432,
		Compositor_SelectDisplayMode = 433,
		Compositor_FailedToCreateNvAPIRenderTargets = 434,
		Compositor_NvAPISetDisplayMode = 435,
		Compositor_FailedToCreateDirectModeDisplay = 436,
		Compositor_InvalidHmdPropertyContainer = 437,
		Compositor_UpdateDisplayFrequency = 438,
		Compositor_CreateRasterizerState = 439,
		Compositor_CreateWireframeRasterizerState = 440,
		Compositor_CreateSamplerState = 441,
		Compositor_CreateClampToBorderSamplerState = 442,
		Compositor_CreateAnisoSamplerState = 443,
		Compositor_CreateOverlaySamplerState = 444,
		Compositor_CreatePanoramaSamplerState = 445,
		Compositor_CreateFontSamplerState = 446,
		Compositor_CreateNoBlendState = 447,
		Compositor_CreateBlendState = 448,
		Compositor_CreateAlphaBlendState = 449,
		Compositor_CreateBlendStateMaskR = 450,
		Compositor_CreateBlendStateMaskG = 451,
		Compositor_CreateBlendStateMaskB = 452,
		Compositor_CreateDepthStencilState = 453,
		Compositor_CreateDepthStencilStateNoWrite = 454,
		Compositor_CreateDepthStencilStateNoDepth = 455,
		Compositor_CreateFlushTexture = 456,
		Compositor_CreateDistortionSurfaces = 457,
		Compositor_CreateConstantBuffer = 458,
		Compositor_CreateHmdPoseConstantBuffer = 459,
		Compositor_CreateHmdPoseStagingConstantBuffer = 460,
		Compositor_CreateSharedFrameInfoConstantBuffer = 461,
		Compositor_CreateOverlayConstantBuffer = 462,
		Compositor_CreateSceneTextureIndexConstantBuffer = 463,
		Compositor_CreateReadableSceneTextureIndexConstantBuffer = 464,
		Compositor_CreateLayerGraphicsTextureIndexConstantBuffer = 465,
		Compositor_CreateLayerComputeTextureIndexConstantBuffer = 466,
		Compositor_CreateLayerComputeSceneTextureIndexConstantBuffer = 467,
		Compositor_CreateComputeHmdPoseConstantBuffer = 468,
		Compositor_CreateGeomConstantBuffer = 469,
		Compositor_CreatePanelMaskConstantBuffer = 470,
		Compositor_CreatePixelSimUBO = 471,
		Compositor_CreateMSAARenderTextures = 472,
		Compositor_CreateResolveRenderTextures = 473,
		Compositor_CreateComputeResolveRenderTextures = 474,
		Compositor_CreateDriverDirectModeResolveTextures = 475,
		Compositor_OpenDriverDirectModeResolveTextures = 476,
		Compositor_CreateFallbackSyncTexture = 477,
		Compositor_ShareFallbackSyncTexture = 478,
		Compositor_CreateOverlayIndexBuffer = 479,
		Compositor_CreateOverlayVertexBuffer = 480,
		Compositor_CreateTextVertexBuffer = 481,
		Compositor_CreateTextIndexBuffer = 482,
		Compositor_CreateMirrorTextures = 483,
		Compositor_CreateLastFrameRenderTexture = 484,
		Compositor_CreateMirrorOverlay = 485,
		Compositor_FailedToCreateVirtualDisplayBackbuffer = 486,
		Compositor_DisplayModeNotSupported = 487,
		Compositor_CreateOverlayInvalidCall = 488,
		Compositor_CreateOverlayAlreadyInitialized = 489,
		Compositor_FailedToCreateMailbox = 490,
		Compositor_WindowInterfaceIsNull = 491,
		Compositor_SystemLayerCreateInstance = 492,
		Compositor_SystemLayerCreateSession = 493,
		Compositor_CreateInverseDistortUVs = 494,
		Compositor_CreateBackbufferDepth = 495,
		Compositor_CannotDRMLeaseDisplay = 496,
		Compositor_CannotConnectToDisplayServer = 497,
		Compositor_GnomeNoDRMLeasing = 498,
		Compositor_FailedToInitializeEncoder = 499,
		Compositor_CreateBlurTexture = 500,
		VendorSpecific_UnableToConnectToOculusRuntime = 1000,
		VendorSpecific_WindowsNotInDevMode = 1001,
		VendorSpecific_OculusLinkNotEnabled = 1002,
		VendorSpecific_HmdFound_CantOpenDevice = 1101,
		VendorSpecific_HmdFound_UnableToRequestConfigStart = 1102,
		VendorSpecific_HmdFound_NoStoredConfig = 1103,
		VendorSpecific_HmdFound_ConfigTooBig = 1104,
		VendorSpecific_HmdFound_ConfigTooSmall = 1105,
		VendorSpecific_HmdFound_UnableToInitZLib = 1106,
		VendorSpecific_HmdFound_CantReadFirmwareVersion = 1107,
		VendorSpecific_HmdFound_UnableToSendUserDataStart = 1108,
		VendorSpecific_HmdFound_UnableToGetUserDataStart = 1109,
		VendorSpecific_HmdFound_UnableToGetUserDataNext = 1110,
		VendorSpecific_HmdFound_UserDataAddressRange = 1111,
		VendorSpecific_HmdFound_UserDataError = 1112,
		VendorSpecific_HmdFound_ConfigFailedSanityCheck = 1113,
		VendorSpecific_OculusRuntimeBadInstall = 1114,
		VendorSpecific_HmdFound_UnexpectedConfiguration_1 = 1115,
		Steam_SteamInstallationNotFound = 2000,
		LastError = 2001,
	}
	public enum EVRScreenshotType
	{
		None = 0,
		Mono = 1,
		Stereo = 2,
		Cubemap = 3,
		MonoPanorama = 4,
		StereoPanorama = 5,
	}
	public enum EVRScreenshotPropertyFilenames
	{
		Preview = 0,
		VR = 1,
	}
	public enum EVRTrackedCameraError
	{
		None = 0,
		OperationFailed = 100,
		InvalidHandle = 101,
		InvalidFrameHeaderVersion = 102,
		OutOfHandles = 103,
		IPCFailure = 104,
		NotSupportedForThisDevice = 105,
		SharedMemoryFailure = 106,
		FrameBufferingFailure = 107,
		StreamSetupFailure = 108,
		InvalidGLTextureId = 109,
		InvalidSharedTextureHandle = 110,
		FailedToGetGLTextureId = 111,
		SharedTextureFailure = 112,
		NoFrameAvailable = 113,
		InvalidArgument = 114,
		InvalidFrameBufferSize = 115,
	}
	public enum EVRTrackedCameraFrameLayout
	{
		Mono = 1,
		Stereo = 2,
		VerticalLayout = 16,
		HorizontalLayout = 32,
	}
	public enum EVRTrackedCameraFrameType
	{
		Distorted = 0,
		Undistorted = 1,
		MaximumUndistorted = 2,
		MAX_CAMERA_FRAME_TYPES = 3,
	}
	public enum EVRDistortionFunctionType
	{
		None = 0,
		FTheta = 1,
		Extended_FTheta = 2,
		MAX_DISTORTION_FUNCTION_TYPES = 3,
	}
	public enum EVSync
	{
		None = 0,
		WaitRender = 1,
		NoWaitRender = 2,
	}
	public enum EVRMuraCorrectionMode
	{
		Default = 0,
		NoCorrection = 1,
	}
	public enum Imu_OffScaleFlags
	{
		OffScale_AccelX = 1,
		OffScale_AccelY = 2,
		OffScale_AccelZ = 4,
		OffScale_GyroX = 8,
		OffScale_GyroY = 16,
		OffScale_GyroZ = 32,
	}
	public enum EVRApplicationError
	{
		None = 0,
		AppKeyAlreadyExists = 100,
		NoManifest = 101,
		NoApplication = 102,
		InvalidIndex = 103,
		UnknownApplication = 104,
		IPCFailed = 105,
		ApplicationAlreadyRunning = 106,
		InvalidManifest = 107,
		InvalidApplication = 108,
		LaunchFailed = 109,
		ApplicationAlreadyStarting = 110,
		LaunchInProgress = 111,
		OldApplicationQuitting = 112,
		TransitionAborted = 113,
		IsTemplate = 114,
		SteamVRIsExiting = 115,
		BufferTooSmall = 200,
		PropertyNotSet = 201,
		UnknownProperty = 202,
		InvalidParameter = 203,
		NotImplemented = 300,
	}
	public enum EVRApplicationProperty
	{
		Name_String = 0,
		LaunchType_String = 11,
		WorkingDirectory_String = 12,
		BinaryPath_String = 13,
		Arguments_String = 14,
		URL_String = 15,
		Description_String = 50,
		NewsURL_String = 51,
		ImagePath_String = 52,
		Source_String = 53,
		ActionManifestURL_String = 54,
		IsDashboardOverlay_Bool = 60,
		IsTemplate_Bool = 61,
		IsInstanced_Bool = 62,
		IsInternal_Bool = 63,
		WantsCompositorPauseInStandby_Bool = 64,
		IsHidden_Bool = 65,
		LastLaunchTime_Uint64 = 70,
	}
	public enum EVRSceneApplicationState
	{
		None = 0,
		Starting = 1,
		Quitting = 2,
		Running = 3,
		Waiting = 4,
	}
	public enum ChaperoneCalibrationState
	{
		OK = 1,
		Warning = 100,
		Warning_BaseStationMayHaveMoved = 101,
		Warning_BaseStationRemoved = 102,
		Warning_SeatedBoundsInvalid = 103,
		Error = 200,
		Error_BaseStationUninitialized = 201,
		Error_BaseStationConflict = 202,
		Error_PlayAreaInvalid = 203,
		Error_CollisionBoundsInvalid = 204,
	}
	public enum EChaperoneConfigFile
	{
		Live = 1,
		Temp = 2,
	}
	public enum EChaperoneImportFlags
	{
		EChaperoneImport_BoundsOnly = 1,
	}
	public enum EVRCompositorError
	{
		None = 0,
		RequestFailed = 1,
		IncompatibleVersion = 100,
		DoNotHaveFocus = 101,
		InvalidTexture = 102,
		IsNotSceneApplication = 103,
		TextureIsOnWrongDevice = 104,
		TextureUsesUnsupportedFormat = 105,
		SharedTexturesNotSupported = 106,
		IndexOutOfRange = 107,
		AlreadySubmitted = 108,
		InvalidBounds = 109,
		AlreadySet = 110,
	}
	public enum EVRCompositorTimingMode
	{
		Implicit = 0,
		Explicit_RuntimePerformsPostPresentHandoff = 1,
		Explicit_ApplicationPerformsPostPresentHandoff = 2,
	}
	public enum VROverlayInputMethod
	{
		None = 0,
		Mouse = 1,
	}
	public enum VROverlayTransformType
	{
		VROverlayTransform_Invalid = -1,
		VROverlayTransform_Absolute = 0,
		VROverlayTransform_TrackedDeviceRelative = 1,
		VROverlayTransform_TrackedComponent = 3,
		VROverlayTransform_Cursor = 4,
		VROverlayTransform_DashboardTab = 5,
		VROverlayTransform_DashboardThumb = 6,
		VROverlayTransform_Mountable = 7,
		VROverlayTransform_Projection = 8,
		VROverlayTransform_Subview = 9,
	}
	public enum VROverlayFlags
	{
		NoDashboardTab = 8,
		SendVRDiscreteScrollEvents = 64,
		SendVRTouchpadEvents = 128,
		ShowTouchPadScrollWheel = 256,
		TransferOwnershipToInternalProcess = 512,
		SideBySide_Parallel = 1024,
		SideBySide_Crossed = 2048,
		Panorama = 4096,
		StereoPanorama = 8192,
		SortWithNonSceneOverlays = 16384,
		VisibleInDashboard = 32768,
		MakeOverlaysInteractiveIfVisible = 65536,
		SendVRSmoothScrollEvents = 131072,
		ProtectedContent = 262144,
		HideLaserIntersection = 524288,
		WantsModalBehavior = 1048576,
		IsPremultiplied = 2097152,
		IgnoreTextureAlpha = 4194304,
		EnableControlBar = 8388608,
		EnableControlBarKeyboard = 16777216,
		EnableControlBarClose = 33554432,
		Reserved = 67108864,
		EnableClickStabilization = 134217728,
		MultiCursor = 268435456,
	}
	public enum VRMessageOverlayResponse
	{
		ButtonPress_0 = 0,
		ButtonPress_1 = 1,
		ButtonPress_2 = 2,
		ButtonPress_3 = 3,
		CouldntFindSystemOverlay = 4,
		CouldntFindOrCreateClientOverlay = 5,
		ApplicationQuit = 6,
	}
	public enum EGamepadTextInputMode
	{
		k_EGamepadTextInputModeNormal = 0,
		k_EGamepadTextInputModePassword = 1,
		k_EGamepadTextInputModeSubmit = 2,
	}
	public enum EGamepadTextInputLineMode
	{
		k_EGamepadTextInputLineModeSingleLine = 0,
		k_EGamepadTextInputLineModeMultipleLines = 1,
	}
	public enum EVROverlayIntersectionMaskPrimitiveType
	{
		OverlayIntersectionPrimitiveType_Rectangle = 0,
		OverlayIntersectionPrimitiveType_Circle = 1,
	}
	public enum EKeyboardFlags
	{
		KeyboardFlag_Minimal = 1,
		KeyboardFlag_Modal = 2,
		KeyboardFlag_ShowArrowKeys = 4,
		KeyboardFlag_HideDoneKey = 8,
	}
	public enum EDeviceType
	{
		Invalid = -1,
		DirectX11 = 0,
		Vulkan = 1,
	}
	public enum HeadsetViewMode_t
	{
		HeadsetViewMode_Left = 0,
		HeadsetViewMode_Right = 1,
		HeadsetViewMode_Both = 2,
	}
	public enum EVRRenderModelError
	{
		None = 0,
		Loading = 100,
		NotSupported = 200,
		InvalidArg = 300,
		InvalidModel = 301,
		NoShapes = 302,
		MultipleShapes = 303,
		TooManyVertices = 304,
		MultipleTextures = 305,
		BufferTooSmall = 306,
		NotEnoughNormals = 307,
		NotEnoughTexCoords = 308,
		InvalidTexture = 400,
	}
	public enum EVRRenderModelTextureFormat
	{
		RGBA8_SRGB = 0,
		BC2 = 1,
		BC4 = 2,
		BC7 = 3,
		BC7_SRGB = 4,
		RGBA16_FLOAT = 5,
	}
	public enum EVRNotificationType
	{
		Transient = 0,
		Persistent = 1,
		Transient_SystemWithUserValue = 2,
	}
	public enum EVRNotificationStyle
	{
		None = 0,
		Application = 100,
		Contact_Disabled = 200,
		Contact_Enabled = 201,
		Contact_Active = 202,
	}
	public enum EVRSettingsError
	{
		None = 0,
		IPCFailed = 1,
		WriteFailed = 2,
		ReadFailed = 3,
		JsonParseFailed = 4,
		UnsetSettingHasNoDefault = 5,
		AccessDenied = 6,
	}
	public enum EVRScreenshotError
	{
		None = 0,
		RequestFailed = 1,
		IncompatibleVersion = 100,
		NotFound = 101,
		BufferTooSmall = 102,
		ScreenshotAlreadyInProgress = 108,
	}
	public enum EVRSkeletalTransformSpace
	{
		Model = 0,
		Parent = 1,
	}
	public enum EVRSkeletalReferencePose
	{
		BindPose = 0,
		OpenHand = 1,
		Fist = 2,
		GripLimit = 3,
	}
	public enum EVRFinger
	{
		Thumb = 0,
		Index = 1,
		Middle = 2,
		Ring = 3,
		Pinky = 4,
		Count = 5,
	}
	public enum EVRFingerSplay
	{
		Thumb_Index = 0,
		Index_Middle = 1,
		Middle_Ring = 2,
		Ring_Pinky = 3,
		Count = 4,
	}
	public enum EVRSummaryType
	{
		FromAnimation = 0,
		FromDevice = 1,
	}
	public enum EVRInputFilterCancelType
	{
		VRInputFilterCancel_Timers = 0,
		VRInputFilterCancel_Momentum = 1,
	}
	public enum EVRInputStringBits
	{
		VRInputString_Hand = 1,
		VRInputString_ControllerType = 2,
		VRInputString_InputSource = 4,
		VRInputString_All = -1,
	}
	public enum EIOBufferError
	{
		IOBuffer_Success = 0,
		IOBuffer_OperationFailed = 100,
		IOBuffer_InvalidHandle = 101,
		IOBuffer_InvalidArgument = 102,
		IOBuffer_PathExists = 103,
		IOBuffer_PathDoesNotExist = 104,
		IOBuffer_Permission = 105,
	}
	public enum EIOBufferMode
	{
		Read = 1,
		Write = 2,
		Create = 512,
	}
	public enum EVRDebugError
	{
		Success = 0,
		BadParameter = 1,
	}
	public enum EPropertyWriteType
	{
		PropertyWrite_Set = 0,
		PropertyWrite_Erase = 1,
		PropertyWrite_SetError = 2,
	}
	public enum EBlockQueueError
	{
		None = 0,
		QueueAlreadyExists = 1,
		QueueNotFound = 2,
		BlockNotAvailable = 3,
		InvalidHandle = 4,
		InvalidParam = 5,
		ParamMismatch = 6,
		InternalError = 7,
		AlreadyInitialized = 8,
		OperationIsServerOnly = 9,
		TooManyConnections = 10,
	}
	public enum EBlockQueueReadType
	{
		BlockQueueRead_Latest = 0,
		BlockQueueRead_New = 1,
		BlockQueueRead_Next = 2,
	}
	public enum EBlockQueueCreationFlag
	{
		BlockQueueFlag_OwnerIsReader = 1,
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct VREvent_Data_t
	{
		[FieldOffset(0)] public VREvent_Reserved_t reserved;
		[FieldOffset(0)] public VREvent_Controller_t controller;
		[FieldOffset(0)] public VREvent_Mouse_t mouse;
		[FieldOffset(0)] public VREvent_Scroll_t scroll;
		[FieldOffset(0)] public VREvent_Process_t process;
		[FieldOffset(0)] public VREvent_Notification_t notification;
		[FieldOffset(0)] public VREvent_Overlay_t overlay;
		[FieldOffset(0)] public VREvent_Status_t status;
		[FieldOffset(0)] public VREvent_Ipd_t ipd;
		[FieldOffset(0)] public VREvent_Chaperone_t chaperone;
		[FieldOffset(0)] public VREvent_PerformanceTest_t performanceTest;
		[FieldOffset(0)] public VREvent_TouchPadMove_t touchPadMove;
		[FieldOffset(0)] public VREvent_SeatedZeroPoseReset_t seatedZeroPoseReset;
		[FieldOffset(0)] public VREvent_Screenshot_t screenshot;
		[FieldOffset(0)] public VREvent_ScreenshotProgress_t screenshotProgress;
		[FieldOffset(0)] public VREvent_ApplicationLaunch_t applicationLaunch;
		[FieldOffset(0)] public VREvent_EditingCameraSurface_t cameraSurface;
		[FieldOffset(0)] public VREvent_MessageOverlay_t messageOverlay;
		[FieldOffset(0)] public VREvent_Property_t property;
		[FieldOffset(0)] public VREvent_HapticVibration_t hapticVibration;
		[FieldOffset(0)] public VREvent_WebConsole_t webConsole;
		[FieldOffset(0)] public VREvent_InputBindingLoad_t inputBinding;
		[FieldOffset(0)] public VREvent_SpatialAnchor_t spatialAnchor;
		[FieldOffset(0)] public VREvent_InputActionManifestLoad_t actionManifest;
		[FieldOffset(0)] public VREvent_ProgressUpdate_t progressUpdate;
		[FieldOffset(0)] public VREvent_ShowUI_t showUi;
		[FieldOffset(0)] public VREvent_ShowDevTools_t showDevTools;
		[FieldOffset(0)] public VREvent_HDCPError_t hdcpError;
		[FieldOffset(0)] public VREvent_AudioVolumeControl_t audioVolumeControl;
		[FieldOffset(0)] public VREvent_AudioMuteControl_t audioMuteControl;
		[FieldOffset(0)] public VREvent_Keyboard_t keyboard; // This has to be at the end due to a mono bug
	}


	[StructLayout(LayoutKind.Explicit)]
	public struct VROverlayIntersectionMaskPrimitive_Data_t
	{
		[FieldOffset(0)] public IntersectionMaskRectangle_t m_Rectangle;
		[FieldOffset(0)] public IntersectionMaskCircle_t m_Circle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct HmdMatrix34_t
	{
		public float m0; //float[3][4]
		public float m1;
		public float m2;
		public float m3;
		public float m4;
		public float m5;
		public float m6;
		public float m7;
		public float m8;
		public float m9;
		public float m10;
		public float m11;
#if UNITY_5_3_OR_NEWER

	public Vector3 GetPosition()
	{
		return new Vector3(m3, m7, -m11);
	}

	public bool IsRotationValid()
	{
		return ((m2 != 0 || m6 != 0 || m10 != 0) && (m1 != 0 || m5 != 0 || m9 != 0));
	}

	public Quaternion GetRotation()
	{
		if (IsRotationValid())
		{
			float w = Mathf.Sqrt(Mathf.Max(0, 1 + m0 + m5 + m10)) / 2;
			float x = Mathf.Sqrt(Mathf.Max(0, 1 + m0 - m5 - m10)) / 2;
			float y = Mathf.Sqrt(Mathf.Max(0, 1 - m0 + m5 - m10)) / 2;
			float z = Mathf.Sqrt(Mathf.Max(0, 1 - m0 - m5 + m10)) / 2;

			_copysign(ref x, -m9 - -m6);
			_copysign(ref y, -m2 - -m8);
			_copysign(ref z, m4 - m1);

			return new Quaternion(x, y, z, w);
		}
		return Quaternion.identity;
	}

	private static void _copysign(ref float sizeval, float signval)
	{
		if (signval > 0 != sizeval > 0)
			sizeval = -sizeval;
	}
#endif
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HmdMatrix33_t
	{
		public float m0; //float[3][3]
		public float m1;
		public float m2;
		public float m3;
		public float m4;
		public float m5;
		public float m6;
		public float m7;
		public float m8;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HmdMatrix44_t
	{
		public float m0; //float[4][4]
		public float m1;
		public float m2;
		public float m3;
		public float m4;
		public float m5;
		public float m6;
		public float m7;
		public float m8;
		public float m9;
		public float m10;
		public float m11;
		public float m12;
		public float m13;
		public float m14;
		public float m15;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HmdVector3_t
	{
		public float v0; //float[3]
		public float v1;
		public float v2;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HmdVector4_t
	{
		public float v0; //float[4]
		public float v1;
		public float v2;
		public float v3;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HmdVector3d_t
	{
		public double v0; //double[3]
		public double v1;
		public double v2;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HmdVector2_t
	{
		public float v0; //float[2]
		public float v1;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HmdQuaternion_t
	{
		public double w;
		public double x;
		public double y;
		public double z;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HmdQuaternionf_t
	{
		public float w;
		public float x;
		public float y;
		public float z;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HmdColor_t
	{
		public float r;
		public float g;
		public float b;
		public float a;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HmdQuad_t
	{
		public HmdVector3_t vCorners0; //HmdVector3_t[4]
		public HmdVector3_t vCorners1;
		public HmdVector3_t vCorners2;
		public HmdVector3_t vCorners3;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HmdRect2_t
	{
		public HmdVector2_t vTopLeft;
		public HmdVector2_t vBottomRight;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRBoneTransform_t
	{
		public HmdVector4_t position;
		public HmdQuaternionf_t orientation;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct DistortionCoordinates_t
	{
		public float rfRed0; //float[2]
		public float rfRed1;
		public float rfGreen0; //float[2]
		public float rfGreen1;
		public float rfBlue0; //float[2]
		public float rfBlue1;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct Texture_t
	{
		public IntPtr handle; // void *
		public ETextureType eType;
		public EColorSpace eColorSpace;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRTextureBounds_t
	{
		public float uMin;
		public float vMin;
		public float uMax;
		public float vMax;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRTextureWithPose_t
	{
		public IntPtr handle; // void *
		public ETextureType eType;
		public EColorSpace eColorSpace;
		public HmdMatrix34_t mDeviceToAbsoluteTracking;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRTextureDepthInfo_t
	{
		public IntPtr handle; // void *
		public HmdMatrix44_t mProjection;
		public HmdVector2_t vRange;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRTextureWithDepth_t
	{
		public IntPtr handle; // void *
		public ETextureType eType;
		public EColorSpace eColorSpace;
		public VRTextureDepthInfo_t depth;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRTextureWithPoseAndDepth_t
	{
		public IntPtr handle; // void *
		public ETextureType eType;
		public EColorSpace eColorSpace;
		public HmdMatrix34_t mDeviceToAbsoluteTracking;
		public VRTextureDepthInfo_t depth;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct DmabufPlane_t
	{
		public uint unOffset;
		public uint unStride;
		public int nFd;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct DmabufAttributes_t
	{
		public IntPtr pNext; // void *
		public uint unWidth;
		public uint unHeight;
		public uint unDepth;
		public uint unMipLevels;
		public uint unArrayLayers;
		public uint unSampleCount;
		public uint unFormat;
		public ulong ulModifier;
		public uint unPlaneCount;
		public DmabufPlane_t plane0; //DmabufPlane_t[4]
		public DmabufPlane_t plane1;
		public DmabufPlane_t plane2;
		public DmabufPlane_t plane3;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct TrackedDevicePose_t
	{
		public HmdMatrix34_t mDeviceToAbsoluteTracking;
		public HmdVector3_t vVelocity;
		public HmdVector3_t vAngularVelocity;
		public ETrackingResult eTrackingResult;
		[MarshalAs(UnmanagedType.I1)]
		public bool bPoseIsValid;
		[MarshalAs(UnmanagedType.I1)]
		public bool bDeviceIsConnected;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRVulkanTextureData_t
	{
		public ulong m_nImage;
		public IntPtr m_pDevice; // struct VkDevice_T *
		public IntPtr m_pPhysicalDevice; // struct VkPhysicalDevice_T *
		public IntPtr m_pInstance; // struct VkInstance_T *
		public IntPtr m_pQueue; // struct VkQueue_T *
		public uint m_nQueueFamilyIndex;
		public uint m_nWidth;
		public uint m_nHeight;
		public uint m_nFormat;
		public uint m_nSampleCount;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRVulkanTextureArrayData_t
	{
		public uint m_unArrayIndex;
		public uint m_unArraySize;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct D3D12TextureData_t
	{
		public IntPtr m_pResource; // struct ID3D12Resource *
		public IntPtr m_pCommandQueue; // struct ID3D12CommandQueue *
		public uint m_nNodeMask;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Controller_t
	{
		public uint button;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Mouse_t
	{
		public float x;
		public float y;
		public uint button;
		public uint cursorIndex;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Scroll_t
	{
		public float xdelta;
		public float ydelta;
		public uint unused;
		public float viewportscale;
		public uint cursorIndex;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_TouchPadMove_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bFingerDown;
		public float flSecondsFingerDown;
		public float fValueXFirst;
		public float fValueYFirst;
		public float fValueXRaw;
		public float fValueYRaw;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Notification_t
	{
		public ulong ulUserValue;
		public uint notificationId;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Process_t
	{
		public uint pid;
		public uint oldPid;
		[MarshalAs(UnmanagedType.I1)]
		public bool bForced;
		[MarshalAs(UnmanagedType.I1)]
		public bool bConnectionLost;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Overlay_t
	{
		public ulong overlayHandle;
		public ulong devicePath;
		public ulong memoryBlockId;
		public uint cursorIndex;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Status_t
	{
		public uint statusState;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Keyboard_t
	{
		public byte cNewInput0, cNewInput1, cNewInput2, cNewInput3, cNewInput4, cNewInput5, cNewInput6, cNewInput7;
		public string cNewInput
		{
			get
			{
				return new string(new char[] {
				(char)cNewInput0,
				(char)cNewInput1,
				(char)cNewInput2,
				(char)cNewInput3,
				(char)cNewInput4,
				(char)cNewInput5,
				(char)cNewInput6,
				(char)cNewInput7
			}).TrimEnd('\0');
			}
		}
		public ulong uUserValue;
		public ulong overlayHandle;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Ipd_t
	{
		public float ipdMeters;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Chaperone_t
	{
		public ulong m_nPreviousUniverse;
		public ulong m_nCurrentUniverse;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Reserved_t
	{
		public ulong reserved0;
		public ulong reserved1;
		public ulong reserved2;
		public ulong reserved3;
		public ulong reserved4;
		public ulong reserved5;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_PerformanceTest_t
	{
		public uint m_nFidelityLevel;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_SeatedZeroPoseReset_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bResetBySystemMenu;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Screenshot_t
	{
		public uint handle;
		public uint type;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_ScreenshotProgress_t
	{
		public float progress;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_ApplicationLaunch_t
	{
		public uint pid;
		public uint unArgsHandle;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_EditingCameraSurface_t
	{
		public ulong overlayHandle;
		public uint nVisualMode;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_MessageOverlay_t
	{
		public uint unVRMessageOverlayResponse;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_Property_t
	{
		public ulong container;
		public ETrackedDeviceProperty prop;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_HapticVibration_t
	{
		public ulong containerHandle;
		public ulong componentHandle;
		public float fDurationSeconds;
		public float fFrequency;
		public float fAmplitude;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_WebConsole_t
	{
		public ulong webConsoleHandle;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_InputBindingLoad_t
	{
		public ulong ulAppContainer;
		public ulong pathMessage;
		public ulong pathUrl;
		public ulong pathControllerType;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_InputActionManifestLoad_t
	{
		public ulong pathAppKey;
		public ulong pathMessage;
		public ulong pathMessageParam;
		public ulong pathManifestPath;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_SpatialAnchor_t
	{
		public uint unHandle;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_ProgressUpdate_t
	{
		public ulong ulApplicationPropertyContainer;
		public ulong pathDevice;
		public ulong pathInputSource;
		public ulong pathProgressAction;
		public ulong pathIcon;
		public float fProgress;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_ShowUI_t
	{
		public EShowUIType eType;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_ShowDevTools_t
	{
		public int nBrowserIdentifier;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_HDCPError_t
	{
		public EHDCPError eCode;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_AudioVolumeControl_t
	{
		public float fVolumeLevel;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_AudioMuteControl_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bMute;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VREvent_t
	{
		public uint eventType;
		public uint trackedDeviceIndex;
		public float eventAgeSeconds;
		public VREvent_Data_t data;
	}
	// This structure is for backwards binary compatibility on Linux and OSX only
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct VREvent_t_Packed
	{
		public uint eventType;
		public uint trackedDeviceIndex;
		public float eventAgeSeconds;
		public VREvent_Data_t data;
		public VREvent_t_Packed(VREvent_t unpacked)
		{
			this.eventType = unpacked.eventType;
			this.trackedDeviceIndex = unpacked.trackedDeviceIndex;
			this.eventAgeSeconds = unpacked.eventAgeSeconds;
			this.data = unpacked.data;
		}
		public void Unpack(ref VREvent_t unpacked)
		{
			unpacked.eventType = this.eventType;
			unpacked.trackedDeviceIndex = this.trackedDeviceIndex;
			unpacked.eventAgeSeconds = this.eventAgeSeconds;
			unpacked.data = this.data;
		}
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct RenderModel_ComponentState_t
	{
		public HmdMatrix34_t mTrackingToComponentRenderModel;
		public HmdMatrix34_t mTrackingToComponentLocal;
		public uint uProperties;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct HiddenAreaMesh_t
	{
		public IntPtr pVertexData; // const struct vr::HmdVector2_t *
		public uint unTriangleCount;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRControllerAxis_t
	{
		public float x;
		public float y;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRControllerState_t
	{
		public uint unPacketNum;
		public ulong ulButtonPressed;
		public ulong ulButtonTouched;
		public VRControllerAxis_t rAxis0; //VRControllerAxis_t[5]
		public VRControllerAxis_t rAxis1;
		public VRControllerAxis_t rAxis2;
		public VRControllerAxis_t rAxis3;
		public VRControllerAxis_t rAxis4;
	}
	// This structure is for backwards binary compatibility on Linux and OSX only
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct VRControllerState_t_Packed
	{
		public uint unPacketNum;
		public ulong ulButtonPressed;
		public ulong ulButtonTouched;
		public VRControllerAxis_t rAxis0; //VRControllerAxis_t[5]
		public VRControllerAxis_t rAxis1;
		public VRControllerAxis_t rAxis2;
		public VRControllerAxis_t rAxis3;
		public VRControllerAxis_t rAxis4;
		public VRControllerState_t_Packed(VRControllerState_t unpacked)
		{
			this.unPacketNum = unpacked.unPacketNum;
			this.ulButtonPressed = unpacked.ulButtonPressed;
			this.ulButtonTouched = unpacked.ulButtonTouched;
			this.rAxis0 = unpacked.rAxis0;
			this.rAxis1 = unpacked.rAxis1;
			this.rAxis2 = unpacked.rAxis2;
			this.rAxis3 = unpacked.rAxis3;
			this.rAxis4 = unpacked.rAxis4;
		}
		public void Unpack(ref VRControllerState_t unpacked)
		{
			unpacked.unPacketNum = this.unPacketNum;
			unpacked.ulButtonPressed = this.ulButtonPressed;
			unpacked.ulButtonTouched = this.ulButtonTouched;
			unpacked.rAxis0 = this.rAxis0;
			unpacked.rAxis1 = this.rAxis1;
			unpacked.rAxis2 = this.rAxis2;
			unpacked.rAxis3 = this.rAxis3;
			unpacked.rAxis4 = this.rAxis4;
		}
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct CameraVideoStreamFrameHeader_t
	{
		public EVRTrackedCameraFrameType eFrameType;
		public uint nWidth;
		public uint nHeight;
		public uint nBytesPerPixel;
		public uint nFrameSequence;
		public TrackedDevicePose_t trackedDevicePose;
		public ulong ulFrameExposureTime;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct Compositor_FrameTiming
	{
		public uint m_nSize;
		public uint m_nFrameIndex;
		public uint m_nNumFramePresents;
		public uint m_nNumMisPresented;
		public uint m_nNumDroppedFrames;
		public uint m_nReprojectionFlags;
		public double m_flSystemTimeInSeconds;
		public float m_flPreSubmitGpuMs;
		public float m_flPostSubmitGpuMs;
		public float m_flTotalRenderGpuMs;
		public float m_flCompositorRenderGpuMs;
		public float m_flCompositorRenderCpuMs;
		public float m_flCompositorIdleCpuMs;
		public float m_flClientFrameIntervalMs;
		public float m_flPresentCallCpuMs;
		public float m_flWaitForPresentCpuMs;
		public float m_flSubmitFrameMs;
		public float m_flWaitGetPosesCalledMs;
		public float m_flNewPosesReadyMs;
		public float m_flNewFrameReadyMs;
		public float m_flCompositorUpdateStartMs;
		public float m_flCompositorUpdateEndMs;
		public float m_flCompositorRenderStartMs;
		public TrackedDevicePose_t m_HmdPose;
		public uint m_nNumVSyncsReadyForUse;
		public uint m_nNumVSyncsToFirstView;
		public float m_flTransferLatencyMs;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct Compositor_BenchmarkResults
	{
		public float m_flMegaPixelsPerSecond;
		public float m_flHmdRecommendedMegaPixelsPerSecond;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct DriverDirectMode_FrameTiming
	{
		public uint m_nSize;
		public uint m_nNumFramePresents;
		public uint m_nNumMisPresented;
		public uint m_nNumDroppedFrames;
		public uint m_nReprojectionFlags;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct ImuSample_t
	{
		public double fSampleTime;
		public HmdVector3d_t vAccel;
		public HmdVector3d_t vGyro;
		public uint unOffScaleFlags;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct AppOverrideKeys_t
	{
		public IntPtr pchKey; // const char *
		public IntPtr pchValue; // const char *
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct Compositor_CumulativeStats
	{
		public uint m_nPid;
		public uint m_nNumFramePresents;
		public uint m_nNumDroppedFrames;
		public uint m_nNumReprojectedFrames;
		public uint m_nNumFramePresentsOnStartup;
		public uint m_nNumDroppedFramesOnStartup;
		public uint m_nNumReprojectedFramesOnStartup;
		public uint m_nNumLoading;
		public uint m_nNumFramePresentsLoading;
		public uint m_nNumDroppedFramesLoading;
		public uint m_nNumReprojectedFramesLoading;
		public uint m_nNumTimedOut;
		public uint m_nNumFramePresentsTimedOut;
		public uint m_nNumDroppedFramesTimedOut;
		public uint m_nNumReprojectedFramesTimedOut;
		public uint m_nNumFrameSubmits;
		public double m_flSumCompositorCPUTimeMS;
		public double m_flSumCompositorGPUTimeMS;
		public double m_flSumTargetFrameTimes;
		public double m_flSumApplicationCPUTimeMS;
		public double m_flSumApplicationGPUTimeMS;
		public uint m_nNumFramesWithDepth;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct Compositor_StageRenderSettings
	{
		public HmdColor_t m_PrimaryColor;
		public HmdColor_t m_SecondaryColor;
		public float m_flVignetteInnerRadius;
		public float m_flVignetteOuterRadius;
		public float m_flFresnelStrength;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bBackfaceCulling;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bGreyscale;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bWireframe;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VROverlayIntersectionParams_t
	{
		public HmdVector3_t vSource;
		public HmdVector3_t vDirection;
		public ETrackingUniverseOrigin eOrigin;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VROverlayIntersectionResults_t
	{
		public HmdVector3_t vPoint;
		public HmdVector3_t vNormal;
		public HmdVector2_t vUVs;
		public float fDistance;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct IntersectionMaskRectangle_t
	{
		public float m_flTopLeftX;
		public float m_flTopLeftY;
		public float m_flWidth;
		public float m_flHeight;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct IntersectionMaskCircle_t
	{
		public float m_flCenterX;
		public float m_flCenterY;
		public float m_flRadius;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VROverlayIntersectionMaskPrimitive_t
	{
		public EVROverlayIntersectionMaskPrimitiveType m_nPrimitiveType;
		public VROverlayIntersectionMaskPrimitive_Data_t m_Primitive;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VROverlayProjection_t
	{
		public float fLeft;
		public float fRight;
		public float fTop;
		public float fBottom;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VROverlayView_t
	{
		public ulong overlayHandle;
		public Texture_t texture;
		public VRTextureBounds_t textureBounds;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRVulkanDevice_t
	{
		public IntPtr m_pInstance; // struct VkInstance_T *
		public IntPtr m_pDevice; // struct VkDevice_T *
		public IntPtr m_pPhysicalDevice; // struct VkPhysicalDevice_T *
		public IntPtr m_pQueue; // struct VkQueue_T *
		public uint m_uQueueFamilyIndex;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRNativeDevice_t
	{
		public IntPtr handle; // void *
		public EDeviceType eType;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct RenderModel_Vertex_t
	{
		public HmdVector3_t vPosition;
		public HmdVector3_t vNormal;
		public float rfTextureCoord0; //float[2]
		public float rfTextureCoord1;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct RenderModel_TextureMap_t
	{
		public ushort unWidth;
		public ushort unHeight;
		public IntPtr rubTextureMapData; // const uint8_t *
		public EVRRenderModelTextureFormat format;
		public ushort unMipLevels;
	}
	// This structure is for backwards binary compatibility on Linux and OSX only
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct RenderModel_TextureMap_t_Packed
	{
		public ushort unWidth;
		public ushort unHeight;
		public IntPtr rubTextureMapData; // const uint8_t *
		public EVRRenderModelTextureFormat format;
		public ushort unMipLevels;
		public RenderModel_TextureMap_t_Packed(RenderModel_TextureMap_t unpacked)
		{
			this.unWidth = unpacked.unWidth;
			this.unHeight = unpacked.unHeight;
			this.rubTextureMapData = unpacked.rubTextureMapData;
			this.format = unpacked.format;
			this.unMipLevels = unpacked.unMipLevels;
		}
		public void Unpack(ref RenderModel_TextureMap_t unpacked)
		{
			unpacked.unWidth = this.unWidth;
			unpacked.unHeight = this.unHeight;
			unpacked.rubTextureMapData = this.rubTextureMapData;
			unpacked.format = this.format;
			unpacked.unMipLevels = this.unMipLevels;
		}
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct RenderModel_t
	{
		public IntPtr rVertexData; // const struct vr::RenderModel_Vertex_t *
		public uint unVertexCount;
		public IntPtr rIndexData; // const uint16_t *
		public uint unTriangleCount;
		public int diffuseTextureId;
	}
	// This structure is for backwards binary compatibility on Linux and OSX only
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct RenderModel_t_Packed
	{
		public IntPtr rVertexData; // const struct vr::RenderModel_Vertex_t *
		public uint unVertexCount;
		public IntPtr rIndexData; // const uint16_t *
		public uint unTriangleCount;
		public int diffuseTextureId;
		public RenderModel_t_Packed(RenderModel_t unpacked)
		{
			this.rVertexData = unpacked.rVertexData;
			this.unVertexCount = unpacked.unVertexCount;
			this.rIndexData = unpacked.rIndexData;
			this.unTriangleCount = unpacked.unTriangleCount;
			this.diffuseTextureId = unpacked.diffuseTextureId;
		}
		public void Unpack(ref RenderModel_t unpacked)
		{
			unpacked.rVertexData = this.rVertexData;
			unpacked.unVertexCount = this.unVertexCount;
			unpacked.rIndexData = this.rIndexData;
			unpacked.unTriangleCount = this.unTriangleCount;
			unpacked.diffuseTextureId = this.diffuseTextureId;
		}
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct RenderModel_ControllerMode_State_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bScrollWheelVisible;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct NotificationBitmap_t
	{
		public IntPtr m_pImageData; // void *
		public int m_nWidth;
		public int m_nHeight;
		public int m_nBytesPerPixel;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct CVRSettingHelper
	{
		public IntPtr m_pSettings; // class vr::IVRSettings *
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct InputAnalogActionData_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bActive;
		public ulong activeOrigin;
		public float x;
		public float y;
		public float z;
		public float deltaX;
		public float deltaY;
		public float deltaZ;
		public float fUpdateTime;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct InputDigitalActionData_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bActive;
		public ulong activeOrigin;
		[MarshalAs(UnmanagedType.I1)]
		public bool bState;
		[MarshalAs(UnmanagedType.I1)]
		public bool bChanged;
		public float fUpdateTime;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct InputPoseActionData_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bActive;
		public ulong activeOrigin;
		public TrackedDevicePose_t pose;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct InputSkeletalActionData_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bActive;
		public ulong activeOrigin;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct InputOriginInfo_t
	{
		public ulong devicePath;
		public uint trackedDeviceIndex;
		public byte rchRenderModelComponentName0, rchRenderModelComponentName1, rchRenderModelComponentName2, rchRenderModelComponentName3, rchRenderModelComponentName4, rchRenderModelComponentName5, rchRenderModelComponentName6, rchRenderModelComponentName7, rchRenderModelComponentName8, rchRenderModelComponentName9, rchRenderModelComponentName10, rchRenderModelComponentName11, rchRenderModelComponentName12, rchRenderModelComponentName13, rchRenderModelComponentName14, rchRenderModelComponentName15, rchRenderModelComponentName16, rchRenderModelComponentName17, rchRenderModelComponentName18, rchRenderModelComponentName19, rchRenderModelComponentName20, rchRenderModelComponentName21, rchRenderModelComponentName22, rchRenderModelComponentName23, rchRenderModelComponentName24, rchRenderModelComponentName25, rchRenderModelComponentName26, rchRenderModelComponentName27, rchRenderModelComponentName28, rchRenderModelComponentName29, rchRenderModelComponentName30, rchRenderModelComponentName31, rchRenderModelComponentName32, rchRenderModelComponentName33, rchRenderModelComponentName34, rchRenderModelComponentName35, rchRenderModelComponentName36, rchRenderModelComponentName37, rchRenderModelComponentName38, rchRenderModelComponentName39, rchRenderModelComponentName40, rchRenderModelComponentName41, rchRenderModelComponentName42, rchRenderModelComponentName43, rchRenderModelComponentName44, rchRenderModelComponentName45, rchRenderModelComponentName46, rchRenderModelComponentName47, rchRenderModelComponentName48, rchRenderModelComponentName49, rchRenderModelComponentName50, rchRenderModelComponentName51, rchRenderModelComponentName52, rchRenderModelComponentName53, rchRenderModelComponentName54, rchRenderModelComponentName55, rchRenderModelComponentName56, rchRenderModelComponentName57, rchRenderModelComponentName58, rchRenderModelComponentName59, rchRenderModelComponentName60, rchRenderModelComponentName61, rchRenderModelComponentName62, rchRenderModelComponentName63, rchRenderModelComponentName64, rchRenderModelComponentName65, rchRenderModelComponentName66, rchRenderModelComponentName67, rchRenderModelComponentName68, rchRenderModelComponentName69, rchRenderModelComponentName70, rchRenderModelComponentName71, rchRenderModelComponentName72, rchRenderModelComponentName73, rchRenderModelComponentName74, rchRenderModelComponentName75, rchRenderModelComponentName76, rchRenderModelComponentName77, rchRenderModelComponentName78, rchRenderModelComponentName79, rchRenderModelComponentName80, rchRenderModelComponentName81, rchRenderModelComponentName82, rchRenderModelComponentName83, rchRenderModelComponentName84, rchRenderModelComponentName85, rchRenderModelComponentName86, rchRenderModelComponentName87, rchRenderModelComponentName88, rchRenderModelComponentName89, rchRenderModelComponentName90, rchRenderModelComponentName91, rchRenderModelComponentName92, rchRenderModelComponentName93, rchRenderModelComponentName94, rchRenderModelComponentName95, rchRenderModelComponentName96, rchRenderModelComponentName97, rchRenderModelComponentName98, rchRenderModelComponentName99, rchRenderModelComponentName100, rchRenderModelComponentName101, rchRenderModelComponentName102, rchRenderModelComponentName103, rchRenderModelComponentName104, rchRenderModelComponentName105, rchRenderModelComponentName106, rchRenderModelComponentName107, rchRenderModelComponentName108, rchRenderModelComponentName109, rchRenderModelComponentName110, rchRenderModelComponentName111, rchRenderModelComponentName112, rchRenderModelComponentName113, rchRenderModelComponentName114, rchRenderModelComponentName115, rchRenderModelComponentName116, rchRenderModelComponentName117, rchRenderModelComponentName118, rchRenderModelComponentName119, rchRenderModelComponentName120, rchRenderModelComponentName121, rchRenderModelComponentName122, rchRenderModelComponentName123, rchRenderModelComponentName124, rchRenderModelComponentName125, rchRenderModelComponentName126, rchRenderModelComponentName127;
		public string rchRenderModelComponentName
		{
			get
			{
				return new string(new char[] {
				(char)rchRenderModelComponentName0,
				(char)rchRenderModelComponentName1,
				(char)rchRenderModelComponentName2,
				(char)rchRenderModelComponentName3,
				(char)rchRenderModelComponentName4,
				(char)rchRenderModelComponentName5,
				(char)rchRenderModelComponentName6,
				(char)rchRenderModelComponentName7,
				(char)rchRenderModelComponentName8,
				(char)rchRenderModelComponentName9,
				(char)rchRenderModelComponentName10,
				(char)rchRenderModelComponentName11,
				(char)rchRenderModelComponentName12,
				(char)rchRenderModelComponentName13,
				(char)rchRenderModelComponentName14,
				(char)rchRenderModelComponentName15,
				(char)rchRenderModelComponentName16,
				(char)rchRenderModelComponentName17,
				(char)rchRenderModelComponentName18,
				(char)rchRenderModelComponentName19,
				(char)rchRenderModelComponentName20,
				(char)rchRenderModelComponentName21,
				(char)rchRenderModelComponentName22,
				(char)rchRenderModelComponentName23,
				(char)rchRenderModelComponentName24,
				(char)rchRenderModelComponentName25,
				(char)rchRenderModelComponentName26,
				(char)rchRenderModelComponentName27,
				(char)rchRenderModelComponentName28,
				(char)rchRenderModelComponentName29,
				(char)rchRenderModelComponentName30,
				(char)rchRenderModelComponentName31,
				(char)rchRenderModelComponentName32,
				(char)rchRenderModelComponentName33,
				(char)rchRenderModelComponentName34,
				(char)rchRenderModelComponentName35,
				(char)rchRenderModelComponentName36,
				(char)rchRenderModelComponentName37,
				(char)rchRenderModelComponentName38,
				(char)rchRenderModelComponentName39,
				(char)rchRenderModelComponentName40,
				(char)rchRenderModelComponentName41,
				(char)rchRenderModelComponentName42,
				(char)rchRenderModelComponentName43,
				(char)rchRenderModelComponentName44,
				(char)rchRenderModelComponentName45,
				(char)rchRenderModelComponentName46,
				(char)rchRenderModelComponentName47,
				(char)rchRenderModelComponentName48,
				(char)rchRenderModelComponentName49,
				(char)rchRenderModelComponentName50,
				(char)rchRenderModelComponentName51,
				(char)rchRenderModelComponentName52,
				(char)rchRenderModelComponentName53,
				(char)rchRenderModelComponentName54,
				(char)rchRenderModelComponentName55,
				(char)rchRenderModelComponentName56,
				(char)rchRenderModelComponentName57,
				(char)rchRenderModelComponentName58,
				(char)rchRenderModelComponentName59,
				(char)rchRenderModelComponentName60,
				(char)rchRenderModelComponentName61,
				(char)rchRenderModelComponentName62,
				(char)rchRenderModelComponentName63,
				(char)rchRenderModelComponentName64,
				(char)rchRenderModelComponentName65,
				(char)rchRenderModelComponentName66,
				(char)rchRenderModelComponentName67,
				(char)rchRenderModelComponentName68,
				(char)rchRenderModelComponentName69,
				(char)rchRenderModelComponentName70,
				(char)rchRenderModelComponentName71,
				(char)rchRenderModelComponentName72,
				(char)rchRenderModelComponentName73,
				(char)rchRenderModelComponentName74,
				(char)rchRenderModelComponentName75,
				(char)rchRenderModelComponentName76,
				(char)rchRenderModelComponentName77,
				(char)rchRenderModelComponentName78,
				(char)rchRenderModelComponentName79,
				(char)rchRenderModelComponentName80,
				(char)rchRenderModelComponentName81,
				(char)rchRenderModelComponentName82,
				(char)rchRenderModelComponentName83,
				(char)rchRenderModelComponentName84,
				(char)rchRenderModelComponentName85,
				(char)rchRenderModelComponentName86,
				(char)rchRenderModelComponentName87,
				(char)rchRenderModelComponentName88,
				(char)rchRenderModelComponentName89,
				(char)rchRenderModelComponentName90,
				(char)rchRenderModelComponentName91,
				(char)rchRenderModelComponentName92,
				(char)rchRenderModelComponentName93,
				(char)rchRenderModelComponentName94,
				(char)rchRenderModelComponentName95,
				(char)rchRenderModelComponentName96,
				(char)rchRenderModelComponentName97,
				(char)rchRenderModelComponentName98,
				(char)rchRenderModelComponentName99,
				(char)rchRenderModelComponentName100,
				(char)rchRenderModelComponentName101,
				(char)rchRenderModelComponentName102,
				(char)rchRenderModelComponentName103,
				(char)rchRenderModelComponentName104,
				(char)rchRenderModelComponentName105,
				(char)rchRenderModelComponentName106,
				(char)rchRenderModelComponentName107,
				(char)rchRenderModelComponentName108,
				(char)rchRenderModelComponentName109,
				(char)rchRenderModelComponentName110,
				(char)rchRenderModelComponentName111,
				(char)rchRenderModelComponentName112,
				(char)rchRenderModelComponentName113,
				(char)rchRenderModelComponentName114,
				(char)rchRenderModelComponentName115,
				(char)rchRenderModelComponentName116,
				(char)rchRenderModelComponentName117,
				(char)rchRenderModelComponentName118,
				(char)rchRenderModelComponentName119,
				(char)rchRenderModelComponentName120,
				(char)rchRenderModelComponentName121,
				(char)rchRenderModelComponentName122,
				(char)rchRenderModelComponentName123,
				(char)rchRenderModelComponentName124,
				(char)rchRenderModelComponentName125,
				(char)rchRenderModelComponentName126,
				(char)rchRenderModelComponentName127
			}).TrimEnd('\0');
			}
		}
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct InputBindingInfo_t
	{
		public byte rchDevicePathName0, rchDevicePathName1, rchDevicePathName2, rchDevicePathName3, rchDevicePathName4, rchDevicePathName5, rchDevicePathName6, rchDevicePathName7, rchDevicePathName8, rchDevicePathName9, rchDevicePathName10, rchDevicePathName11, rchDevicePathName12, rchDevicePathName13, rchDevicePathName14, rchDevicePathName15, rchDevicePathName16, rchDevicePathName17, rchDevicePathName18, rchDevicePathName19, rchDevicePathName20, rchDevicePathName21, rchDevicePathName22, rchDevicePathName23, rchDevicePathName24, rchDevicePathName25, rchDevicePathName26, rchDevicePathName27, rchDevicePathName28, rchDevicePathName29, rchDevicePathName30, rchDevicePathName31, rchDevicePathName32, rchDevicePathName33, rchDevicePathName34, rchDevicePathName35, rchDevicePathName36, rchDevicePathName37, rchDevicePathName38, rchDevicePathName39, rchDevicePathName40, rchDevicePathName41, rchDevicePathName42, rchDevicePathName43, rchDevicePathName44, rchDevicePathName45, rchDevicePathName46, rchDevicePathName47, rchDevicePathName48, rchDevicePathName49, rchDevicePathName50, rchDevicePathName51, rchDevicePathName52, rchDevicePathName53, rchDevicePathName54, rchDevicePathName55, rchDevicePathName56, rchDevicePathName57, rchDevicePathName58, rchDevicePathName59, rchDevicePathName60, rchDevicePathName61, rchDevicePathName62, rchDevicePathName63, rchDevicePathName64, rchDevicePathName65, rchDevicePathName66, rchDevicePathName67, rchDevicePathName68, rchDevicePathName69, rchDevicePathName70, rchDevicePathName71, rchDevicePathName72, rchDevicePathName73, rchDevicePathName74, rchDevicePathName75, rchDevicePathName76, rchDevicePathName77, rchDevicePathName78, rchDevicePathName79, rchDevicePathName80, rchDevicePathName81, rchDevicePathName82, rchDevicePathName83, rchDevicePathName84, rchDevicePathName85, rchDevicePathName86, rchDevicePathName87, rchDevicePathName88, rchDevicePathName89, rchDevicePathName90, rchDevicePathName91, rchDevicePathName92, rchDevicePathName93, rchDevicePathName94, rchDevicePathName95, rchDevicePathName96, rchDevicePathName97, rchDevicePathName98, rchDevicePathName99, rchDevicePathName100, rchDevicePathName101, rchDevicePathName102, rchDevicePathName103, rchDevicePathName104, rchDevicePathName105, rchDevicePathName106, rchDevicePathName107, rchDevicePathName108, rchDevicePathName109, rchDevicePathName110, rchDevicePathName111, rchDevicePathName112, rchDevicePathName113, rchDevicePathName114, rchDevicePathName115, rchDevicePathName116, rchDevicePathName117, rchDevicePathName118, rchDevicePathName119, rchDevicePathName120, rchDevicePathName121, rchDevicePathName122, rchDevicePathName123, rchDevicePathName124, rchDevicePathName125, rchDevicePathName126, rchDevicePathName127;
		public string rchDevicePathName
		{
			get
			{
				return new string(new char[] {
				(char)rchDevicePathName0,
				(char)rchDevicePathName1,
				(char)rchDevicePathName2,
				(char)rchDevicePathName3,
				(char)rchDevicePathName4,
				(char)rchDevicePathName5,
				(char)rchDevicePathName6,
				(char)rchDevicePathName7,
				(char)rchDevicePathName8,
				(char)rchDevicePathName9,
				(char)rchDevicePathName10,
				(char)rchDevicePathName11,
				(char)rchDevicePathName12,
				(char)rchDevicePathName13,
				(char)rchDevicePathName14,
				(char)rchDevicePathName15,
				(char)rchDevicePathName16,
				(char)rchDevicePathName17,
				(char)rchDevicePathName18,
				(char)rchDevicePathName19,
				(char)rchDevicePathName20,
				(char)rchDevicePathName21,
				(char)rchDevicePathName22,
				(char)rchDevicePathName23,
				(char)rchDevicePathName24,
				(char)rchDevicePathName25,
				(char)rchDevicePathName26,
				(char)rchDevicePathName27,
				(char)rchDevicePathName28,
				(char)rchDevicePathName29,
				(char)rchDevicePathName30,
				(char)rchDevicePathName31,
				(char)rchDevicePathName32,
				(char)rchDevicePathName33,
				(char)rchDevicePathName34,
				(char)rchDevicePathName35,
				(char)rchDevicePathName36,
				(char)rchDevicePathName37,
				(char)rchDevicePathName38,
				(char)rchDevicePathName39,
				(char)rchDevicePathName40,
				(char)rchDevicePathName41,
				(char)rchDevicePathName42,
				(char)rchDevicePathName43,
				(char)rchDevicePathName44,
				(char)rchDevicePathName45,
				(char)rchDevicePathName46,
				(char)rchDevicePathName47,
				(char)rchDevicePathName48,
				(char)rchDevicePathName49,
				(char)rchDevicePathName50,
				(char)rchDevicePathName51,
				(char)rchDevicePathName52,
				(char)rchDevicePathName53,
				(char)rchDevicePathName54,
				(char)rchDevicePathName55,
				(char)rchDevicePathName56,
				(char)rchDevicePathName57,
				(char)rchDevicePathName58,
				(char)rchDevicePathName59,
				(char)rchDevicePathName60,
				(char)rchDevicePathName61,
				(char)rchDevicePathName62,
				(char)rchDevicePathName63,
				(char)rchDevicePathName64,
				(char)rchDevicePathName65,
				(char)rchDevicePathName66,
				(char)rchDevicePathName67,
				(char)rchDevicePathName68,
				(char)rchDevicePathName69,
				(char)rchDevicePathName70,
				(char)rchDevicePathName71,
				(char)rchDevicePathName72,
				(char)rchDevicePathName73,
				(char)rchDevicePathName74,
				(char)rchDevicePathName75,
				(char)rchDevicePathName76,
				(char)rchDevicePathName77,
				(char)rchDevicePathName78,
				(char)rchDevicePathName79,
				(char)rchDevicePathName80,
				(char)rchDevicePathName81,
				(char)rchDevicePathName82,
				(char)rchDevicePathName83,
				(char)rchDevicePathName84,
				(char)rchDevicePathName85,
				(char)rchDevicePathName86,
				(char)rchDevicePathName87,
				(char)rchDevicePathName88,
				(char)rchDevicePathName89,
				(char)rchDevicePathName90,
				(char)rchDevicePathName91,
				(char)rchDevicePathName92,
				(char)rchDevicePathName93,
				(char)rchDevicePathName94,
				(char)rchDevicePathName95,
				(char)rchDevicePathName96,
				(char)rchDevicePathName97,
				(char)rchDevicePathName98,
				(char)rchDevicePathName99,
				(char)rchDevicePathName100,
				(char)rchDevicePathName101,
				(char)rchDevicePathName102,
				(char)rchDevicePathName103,
				(char)rchDevicePathName104,
				(char)rchDevicePathName105,
				(char)rchDevicePathName106,
				(char)rchDevicePathName107,
				(char)rchDevicePathName108,
				(char)rchDevicePathName109,
				(char)rchDevicePathName110,
				(char)rchDevicePathName111,
				(char)rchDevicePathName112,
				(char)rchDevicePathName113,
				(char)rchDevicePathName114,
				(char)rchDevicePathName115,
				(char)rchDevicePathName116,
				(char)rchDevicePathName117,
				(char)rchDevicePathName118,
				(char)rchDevicePathName119,
				(char)rchDevicePathName120,
				(char)rchDevicePathName121,
				(char)rchDevicePathName122,
				(char)rchDevicePathName123,
				(char)rchDevicePathName124,
				(char)rchDevicePathName125,
				(char)rchDevicePathName126,
				(char)rchDevicePathName127
			}).TrimEnd('\0');
			}
		}
		public byte rchInputPathName0, rchInputPathName1, rchInputPathName2, rchInputPathName3, rchInputPathName4, rchInputPathName5, rchInputPathName6, rchInputPathName7, rchInputPathName8, rchInputPathName9, rchInputPathName10, rchInputPathName11, rchInputPathName12, rchInputPathName13, rchInputPathName14, rchInputPathName15, rchInputPathName16, rchInputPathName17, rchInputPathName18, rchInputPathName19, rchInputPathName20, rchInputPathName21, rchInputPathName22, rchInputPathName23, rchInputPathName24, rchInputPathName25, rchInputPathName26, rchInputPathName27, rchInputPathName28, rchInputPathName29, rchInputPathName30, rchInputPathName31, rchInputPathName32, rchInputPathName33, rchInputPathName34, rchInputPathName35, rchInputPathName36, rchInputPathName37, rchInputPathName38, rchInputPathName39, rchInputPathName40, rchInputPathName41, rchInputPathName42, rchInputPathName43, rchInputPathName44, rchInputPathName45, rchInputPathName46, rchInputPathName47, rchInputPathName48, rchInputPathName49, rchInputPathName50, rchInputPathName51, rchInputPathName52, rchInputPathName53, rchInputPathName54, rchInputPathName55, rchInputPathName56, rchInputPathName57, rchInputPathName58, rchInputPathName59, rchInputPathName60, rchInputPathName61, rchInputPathName62, rchInputPathName63, rchInputPathName64, rchInputPathName65, rchInputPathName66, rchInputPathName67, rchInputPathName68, rchInputPathName69, rchInputPathName70, rchInputPathName71, rchInputPathName72, rchInputPathName73, rchInputPathName74, rchInputPathName75, rchInputPathName76, rchInputPathName77, rchInputPathName78, rchInputPathName79, rchInputPathName80, rchInputPathName81, rchInputPathName82, rchInputPathName83, rchInputPathName84, rchInputPathName85, rchInputPathName86, rchInputPathName87, rchInputPathName88, rchInputPathName89, rchInputPathName90, rchInputPathName91, rchInputPathName92, rchInputPathName93, rchInputPathName94, rchInputPathName95, rchInputPathName96, rchInputPathName97, rchInputPathName98, rchInputPathName99, rchInputPathName100, rchInputPathName101, rchInputPathName102, rchInputPathName103, rchInputPathName104, rchInputPathName105, rchInputPathName106, rchInputPathName107, rchInputPathName108, rchInputPathName109, rchInputPathName110, rchInputPathName111, rchInputPathName112, rchInputPathName113, rchInputPathName114, rchInputPathName115, rchInputPathName116, rchInputPathName117, rchInputPathName118, rchInputPathName119, rchInputPathName120, rchInputPathName121, rchInputPathName122, rchInputPathName123, rchInputPathName124, rchInputPathName125, rchInputPathName126, rchInputPathName127;
		public string rchInputPathName
		{
			get
			{
				return new string(new char[] {
				(char)rchInputPathName0,
				(char)rchInputPathName1,
				(char)rchInputPathName2,
				(char)rchInputPathName3,
				(char)rchInputPathName4,
				(char)rchInputPathName5,
				(char)rchInputPathName6,
				(char)rchInputPathName7,
				(char)rchInputPathName8,
				(char)rchInputPathName9,
				(char)rchInputPathName10,
				(char)rchInputPathName11,
				(char)rchInputPathName12,
				(char)rchInputPathName13,
				(char)rchInputPathName14,
				(char)rchInputPathName15,
				(char)rchInputPathName16,
				(char)rchInputPathName17,
				(char)rchInputPathName18,
				(char)rchInputPathName19,
				(char)rchInputPathName20,
				(char)rchInputPathName21,
				(char)rchInputPathName22,
				(char)rchInputPathName23,
				(char)rchInputPathName24,
				(char)rchInputPathName25,
				(char)rchInputPathName26,
				(char)rchInputPathName27,
				(char)rchInputPathName28,
				(char)rchInputPathName29,
				(char)rchInputPathName30,
				(char)rchInputPathName31,
				(char)rchInputPathName32,
				(char)rchInputPathName33,
				(char)rchInputPathName34,
				(char)rchInputPathName35,
				(char)rchInputPathName36,
				(char)rchInputPathName37,
				(char)rchInputPathName38,
				(char)rchInputPathName39,
				(char)rchInputPathName40,
				(char)rchInputPathName41,
				(char)rchInputPathName42,
				(char)rchInputPathName43,
				(char)rchInputPathName44,
				(char)rchInputPathName45,
				(char)rchInputPathName46,
				(char)rchInputPathName47,
				(char)rchInputPathName48,
				(char)rchInputPathName49,
				(char)rchInputPathName50,
				(char)rchInputPathName51,
				(char)rchInputPathName52,
				(char)rchInputPathName53,
				(char)rchInputPathName54,
				(char)rchInputPathName55,
				(char)rchInputPathName56,
				(char)rchInputPathName57,
				(char)rchInputPathName58,
				(char)rchInputPathName59,
				(char)rchInputPathName60,
				(char)rchInputPathName61,
				(char)rchInputPathName62,
				(char)rchInputPathName63,
				(char)rchInputPathName64,
				(char)rchInputPathName65,
				(char)rchInputPathName66,
				(char)rchInputPathName67,
				(char)rchInputPathName68,
				(char)rchInputPathName69,
				(char)rchInputPathName70,
				(char)rchInputPathName71,
				(char)rchInputPathName72,
				(char)rchInputPathName73,
				(char)rchInputPathName74,
				(char)rchInputPathName75,
				(char)rchInputPathName76,
				(char)rchInputPathName77,
				(char)rchInputPathName78,
				(char)rchInputPathName79,
				(char)rchInputPathName80,
				(char)rchInputPathName81,
				(char)rchInputPathName82,
				(char)rchInputPathName83,
				(char)rchInputPathName84,
				(char)rchInputPathName85,
				(char)rchInputPathName86,
				(char)rchInputPathName87,
				(char)rchInputPathName88,
				(char)rchInputPathName89,
				(char)rchInputPathName90,
				(char)rchInputPathName91,
				(char)rchInputPathName92,
				(char)rchInputPathName93,
				(char)rchInputPathName94,
				(char)rchInputPathName95,
				(char)rchInputPathName96,
				(char)rchInputPathName97,
				(char)rchInputPathName98,
				(char)rchInputPathName99,
				(char)rchInputPathName100,
				(char)rchInputPathName101,
				(char)rchInputPathName102,
				(char)rchInputPathName103,
				(char)rchInputPathName104,
				(char)rchInputPathName105,
				(char)rchInputPathName106,
				(char)rchInputPathName107,
				(char)rchInputPathName108,
				(char)rchInputPathName109,
				(char)rchInputPathName110,
				(char)rchInputPathName111,
				(char)rchInputPathName112,
				(char)rchInputPathName113,
				(char)rchInputPathName114,
				(char)rchInputPathName115,
				(char)rchInputPathName116,
				(char)rchInputPathName117,
				(char)rchInputPathName118,
				(char)rchInputPathName119,
				(char)rchInputPathName120,
				(char)rchInputPathName121,
				(char)rchInputPathName122,
				(char)rchInputPathName123,
				(char)rchInputPathName124,
				(char)rchInputPathName125,
				(char)rchInputPathName126,
				(char)rchInputPathName127
			}).TrimEnd('\0');
			}
		}
		public byte rchModeName0, rchModeName1, rchModeName2, rchModeName3, rchModeName4, rchModeName5, rchModeName6, rchModeName7, rchModeName8, rchModeName9, rchModeName10, rchModeName11, rchModeName12, rchModeName13, rchModeName14, rchModeName15, rchModeName16, rchModeName17, rchModeName18, rchModeName19, rchModeName20, rchModeName21, rchModeName22, rchModeName23, rchModeName24, rchModeName25, rchModeName26, rchModeName27, rchModeName28, rchModeName29, rchModeName30, rchModeName31, rchModeName32, rchModeName33, rchModeName34, rchModeName35, rchModeName36, rchModeName37, rchModeName38, rchModeName39, rchModeName40, rchModeName41, rchModeName42, rchModeName43, rchModeName44, rchModeName45, rchModeName46, rchModeName47, rchModeName48, rchModeName49, rchModeName50, rchModeName51, rchModeName52, rchModeName53, rchModeName54, rchModeName55, rchModeName56, rchModeName57, rchModeName58, rchModeName59, rchModeName60, rchModeName61, rchModeName62, rchModeName63, rchModeName64, rchModeName65, rchModeName66, rchModeName67, rchModeName68, rchModeName69, rchModeName70, rchModeName71, rchModeName72, rchModeName73, rchModeName74, rchModeName75, rchModeName76, rchModeName77, rchModeName78, rchModeName79, rchModeName80, rchModeName81, rchModeName82, rchModeName83, rchModeName84, rchModeName85, rchModeName86, rchModeName87, rchModeName88, rchModeName89, rchModeName90, rchModeName91, rchModeName92, rchModeName93, rchModeName94, rchModeName95, rchModeName96, rchModeName97, rchModeName98, rchModeName99, rchModeName100, rchModeName101, rchModeName102, rchModeName103, rchModeName104, rchModeName105, rchModeName106, rchModeName107, rchModeName108, rchModeName109, rchModeName110, rchModeName111, rchModeName112, rchModeName113, rchModeName114, rchModeName115, rchModeName116, rchModeName117, rchModeName118, rchModeName119, rchModeName120, rchModeName121, rchModeName122, rchModeName123, rchModeName124, rchModeName125, rchModeName126, rchModeName127;
		public string rchModeName
		{
			get
			{
				return new string(new char[] {
				(char)rchModeName0,
				(char)rchModeName1,
				(char)rchModeName2,
				(char)rchModeName3,
				(char)rchModeName4,
				(char)rchModeName5,
				(char)rchModeName6,
				(char)rchModeName7,
				(char)rchModeName8,
				(char)rchModeName9,
				(char)rchModeName10,
				(char)rchModeName11,
				(char)rchModeName12,
				(char)rchModeName13,
				(char)rchModeName14,
				(char)rchModeName15,
				(char)rchModeName16,
				(char)rchModeName17,
				(char)rchModeName18,
				(char)rchModeName19,
				(char)rchModeName20,
				(char)rchModeName21,
				(char)rchModeName22,
				(char)rchModeName23,
				(char)rchModeName24,
				(char)rchModeName25,
				(char)rchModeName26,
				(char)rchModeName27,
				(char)rchModeName28,
				(char)rchModeName29,
				(char)rchModeName30,
				(char)rchModeName31,
				(char)rchModeName32,
				(char)rchModeName33,
				(char)rchModeName34,
				(char)rchModeName35,
				(char)rchModeName36,
				(char)rchModeName37,
				(char)rchModeName38,
				(char)rchModeName39,
				(char)rchModeName40,
				(char)rchModeName41,
				(char)rchModeName42,
				(char)rchModeName43,
				(char)rchModeName44,
				(char)rchModeName45,
				(char)rchModeName46,
				(char)rchModeName47,
				(char)rchModeName48,
				(char)rchModeName49,
				(char)rchModeName50,
				(char)rchModeName51,
				(char)rchModeName52,
				(char)rchModeName53,
				(char)rchModeName54,
				(char)rchModeName55,
				(char)rchModeName56,
				(char)rchModeName57,
				(char)rchModeName58,
				(char)rchModeName59,
				(char)rchModeName60,
				(char)rchModeName61,
				(char)rchModeName62,
				(char)rchModeName63,
				(char)rchModeName64,
				(char)rchModeName65,
				(char)rchModeName66,
				(char)rchModeName67,
				(char)rchModeName68,
				(char)rchModeName69,
				(char)rchModeName70,
				(char)rchModeName71,
				(char)rchModeName72,
				(char)rchModeName73,
				(char)rchModeName74,
				(char)rchModeName75,
				(char)rchModeName76,
				(char)rchModeName77,
				(char)rchModeName78,
				(char)rchModeName79,
				(char)rchModeName80,
				(char)rchModeName81,
				(char)rchModeName82,
				(char)rchModeName83,
				(char)rchModeName84,
				(char)rchModeName85,
				(char)rchModeName86,
				(char)rchModeName87,
				(char)rchModeName88,
				(char)rchModeName89,
				(char)rchModeName90,
				(char)rchModeName91,
				(char)rchModeName92,
				(char)rchModeName93,
				(char)rchModeName94,
				(char)rchModeName95,
				(char)rchModeName96,
				(char)rchModeName97,
				(char)rchModeName98,
				(char)rchModeName99,
				(char)rchModeName100,
				(char)rchModeName101,
				(char)rchModeName102,
				(char)rchModeName103,
				(char)rchModeName104,
				(char)rchModeName105,
				(char)rchModeName106,
				(char)rchModeName107,
				(char)rchModeName108,
				(char)rchModeName109,
				(char)rchModeName110,
				(char)rchModeName111,
				(char)rchModeName112,
				(char)rchModeName113,
				(char)rchModeName114,
				(char)rchModeName115,
				(char)rchModeName116,
				(char)rchModeName117,
				(char)rchModeName118,
				(char)rchModeName119,
				(char)rchModeName120,
				(char)rchModeName121,
				(char)rchModeName122,
				(char)rchModeName123,
				(char)rchModeName124,
				(char)rchModeName125,
				(char)rchModeName126,
				(char)rchModeName127
			}).TrimEnd('\0');
			}
		}
		public byte rchSlotName0, rchSlotName1, rchSlotName2, rchSlotName3, rchSlotName4, rchSlotName5, rchSlotName6, rchSlotName7, rchSlotName8, rchSlotName9, rchSlotName10, rchSlotName11, rchSlotName12, rchSlotName13, rchSlotName14, rchSlotName15, rchSlotName16, rchSlotName17, rchSlotName18, rchSlotName19, rchSlotName20, rchSlotName21, rchSlotName22, rchSlotName23, rchSlotName24, rchSlotName25, rchSlotName26, rchSlotName27, rchSlotName28, rchSlotName29, rchSlotName30, rchSlotName31, rchSlotName32, rchSlotName33, rchSlotName34, rchSlotName35, rchSlotName36, rchSlotName37, rchSlotName38, rchSlotName39, rchSlotName40, rchSlotName41, rchSlotName42, rchSlotName43, rchSlotName44, rchSlotName45, rchSlotName46, rchSlotName47, rchSlotName48, rchSlotName49, rchSlotName50, rchSlotName51, rchSlotName52, rchSlotName53, rchSlotName54, rchSlotName55, rchSlotName56, rchSlotName57, rchSlotName58, rchSlotName59, rchSlotName60, rchSlotName61, rchSlotName62, rchSlotName63, rchSlotName64, rchSlotName65, rchSlotName66, rchSlotName67, rchSlotName68, rchSlotName69, rchSlotName70, rchSlotName71, rchSlotName72, rchSlotName73, rchSlotName74, rchSlotName75, rchSlotName76, rchSlotName77, rchSlotName78, rchSlotName79, rchSlotName80, rchSlotName81, rchSlotName82, rchSlotName83, rchSlotName84, rchSlotName85, rchSlotName86, rchSlotName87, rchSlotName88, rchSlotName89, rchSlotName90, rchSlotName91, rchSlotName92, rchSlotName93, rchSlotName94, rchSlotName95, rchSlotName96, rchSlotName97, rchSlotName98, rchSlotName99, rchSlotName100, rchSlotName101, rchSlotName102, rchSlotName103, rchSlotName104, rchSlotName105, rchSlotName106, rchSlotName107, rchSlotName108, rchSlotName109, rchSlotName110, rchSlotName111, rchSlotName112, rchSlotName113, rchSlotName114, rchSlotName115, rchSlotName116, rchSlotName117, rchSlotName118, rchSlotName119, rchSlotName120, rchSlotName121, rchSlotName122, rchSlotName123, rchSlotName124, rchSlotName125, rchSlotName126, rchSlotName127;
		public string rchSlotName
		{
			get
			{
				return new string(new char[] {
				(char)rchSlotName0,
				(char)rchSlotName1,
				(char)rchSlotName2,
				(char)rchSlotName3,
				(char)rchSlotName4,
				(char)rchSlotName5,
				(char)rchSlotName6,
				(char)rchSlotName7,
				(char)rchSlotName8,
				(char)rchSlotName9,
				(char)rchSlotName10,
				(char)rchSlotName11,
				(char)rchSlotName12,
				(char)rchSlotName13,
				(char)rchSlotName14,
				(char)rchSlotName15,
				(char)rchSlotName16,
				(char)rchSlotName17,
				(char)rchSlotName18,
				(char)rchSlotName19,
				(char)rchSlotName20,
				(char)rchSlotName21,
				(char)rchSlotName22,
				(char)rchSlotName23,
				(char)rchSlotName24,
				(char)rchSlotName25,
				(char)rchSlotName26,
				(char)rchSlotName27,
				(char)rchSlotName28,
				(char)rchSlotName29,
				(char)rchSlotName30,
				(char)rchSlotName31,
				(char)rchSlotName32,
				(char)rchSlotName33,
				(char)rchSlotName34,
				(char)rchSlotName35,
				(char)rchSlotName36,
				(char)rchSlotName37,
				(char)rchSlotName38,
				(char)rchSlotName39,
				(char)rchSlotName40,
				(char)rchSlotName41,
				(char)rchSlotName42,
				(char)rchSlotName43,
				(char)rchSlotName44,
				(char)rchSlotName45,
				(char)rchSlotName46,
				(char)rchSlotName47,
				(char)rchSlotName48,
				(char)rchSlotName49,
				(char)rchSlotName50,
				(char)rchSlotName51,
				(char)rchSlotName52,
				(char)rchSlotName53,
				(char)rchSlotName54,
				(char)rchSlotName55,
				(char)rchSlotName56,
				(char)rchSlotName57,
				(char)rchSlotName58,
				(char)rchSlotName59,
				(char)rchSlotName60,
				(char)rchSlotName61,
				(char)rchSlotName62,
				(char)rchSlotName63,
				(char)rchSlotName64,
				(char)rchSlotName65,
				(char)rchSlotName66,
				(char)rchSlotName67,
				(char)rchSlotName68,
				(char)rchSlotName69,
				(char)rchSlotName70,
				(char)rchSlotName71,
				(char)rchSlotName72,
				(char)rchSlotName73,
				(char)rchSlotName74,
				(char)rchSlotName75,
				(char)rchSlotName76,
				(char)rchSlotName77,
				(char)rchSlotName78,
				(char)rchSlotName79,
				(char)rchSlotName80,
				(char)rchSlotName81,
				(char)rchSlotName82,
				(char)rchSlotName83,
				(char)rchSlotName84,
				(char)rchSlotName85,
				(char)rchSlotName86,
				(char)rchSlotName87,
				(char)rchSlotName88,
				(char)rchSlotName89,
				(char)rchSlotName90,
				(char)rchSlotName91,
				(char)rchSlotName92,
				(char)rchSlotName93,
				(char)rchSlotName94,
				(char)rchSlotName95,
				(char)rchSlotName96,
				(char)rchSlotName97,
				(char)rchSlotName98,
				(char)rchSlotName99,
				(char)rchSlotName100,
				(char)rchSlotName101,
				(char)rchSlotName102,
				(char)rchSlotName103,
				(char)rchSlotName104,
				(char)rchSlotName105,
				(char)rchSlotName106,
				(char)rchSlotName107,
				(char)rchSlotName108,
				(char)rchSlotName109,
				(char)rchSlotName110,
				(char)rchSlotName111,
				(char)rchSlotName112,
				(char)rchSlotName113,
				(char)rchSlotName114,
				(char)rchSlotName115,
				(char)rchSlotName116,
				(char)rchSlotName117,
				(char)rchSlotName118,
				(char)rchSlotName119,
				(char)rchSlotName120,
				(char)rchSlotName121,
				(char)rchSlotName122,
				(char)rchSlotName123,
				(char)rchSlotName124,
				(char)rchSlotName125,
				(char)rchSlotName126,
				(char)rchSlotName127
			}).TrimEnd('\0');
			}
		}
		public byte rchInputSourceType0, rchInputSourceType1, rchInputSourceType2, rchInputSourceType3, rchInputSourceType4, rchInputSourceType5, rchInputSourceType6, rchInputSourceType7, rchInputSourceType8, rchInputSourceType9, rchInputSourceType10, rchInputSourceType11, rchInputSourceType12, rchInputSourceType13, rchInputSourceType14, rchInputSourceType15, rchInputSourceType16, rchInputSourceType17, rchInputSourceType18, rchInputSourceType19, rchInputSourceType20, rchInputSourceType21, rchInputSourceType22, rchInputSourceType23, rchInputSourceType24, rchInputSourceType25, rchInputSourceType26, rchInputSourceType27, rchInputSourceType28, rchInputSourceType29, rchInputSourceType30, rchInputSourceType31;
		public string rchInputSourceType
		{
			get
			{
				return new string(new char[] {
				(char)rchInputSourceType0,
				(char)rchInputSourceType1,
				(char)rchInputSourceType2,
				(char)rchInputSourceType3,
				(char)rchInputSourceType4,
				(char)rchInputSourceType5,
				(char)rchInputSourceType6,
				(char)rchInputSourceType7,
				(char)rchInputSourceType8,
				(char)rchInputSourceType9,
				(char)rchInputSourceType10,
				(char)rchInputSourceType11,
				(char)rchInputSourceType12,
				(char)rchInputSourceType13,
				(char)rchInputSourceType14,
				(char)rchInputSourceType15,
				(char)rchInputSourceType16,
				(char)rchInputSourceType17,
				(char)rchInputSourceType18,
				(char)rchInputSourceType19,
				(char)rchInputSourceType20,
				(char)rchInputSourceType21,
				(char)rchInputSourceType22,
				(char)rchInputSourceType23,
				(char)rchInputSourceType24,
				(char)rchInputSourceType25,
				(char)rchInputSourceType26,
				(char)rchInputSourceType27,
				(char)rchInputSourceType28,
				(char)rchInputSourceType29,
				(char)rchInputSourceType30,
				(char)rchInputSourceType31
			}).TrimEnd('\0');
			}
		}
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRActiveActionSet_t
	{
		public ulong ulActionSet;
		public ulong ulRestrictedToDevice;
		public ulong ulSecondaryActionSet;
		public uint unPadding;
		public int nPriority;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct VRSkeletalSummaryData_t
	{
		public float flFingerCurl0; //float[5]
		public float flFingerCurl1;
		public float flFingerCurl2;
		public float flFingerCurl3;
		public float flFingerCurl4;
		public float flFingerSplay0; //float[4]
		public float flFingerSplay1;
		public float flFingerSplay2;
		public float flFingerSplay3;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct SpatialAnchorPose_t
	{
		public HmdMatrix34_t mAnchorToAbsoluteTracking;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct COpenVRContext
	{
		public IntPtr m_pVRSystem; // class vr::IVRSystem *
		public IntPtr m_pVRChaperone; // class vr::IVRChaperone *
		public IntPtr m_pVRChaperoneSetup; // class vr::IVRChaperoneSetup *
		public IntPtr m_pVRCompositor; // class vr::IVRCompositor *
		public IntPtr m_pVRHeadsetView; // class vr::IVRHeadsetView *
		public IntPtr m_pVROverlay; // class vr::IVROverlay *
		public IntPtr m_pVROverlayView; // class vr::IVROverlayView *
		public IntPtr m_pVRResources; // class vr::IVRResources *
		public IntPtr m_pVRRenderModels; // class vr::IVRRenderModels *
		public IntPtr m_pVRExtendedDisplay; // class vr::IVRExtendedDisplay *
		public IntPtr m_pVRSettings; // class vr::IVRSettings *
		public IntPtr m_pVRApplications; // class vr::IVRApplications *
		public IntPtr m_pVRTrackedCamera; // class vr::IVRTrackedCamera *
		public IntPtr m_pVRScreenshots; // class vr::IVRScreenshots *
		public IntPtr m_pVRDriverManager; // class vr::IVRDriverManager *
		public IntPtr m_pVRInput; // class vr::IVRInput *
		public IntPtr m_pVRIOBuffer; // class vr::IVRIOBuffer *
		public IntPtr m_pVRSpatialAnchors; // class vr::IVRSpatialAnchors *
		public IntPtr m_pVRDebug; // class vr::IVRDebug *
		public IntPtr m_pVRNotifications; // class vr::IVRNotifications *
		public IntPtr m_pVRIPCResourceManagerClient; // class vr::IVRIPCResourceManagerClient *
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct PropertyWrite_t
	{
		public ETrackedDeviceProperty prop;
		public EPropertyWriteType writeType;
		public ETrackedPropertyError eSetError;
		public IntPtr pvBuffer; // void *
		public uint unBufferSize;
		public uint unTag;
		public ETrackedPropertyError eError;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct PropertyRead_t
	{
		public ETrackedDeviceProperty prop;
		public IntPtr pvBuffer; // void *
		public uint unBufferSize;
		public uint unTag;
		public uint unRequiredBufferSize;
		public ETrackedPropertyError eError;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct CVRPropertyHelpers
	{
		public IntPtr m_pProperties; // class vr::IVRProperties *
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct PathWrite_t
	{
		public ulong ulPath;
		public EPropertyWriteType writeType;
		public ETrackedPropertyError eSetError;
		public IntPtr pvBuffer; // void *
		public uint unBufferSize;
		public uint unTag;
		public ETrackedPropertyError eError;
		public IntPtr pszPath; // const char *
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct PathRead_t
	{
		public ulong ulPath;
		public IntPtr pvBuffer; // void *
		public uint unBufferSize;
		public uint unTag;
		public uint unRequiredBufferSize;
		public ETrackedPropertyError eError;
		public IntPtr pszPath; // const char *
	}

	public class OpenVR
	{

		public static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType)
		{
			return OpenVRInterop.InitInternal(ref peError, eApplicationType);
		}

		public static uint InitInternal2(ref EVRInitError peError, EVRApplicationType eApplicationType, string pchStartupInfo)
		{
			return OpenVRInterop.InitInternal2(ref peError, eApplicationType, pchStartupInfo);
		}

		public static void ShutdownInternal()
		{
			OpenVRInterop.ShutdownInternal();
		}

		public static bool IsHmdPresent()
		{
			return OpenVRInterop.IsHmdPresent();
		}

		public static bool IsRuntimeInstalled()
		{
			return OpenVRInterop.IsRuntimeInstalled();
		}

		public static string RuntimePath()
		{
			try
			{
				uint pathSize = 512;
				uint requiredPathSize = 512;
				System.Text.StringBuilder path = new System.Text.StringBuilder((int)pathSize);
				bool success = OpenVRInterop.GetRuntimePath(path, pathSize, ref requiredPathSize);
				if (success == false)
				{
					return null;
				}

				return path.ToString();
			}
			catch
			{
				return OpenVRInterop.RuntimePath(); //this api is deprecated but here to support older unity versions
			}
		}

		public static string GetStringForHmdError(EVRInitError error)
		{
			return Marshal.PtrToStringAnsi(OpenVRInterop.GetStringForHmdError(error));
		}

		public static IntPtr GetGenericInterface(string pchInterfaceVersion, ref EVRInitError peError)
		{
			return OpenVRInterop.GetGenericInterface(pchInterfaceVersion, ref peError);
		}

		public static bool IsInterfaceVersionValid(string pchInterfaceVersion)
		{
			return OpenVRInterop.IsInterfaceVersionValid(pchInterfaceVersion);
		}

		public static uint GetInitToken()
		{
			return OpenVRInterop.GetInitToken();
		}

		public const uint MaxDmabufPlaneCount = 4;
		public const uint k_nDriverNone = 4294967295;
		public const uint k_unMaxDriverDebugResponseSize = 32768;
		public const uint k_unTrackedDeviceIndex_Hmd = 0;
		public const uint k_unMaxTrackedDeviceCount = 64;
		public const uint k_unTrackedDeviceIndexOther = 4294967294;
		public const uint k_unTrackedDeviceIndexInvalid = 4294967295;
		public const ulong k_ulInvalidPropertyContainer = 0;
		public const uint k_unInvalidPropertyTag = 0;
		public const ulong k_ulInvalidDriverHandle = 0;
		public const uint k_unFloatPropertyTag = 1;
		public const uint k_unInt32PropertyTag = 2;
		public const uint k_unUint64PropertyTag = 3;
		public const uint k_unBoolPropertyTag = 4;
		public const uint k_unStringPropertyTag = 5;
		public const uint k_unErrorPropertyTag = 6;
		public const uint k_unDoublePropertyTag = 7;
		public const uint k_unHmdMatrix34PropertyTag = 20;
		public const uint k_unHmdMatrix44PropertyTag = 21;
		public const uint k_unHmdVector3PropertyTag = 22;
		public const uint k_unHmdVector4PropertyTag = 23;
		public const uint k_unHmdVector2PropertyTag = 24;
		public const uint k_unHmdQuadPropertyTag = 25;
		public const uint k_unHiddenAreaPropertyTag = 30;
		public const uint k_unPathHandleInfoTag = 31;
		public const uint k_unActionPropertyTag = 32;
		public const uint k_unInputValuePropertyTag = 33;
		public const uint k_unWildcardPropertyTag = 34;
		public const uint k_unHapticVibrationPropertyTag = 35;
		public const uint k_unSkeletonPropertyTag = 36;
		public const uint k_unSpatialAnchorPosePropertyTag = 40;
		public const uint k_unJsonPropertyTag = 41;
		public const uint k_unActiveActionSetPropertyTag = 42;
		public const uint k_unOpenVRInternalReserved_Start = 1000;
		public const uint k_unOpenVRInternalReserved_End = 10000;
		public const uint k_unMaxPropertyStringSize = 32768;
		public const ulong k_ulInvalidActionHandle = 0;
		public const ulong k_ulInvalidActionSetHandle = 0;
		public const ulong k_ulInvalidInputValueHandle = 0;
		public const uint k_unControllerStateAxisCount = 5;
		public const ulong k_ulOverlayHandleInvalid = 0;
		public const uint k_unMaxDistortionFunctionParameters = 8;
		public const uint k_unScreenshotHandleInvalid = 0;
		public const string IVRSystem_Version = "IVRSystem_022";
		public const string IVRExtendedDisplay_Version = "IVRExtendedDisplay_001";
		public const string IVRTrackedCamera_Version = "IVRTrackedCamera_006";
		public const uint k_unMaxApplicationKeyLength = 128;
		public const string k_pch_MimeType_HomeApp = "vr/home";
		public const string k_pch_MimeType_GameTheater = "vr/game_theater";
		public const string IVRApplications_Version = "IVRApplications_007";
		public const string IVRChaperone_Version = "IVRChaperone_004";
		public const string IVRChaperoneSetup_Version = "IVRChaperoneSetup_006";
		public const string IVRCompositor_Version = "IVRCompositor_028";
		public const uint k_unVROverlayMaxKeyLength = 128;
		public const uint k_unVROverlayMaxNameLength = 128;
		public const uint k_unMaxOverlayCount = 128;
		public const uint k_unMaxOverlayIntersectionMaskPrimitivesCount = 32;
		public const string IVROverlay_Version = "IVROverlay_028";
		public const string IVROverlayView_Version = "IVROverlayView_003";
		public const uint k_unHeadsetViewMaxWidth = 3840;
		public const uint k_unHeadsetViewMaxHeight = 2160;
		public const string k_pchHeadsetViewOverlayKey = "system.HeadsetView";
		public const string IVRHeadsetView_Version = "IVRHeadsetView_001";
		public const string k_pch_Controller_Component_GDC2015 = "gdc2015";
		public const string k_pch_Controller_Component_Base = "base";
		public const string k_pch_Controller_Component_Tip = "tip";
		public const string k_pch_Controller_Component_OpenXR_Aim = "openxr_aim";
		public const string k_pch_Controller_Component_HandGrip = "handgrip";
		public const string k_pch_Controller_Component_OpenXR_Grip = "openxr_grip";
		public const string k_pch_Controller_Component_OpenXR_HandModel = "openxr_handmodel";
		public const string k_pch_Controller_Component_Status = "status";
		public const string IVRRenderModels_Version = "IVRRenderModels_006";
		public const uint k_unNotificationTextMaxSize = 256;
		public const string IVRNotifications_Version = "IVRNotifications_002";
		public const uint k_unMaxSettingsKeyLength = 128;
		public const string IVRSettings_Version = "IVRSettings_003";
		public const string k_pch_SteamVR_Section = "steamvr";
		public const string k_pch_SteamVR_RequireHmd_String = "requireHmd";
		public const string k_pch_SteamVR_ForcedDriverKey_String = "forcedDriver";
		public const string k_pch_SteamVR_ForcedHmdKey_String = "forcedHmd";
		public const string k_pch_SteamVR_DisplayDebug_Bool = "displayDebug";
		public const string k_pch_SteamVR_DebugProcessPipe_String = "debugProcessPipe";
		public const string k_pch_SteamVR_DisplayDebugX_Int32 = "displayDebugX";
		public const string k_pch_SteamVR_DisplayDebugY_Int32 = "displayDebugY";
		public const string k_pch_SteamVR_SendSystemButtonToAllApps_Bool = "sendSystemButtonToAllApps";
		public const string k_pch_SteamVR_LogLevel_Int32 = "loglevel";
		public const string k_pch_SteamVR_IPD_Float = "ipd";
		public const string k_pch_SteamVR_Background_String = "background";
		public const string k_pch_SteamVR_BackgroundUseDomeProjection_Bool = "backgroundUseDomeProjection";
		public const string k_pch_SteamVR_BackgroundCameraHeight_Float = "backgroundCameraHeight";
		public const string k_pch_SteamVR_BackgroundDomeRadius_Float = "backgroundDomeRadius";
		public const string k_pch_SteamVR_GridColor_String = "gridColor";
		public const string k_pch_SteamVR_PlayAreaColor_String = "playAreaColor";
		public const string k_pch_SteamVR_TrackingLossColor_String = "trackingLossColor";
		public const string k_pch_SteamVR_ShowStage_Bool = "showStage";
		public const string k_pch_SteamVR_DrawTrackingReferences_Bool = "drawTrackingReferences";
		public const string k_pch_SteamVR_ActivateMultipleDrivers_Bool = "activateMultipleDrivers";
		public const string k_pch_SteamVR_UsingSpeakers_Bool = "usingSpeakers";
		public const string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float = "speakersForwardYawOffsetDegrees";
		public const string k_pch_SteamVR_BaseStationPowerManagement_Int32 = "basestationPowerManagement";
		public const string k_pch_SteamVR_ShowBaseStationPowerManagementTip_Int32 = "ShowBaseStationPowerManagementTip";
		public const string k_pch_SteamVR_NeverKillProcesses_Bool = "neverKillProcesses";
		public const string k_pch_SteamVR_SupersampleScale_Float = "supersampleScale";
		public const string k_pch_SteamVR_MaxRecommendedResolution_Int32 = "maxRecommendedResolution";
		public const string k_pch_SteamVR_MotionSmoothing_Bool = "motionSmoothing";
		public const string k_pch_SteamVR_MotionSmoothingOverride_Int32 = "motionSmoothingOverride";
		public const string k_pch_SteamVR_FramesToThrottle_Int32 = "framesToThrottle";
		public const string k_pch_SteamVR_AdditionalFramesToPredict_Int32 = "additionalFramesToPredict";
		public const string k_pch_SteamVR_WorldScale_Float = "worldScale";
		public const string k_pch_SteamVR_FovScale_Int32 = "fovScale";
		public const string k_pch_SteamVR_FovScaleLetterboxed_Bool = "fovScaleLetterboxed";
		public const string k_pch_SteamVR_DisableAsyncReprojection_Bool = "disableAsync";
		public const string k_pch_SteamVR_ForceFadeOnBadTracking_Bool = "forceFadeOnBadTracking";
		public const string k_pch_SteamVR_DefaultMirrorView_Int32 = "mirrorView";
		public const string k_pch_SteamVR_ShowLegacyMirrorView_Bool = "showLegacyMirrorView";
		public const string k_pch_SteamVR_MirrorViewVisibility_Bool = "showMirrorView";
		public const string k_pch_SteamVR_MirrorViewDisplayMode_Int32 = "mirrorViewDisplayMode";
		public const string k_pch_SteamVR_MirrorViewEye_Int32 = "mirrorViewEye";
		public const string k_pch_SteamVR_MirrorViewGeometry_String = "mirrorViewGeometry";
		public const string k_pch_SteamVR_MirrorViewGeometryMaximized_String = "mirrorViewGeometryMaximized";
		public const string k_pch_SteamVR_PerfGraphVisibility_Bool = "showPerfGraph";
		public const string k_pch_SteamVR_StartMonitorFromAppLaunch = "startMonitorFromAppLaunch";
		public const string k_pch_SteamVR_StartCompositorFromAppLaunch_Bool = "startCompositorFromAppLaunch";
		public const string k_pch_SteamVR_StartDashboardFromAppLaunch_Bool = "startDashboardFromAppLaunch";
		public const string k_pch_SteamVR_StartOverlayAppsFromDashboard_Bool = "startOverlayAppsFromDashboard";
		public const string k_pch_SteamVR_EnableHomeApp = "enableHomeApp";
		public const string k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32 = "CycleBackgroundImageTimeSec";
		public const string k_pch_SteamVR_RetailDemo_Bool = "retailDemo";
		public const string k_pch_SteamVR_IpdOffset_Float = "ipdOffset";
		public const string k_pch_SteamVR_AllowSupersampleFiltering_Bool = "allowSupersampleFiltering";
		public const string k_pch_SteamVR_SupersampleManualOverride_Bool = "supersampleManualOverride";
		public const string k_pch_SteamVR_EnableLinuxVulkanAsync_Bool = "enableLinuxVulkanAsync";
		public const string k_pch_SteamVR_AllowDisplayLockedMode_Bool = "allowDisplayLockedMode";
		public const string k_pch_SteamVR_HaveStartedTutorialForNativeChaperoneDriver_Bool = "haveStartedTutorialForNativeChaperoneDriver";
		public const string k_pch_SteamVR_ForceWindows32bitVRMonitor = "forceWindows32BitVRMonitor";
		public const string k_pch_SteamVR_DebugInputBinding = "debugInputBinding";
		public const string k_pch_SteamVR_DoNotFadeToGrid = "doNotFadeToGrid";
		public const string k_pch_SteamVR_EnableSharedResourceJournaling = "enableSharedResourceJournaling";
		public const string k_pch_SteamVR_EnableSafeMode = "enableSafeMode";
		public const string k_pch_SteamVR_PreferredRefreshRate = "preferredRefreshRate";
		public const string k_pch_SteamVR_LastVersionNotice = "lastVersionNotice";
		public const string k_pch_SteamVR_LastVersionNoticeDate = "lastVersionNoticeDate";
		public const string k_pch_SteamVR_HmdDisplayColorGainR_Float = "hmdDisplayColorGainR";
		public const string k_pch_SteamVR_HmdDisplayColorGainG_Float = "hmdDisplayColorGainG";
		public const string k_pch_SteamVR_HmdDisplayColorGainB_Float = "hmdDisplayColorGainB";
		public const string k_pch_SteamVR_CustomIconStyle_String = "customIconStyle";
		public const string k_pch_SteamVR_CustomOffIconStyle_String = "customOffIconStyle";
		public const string k_pch_SteamVR_CustomIconForceUpdate_String = "customIconForceUpdate";
		public const string k_pch_SteamVR_AllowGlobalActionSetPriority = "globalActionSetPriority";
		public const string k_pch_SteamVR_OverlayRenderQuality = "overlayRenderQuality_2";
		public const string k_pch_SteamVR_BlockOculusSDKOnOpenVRLaunchOption_Bool = "blockOculusSDKOnOpenVRLaunchOption";
		public const string k_pch_SteamVR_BlockOculusSDKOnAllLaunches_Bool = "blockOculusSDKOnAllLaunches";
		public const string k_pch_SteamVR_HDCPLegacyCompatibility_Bool = "hdcp14legacyCompatibility";
		public const string k_pch_SteamVR_DisplayPortTrainingMode_Int = "displayPortTrainingMode";
		public const string k_pch_SteamVR_UsePrism_Bool = "usePrism";
		public const string k_pch_SteamVR_AllowFallbackMirrorWindowLinux_Bool = "allowFallbackMirrorWindowLinux";
		public const string k_pch_OpenXR_Section = "openxr";
		public const string k_pch_OpenXR_MetaUnityPluginCompatibility_Int32 = "metaUnityPluginCompatibility";
		public const string k_pch_DirectMode_Section = "direct_mode";
		public const string k_pch_DirectMode_Enable_Bool = "enable";
		public const string k_pch_DirectMode_Count_Int32 = "count";
		public const string k_pch_DirectMode_EdidVid_Int32 = "edidVid";
		public const string k_pch_DirectMode_EdidPid_Int32 = "edidPid";
		public const string k_pch_Lighthouse_Section = "driver_lighthouse";
		public const string k_pch_Lighthouse_DisableIMU_Bool = "disableimu";
		public const string k_pch_Lighthouse_DisableIMUExceptHMD_Bool = "disableimuexcepthmd";
		public const string k_pch_Lighthouse_UseDisambiguation_String = "usedisambiguation";
		public const string k_pch_Lighthouse_DisambiguationDebug_Int32 = "disambiguationdebug";
		public const string k_pch_Lighthouse_PrimaryBasestation_Int32 = "primarybasestation";
		public const string k_pch_Lighthouse_DBHistory_Bool = "dbhistory";
		public const string k_pch_Lighthouse_EnableBluetooth_Bool = "enableBluetooth";
		public const string k_pch_Lighthouse_PowerManagedBaseStations_String = "PowerManagedBaseStations";
		public const string k_pch_Lighthouse_PowerManagedBaseStations2_String = "PowerManagedBaseStations2";
		public const string k_pch_Lighthouse_InactivityTimeoutForBaseStations_Int32 = "InactivityTimeoutForBaseStations";
		public const string k_pch_Lighthouse_EnableImuFallback_Bool = "enableImuFallback";
		public const string k_pch_Null_Section = "driver_null";
		public const string k_pch_Null_SerialNumber_String = "serialNumber";
		public const string k_pch_Null_ModelNumber_String = "modelNumber";
		public const string k_pch_Null_WindowX_Int32 = "windowX";
		public const string k_pch_Null_WindowY_Int32 = "windowY";
		public const string k_pch_Null_WindowWidth_Int32 = "windowWidth";
		public const string k_pch_Null_WindowHeight_Int32 = "windowHeight";
		public const string k_pch_Null_RenderWidth_Int32 = "renderWidth";
		public const string k_pch_Null_RenderHeight_Int32 = "renderHeight";
		public const string k_pch_Null_SecondsFromVsyncToPhotons_Float = "secondsFromVsyncToPhotons";
		public const string k_pch_Null_DisplayFrequency_Float = "displayFrequency";
		public const string k_pch_WindowsMR_Section = "driver_holographic";
		public const string k_pch_UserInterface_Section = "userinterface";
		public const string k_pch_UserInterface_StatusAlwaysOnTop_Bool = "StatusAlwaysOnTop";
		public const string k_pch_UserInterface_MinimizeToTray_Bool = "MinimizeToTray";
		public const string k_pch_UserInterface_HidePopupsWhenStatusMinimized_Bool = "HidePopupsWhenStatusMinimized";
		public const string k_pch_UserInterface_Screenshots_Bool = "screenshots";
		public const string k_pch_UserInterface_ScreenshotType_Int = "screenshotType";
		public const string k_pch_Notifications_Section = "notifications";
		public const string k_pch_Notifications_DoNotDisturb_Bool = "DoNotDisturb";
		public const string k_pch_Keyboard_Section = "keyboard";
		public const string k_pch_Keyboard_TutorialCompletions = "TutorialCompletions";
		public const string k_pch_Keyboard_ScaleX = "ScaleX";
		public const string k_pch_Keyboard_ScaleY = "ScaleY";
		public const string k_pch_Keyboard_OffsetLeftX = "OffsetLeftX";
		public const string k_pch_Keyboard_OffsetRightX = "OffsetRightX";
		public const string k_pch_Keyboard_OffsetY = "OffsetY";
		public const string k_pch_Keyboard_Smoothing = "Smoothing";
		public const string k_pch_Perf_Section = "perfcheck";
		public const string k_pch_Perf_PerfGraphInHMD_Bool = "perfGraphInHMD";
		public const string k_pch_Perf_AllowTimingStore_Bool = "allowTimingStore";
		public const string k_pch_Perf_SaveTimingsOnExit_Bool = "saveTimingsOnExit";
		public const string k_pch_Perf_TestData_Float = "perfTestData";
		public const string k_pch_Perf_GPUProfiling_Bool = "GPUProfiling";
		public const string k_pch_Perf_GpuBusMonitoring_Bool = "gpuBusMonitoring";
		public const string k_pch_CollisionBounds_Section = "collisionBounds";
		public const string k_pch_CollisionBounds_Style_Int32 = "CollisionBoundsStyle";
		public const string k_pch_CollisionBounds_GroundPerimeterOn_Bool = "CollisionBoundsGroundPerimeterOn";
		public const string k_pch_CollisionBounds_CenterMarkerOn_Bool = "CollisionBoundsCenterMarkerOn";
		public const string k_pch_CollisionBounds_PlaySpaceOn_Bool = "CollisionBoundsPlaySpaceOn";
		public const string k_pch_CollisionBounds_FadeDistance_Float = "CollisionBoundsFadeDistance";
		public const string k_pch_CollisionBounds_WallHeight_Float = "CollisionBoundsWallHeight";
		public const string k_pch_CollisionBounds_ColorGammaR_Int32 = "CollisionBoundsColorGammaR";
		public const string k_pch_CollisionBounds_ColorGammaG_Int32 = "CollisionBoundsColorGammaG";
		public const string k_pch_CollisionBounds_ColorGammaB_Int32 = "CollisionBoundsColorGammaB";
		public const string k_pch_CollisionBounds_ColorGammaA_Int32 = "CollisionBoundsColorGammaA";
		public const string k_pch_CollisionBounds_EnableDriverImport = "enableDriverBoundsImport";
		public const string k_pch_Camera_Section = "camera";
		public const string k_pch_Camera_EnableCamera_Bool = "enableCamera";
		public const string k_pch_Camera_ShowOnController_Bool = "showOnController";
		public const string k_pch_Camera_EnableCameraForCollisionBounds_Bool = "enableCameraForCollisionBounds";
		public const string k_pch_Camera_RoomView_Int32 = "roomView";
		public const string k_pch_Camera_BoundsColorGammaR_Int32 = "cameraBoundsColorGammaR";
		public const string k_pch_Camera_BoundsColorGammaG_Int32 = "cameraBoundsColorGammaG";
		public const string k_pch_Camera_BoundsColorGammaB_Int32 = "cameraBoundsColorGammaB";
		public const string k_pch_Camera_BoundsColorGammaA_Int32 = "cameraBoundsColorGammaA";
		public const string k_pch_Camera_BoundsStrength_Int32 = "cameraBoundsStrength";
		public const string k_pch_Camera_RoomViewStyle_Int32 = "roomViewStyle";
		public const string k_pch_audio_Section = "audio";
		public const string k_pch_audio_SetOsDefaultPlaybackDevice_Bool = "setOsDefaultPlaybackDevice";
		public const string k_pch_audio_EnablePlaybackDeviceOverride_Bool = "enablePlaybackDeviceOverride";
		public const string k_pch_audio_PlaybackDeviceOverride_String = "playbackDeviceOverride";
		public const string k_pch_audio_PlaybackDeviceOverrideName_String = "playbackDeviceOverrideName";
		public const string k_pch_audio_SetOsDefaultRecordingDevice_Bool = "setOsDefaultRecordingDevice";
		public const string k_pch_audio_EnableRecordingDeviceOverride_Bool = "enableRecordingDeviceOverride";
		public const string k_pch_audio_RecordingDeviceOverride_String = "recordingDeviceOverride";
		public const string k_pch_audio_RecordingDeviceOverrideName_String = "recordingDeviceOverrideName";
		public const string k_pch_audio_EnablePlaybackMirror_Bool = "enablePlaybackMirror";
		public const string k_pch_audio_PlaybackMirrorDevice_String = "playbackMirrorDevice";
		public const string k_pch_audio_PlaybackMirrorDeviceName_String = "playbackMirrorDeviceName";
		public const string k_pch_audio_OldPlaybackMirrorDevice_String = "onPlaybackMirrorDevice";
		public const string k_pch_audio_ActiveMirrorDevice_String = "activePlaybackMirrorDevice";
		public const string k_pch_audio_EnablePlaybackMirrorIndependentVolume_Bool = "enablePlaybackMirrorIndependentVolume";
		public const string k_pch_audio_LastHmdPlaybackDeviceId_String = "lastHmdPlaybackDeviceId";
		public const string k_pch_audio_VIVEHDMIGain = "viveHDMIGain";
		public const string k_pch_audio_DualSpeakerAndJackOutput_Bool = "dualSpeakerAndJackOutput";
		public const string k_pch_audio_MuteMicMonitor_Bool = "muteMicMonitor";
		public const string k_pch_Power_Section = "power";
		public const string k_pch_Power_PowerOffOnExit_Bool = "powerOffOnExit";
		public const string k_pch_Power_TurnOffScreensTimeout_Float = "turnOffScreensTimeout";
		public const string k_pch_Power_TurnOffControllersTimeout_Float = "turnOffControllersTimeout";
		public const string k_pch_Power_ReturnToWatchdogTimeout_Float = "returnToWatchdogTimeout";
		public const string k_pch_Power_AutoLaunchSteamVROnButtonPress = "autoLaunchSteamVROnButtonPress";
		public const string k_pch_Power_PauseCompositorOnStandby_Bool = "pauseCompositorOnStandby";
		public const string k_pch_Dashboard_Section = "dashboard";
		public const string k_pch_Dashboard_EnableDashboard_Bool = "enableDashboard";
		public const string k_pch_Dashboard_ArcadeMode_Bool = "arcadeMode";
		public const string k_pch_Dashboard_Position = "position";
		public const string k_pch_Dashboard_DesktopScale = "desktopScale";
		public const string k_pch_Dashboard_DashboardScale = "dashboardScale";
		public const string k_pch_Dashboard_UseStandaloneSystemLayer = "standaloneSystemLayer";
		public const string k_pch_Dashboard_StickyDashboard = "stickyDashboard";
		public const string k_pch_Dashboard_AllowSteamOverlays_Bool = "allowSteamOverlays";
		public const string k_pch_Dashboard_AllowVRGamepadUI_Bool = "allowVRGamepadUI";
		public const string k_pch_Dashboard_AllowVRGamepadUIViaGamescope_Bool = "allowVRGamepadUIViaGamescope";
		public const string k_pch_Dashboard_SteamMatchesHMDFramerate = "steamMatchesHMDFramerate";
		public const string k_pch_modelskin_Section = "modelskins";
		public const string k_pch_Driver_Enable_Bool = "enable";
		public const string k_pch_Driver_BlockedBySafemode_Bool = "blocked_by_safe_mode";
		public const string k_pch_Driver_LoadPriority_Int32 = "loadPriority";
		public const string k_pch_WebInterface_Section = "WebInterface";
		public const string k_pch_VRWebHelper_Section = "VRWebHelper";
		public const string k_pch_VRWebHelper_DebuggerEnabled_Bool = "DebuggerEnabled";
		public const string k_pch_VRWebHelper_DebuggerPort_Int32 = "DebuggerPort";
		public const string k_pch_TrackingOverride_Section = "TrackingOverrides";
		public const string k_pch_App_BindingAutosaveURLSuffix_String = "AutosaveURL";
		public const string k_pch_App_BindingLegacyAPISuffix_String = "_legacy";
		public const string k_pch_App_BindingSteamVRInputAPISuffix_String = "_steamvrinput";
		public const string k_pch_App_BindingOpenXRAPISuffix_String = "_openxr";
		public const string k_pch_App_BindingCurrentURLSuffix_String = "CurrentURL";
		public const string k_pch_App_BindingPreviousURLSuffix_String = "PreviousURL";
		public const string k_pch_App_NeedToUpdateAutosaveSuffix_Bool = "NeedToUpdateAutosave";
		public const string k_pch_App_DominantHand_Int32 = "DominantHand";
		public const string k_pch_App_BlockOculusSDK_Bool = "blockOculusSDK";
		public const string k_pch_Trackers_Section = "trackers";
		public const string k_pch_DesktopUI_Section = "DesktopUI";
		public const string k_pch_LastKnown_Section = "LastKnown";
		public const string k_pch_LastKnown_HMDManufacturer_String = "HMDManufacturer";
		public const string k_pch_LastKnown_HMDModel_String = "HMDModel";
		public const string k_pch_LastKnown_ActualHMDDriver_String = "ActualHMDDriver";
		public const string k_pch_DismissedWarnings_Section = "DismissedWarnings";
		public const string k_pch_Input_Section = "input";
		public const string k_pch_Input_LeftThumbstickRotation_Float = "leftThumbstickRotation";
		public const string k_pch_Input_RightThumbstickRotation_Float = "rightThumbstickRotation";
		public const string k_pch_Input_ThumbstickDeadzone_Float = "thumbstickDeadzone";
		public const string k_pch_GpuSpeed_Section = "GpuSpeed";
		public const string IVRScreenshots_Version = "IVRScreenshots_001";
		public const string IVRResources_Version = "IVRResources_001";
		public const string IVRDriverManager_Version = "IVRDriverManager_001";
		public const uint k_unMaxActionNameLength = 64;
		public const uint k_unMaxActionSetNameLength = 64;
		public const uint k_unMaxActionOriginCount = 16;
		public const uint k_unMaxBoneNameLength = 32;
		public const int k_nActionSetOverlayGlobalPriorityMin = 16777216;
		public const int k_nActionSetOverlayGlobalPriorityMax = 33554431;
		public const int k_nActionSetPriorityReservedMin = 33554432;
		public const string IVRInput_Version = "IVRInput_010";
		public const ulong k_ulInvalidIOBufferHandle = 0;
		public const string IVRIOBuffer_Version = "IVRIOBuffer_002";
		public const uint k_ulInvalidSpatialAnchorHandle = 0;
		public const string IVRSpatialAnchors_Version = "IVRSpatialAnchors_001";
		public const string IVRDebug_Version = "IVRDebug_001";
		public const string IVRIPCResourceManagerClient_Version = "IVRIPCResourceManagerClient_001";
		public const ulong k_ulDisplayRedirectContainer = 25769803779;
		public const string IVRProperties_Version = "IVRProperties_001";
		public const string k_pchPathUserHandRight = "/user/hand/right";
		public const string k_pchPathUserHandLeft = "/user/hand/left";
		public const string k_pchPathUserHandPrimary = "/user/hand/primary";
		public const string k_pchPathUserHandSecondary = "/user/hand/secondary";
		public const string k_pchPathUserHead = "/user/head";
		public const string k_pchPathUserGamepad = "/user/gamepad";
		public const string k_pchPathUserTreadmill = "/user/treadmill";
		public const string k_pchPathUserStylus = "/user/stylus";
		public const string k_pchPathDevices = "/devices";
		public const string k_pchPathDevicePath = "/device_path";
		public const string k_pchPathBestAliasPath = "/best_alias_path";
		public const string k_pchPathBoundTrackerAliasPath = "/bound_tracker_path";
		public const string k_pchPathBoundTrackerRole = "/bound_tracker_role";
		public const string k_pchPathPoseRaw = "/pose/raw";
		public const string k_pchPathPoseTip = "/pose/tip";
		public const string k_pchPathPoseGrip = "/pose/grip";
		public const string k_pchPathSystemButtonClick = "/input/system/click";
		public const string k_pchPathProximity = "/proximity";
		public const string k_pchPathControllerTypePrefix = "/controller_type/";
		public const string k_pchPathInputProfileSuffix = "/input_profile";
		public const string k_pchPathBindingNameSuffix = "/binding_name";
		public const string k_pchPathBindingUrlSuffix = "/binding_url";
		public const string k_pchPathBindingErrorSuffix = "/binding_error";
		public const string k_pchPathActiveActionSets = "/active_action_sets";
		public const string k_pchPathComponentUpdates = "/total_component_updates";
		public const string k_pchPathUserFootLeft = "/user/foot/left";
		public const string k_pchPathUserFootRight = "/user/foot/right";
		public const string k_pchPathUserShoulderLeft = "/user/shoulder/left";
		public const string k_pchPathUserShoulderRight = "/user/shoulder/right";
		public const string k_pchPathUserElbowLeft = "/user/elbow/left";
		public const string k_pchPathUserElbowRight = "/user/elbow/right";
		public const string k_pchPathUserKneeLeft = "/user/knee/left";
		public const string k_pchPathUserKneeRight = "/user/knee/right";
		public const string k_pchPathUserWristLeft = "/user/wrist/left";
		public const string k_pchPathUserWristRight = "/user/wrist/right";
		public const string k_pchPathUserAnkleLeft = "/user/ankle/left";
		public const string k_pchPathUserAnkleRight = "/user/ankle/right";
		public const string k_pchPathUserWaist = "/user/waist";
		public const string k_pchPathUserChest = "/user/chest";
		public const string k_pchPathUserCamera = "/user/camera";
		public const string k_pchPathUserKeyboard = "/user/keyboard";
		public const string k_pchPathClientAppKey = "/client_info/app_key";
		public const ulong k_ulInvalidPathHandle = 0;
		public const string IVRPaths_Version = "IVRPaths_001";
		public const string IVRBlockQueue_Version = "IVRBlockQueue_005";

		static uint VRToken { get; set; }

		const string FnTable_Prefix = "FnTable:";

		class COpenVRContext
		{
			public COpenVRContext() { Clear(); }

			public void Clear()
			{
				m_pVRSystem = null;
				m_pVRChaperone = null;
				m_pVRChaperoneSetup = null;
				m_pVRCompositor = null;
				m_pVRHeadsetView = null;
				m_pVROverlay = null;
				m_pVROverlayView = null;
				m_pVRRenderModels = null;
				m_pVRExtendedDisplay = null;
				m_pVRSettings = null;
				m_pVRApplications = null;
				m_pVRScreenshots = null;
				m_pVRTrackedCamera = null;
				m_pVRInput = null;
				m_pVRIOBuffer = null;
				m_pVRSpatialAnchors = null;
				m_pVRNotifications = null;
				m_pVRDebug = null;
			}

			void CheckClear()
			{
				if (VRToken != GetInitToken())
				{
					Clear();
					VRToken = GetInitToken();
				}
			}

			public CVRSystem VRSystem()
			{
				CheckClear();
				if (m_pVRSystem == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRSystem_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRSystem = new CVRSystem(pInterface);
				}
				return m_pVRSystem;
			}

			public CVRChaperone VRChaperone()
			{
				CheckClear();
				if (m_pVRChaperone == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRChaperone_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRChaperone = new CVRChaperone(pInterface);
				}
				return m_pVRChaperone;
			}

			public CVRChaperoneSetup VRChaperoneSetup()
			{
				CheckClear();
				if (m_pVRChaperoneSetup == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRChaperoneSetup_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRChaperoneSetup = new CVRChaperoneSetup(pInterface);
				}
				return m_pVRChaperoneSetup;
			}

			public CVRCompositor VRCompositor()
			{
				CheckClear();
				if (m_pVRCompositor == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRCompositor_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRCompositor = new CVRCompositor(pInterface);
				}
				return m_pVRCompositor;
			}

			public CVRHeadsetView VRHeadsetView()
			{
				CheckClear();
				if (m_pVRHeadsetView == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRHeadsetView_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRHeadsetView = new CVRHeadsetView(pInterface);
				}
				return m_pVRHeadsetView;
			}

			public CVROverlay VROverlay()
			{
				CheckClear();
				if (m_pVROverlay == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVROverlay_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVROverlay = new CVROverlay(pInterface);
				}
				return m_pVROverlay;
			}

			public CVROverlayView VROverlayView()
			{
				CheckClear();
				if (m_pVROverlayView == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVROverlayView_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVROverlayView = new CVROverlayView(pInterface);
				}
				return m_pVROverlayView;
			}

			public CVRRenderModels VRRenderModels()
			{
				CheckClear();
				if (m_pVRRenderModels == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRRenderModels_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRRenderModels = new CVRRenderModels(pInterface);
				}
				return m_pVRRenderModels;
			}

			public CVRExtendedDisplay VRExtendedDisplay()
			{
				CheckClear();
				if (m_pVRExtendedDisplay == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRExtendedDisplay_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRExtendedDisplay = new CVRExtendedDisplay(pInterface);
				}
				return m_pVRExtendedDisplay;
			}

			public CVRSettings VRSettings()
			{
				CheckClear();
				if (m_pVRSettings == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRSettings_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRSettings = new CVRSettings(pInterface);
				}
				return m_pVRSettings;
			}

			public CVRApplications VRApplications()
			{
				CheckClear();
				if (m_pVRApplications == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRApplications_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRApplications = new CVRApplications(pInterface);
				}
				return m_pVRApplications;
			}

			public CVRScreenshots VRScreenshots()
			{
				CheckClear();
				if (m_pVRScreenshots == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRScreenshots_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRScreenshots = new CVRScreenshots(pInterface);
				}
				return m_pVRScreenshots;
			}

			public CVRTrackedCamera VRTrackedCamera()
			{
				CheckClear();
				if (m_pVRTrackedCamera == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRTrackedCamera_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRTrackedCamera = new CVRTrackedCamera(pInterface);
				}
				return m_pVRTrackedCamera;
			}

			public CVRInput VRInput()
			{
				CheckClear();
				if (m_pVRInput == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRInput_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRInput = new CVRInput(pInterface);
				}
				return m_pVRInput;
			}

			public CVRIOBuffer VRIOBuffer()
			{
				CheckClear();
				if (m_pVRIOBuffer == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRIOBuffer_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRIOBuffer = new CVRIOBuffer(pInterface);
				}
				return m_pVRIOBuffer;
			}

			public CVRSpatialAnchors VRSpatialAnchors()
			{
				CheckClear();
				if (m_pVRSpatialAnchors == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRSpatialAnchors_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRSpatialAnchors = new CVRSpatialAnchors(pInterface);
				}
				return m_pVRSpatialAnchors;
			}

			public CVRDebug VRDebug()
			{
				CheckClear();
				if (m_pVRDebug == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRDebug_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRDebug = new CVRDebug(pInterface);
				}
				return m_pVRDebug;
			}

			public CVRNotifications VRNotifications()
			{
				CheckClear();
				if (m_pVRNotifications == null)
				{
					var eError = EVRInitError.None;
					var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix + IVRNotifications_Version, ref eError);
					if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
						m_pVRNotifications = new CVRNotifications(pInterface);
				}
				return m_pVRNotifications;
			}

			private CVRSystem m_pVRSystem;
			private CVRChaperone m_pVRChaperone;
			private CVRChaperoneSetup m_pVRChaperoneSetup;
			private CVRCompositor m_pVRCompositor;
			private CVRHeadsetView m_pVRHeadsetView;
			private CVROverlay m_pVROverlay;
			private CVROverlayView m_pVROverlayView;
			private CVRRenderModels m_pVRRenderModels;
			private CVRExtendedDisplay m_pVRExtendedDisplay;
			private CVRSettings m_pVRSettings;
			private CVRApplications m_pVRApplications;
			private CVRScreenshots m_pVRScreenshots;
			private CVRTrackedCamera m_pVRTrackedCamera;
			private CVRInput m_pVRInput;
			private CVRIOBuffer m_pVRIOBuffer;
			private CVRSpatialAnchors m_pVRSpatialAnchors;
			private CVRNotifications m_pVRNotifications;
			private CVRDebug m_pVRDebug;
		};

		private static COpenVRContext _OpenVRInternal_ModuleContext = null;
		static COpenVRContext OpenVRInternal_ModuleContext
		{
			get
			{
				if (_OpenVRInternal_ModuleContext == null)
					_OpenVRInternal_ModuleContext = new COpenVRContext();
				return _OpenVRInternal_ModuleContext;
			}
		}

		public static CVRSystem System { get { return OpenVRInternal_ModuleContext.VRSystem(); } }
		public static CVRChaperone Chaperone { get { return OpenVRInternal_ModuleContext.VRChaperone(); } }
		public static CVRChaperoneSetup ChaperoneSetup { get { return OpenVRInternal_ModuleContext.VRChaperoneSetup(); } }
		public static CVRCompositor Compositor { get { return OpenVRInternal_ModuleContext.VRCompositor(); } }
		public static CVRHeadsetView HeadsetView { get { return OpenVRInternal_ModuleContext.VRHeadsetView(); } }
		public static CVROverlay Overlay { get { return OpenVRInternal_ModuleContext.VROverlay(); } }
		public static CVROverlayView OverlayView { get { return OpenVRInternal_ModuleContext.VROverlayView(); } }
		public static CVRRenderModels RenderModels { get { return OpenVRInternal_ModuleContext.VRRenderModels(); } }
		public static CVRExtendedDisplay ExtendedDisplay { get { return OpenVRInternal_ModuleContext.VRExtendedDisplay(); } }
		public static CVRSettings Settings { get { return OpenVRInternal_ModuleContext.VRSettings(); } }
		public static CVRApplications Applications { get { return OpenVRInternal_ModuleContext.VRApplications(); } }
		public static CVRScreenshots Screenshots { get { return OpenVRInternal_ModuleContext.VRScreenshots(); } }
		public static CVRTrackedCamera TrackedCamera { get { return OpenVRInternal_ModuleContext.VRTrackedCamera(); } }
		public static CVRInput Input { get { return OpenVRInternal_ModuleContext.VRInput(); } }
		public static CVRIOBuffer IOBuffer { get { return OpenVRInternal_ModuleContext.VRIOBuffer(); } }
		public static CVRSpatialAnchors SpatialAnchors { get { return OpenVRInternal_ModuleContext.VRSpatialAnchors(); } }
		public static CVRNotifications Notifications { get { return OpenVRInternal_ModuleContext.VRNotifications(); } }
		public static CVRDebug Debug { get { return OpenVRInternal_ModuleContext.VRDebug(); } }


		/** Finds the active installation of vrclient.dll and initializes it */
		public static CVRSystem Init(ref EVRInitError peError, EVRApplicationType eApplicationType = EVRApplicationType.VRApplication_Scene, string pchStartupInfo = "")
		{
			try
			{
				VRToken = InitInternal2(ref peError, eApplicationType, pchStartupInfo);
			}
			catch (EntryPointNotFoundException)
			{
				VRToken = InitInternal(ref peError, eApplicationType);
			}

			OpenVRInternal_ModuleContext.Clear();

			if (peError != EVRInitError.None)
				return null;

			bool bInterfaceValid = IsInterfaceVersionValid(IVRSystem_Version);
			if (!bInterfaceValid)
			{
				ShutdownInternal();
				peError = EVRInitError.Init_InterfaceNotFound;
				return null;
			}

			return OpenVR.System;
		}

		/** unloads vrclient.dll. Any interface pointers from the interface are
		* invalid after this point */
		public static void Shutdown()
		{
			ShutdownInternal();
		}

	}



}
#endif
