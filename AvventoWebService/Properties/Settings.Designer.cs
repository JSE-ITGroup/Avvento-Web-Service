﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AvventoWebService.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10.100.100.202")]
        public string ProxyIPAddress {
            get {
                return ((string)(this["ProxyIPAddress"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int MarketNumber {
            get {
                return ((int)(this["MarketNumber"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string XmlSchemas {
            get {
                return ((string)(this["XmlSchemas"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DataDownload.xsd")]
        public string DownloadDataSchemaFile {
            get {
                return ((string)(this["DownloadDataSchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SubmitOrder.xsd")]
        public string SendOrderInsertSchemaFile {
            get {
                return ((string)(this["SendOrderInsertSchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SuspendActiveOrder.xsd")]
        public string SuspendActiveOrderSchemaFile {
            get {
                return ((string)(this["SuspendActiveOrderSchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DeleteActiveOrder.xsd")]
        public string DeleteActiveOrderSchemaFile {
            get {
                return ((string)(this["DeleteActiveOrderSchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ResubmitSuspendedOrder.xsd")]
        public string ResubmitSuspendedOrderSchemaFile {
            get {
                return ((string)(this["ResubmitSuspendedOrderSchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ReduceActiveOrder.xsd")]
        public string ReduceOrderQuantitySchemaFile {
            get {
                return ((string)(this["ReduceOrderQuantitySchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CancelAllOrders.xsd")]
        public string SendCancelAllOrdersSchemaFile {
            get {
                return ((string)(this["SendCancelAllOrdersSchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("EditSuspendedOrder.xsd")]
        public string EditSuspendedOrderSchemaFile {
            get {
                return ((string)(this["EditSuspendedOrderSchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("EditActiveOrder.xsd")]
        public string EditActiveOrderSchemaFile {
            get {
                return ((string)(this["EditActiveOrderSchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SubmitBulkOrder.xsd")]
        public string SubmitBulkOrderSchemaFile {
            get {
                return ((string)(this["SubmitBulkOrderSchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        public string UseModelValidation {
            get {
                return ((string)(this["UseModelValidation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8028")]
        public string ProxyPort {
            get {
                return ((string)(this["ProxyPort"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public string WaitTime {
            get {
                return ((string)(this["WaitTime"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public string WaitRetryAttempts {
            get {
                return ((string)(this["WaitRetryAttempts"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("InstrumentSubscription.xsd")]
        public string InstrumentSubscriptionSchemaFile {
            get {
                return ((string)(this["InstrumentSubscriptionSchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("IndicesSubscription.xsd")]
        public string IndicesSubscriptionSchemaFile {
            get {
                return ((string)(this["IndicesSubscriptionSchemaFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AtsWebFeedService")]
        public string AvventoFeedServiceContract {
            get {
                return ((string)(this["AvventoFeedServiceContract"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7,8,16,89,129,146,5")]
        public string DatasetForHistoricalDataRetrieval {
            get {
                return ((string)(this["DatasetForHistoricalDataRetrieval"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://10.240.18.196/FeedWebService/FeedWebService.svc?singleWsdl")]
        public string AvventoFeedServiceWsdl {
            get {
                return ((string)(this["AvventoFeedServiceWsdl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://10.240.18.196/FeedWebService/FeedWebService.svc")]
        public string AvventoFeedServiceEndPoint {
            get {
                return ((string)(this["AvventoFeedServiceEndPoint"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public string MaxRecordCount {
            get {
                return ((string)(this["MaxRecordCount"]));
            }
        }
    }
}
