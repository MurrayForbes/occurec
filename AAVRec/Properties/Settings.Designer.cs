﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AAVRec.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string OutputLocation {
            get {
                return ((string)(this["OutputLocation"]));
            }
            set {
                this["OutputLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CameraModel {
            get {
                return ((string)(this["CameraModel"]));
            }
            set {
                this["CameraModel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PreferredCaptureDevice {
            get {
                return ((string)(this["PreferredCaptureDevice"]));
            }
            set {
                this["PreferredCaptureDevice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("R")]
        public global::AAVRec.Helpers.LumaConversionMode MonochromePixelsType {
            get {
                return ((global::AAVRec.Helpers.LumaConversionMode)(this["MonochromePixelsType"]));
            }
            set {
                this["MonochromePixelsType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AAV")]
        public string FileFormat {
            get {
                return ((string)(this["FileFormat"]));
            }
            set {
                this["FileFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PreferredCompressorDevice {
            get {
                return ((string)(this["PreferredCompressorDevice"]));
            }
            set {
                this["PreferredCompressorDevice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsIntegrating {
            get {
                return ((bool)(this["IsIntegrating"]));
            }
            set {
                this["IsIntegrating"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FlipVertically {
            get {
                return ((bool)(this["FlipVertically"]));
            }
            set {
                this["FlipVertically"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FlipHorizontally {
            get {
                return ((bool)(this["FlipHorizontally"]));
            }
            set {
                this["FlipHorizontally"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public double SignatureDiffFactorEx2 {
            get {
                return ((double)(this["SignatureDiffFactorEx2"]));
            }
            set {
                this["SignatureDiffFactorEx2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UsesTunerCrossbar {
            get {
                return ((bool)(this["UsesTunerCrossbar"]));
            }
            set {
                this["UsesTunerCrossbar"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int CrossbarInputPin {
            get {
                return ((int)(this["CrossbarInputPin"]));
            }
            set {
                this["CrossbarInputPin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int CrossbarOutputPin {
            get {
                return ((int)(this["CrossbarOutputPin"]));
            }
            set {
                this["CrossbarOutputPin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool VideoGraphDebugMode {
            get {
                return ((bool)(this["VideoGraphDebugMode"]));
            }
            set {
                this["VideoGraphDebugMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.2")]
        public float MinSignatureDiff {
            get {
                return ((float)(this["MinSignatureDiff"]));
            }
            set {
                this["MinSignatureDiff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayTimeInUT {
            get {
                return ((bool)(this["DisplayTimeInUT"]));
            }
            set {
                this["DisplayTimeInUT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SimulatorFilePath {
            get {
                return ((string)(this["SimulatorFilePath"]));
            }
            set {
                this["SimulatorFilePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public float SimulatorFrameRate {
            get {
                return ((float)(this["SimulatorFrameRate"]));
            }
            set {
                this["SimulatorFrameRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string OcrDebugOutputFolder {
            get {
                return ((string)(this["OcrDebugOutputFolder"]));
            }
            set {
                this["OcrDebugOutputFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OcrCameraTestModeAvi {
            get {
                return ((bool)(this["OcrCameraTestModeAvi"]));
            }
            set {
                this["OcrCameraTestModeAvi"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OcrSimulatorTestMode {
            get {
                return ((bool)(this["OcrSimulatorTestMode"]));
            }
            set {
                this["OcrSimulatorTestMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string FileNameFormat {
            get {
                return ((string)(this["FileNameFormat"]));
            }
            set {
                this["FileNameFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SimulatorRunOCR {
            get {
                return ((bool)(this["SimulatorRunOCR"]));
            }
            set {
                this["SimulatorRunOCR"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int OcrMaxErrorsPerCameraTestRun {
            get {
                return ((int)(this["OcrMaxErrorsPerCameraTestRun"]));
            }
            set {
                this["OcrMaxErrorsPerCameraTestRun"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OcrCameraTestModeAav {
            get {
                return ((bool)(this["OcrCameraTestModeAav"]));
            }
            set {
                this["OcrCameraTestModeAav"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CompressedRaw")]
        public global::AAVRec.Helpers.AavImageLayout AavImageLayout {
            get {
                return ((global::AAVRec.Helpers.AavImageLayout)(this["AavImageLayout"]));
            }
            set {
                this["AavImageLayout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("time.windows.com")]
        public string NTPServer {
            get {
                return ((string)(this["NTPServer"]));
            }
            set {
                this["NTPServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OcrSimulatorNativeCode {
            get {
                return ((bool)(this["OcrSimulatorNativeCode"]));
            }
            set {
                this["OcrSimulatorNativeCode"] = value;
            }
        }
    }
}
