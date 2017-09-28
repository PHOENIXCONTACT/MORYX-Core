﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marvin.TestTools.SystemTest.DatabaseMaintenance {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataModel", Namespace="http://schemas.datacontract.org/2004/07/Marvin.Runtime.Maintenance.Plugins.Databa" +
        "seMaintenance.Wcf")]
    [System.SerializableAttribute()]
    public partial class DataModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Marvin.TestTools.SystemTest.DatabaseMaintenance.BackupModel> BackupsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel ConfigField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Marvin.TestTools.SystemTest.DatabaseMaintenance.ScriptModel> ScriptsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Marvin.TestTools.SystemTest.DatabaseMaintenance.SetupModel> SetupsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TargetModelField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Marvin.TestTools.SystemTest.DatabaseMaintenance.BackupModel> Backups {
            get {
                return this.BackupsField;
            }
            set {
                if ((object.ReferenceEquals(this.BackupsField, value) != true)) {
                    this.BackupsField = value;
                    this.RaisePropertyChanged("Backups");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel Config {
            get {
                return this.ConfigField;
            }
            set {
                if ((object.ReferenceEquals(this.ConfigField, value) != true)) {
                    this.ConfigField = value;
                    this.RaisePropertyChanged("Config");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Marvin.TestTools.SystemTest.DatabaseMaintenance.ScriptModel> Scripts {
            get {
                return this.ScriptsField;
            }
            set {
                if ((object.ReferenceEquals(this.ScriptsField, value) != true)) {
                    this.ScriptsField = value;
                    this.RaisePropertyChanged("Scripts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Marvin.TestTools.SystemTest.DatabaseMaintenance.SetupModel> Setups {
            get {
                return this.SetupsField;
            }
            set {
                if ((object.ReferenceEquals(this.SetupsField, value) != true)) {
                    this.SetupsField = value;
                    this.RaisePropertyChanged("Setups");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TargetModel {
            get {
                return this.TargetModelField;
            }
            set {
                if ((object.ReferenceEquals(this.TargetModelField, value) != true)) {
                    this.TargetModelField = value;
                    this.RaisePropertyChanged("TargetModel");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DatabaseConfigModel", Namespace="http://schemas.datacontract.org/2004/07/Marvin.Runtime.Maintenance.Plugins.Databa" +
        "seMaintenance.Wcf")]
    [System.SerializableAttribute()]
    public partial class DatabaseConfigModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DatabaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PortField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SchemaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Database {
            get {
                return this.DatabaseField;
            }
            set {
                if ((object.ReferenceEquals(this.DatabaseField, value) != true)) {
                    this.DatabaseField = value;
                    this.RaisePropertyChanged("Database");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Port {
            get {
                return this.PortField;
            }
            set {
                if ((this.PortField.Equals(value) != true)) {
                    this.PortField = value;
                    this.RaisePropertyChanged("Port");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Schema {
            get {
                return this.SchemaField;
            }
            set {
                if ((object.ReferenceEquals(this.SchemaField, value) != true)) {
                    this.SchemaField = value;
                    this.RaisePropertyChanged("Schema");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Server {
            get {
                return this.ServerField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerField, value) != true)) {
                    this.ServerField = value;
                    this.RaisePropertyChanged("Server");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BackupModel", Namespace="http://schemas.datacontract.org/2004/07/Marvin.Runtime.Maintenance.Plugins.Databa" +
        "seMaintenance.Wcf")]
    [System.SerializableAttribute()]
    public partial class BackupModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsForTargetModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SizeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationDate {
            get {
                return this.CreationDateField;
            }
            set {
                if ((this.CreationDateField.Equals(value) != true)) {
                    this.CreationDateField = value;
                    this.RaisePropertyChanged("CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName {
            get {
                return this.FileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FileNameField, value) != true)) {
                    this.FileNameField = value;
                    this.RaisePropertyChanged("FileName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsForTargetModel {
            get {
                return this.IsForTargetModelField;
            }
            set {
                if ((this.IsForTargetModelField.Equals(value) != true)) {
                    this.IsForTargetModelField = value;
                    this.RaisePropertyChanged("IsForTargetModel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Size {
            get {
                return this.SizeField;
            }
            set {
                if ((this.SizeField.Equals(value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScriptModel", Namespace="http://schemas.datacontract.org/2004/07/Marvin.Runtime.Maintenance.Plugins.Databa" +
        "seMaintenance.Wcf")]
    [System.SerializableAttribute()]
    public partial class ScriptModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsCreationScriptField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsCreationScript {
            get {
                return this.IsCreationScriptField;
            }
            set {
                if ((this.IsCreationScriptField.Equals(value) != true)) {
                    this.IsCreationScriptField = value;
                    this.RaisePropertyChanged("IsCreationScript");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SetupModel", Namespace="http://schemas.datacontract.org/2004/07/Marvin.Runtime.Maintenance.Plugins.Databa" +
        "seMaintenance.Wcf")]
    [System.SerializableAttribute()]
    public partial class SetupModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SetupDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SortOrderField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fullname {
            get {
                return this.FullnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullnameField, value) != true)) {
                    this.FullnameField = value;
                    this.RaisePropertyChanged("Fullname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SetupData {
            get {
                return this.SetupDataField;
            }
            set {
                if ((object.ReferenceEquals(this.SetupDataField, value) != true)) {
                    this.SetupDataField = value;
                    this.RaisePropertyChanged("SetupData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SortOrder {
            get {
                return this.SortOrderField;
            }
            set {
                if ((this.SortOrderField.Equals(value) != true)) {
                    this.SortOrderField = value;
                    this.RaisePropertyChanged("SortOrder");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DumpResult", Namespace="http://schemas.datacontract.org/2004/07/Marvin.Runtime.Maintenance.Plugins.Databa" +
        "seMaintenance")]
    [System.SerializableAttribute()]
    public partial class DumpResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DumpNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DumpName {
            get {
                return this.DumpNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DumpNameField, value) != true)) {
                    this.DumpNameField = value;
                    this.RaisePropertyChanged("DumpName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DatabaseMaintenance.IDatabaseMaintenance")]
    public interface IDatabaseMaintenance {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/GetDataModels", ReplyAction="http://tempuri.org/IDatabaseMaintenance/GetDataModelsResponse")]
        System.Collections.Generic.List<Marvin.TestTools.SystemTest.DatabaseMaintenance.DataModel> GetDataModels();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/GetDataModels", ReplyAction="http://tempuri.org/IDatabaseMaintenance/GetDataModelsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Marvin.TestTools.SystemTest.DatabaseMaintenance.DataModel>> GetDataModelsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/SetAllConfigs", ReplyAction="http://tempuri.org/IDatabaseMaintenance/SetAllConfigsResponse")]
        void SetAllConfigs(Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/SetAllConfigs", ReplyAction="http://tempuri.org/IDatabaseMaintenance/SetAllConfigsResponse")]
        System.Threading.Tasks.Task SetAllConfigsAsync(Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/SetDatabaseConfig", ReplyAction="http://tempuri.org/IDatabaseMaintenance/SetDatabaseConfigResponse")]
        void SetDatabaseConfig(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/SetDatabaseConfig", ReplyAction="http://tempuri.org/IDatabaseMaintenance/SetDatabaseConfigResponse")]
        System.Threading.Tasks.Task SetDatabaseConfigAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/TestDatabaseConfig", ReplyAction="http://tempuri.org/IDatabaseMaintenance/TestDatabaseConfigResponse")]
        bool TestDatabaseConfig(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/TestDatabaseConfig", ReplyAction="http://tempuri.org/IDatabaseMaintenance/TestDatabaseConfigResponse")]
        System.Threading.Tasks.Task<bool> TestDatabaseConfigAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/CreateAll", ReplyAction="http://tempuri.org/IDatabaseMaintenance/CreateAllResponse")]
        string CreateAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/CreateAll", ReplyAction="http://tempuri.org/IDatabaseMaintenance/CreateAllResponse")]
        System.Threading.Tasks.Task<string> CreateAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/CreateDatabase", ReplyAction="http://tempuri.org/IDatabaseMaintenance/CreateDatabaseResponse")]
        string CreateDatabase(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/CreateDatabase", ReplyAction="http://tempuri.org/IDatabaseMaintenance/CreateDatabaseResponse")]
        System.Threading.Tasks.Task<string> CreateDatabaseAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/EraseAll", ReplyAction="http://tempuri.org/IDatabaseMaintenance/EraseAllResponse")]
        string EraseAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/EraseAll", ReplyAction="http://tempuri.org/IDatabaseMaintenance/EraseAllResponse")]
        System.Threading.Tasks.Task<string> EraseAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/EraseDatabase", ReplyAction="http://tempuri.org/IDatabaseMaintenance/EraseDatabaseResponse")]
        string EraseDatabase(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/EraseDatabase", ReplyAction="http://tempuri.org/IDatabaseMaintenance/EraseDatabaseResponse")]
        System.Threading.Tasks.Task<string> EraseDatabaseAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/DumpDatabase", ReplyAction="http://tempuri.org/IDatabaseMaintenance/DumpDatabaseResponse")]
        Marvin.TestTools.SystemTest.DatabaseMaintenance.DumpResult DumpDatabase(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/DumpDatabase", ReplyAction="http://tempuri.org/IDatabaseMaintenance/DumpDatabaseResponse")]
        System.Threading.Tasks.Task<Marvin.TestTools.SystemTest.DatabaseMaintenance.DumpResult> DumpDatabaseAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/RestoreDatabase", ReplyAction="http://tempuri.org/IDatabaseMaintenance/RestoreDatabaseResponse")]
        string RestoreDatabase(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config, Marvin.TestTools.SystemTest.DatabaseMaintenance.BackupModel backupModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/RestoreDatabase", ReplyAction="http://tempuri.org/IDatabaseMaintenance/RestoreDatabaseResponse")]
        System.Threading.Tasks.Task<string> RestoreDatabaseAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config, Marvin.TestTools.SystemTest.DatabaseMaintenance.BackupModel backupModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/ExecuteSetup", ReplyAction="http://tempuri.org/IDatabaseMaintenance/ExecuteSetupResponse")]
        string ExecuteSetup(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config, Marvin.TestTools.SystemTest.DatabaseMaintenance.SetupModel setup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/ExecuteSetup", ReplyAction="http://tempuri.org/IDatabaseMaintenance/ExecuteSetupResponse")]
        System.Threading.Tasks.Task<string> ExecuteSetupAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config, Marvin.TestTools.SystemTest.DatabaseMaintenance.SetupModel setup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/ExecuteScript", ReplyAction="http://tempuri.org/IDatabaseMaintenance/ExecuteScriptResponse")]
        string ExecuteScript(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel model, Marvin.TestTools.SystemTest.DatabaseMaintenance.ScriptModel script);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseMaintenance/ExecuteScript", ReplyAction="http://tempuri.org/IDatabaseMaintenance/ExecuteScriptResponse")]
        System.Threading.Tasks.Task<string> ExecuteScriptAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel model, Marvin.TestTools.SystemTest.DatabaseMaintenance.ScriptModel script);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDatabaseMaintenanceChannel : Marvin.TestTools.SystemTest.DatabaseMaintenance.IDatabaseMaintenance, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DatabaseMaintenanceClient : System.ServiceModel.ClientBase<Marvin.TestTools.SystemTest.DatabaseMaintenance.IDatabaseMaintenance>, Marvin.TestTools.SystemTest.DatabaseMaintenance.IDatabaseMaintenance {
        
        public DatabaseMaintenanceClient() {
        }
        
        public DatabaseMaintenanceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DatabaseMaintenanceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatabaseMaintenanceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatabaseMaintenanceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Marvin.TestTools.SystemTest.DatabaseMaintenance.DataModel> GetDataModels() {
            return base.Channel.GetDataModels();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Marvin.TestTools.SystemTest.DatabaseMaintenance.DataModel>> GetDataModelsAsync() {
            return base.Channel.GetDataModelsAsync();
        }
        
        public void SetAllConfigs(Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            base.Channel.SetAllConfigs(config);
        }
        
        public System.Threading.Tasks.Task SetAllConfigsAsync(Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            return base.Channel.SetAllConfigsAsync(config);
        }
        
        public void SetDatabaseConfig(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            base.Channel.SetDatabaseConfig(targetModel, config);
        }
        
        public System.Threading.Tasks.Task SetDatabaseConfigAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            return base.Channel.SetDatabaseConfigAsync(targetModel, config);
        }
        
        public bool TestDatabaseConfig(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            return base.Channel.TestDatabaseConfig(targetModel, config);
        }
        
        public System.Threading.Tasks.Task<bool> TestDatabaseConfigAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            return base.Channel.TestDatabaseConfigAsync(targetModel, config);
        }
        
        public string CreateAll() {
            return base.Channel.CreateAll();
        }
        
        public System.Threading.Tasks.Task<string> CreateAllAsync() {
            return base.Channel.CreateAllAsync();
        }
        
        public string CreateDatabase(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            return base.Channel.CreateDatabase(targetModel, config);
        }
        
        public System.Threading.Tasks.Task<string> CreateDatabaseAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            return base.Channel.CreateDatabaseAsync(targetModel, config);
        }
        
        public string EraseAll() {
            return base.Channel.EraseAll();
        }
        
        public System.Threading.Tasks.Task<string> EraseAllAsync() {
            return base.Channel.EraseAllAsync();
        }
        
        public string EraseDatabase(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            return base.Channel.EraseDatabase(targetModel, config);
        }
        
        public System.Threading.Tasks.Task<string> EraseDatabaseAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            return base.Channel.EraseDatabaseAsync(targetModel, config);
        }
        
        public Marvin.TestTools.SystemTest.DatabaseMaintenance.DumpResult DumpDatabase(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            return base.Channel.DumpDatabase(targetModel, config);
        }
        
        public System.Threading.Tasks.Task<Marvin.TestTools.SystemTest.DatabaseMaintenance.DumpResult> DumpDatabaseAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config) {
            return base.Channel.DumpDatabaseAsync(targetModel, config);
        }
        
        public string RestoreDatabase(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config, Marvin.TestTools.SystemTest.DatabaseMaintenance.BackupModel backupModel) {
            return base.Channel.RestoreDatabase(targetModel, config, backupModel);
        }
        
        public System.Threading.Tasks.Task<string> RestoreDatabaseAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config, Marvin.TestTools.SystemTest.DatabaseMaintenance.BackupModel backupModel) {
            return base.Channel.RestoreDatabaseAsync(targetModel, config, backupModel);
        }
        
        public string ExecuteSetup(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config, Marvin.TestTools.SystemTest.DatabaseMaintenance.SetupModel setup) {
            return base.Channel.ExecuteSetup(targetModel, config, setup);
        }
        
        public System.Threading.Tasks.Task<string> ExecuteSetupAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel config, Marvin.TestTools.SystemTest.DatabaseMaintenance.SetupModel setup) {
            return base.Channel.ExecuteSetupAsync(targetModel, config, setup);
        }
        
        public string ExecuteScript(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel model, Marvin.TestTools.SystemTest.DatabaseMaintenance.ScriptModel script) {
            return base.Channel.ExecuteScript(targetModel, model, script);
        }
        
        public System.Threading.Tasks.Task<string> ExecuteScriptAsync(string targetModel, Marvin.TestTools.SystemTest.DatabaseMaintenance.DatabaseConfigModel model, Marvin.TestTools.SystemTest.DatabaseMaintenance.ScriptModel script) {
            return base.Channel.ExecuteScriptAsync(targetModel, model, script);
        }
    }
}
