﻿using System;
using static Vanara.PInvoke.Ole32;

namespace Vanara.PInvoke;

public static partial class FunDisc
{
#pragma warning disable CS1591
	/* 08c0c253-a154-4746-9005-82de5317148b */
	public static readonly PROPERTYKEY PKEY_FunctionInstance = new PROPERTYKEY(new Guid(0x08c0c253, 0xa154, 0x4746, 0x90, 0x05, 0x82, 0xde, 0x53, 0x17, 0x14, 0x8b), 0x00000001);  // VT_UNKNOWN

	// FMTID_FD = {904b03a2-471d-423c-a584-f3483238a146}
	public static readonly Guid FMTID_FD = new Guid(0x904b03a2, 0x471d, 0x423c, 0xa5, 0x84, 0xf3, 0x48, 0x32, 0x38, 0xa1, 0x46);
	public static readonly PROPERTYKEY PKEY_FD_Visibility = new PROPERTYKEY(new Guid(0x904b03a2, 0x471d, 0x423c, 0xa5, 0x84, 0xf3, 0x48, 0x32, 0x38, 0xa1, 0x46), 0x00000001); //    VT_UINT

	public const int FD_Visibility_Default = 0;
	public const int FD_Visibility_Hidden = 1;

	// FMTID_Device = {78C34FC8-104A-4aca-9EA4-524D52996E57}
	public static readonly Guid FMTID_Device = new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57);

	public static readonly PROPERTYKEY PKEY_Device_NotPresent = new PROPERTYKEY(new Guid(0x904b03a2, 0x471d, 0x423c, 0xa5, 0x84, 0xf3, 0x48, 0x32, 0x38, 0xa1, 0x46), 0x00000002); //    VT_UINT
	public static readonly PROPERTYKEY PKEY_Device_QueueSize = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000024); //    VT_UI4
	public static readonly PROPERTYKEY PKEY_Device_Status = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000025); //    VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_Device_Comment = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000026); //    VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_Device_Model = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000027); //    VT_LPWSTR

	// FMTID_Device = {53808008-07BB-4661-BC3C-B5953E708560}
	public static readonly Guid FMTID_DeviceInterface = new Guid(0x53808008, 0x07BB, 0x4661, 0xBC, 0x3C, 0xB5, 0x95, 0x3E, 0x70, 0x85, 0x60);

	public static readonly PROPERTYKEY PKEY_DeviceInterface_DevicePath = new PROPERTYKEY(new Guid(0x53808008, 0x07BB, 0x4661, 0xBC, 0x3C, 0xB5, 0x95, 0x3E, 0x70, 0x85, 0x60), 0x00000001); //    VT_LPWSTR

	public static readonly PROPERTYKEY PKEY_DeviceDisplay_Address = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000033);  // VT_LPWSTR or VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_DiscoveryMethod = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000034);  // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsEncrypted = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000035);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsAuthenticated = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000036);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsConnected = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000037);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsPaired = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000038);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_Icon = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000039);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_Version = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000041);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_Last_Seen = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000042);  // VT_FIELTIME
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_Last_Connected = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000043);  // VT_FILETIME
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsShowInDisconnectedState = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000044);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsLocalMachine = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000046);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_MetadataPath = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000047);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsMetadataSearchInProgress = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000048);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_MetadataChecksum = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000049);  // VT_UI1 | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsNotInterestingForDisplay = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x0000004A);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_LaunchDeviceStageOnDeviceConnect = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x0000004C);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_LaunchDeviceStageFromExplorer = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x0000004D);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_BaselineExperienceId = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x0000004E);  // VT_CLSID
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsDeviceUniquelyIdentifiable = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x0000004F);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_AssociationArray = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000050);  // VT_LPWSTR  | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_DeviceDescription1 = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000051);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_DeviceDescription2 = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000052);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsNotWorkingProperly = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000053);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsSharedDevice = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000054);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsNetworkDevice = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000055);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_IsDefaultDevice = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000056);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_MetadataCabinet = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000057);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_RequiresPairingElevation = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000058);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_ExperienceId = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000059);  // VT_CLSID
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_Category = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x0000005A);  // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_Category_Desc_Singular = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x0000005B);  // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_Category_Desc_Plural = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x0000005C);  // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_Category_Icon = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x0000005D);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_CategoryGroup_Desc = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x0000005E);  // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_CategoryGroup_Icon = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x0000005F);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_PrimaryCategory = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000061);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_UnpairUninstall = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000062);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_RequiresUninstallElevation = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000063);  // VT_BOOL
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_DeviceFunctionSubRank = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000064);  // VT_UI4
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_AlwaysShowDeviceAsConnected = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000065);  // VT_BOOL

	public static readonly PROPERTYKEY PKEY_DeviceDisplay_FriendlyName = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00003000);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_Manufacturer = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00002000);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_ModelName = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00002002);  // VT_LPWSTR (localizable)
	public static readonly PROPERTYKEY PKEY_DeviceDisplay_ModelNumber = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00002003);  // VT_LPWSTR

	public static readonly PROPERTYKEY PKEY_DeviceDisplay_InstallInProgress = new PROPERTYKEY(new Guid(0x83da6326, 0x97a6, 0x4088, 0x94, 0x53, 0xa1, 0x92, 0x3f, 0x57, 0x3b, 0x29), 9);     // DEVPROP_TYPE_BOOLEAN

	// FMTID_Pairing = {8807CAE6-7DB6-4f10-8EE4-435EAA1392BC}
	public static readonly Guid FMTID_Pairing = new Guid(0x8807cae6, 0x7db6, 0x4f10, 0x8e, 0xe4, 0x43, 0x5e, 0xaa, 0x13, 0x92, 0xbc);
	public static readonly PROPERTYKEY PKEY_Pairing_ListItemText = new PROPERTYKEY(new Guid(0x8807cae6, 0x7db6, 0x4f10, 0x8e, 0xe4, 0x43, 0x5e, 0xaa, 0x13, 0x92, 0xbc), 0x0000001);        // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_Pairing_ListItemDescription = new PROPERTYKEY(new Guid(0x8807cae6, 0x7db6, 0x4f10, 0x8e, 0xe4, 0x43, 0x5e, 0xaa, 0x13, 0x92, 0xbc), 0x0000002); // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_Pairing_ListItemIcon = new PROPERTYKEY(new Guid(0x8807cae6, 0x7db6, 0x4f10, 0x8e, 0xe4, 0x43, 0x5e, 0xaa, 0x13, 0x92, 0xbc), 0x0000003);        // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_Pairing_ListItemDefault = new PROPERTYKEY(new Guid(0x8807cae6, 0x7db6, 0x4f10, 0x8e, 0xe4, 0x43, 0x5e, 0xaa, 0x13, 0x92, 0xbc), 0x0000004);     // VT_BOOL
	public static readonly PROPERTYKEY PKEY_Pairing_IsWifiOnlyDevice = new PROPERTYKEY(new Guid(0x8807cae6, 0x7db6, 0x4f10, 0x8e, 0xe4, 0x43, 0x5e, 0xaa, 0x13, 0x92, 0xbc), 0x0000010);    // VT_BOOL

	// DiscoveryMethod values
	public const string DEVICEDISPLAY_DISCOVERYMETHOD_BLUETOOTH = "Bluetooth";
	public const string DEVICEDISPLAY_DISCOVERYMETHOD_BLUETOOTH_LE = "Bluetooth Low Energy";
	public const string DEVICEDISPLAY_DISCOVERYMETHOD_NETBIOS = "NetBIOS";
	public const string DEVICEDISPLAY_DISCOVERYMETHOD_AD_PRINTER = "Published Printer";
	public const string DEVICEDISPLAY_DISCOVERYMETHOD_PNP = "PnP";
	public const string DEVICEDISPLAY_DISCOVERYMETHOD_UPNP = "UPnP";
	public const string DEVICEDISPLAY_DISCOVERYMETHOD_WSD = "WSD";
	public const string DEVICEDISPLAY_DISCOVERYMETHOD_WUSB = "WUSB";
	public const string DEVICEDISPLAY_DISCOVERYMETHOD_WFD = "WiFiDirect";
	public const string DEVICEDISPLAY_DISCOVERYMETHOD_ASP_INFRA = "AspInfra";


	//  Name:     System.Device.BIOSVersion -- PKEY_Device_BIOSVersion
	//  Type:     String -- VT_LPWSTR  (For variants: VT_BSTR)  Legacy code may treat this as VT_BSTR.
	//  FormatID: EAEE7F1D-6A33-44D1-9441-5F46DEF23198, 9
	public static readonly PROPERTYKEY PKEY_Device_BIOSVersion = new PROPERTYKEY(new Guid(0xEAEE7F1D, 0x6A33, 0x44D1, 0x94, 0x41, 0x5F, 0x46, 0xDE, 0xF2, 0x31, 0x98), 9);

	public static readonly PROPERTYKEY PKEY_Write_Time = new PROPERTYKEY(new Guid(0xf53b7e1c, 0x77e0, 0x4450, 0x8c, 0x5f, 0xa7, 0x6c, 0xc7, 0xfd, 0xe0, 0x58), 0x00000100); //    VT_FILETIME
	public static readonly PROPERTYKEY PKEY_Create_Time = new PROPERTYKEY(new Guid(0xf53b7e1c, 0x77e0, 0x4450, 0x8c, 0x5f, 0xa7, 0x6c, 0xc7, 0xfd, 0xe0, 0x58), 0x00000101); //    VT_FILETIME

	public static readonly PROPERTYKEY PKEY_Device_InstanceId = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000100); //    VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_Device_Interface = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00000101); //    VT_CLSID

	public static readonly PROPERTYKEY PKEY_ExposedIIDs = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00003002); //  VT_VECTOR | VT_CLSID
	public static readonly PROPERTYKEY PKEY_ExposedCLSIDs = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00003003); //  VT_VECTOR | VT_CLSID
	public static readonly PROPERTYKEY PKEY_InstanceValidatorClsid = new PROPERTYKEY(new Guid(0x78c34fc8, 0x104a, 0x4aca, 0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57), 0x00003004); // VT_CLSID

	// FMTID_WSD = {92506491-FF95-4724-A05A-5B81885A7C92}
	public static readonly Guid FMTID_WSD = new Guid(0x92506491, 0xFF95, 0x4724, 0xA0, 0x5A, 0x5B, 0x81, 0x88, 0x5A, 0x7C, 0x92);

	public static readonly PROPERTYKEY PKEY_WSD_AddressURI = new PROPERTYKEY(new Guid(0x92506491, 0xFF95, 0x4724, 0xA0, 0x5A, 0x5B, 0x81, 0x88, 0x5A, 0x7C, 0x92), 0x00001000);   // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_WSD_Types = new PROPERTYKEY(new Guid(0x92506491, 0xFF95, 0x4724, 0xA0, 0x5A, 0x5B, 0x81, 0x88, 0x5A, 0x7C, 0x92), 0x00001001); // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_WSD_Scopes = new PROPERTYKEY(new Guid(0x92506491, 0xFF95, 0x4724, 0xA0, 0x5A, 0x5B, 0x81, 0x88, 0x5A, 0x7C, 0x92), 0x00001002);   // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_WSD_MetadataVersion = new PROPERTYKEY(new Guid(0x92506491, 0xFF95, 0x4724, 0xA0, 0x5A, 0x5B, 0x81, 0x88, 0x5A, 0x7C, 0x92), 0x00001003); //VT_UI8
	public static readonly PROPERTYKEY PKEY_WSD_AppSeqInstanceID = new PROPERTYKEY(new Guid(0x92506491, 0xFF95, 0x4724, 0xA0, 0x5A, 0x5B, 0x81, 0x88, 0x5A, 0x7C, 0x92), 0x00001004);   // VT_UI8
	public static readonly PROPERTYKEY PKEY_WSD_AppSeqSessionID = new PROPERTYKEY(new Guid(0x92506491, 0xFF95, 0x4724, 0xA0, 0x5A, 0x5B, 0x81, 0x88, 0x5A, 0x7C, 0x92), 0x00001005); // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_WSD_AppSeqMessageNumber = new PROPERTYKEY(new Guid(0x92506491, 0xFF95, 0x4724, 0xA0, 0x5A, 0x5B, 0x81, 0x88, 0x5A, 0x7C, 0x92), 0x00001006); // VT_UI8
	public static readonly PROPERTYKEY PKEY_WSD_XAddrs = new PROPERTYKEY(new Guid(0x92506491, 0xFF95, 0x4724, 0xA0, 0x5A, 0x5B, 0x81, 0x88, 0x5A, 0x7C, 0x92), 0x00002000); // VT_LPWSTR or VT_VECTOR | VT_LPWSTR

	public static readonly PROPERTYKEY PKEY_WSD_MetadataClean = new PROPERTYKEY(new Guid(0x92506491, 0xFF95, 0x4724, 0xA0, 0x5A, 0x5B, 0x81, 0x88, 0x5A, 0x7C, 0x92), 0x00000001);   // VT_BOOL
	public static readonly PROPERTYKEY PKEY_WSD_ServiceInfo = new PROPERTYKEY(new Guid(0x92506491, 0xFF95, 0x4724, 0xA0, 0x5A, 0x5B, 0x81, 0x88, 0x5A, 0x7C, 0x92), 0x00000002);   // VT_VECTOR|VT_VARIANT (variants are VT_UNKNOWN)

	public static readonly PROPERTYKEY PKEY_PUBSVCS_TYPE = new PROPERTYKEY(new Guid(0xF1B88AD3, 0x109C, 0x4FD2, 0xBA, 0x3F, 0x53, 0x5A, 0x76, 0x5F, 0x82, 0xF4), 0x00005001); // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PUBSVCS_SCOPE = new PROPERTYKEY(new Guid(0x2AE2B567, 0xEECB, 0x4A3E, 0xB7, 0x53, 0x54, 0xC7, 0x25, 0x49, 0x43, 0x66), 0x00005002);   // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_PUBSVCS_METADATA = new PROPERTYKEY(new Guid(0x63C6D5B8, 0xF73A, 0x4ACA, 0x96, 0x7E, 0x0C, 0xC7, 0x87, 0xE0, 0xB5, 0x59), 0x00005003); // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PUBSVCS_METADATA_VERSION = new PROPERTYKEY(new Guid(0xC0C96C15, 0x1823, 0x4E5B, 0x93, 0x48, 0xE8, 0x25, 0x19, 0x92, 0x3F, 0x04), 0x00005004); // VT_UI8
	public static readonly PROPERTYKEY PKEY_PUBSVCS_NETWORK_PROFILES_ALLOWED = new PROPERTYKEY(new Guid(0x63C6D5B8, 0xF73A, 0x4ACA, 0x96, 0x7E, 0x0C, 0xC7, 0x87, 0xE0, 0xB5, 0x59), 0x00005005); // VT_VECTOR | VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PUBSVCS_NETWORK_PROFILES_DENIED = new PROPERTYKEY(new Guid(0x63C6D5B8, 0xF73A, 0x4ACA, 0x96, 0x7E, 0x0C, 0xC7, 0x87, 0xE0, 0xB5, 0x59), 0x00005006); // VT_VECTOR | VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PUBSVCS_NETWORK_PROFILES_DEFAULT = new PROPERTYKEY(new Guid(0x63C6D5B8, 0xF73A, 0x4ACA, 0x96, 0x7E, 0x0C, 0xC7, 0x87, 0xE0, 0xB5, 0x59), 0x00005007); // VT_BOOL

	// FMTID_PNPX = {656A3BB3-ECC0-43FD-8477-4AE0404A96CD}
	public static readonly Guid FMTID_PNPX = new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD);
	// from Discovery messages
	public static readonly PROPERTYKEY PKEY_PNPX_GlobalIdentity = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00001000);   // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PNPX_Types = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00001001);   // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_PNPX_Scopes = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00001002);   // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_PNPX_XAddrs = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00001003);   // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_PNPX_MetadataVersion = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00001004);   // VT_UI8
	public static readonly PROPERTYKEY PKEY_PNPX_ID = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00001005);   // VT_LPWSTR

	// for Directed Discovery
	public static readonly PROPERTYKEY PKEY_PNPX_RemoteAddress = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00001006);   // VT_LPWSTR
																																													  // for installable ssdp root devices
	public static readonly PROPERTYKEY PKEY_PNPX_RootProxy = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00001007);   // VT_BOOL


	// from ThisModel metadata
	public static readonly PROPERTYKEY PKEY_PNPX_ManufacturerUrl = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00002001);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PNPX_ModelUrl = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00002004);  // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PNPX_Upc = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00002005);   // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PNPX_PresentationUrl = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00002006);   // VT_LPWSTR
																																														// from ThisDevice metadata
	public static readonly PROPERTYKEY PKEY_PNPX_FirmwareVersion = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00003001);   // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PNPX_SerialNumber = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00003002);   // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PNPX_DeviceCategory = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00003004);  // VT_LPWSTR | VT_VECTOR

	// for secure devices
	public static readonly PROPERTYKEY PKEY_PNPX_SecureChannel = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00007001);   // VT_BOOL
	public static readonly PROPERTYKEY PKEY_PNPX_CompactSignature = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00007002);   // VT_BOOL
	public static readonly PROPERTYKEY PKEY_PNPX_DeviceCertHash = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00007003);   // VT_LPWSTR


	// DeviceCategory values
	public const string PNPX_DEVICECATEGORY_COMPUTER = "Computers";
	public const string PNPX_DEVICECATEGORY_INPUTDEVICE = "Input";
	public const string PNPX_DEVICECATEGORY_PRINTER = "Printers";
	public const string PNPX_DEVICECATEGORY_SCANNER = "Scanners";
	public const string PNPX_DEVICECATEGORY_FAX = "FAX";
	public const string PNPX_DEVICECATEGORY_MFP = "MFP";
	public const string PNPX_DEVICECATEGORY_CAMERA = "Cameras";
	public const string PNPX_DEVICECATEGORY_STORAGE = "Storage";
	public const string PNPX_DEVICECATEGORY_NETWORK_INFRASTRUCTURE = "NetworkInfrastructure";
	public const string PNPX_DEVICECATEGORY_DISPLAYS = "Displays";
	public const string PNPX_DEVICECATEGORY_MULTIMEDIA_DEVICE = "MediaDevices";
	public const string PNPX_DEVICECATEGORY_GAMING_DEVICE = "Gaming";
	public const string PNPX_DEVICECATEGORY_TELEPHONE = "Phones";
	public const string PNPX_DEVICECATEGORY_HOME_AUTOMATION_SYSTEM = "HomeAutomation";
	public const string PNPX_DEVICECATEGORY_HOME_SECURITY_SYSTEM = "HomeSecurity";
	public const string PNPX_DEVICECATEGORY_OTHER = "Other";

	public static readonly PROPERTYKEY PKEY_PNPX_DeviceCategory_Desc = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00003005);   // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_PNPX_Category_Desc_NonPlural = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00003010);   // VT_LPWSTR | VT_VECTOR

	public static readonly PROPERTYKEY PKEY_PNPX_PhysicalAddress = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00003006);   // VT_UI1 | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_PNPX_NetworkInterfaceLuid = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00003007);   // VT_UI8
	public static readonly PROPERTYKEY PKEY_PNPX_NetworkInterfaceGuid = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00003008);   // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PNPX_IpAddress = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00003009);   // VT_LPWSTR | VT_VECTOR
																																												  // from Relationship metadata
	public static readonly PROPERTYKEY PKEY_PNPX_ServiceAddress = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00004000);   // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_PNPX_ServiceId = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00004001);   // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PNPX_ServiceTypes = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00004002);   // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_PNPX_ServiceControlUrl = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x4004);    // VT_LPWSTR 
	public static readonly PROPERTYKEY PKEY_PNPX_ServiceDescUrl = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x4005);    // VT_LPWSTR 
	public static readonly PROPERTYKEY PKEY_PNPX_ServiceEventSubUrl = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x4006);    // VT_LPWSTR 

	// Association DB PKEYs
	public static readonly PROPERTYKEY PKEY_PNPX_Devnode = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00000001); // VT_BOOL
	public static readonly PROPERTYKEY PKEY_PNPX_AssociationState = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00000002); // VT_UINT
	public static readonly PROPERTYKEY PKEY_PNPX_AssociatedInstanceId = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00000003); // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PNPX_LastNotificationTime = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00000004); // VT_DATE
																																														   // for Computer Discovery
	public static readonly PROPERTYKEY PKEY_PNPX_DomainName = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00005000);   // VT_LPWSTR
																																												   // Use PKEY_ComputerName (propkey.h)
	public static readonly PROPERTYKEY PKEY_PNPX_MachineName = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00005001);   // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_PNPX_ShareName = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00005002);   // VT_LPWSTR

	// SSDP Provider custom properties
	public static readonly PROPERTYKEY PKEY_SSDP_AltLocationInfo = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00006000);   // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_SSDP_DevLifeTime = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00006001);   // VT_UI4
	public static readonly PROPERTYKEY PKEY_SSDP_NetworkInterface = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00006002);   // VT_BOOL

	// FMTID_PNPXDynamicProperty = {4FC5077E-B686-44BE-93E3-86CAFE368CCD}
	public static readonly Guid FMTID_PNPXDynamicProperty = new Guid(0x4FC5077E, 0xB686, 0x44BE, 0x93, 0xE3, 0x86, 0xCA, 0xFE, 0x36, 0x8C, 0xCD);

	public static readonly PROPERTYKEY PKEY_PNPX_Installable = new PROPERTYKEY(new Guid(0x4FC5077E, 0xB686, 0x44BE, 0x93, 0xE3, 0x86, 0xCA, 0xFE, 0x36, 0x8C, 0xCD), 0x00000001); // VT_BOOL
	public static readonly PROPERTYKEY PKEY_PNPX_Associated = new PROPERTYKEY(new Guid(0x4FC5077E, 0xB686, 0x44BE, 0x93, 0xE3, 0x86, 0xCA, 0xFE, 0x36, 0x8C, 0xCD), 0x00000002); // VT_BOOL
																																												 // PKEY_PNPX_Installed is deprecated this PKEY really represents Associated state
	public static readonly PROPERTYKEY PKEY_PNPX_CompatibleTypes = new PROPERTYKEY(new Guid(0x4FC5077E, 0xB686, 0x44BE, 0x93, 0xE3, 0x86, 0xCA, 0xFE, 0x36, 0x8C, 0xCD), 0x00000003); // VT_LPWSTR | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_PNPX_InstallState = new PROPERTYKEY(new Guid(0x4FC5077E, 0xB686, 0x44BE, 0x93, 0xE3, 0x86, 0xCA, 0xFE, 0x36, 0x8C, 0xCD), 0x00000004); // VT_UI4 | VT_VECTOR

	public const int PNPX_INSTALLSTATE_NOTINSTALLED = 0;   // vector length = 1

	public const int PNPX_INSTALLSTATE_INSTALLED = 1;   // vector length = 3, CM_Get_DevNode_Status in 2nd and 3rd elements

	public const int PNPX_INSTALLSTATE_INSTALLING = 2;   // vector length = 1 or 3, CM_Get_DevNode_Status in 2nd and 3rd elements if available

	public const int PNPX_INSTALLSTATE_FAILED = 3;   // vector length = 3, CM_Get_DevNode_Status in 2nd and 3rd elements


	// Other
	public static readonly PROPERTYKEY PKEY_PNPX_Removable = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00007000);   // VT_BOOL
	public static readonly PROPERTYKEY PKEY_PNPX_IPBusEnumerated = new PROPERTYKEY(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD), 0x00007010);   // VT_BOOL

	// WNET Provider properties
	public static readonly PROPERTYKEY PKEY_WNET_Scope = new PROPERTYKEY(new Guid(0xdebda43a, 0x37b3, 0x4383, 0x91, 0xE7, 0x44, 0x98, 0xda, 0x29, 0x95, 0xab), 0x00000001); // VT_UINT
	public static readonly PROPERTYKEY PKEY_WNET_Type = new PROPERTYKEY(new Guid(0xdebda43a, 0x37b3, 0x4383, 0x91, 0xE7, 0x44, 0x98, 0xda, 0x29, 0x95, 0xab), 0x00000002); // VT_UINT
	public static readonly PROPERTYKEY PKEY_WNET_DisplayType = new PROPERTYKEY(new Guid(0xdebda43a, 0x37b3, 0x4383, 0x91, 0xE7, 0x44, 0x98, 0xda, 0x29, 0x95, 0xab), 0x00000003); // VT_UINT
	public static readonly PROPERTYKEY PKEY_WNET_Usage = new PROPERTYKEY(new Guid(0xdebda43a, 0x37b3, 0x4383, 0x91, 0xE7, 0x44, 0x98, 0xda, 0x29, 0x95, 0xab), 0x00000004); // VT_UINT
	public static readonly PROPERTYKEY PKEY_WNET_LocalName = new PROPERTYKEY(new Guid(0xdebda43a, 0x37b3, 0x4383, 0x91, 0xE7, 0x44, 0x98, 0xda, 0x29, 0x95, 0xab), 0x00000005); // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_WNET_RemoteName = new PROPERTYKEY(new Guid(0xdebda43a, 0x37b3, 0x4383, 0x91, 0xE7, 0x44, 0x98, 0xda, 0x29, 0x95, 0xab), 0x00000006); // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_WNET_Comment = new PROPERTYKEY(new Guid(0xdebda43a, 0x37b3, 0x4383, 0x91, 0xE7, 0x44, 0x98, 0xda, 0x29, 0x95, 0xab), 0x00000007); // VT_LPWSTR
	public static readonly PROPERTYKEY PKEY_WNET_Provider = new PROPERTYKEY(new Guid(0xdebda43a, 0x37b3, 0x4383, 0x91, 0xE7, 0x44, 0x98, 0xda, 0x29, 0x95, 0xab), 0x00000008); // VT_LPWSTR


	// WCN Provider properties

	public static readonly PROPERTYKEY PKEY_WCN_Version = new PROPERTYKEY(new Guid(0x88190b80, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x00000001); // VT_UI1
	public static readonly PROPERTYKEY PKEY_WCN_RequestType = new PROPERTYKEY(new Guid(0x88190b81, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x00000002); // VT_INT
	public static readonly PROPERTYKEY PKEY_WCN_AuthType = new PROPERTYKEY(new Guid(0x88190b82, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x00000003); // VT_INT
	public static readonly PROPERTYKEY PKEY_WCN_EncryptType = new PROPERTYKEY(new Guid(0x88190b83, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x00000004); // VT_INT
	public static readonly PROPERTYKEY PKEY_WCN_ConnType = new PROPERTYKEY(new Guid(0x88190b84, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x00000005); // VT_INT
	public static readonly PROPERTYKEY PKEY_WCN_ConfigMethods = new PROPERTYKEY(new Guid(0x88190b85, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x00000006); // VT_INT
																																												   // map WCN DeviceType to PKEY_PNPX_DeviceCategory
																																												   //public static readonly PROPERTYKEY PKEY_WCN_DeviceType = new PROPERTYKEY(new Guid(0x88190b86, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x00000007); // VT_INT
	public static readonly PROPERTYKEY PKEY_WCN_RfBand = new PROPERTYKEY(new Guid(0x88190b87, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x00000008); // VT_INT
	public static readonly PROPERTYKEY PKEY_WCN_AssocState = new PROPERTYKEY(new Guid(0x88190b88, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x00000009); // VT_INT
	public static readonly PROPERTYKEY PKEY_WCN_ConfigError = new PROPERTYKEY(new Guid(0x88190b89, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x0000000a); // VT_INT
	public static readonly PROPERTYKEY PKEY_WCN_ConfigState = new PROPERTYKEY(new Guid(0x88190b89, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x0000000b); // VT_UI1
	public static readonly PROPERTYKEY PKEY_WCN_DevicePasswordId = new PROPERTYKEY(new Guid(0x88190b89, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x0000000c); // VT_INT
	public static readonly PROPERTYKEY PKEY_WCN_OSVersion = new PROPERTYKEY(new Guid(0x88190b89, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x0000000d); // VT_UINT
	public static readonly PROPERTYKEY PKEY_WCN_VendorExtension = new PROPERTYKEY(new Guid(0x88190b8a, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x0000000e); // VT_UI1 | VT_VECTOR
	public static readonly PROPERTYKEY PKEY_WCN_RegistrarType = new PROPERTYKEY(new Guid(0x88190b8b, 0x4684, 0x11da, 0xa2, 0x6a, 0x00, 0x02, 0xb3, 0x98, 0x8e, 0x81), 0x0000000f); // VT_INT

	//-----------------------------------------------------------------------------
	// Hardware properties

	public static readonly PROPERTYKEY PKEY_Hardware_Devinst = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 4097);

	//  Name:     System.Hardware.DisplayAttribute -- PKEY_Hardware_DisplayAttribute
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 5
	public static readonly PROPERTYKEY PKEY_Hardware_DisplayAttribute = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 5);

	//  Name:     System.Hardware.DriverDate -- PKEY_Hardware_DriverDate
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 11
	public static readonly PROPERTYKEY PKEY_Hardware_DriverDate = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 11);

	//  Name:     System.Hardware.DriverProvider -- PKEY_Hardware_DriverProvider
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 10
	public static readonly PROPERTYKEY PKEY_Hardware_DriverProvider = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 10);

	//  Name:     System.Hardware.DriverVersion -- PKEY_Hardware_DriverVersion
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 9
	public static readonly PROPERTYKEY PKEY_Hardware_DriverVersion = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 9);

	//  Name:     System.Hardware.Function -- PKEY_Hardware_Function
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 4099
	public static readonly PROPERTYKEY PKEY_Hardware_Function = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 4099);

	//  Name:     System.Hardware.Icon -- PKEY_Hardware_Icon
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 3
	public static readonly PROPERTYKEY PKEY_Hardware_Icon = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 3);

	//  Name:     System.Hardware.Image -- PKEY_Hardware_Image
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 4098
	public static readonly PROPERTYKEY PKEY_Hardware_Image = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 4098);

	//  Name:     System.Hardware.Manufacturer -- PKEY_Hardware_Manufacturer
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 6
	public static readonly PROPERTYKEY PKEY_Hardware_Manufacturer = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 6);

	//  Name:     System.Hardware.Model -- PKEY_Hardware_Model
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 7
	public static readonly PROPERTYKEY PKEY_Hardware_Model = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 7);

	//  Name:     System.Hardware.Name -- PKEY_Hardware_Name
	//  Type:     String -- VT_LPWSTR  (For variants: VT_BSTR)
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 2
	public static readonly PROPERTYKEY PKEY_Hardware_Name = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 2);

	//  Name:     System.Hardware.SerialNumber -- PKEY_Hardware_SerialNumber
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 8
	public static readonly PROPERTYKEY PKEY_Hardware_SerialNumber = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 8);

	//  Name:     System.Hardware.ShellAttributes -- PKEY_Hardware_ShellAttributes
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 4100
	public static readonly PROPERTYKEY PKEY_Hardware_ShellAttributes = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 4100);

	//  Name:     System.Hardware.Status -- PKEY_Hardware_Status
	//  Type:     Unspecified -- VT_NULL
	//  FormatID: 5EAF3EF2-E0CA-4598-BF06-71ED1D9DD953, 4096
	public static readonly PROPERTYKEY PKEY_Hardware_Status = new PROPERTYKEY(new Guid(0x5EAF3EF2, 0xE0CA, 0x4598, 0xBF, 0x06, 0x71, 0xED, 0x1D, 0x9D, 0xD9, 0x53), 4096);
}