//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScpControl.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string RootHubNativeFeedHost {
            get {
                return ((string)(this["RootHubNativeFeedHost"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("26761")]
        public int RootHubNativeFeedPort {
            get {
                return ((int)(this["RootHubNativeFeedPort"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FlipAxisLx {
            get {
                return ((bool)(this["FlipAxisLx"]));
            }
            set {
                this["FlipAxisLx"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FlipAxisLy {
            get {
                return ((bool)(this["FlipAxisLy"]));
            }
            set {
                this["FlipAxisLy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FlipAxisRx {
            get {
                return ((bool)(this["FlipAxisRx"]));
            }
            set {
                this["FlipAxisRx"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FlipAxisRy {
            get {
                return ((bool)(this["FlipAxisRy"]));
            }
            set {
                this["FlipAxisRy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisableRumble {
            get {
                return ((bool)(this["DisableRumble"]));
            }
            set {
                this["DisableRumble"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisableNativeFeed {
            get {
                return ((bool)(this["DisableNativeFeed"]));
            }
            set {
                this["DisableNativeFeed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisableSecureSimplePairing {
            get {
                return ((bool)(this["DisableSecureSimplePairing"]));
            }
            set {
                this["DisableSecureSimplePairing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600000")]
        public int IdleTimeout {
            get {
                return ((int)(this["IdleTimeout"]));
            }
            set {
                this["IdleTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("128")]
        public int Ds3RumbleLatency {
            get {
                return ((int)(this["Ds3RumbleLatency"]));
            }
            set {
                this["Ds3RumbleLatency"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("128")]
        public byte Ds4LightBarBrightness {
            get {
                return ((byte)(this["Ds4LightBarBrightness"]));
            }
            set {
                this["Ds4LightBarBrightness"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Ds4Repair {
            get {
                return ((bool)(this["Ds4Repair"]));
            }
            set {
                this["Ds4Repair"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int BusId {
            get {
                return ((int)(this["BusId"]));
            }
            set {
                this["BusId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SwapTriggers {
            get {
                return ((bool)(this["SwapTriggers"]));
            }
            set {
                this["SwapTriggers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte DeadZoneL {
            get {
                return ((byte)(this["DeadZoneL"]));
            }
            set {
                this["DeadZoneL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte DeadZoneR {
            get {
                return ((byte)(this["DeadZoneR"]));
            }
            set {
                this["DeadZoneR"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DumpHidReports {
            get {
                return ((bool)(this["DumpHidReports"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("128")]
        public byte Ds4InputUpdateDelay {
            get {
                return ((byte)(this["Ds4InputUpdateDelay"]));
            }
            set {
                this["Ds4InputUpdateDelay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ForceBluetoothDriverReinstallation {
            get {
                return ((bool)(this["ForceBluetoothDriverReinstallation"]));
            }
            set {
                this["ForceBluetoothDriverReinstallation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ForceDs3DriverReinstallation {
            get {
                return ((bool)(this["ForceDs3DriverReinstallation"]));
            }
            set {
                this["ForceDs3DriverReinstallation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ForceDs4DriverReinstallation {
            get {
                return ((bool)(this["ForceDs4DriverReinstallation"]));
            }
            set {
                this["ForceDs4DriverReinstallation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SoundsEnabled {
            get {
                return ((bool)(this["SoundsEnabled"]));
            }
            set {
                this["SoundsEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Media\\startup.ogg")]
        public string StartupSoundFile {
            get {
                return ((string)(this["StartupSoundFile"]));
            }
            set {
                this["StartupSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Media\\connect.wav")]
        public string UsbConnectSoundFile {
            get {
                return ((string)(this["UsbConnectSoundFile"]));
            }
            set {
                this["UsbConnectSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Media\\disconnect.flac")]
        public string UsbDisconnectSoundFile {
            get {
                return ((string)(this["UsbDisconnectSoundFile"]));
            }
            set {
                this["UsbDisconnectSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Media\\connect.wav")]
        public string BluetoothConnectSoundFile {
            get {
                return ((string)(this["BluetoothConnectSoundFile"]));
            }
            set {
                this["BluetoothConnectSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Media\\disconnect.flac")]
        public string BluetoothDisconnectSoundFile {
            get {
                return ((string)(this["BluetoothDisconnectSoundFile"]));
            }
            set {
                this["BluetoothDisconnectSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1500")]
        public int Ds3LEDsFlashingPeriod {
            get {
                return ((int)(this["Ds3LEDsFlashingPeriod"]));
            }
            set {
                this["Ds3LEDsFlashingPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int Ds3LEDsFunction {
            get {
                return ((int)(this["Ds3LEDsFunction"]));
            }
            set {
                this["Ds3LEDsFunction"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Ds3PadIDLEDsFlashCharging {
            get {
                return ((bool)(this["Ds3PadIDLEDsFlashCharging"]));
            }
            set {
                this["Ds3PadIDLEDsFlashCharging"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Ds3LEDsCustom1 {
            get {
                return ((bool)(this["Ds3LEDsCustom1"]));
            }
            set {
                this["Ds3LEDsCustom1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Ds3LEDsCustom2 {
            get {
                return ((bool)(this["Ds3LEDsCustom2"]));
            }
            set {
                this["Ds3LEDsCustom2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Ds3LEDsCustom3 {
            get {
                return ((bool)(this["Ds3LEDsCustom3"]));
            }
            set {
                this["Ds3LEDsCustom3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Ds3LEDsCustom4 {
            get {
                return ((bool)(this["Ds3LEDsCustom4"]));
            }
            set {
                this["Ds3LEDsCustom4"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsStartupSoundEnabled {
            get {
                return ((bool)(this["IsStartupSoundEnabled"]));
            }
            set {
                this["IsStartupSoundEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsUsbConnectSoundEnabled {
            get {
                return ((bool)(this["IsUsbConnectSoundEnabled"]));
            }
            set {
                this["IsUsbConnectSoundEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsUsbDisconnectSoundEnabled {
            get {
                return ((bool)(this["IsUsbDisconnectSoundEnabled"]));
            }
            set {
                this["IsUsbDisconnectSoundEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsBluetoothConnectSoundEnabled {
            get {
                return ((bool)(this["IsBluetoothConnectSoundEnabled"]));
            }
            set {
                this["IsBluetoothConnectSoundEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsBluetoothDisconnectSoundEnabled {
            get {
                return ((bool)(this["IsBluetoothDisconnectSoundEnabled"]));
            }
            set {
                this["IsBluetoothDisconnectSoundEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Pcsx2RootPath {
            get {
                return ((string)(this["Pcsx2RootPath"]));
            }
            set {
                this["Pcsx2RootPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsPressureSensitivityModEnabled {
            get {
                return ((bool)(this["IsPressureSensitivityModEnabled"]));
            }
            set {
                this["IsPressureSensitivityModEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsVBusDisabled {
            get {
                return ((bool)(this["IsVBusDisabled"]));
            }
            set {
                this["IsVBusDisabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AlwaysUnPlugVirtualBusDevice {
            get {
                return ((bool)(this["AlwaysUnPlugVirtualBusDevice"]));
            }
            set {
                this["AlwaysUnPlugVirtualBusDevice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseAsyncHidReportProcessing {
            get {
                return ((bool)(this["UseAsyncHidReportProcessing"]));
            }
            set {
                this["UseAsyncHidReportProcessing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ProfilesEnabled {
            get {
                return ((bool)(this["ProfilesEnabled"]));
            }
            set {
                this["ProfilesEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ReservePadSlot {
            get {
                return ((bool)(this["ReservePadSlot"]));
            }
            set {
                this["ReservePadSlot"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Diagnostics.ProcessPriorityClass ServiceProcessPriority {
            get {
                return ((global::System.Diagnostics.ProcessPriorityClass)(this["ServiceProcessPriority"]));
            }
            set {
                this["ServiceProcessPriority"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Ds4ShowBatteryInfo {
            get {
                return ((bool)(this["Ds4ShowBatteryInfo"]));
            }
            set {
                this["Ds4ShowBatteryInfo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public uint Ds4ColorFull {
            get {
                return ((uint)(this["Ds4ColorFull"]));
            }
            set {
                this["Ds4ColorFull"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public uint Ds4ColorHigh {
            get {
                return ((uint)(this["Ds4ColorHigh"]));
            }
            set {
                this["Ds4ColorHigh"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public uint Ds4ColorMedium {
            get {
                return ((uint)(this["Ds4ColorMedium"]));
            }
            set {
                this["Ds4ColorMedium"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public uint Ds4ColorLow {
            get {
                return ((uint)(this["Ds4ColorLow"]));
            }
            set {
                this["Ds4ColorLow"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(ScpControl.Utilities.PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public uint Ds4ColorDying {
            get {
                return ((uint)(this["Ds4ColorDying"]));
            }
            set {
                this["Ds4ColorDying"] = value;
            }
        }
    }
}
