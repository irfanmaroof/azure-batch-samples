﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Batch.Samples.JobManager {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BatchAccountName {
            get {
                return ((string)(this["BatchAccountName"]));
            }
            set {
                this["BatchAccountName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BatchAccountKey {
            get {
                return ((string)(this["BatchAccountKey"]));
            }
            set {
                this["BatchAccountKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://(YourAccount).(region).batch.azure.com")]
        public string BatchServiceUrl {
            get {
                return ((string)(this["BatchServiceUrl"]));
            }
            set {
                this["BatchServiceUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://(Your Storage Account).blob.core.windows.net")]
        public string StorageBlobEndpoint {
            get {
                return ((string)(this["StorageBlobEndpoint"]));
            }
            set {
                this["StorageBlobEndpoint"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string StorageAccountName {
            get {
                return ((string)(this["StorageAccountName"]));
            }
            set {
                this["StorageAccountName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string StorageAccountKey {
            get {
                return ((string)(this["StorageAccountKey"]));
            }
            set {
                this["StorageAccountKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int PoolTargetNodeCount {
            get {
                return ((int)(this["PoolTargetNodeCount"]));
            }
            set {
                this["PoolTargetNodeCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("small")]
        public string PoolNodeVirtualMachineSize {
            get {
                return ((string)(this["PoolNodeVirtualMachineSize"]));
            }
            set {
                this["PoolNodeVirtualMachineSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public string PoolOSFamily {
            get {
                return ((string)(this["PoolOSFamily"]));
            }
            set {
                this["PoolOSFamily"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("JobManagerSamplePool")]
        public string PoolId {
            get {
                return ((string)(this["PoolId"]));
            }
            set {
                this["PoolId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShouldDeletePool {
            get {
                return ((bool)(this["ShouldDeletePool"]));
            }
            set {
                this["ShouldDeletePool"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShouldDeleteJob {
            get {
                return ((bool)(this["ShouldDeleteJob"]));
            }
            set {
                this["ShouldDeleteJob"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("JobManagerSampleContainer")]
        public string BlobContainer {
            get {
                return ((string)(this["BlobContainer"]));
            }
            set {
                this["BlobContainer"] = value;
            }
        }
    }
}
