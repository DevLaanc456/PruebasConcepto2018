﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleWcFClienteAplication.HelloWordService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JJSo", Namespace="http://Prueba.com")]
    [System.SerializableAttribute()]
    public partial class JJSo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EdadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
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
        public string Edad {
            get {
                return this.EdadField;
            }
            set {
                if ((object.ReferenceEquals(this.EdadField, value) != true)) {
                    this.EdadField = value;
                    this.RaisePropertyChanged("Edad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
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
    [System.ServiceModel.ServiceContractAttribute(Name="JJSo", Namespace="http://Prueba.com", ConfigurationName="HelloWordService.JJSo1")]
    public interface JJSo1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Prueba.com/JJSo/GetMessage", ReplyAction="http://Prueba.com/JJSo/GetMessageResponse")]
        string GetMessage(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Prueba.com/JJSo/GetMessage", ReplyAction="http://Prueba.com/JJSo/GetMessageResponse")]
        System.Threading.Tasks.Task<string> GetMessageAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Prueba.com/JJSo/GetPersona", ReplyAction="http://Prueba.com/JJSo/GetPersonaResponse")]
        ConsoleWcFClienteAplication.HelloWordService.JJSo GetPersona(ConsoleWcFClienteAplication.HelloWordService.JJSo _persona);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Prueba.com/JJSo/GetPersona", ReplyAction="http://Prueba.com/JJSo/GetPersonaResponse")]
        System.Threading.Tasks.Task<ConsoleWcFClienteAplication.HelloWordService.JJSo> GetPersonaAsync(ConsoleWcFClienteAplication.HelloWordService.JJSo _persona);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface JJSo1Channel : ConsoleWcFClienteAplication.HelloWordService.JJSo1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JJSo1Client : System.ServiceModel.ClientBase<ConsoleWcFClienteAplication.HelloWordService.JJSo1>, ConsoleWcFClienteAplication.HelloWordService.JJSo1 {
        
        public JJSo1Client() {
        }
        
        public JJSo1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JJSo1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JJSo1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JJSo1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMessage(string name) {
            return base.Channel.GetMessage(name);
        }
        
        public System.Threading.Tasks.Task<string> GetMessageAsync(string name) {
            return base.Channel.GetMessageAsync(name);
        }
        
        public ConsoleWcFClienteAplication.HelloWordService.JJSo GetPersona(ConsoleWcFClienteAplication.HelloWordService.JJSo _persona) {
            return base.Channel.GetPersona(_persona);
        }
        
        public System.Threading.Tasks.Task<ConsoleWcFClienteAplication.HelloWordService.JJSo> GetPersonaAsync(ConsoleWcFClienteAplication.HelloWordService.JJSo _persona) {
            return base.Channel.GetPersonaAsync(_persona);
        }
    }
}
