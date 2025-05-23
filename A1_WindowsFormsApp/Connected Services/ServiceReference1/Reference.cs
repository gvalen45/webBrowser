﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A1_WindowsFormsApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/converterService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/c2f", ReplyAction="http://tempuri.org/IService1/c2fResponse")]
        int c2f(int celsius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/c2f", ReplyAction="http://tempuri.org/IService1/c2fResponse")]
        System.Threading.Tasks.Task<int> c2fAsync(int celsius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/f2c", ReplyAction="http://tempuri.org/IService1/f2cResponse")]
        int f2c(int fahrenheit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/f2c", ReplyAction="http://tempuri.org/IService1/f2cResponse")]
        System.Threading.Tasks.Task<int> f2cAsync(int fahrenheit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sort", ReplyAction="http://tempuri.org/IService1/sortResponse")]
        string sort(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sort", ReplyAction="http://tempuri.org/IService1/sortResponse")]
        System.Threading.Tasks.Task<string> sortAsync(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        A1_WindowsFormsApp.ServiceReference1.CompositeType GetDataUsingDataContract(A1_WindowsFormsApp.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<A1_WindowsFormsApp.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(A1_WindowsFormsApp.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : A1_WindowsFormsApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<A1_WindowsFormsApp.ServiceReference1.IService1>, A1_WindowsFormsApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public int c2f(int celsius) {
            return base.Channel.c2f(celsius);
        }
        
        public System.Threading.Tasks.Task<int> c2fAsync(int celsius) {
            return base.Channel.c2fAsync(celsius);
        }
        
        public int f2c(int fahrenheit) {
            return base.Channel.f2c(fahrenheit);
        }
        
        public System.Threading.Tasks.Task<int> f2cAsync(int fahrenheit) {
            return base.Channel.f2cAsync(fahrenheit);
        }
        
        public string sort(string s) {
            return base.Channel.sort(s);
        }
        
        public System.Threading.Tasks.Task<string> sortAsync(string s) {
            return base.Channel.sortAsync(s);
        }
        
        public A1_WindowsFormsApp.ServiceReference1.CompositeType GetDataUsingDataContract(A1_WindowsFormsApp.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<A1_WindowsFormsApp.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(A1_WindowsFormsApp.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
