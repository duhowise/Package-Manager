﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Package_Manager.PackagesService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Package", Namespace="http://schemas.datacontract.org/2004/07/PackageEntities")]
    [System.SerializableAttribute()]
    public partial class Package : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DestinationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DispatchedTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DispatcherIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime RecievedTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RecieverField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RecieverIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RecieverNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SenderNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
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
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
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
        public int DestinationId {
            get {
                return this.DestinationIdField;
            }
            set {
                if ((this.DestinationIdField.Equals(value) != true)) {
                    this.DestinationIdField = value;
                    this.RaisePropertyChanged("DestinationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DispatchedTime {
            get {
                return this.DispatchedTimeField;
            }
            set {
                if ((this.DispatchedTimeField.Equals(value) != true)) {
                    this.DispatchedTimeField = value;
                    this.RaisePropertyChanged("DispatchedTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DispatcherId {
            get {
                return this.DispatcherIdField;
            }
            set {
                if ((this.DispatcherIdField.Equals(value) != true)) {
                    this.DispatcherIdField = value;
                    this.RaisePropertyChanged("DispatcherId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RecievedTime {
            get {
                return this.RecievedTimeField;
            }
            set {
                if ((this.RecievedTimeField.Equals(value) != true)) {
                    this.RecievedTimeField = value;
                    this.RaisePropertyChanged("RecievedTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reciever {
            get {
                return this.RecieverField;
            }
            set {
                if ((object.ReferenceEquals(this.RecieverField, value) != true)) {
                    this.RecieverField = value;
                    this.RaisePropertyChanged("Reciever");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RecieverId {
            get {
                return this.RecieverIdField;
            }
            set {
                if ((this.RecieverIdField.Equals(value) != true)) {
                    this.RecieverIdField = value;
                    this.RaisePropertyChanged("RecieverId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RecieverNumber {
            get {
                return this.RecieverNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.RecieverNumberField, value) != true)) {
                    this.RecieverNumberField = value;
                    this.RaisePropertyChanged("RecieverNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sender {
            get {
                return this.SenderField;
            }
            set {
                if ((object.ReferenceEquals(this.SenderField, value) != true)) {
                    this.SenderField = value;
                    this.RaisePropertyChanged("Sender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SenderNumber {
            get {
                return this.SenderNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.SenderNumberField, value) != true)) {
                    this.SenderNumberField = value;
                    this.RaisePropertyChanged("SenderNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PackagesService.IPackageService")]
    public interface IPackageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackageService/Login", ReplyAction="http://tempuri.org/IPackageService/LoginResponse")]
        int Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackageService/Login", ReplyAction="http://tempuri.org/IPackageService/LoginResponse")]
        System.Threading.Tasks.Task<int> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackageService/GetPackages", ReplyAction="http://tempuri.org/IPackageService/GetPackagesResponse")]
        Package_Manager.PackagesService.Package[] GetPackages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackageService/GetPackages", ReplyAction="http://tempuri.org/IPackageService/GetPackagesResponse")]
        System.Threading.Tasks.Task<Package_Manager.PackagesService.Package[]> GetPackagesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPackageServiceChannel : Package_Manager.PackagesService.IPackageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PackageServiceClient : System.ServiceModel.ClientBase<Package_Manager.PackagesService.IPackageService>, Package_Manager.PackagesService.IPackageService {
        
        public PackageServiceClient() {
        }
        
        public PackageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PackageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PackageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PackageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<int> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public Package_Manager.PackagesService.Package[] GetPackages() {
            return base.Channel.GetPackages();
        }
        
        public System.Threading.Tasks.Task<Package_Manager.PackagesService.Package[]> GetPackagesAsync() {
            return base.Channel.GetPackagesAsync();
        }
    }
}
