﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://Prueba.com", ClrNamespace="prueba.com")]
namespace prueba.com
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JJSo", Namespace="http://Prueba.com")]
    public partial class JJSo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string EdadField;
        
        private string NombreField;
        
        private string ApellidoField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Edad
        {
            get
            {
                return this.EdadField;
            }
            set
            {
                this.EdadField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre
        {
            get
            {
                return this.NombreField;
            }
            set
            {
                this.NombreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Apellido
        {
            get
            {
                return this.ApellidoField;
            }
            set
            {
                this.ApellidoField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://Prueba.com", ConfigurationName="JJSo")]
public interface JJSo
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Prueba.com/JJSo/GetMessage", ReplyAction="http://Prueba.com/JJSo/GetMessageResponse")]
    string GetMessage(string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Prueba.com/JJSo/GetMessage", ReplyAction="http://Prueba.com/JJSo/GetMessageResponse")]
    System.Threading.Tasks.Task<string> GetMessageAsync(string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Prueba.com/JJSo/GetPersona", ReplyAction="http://Prueba.com/JJSo/GetPersonaResponse")]
    prueba.com.JJSo GetPersona(prueba.com.JJSo _persona);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Prueba.com/JJSo/GetPersona", ReplyAction="http://Prueba.com/JJSo/GetPersonaResponse")]
    System.Threading.Tasks.Task<prueba.com.JJSo> GetPersonaAsync(prueba.com.JJSo _persona);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface JJSoChannel : JJSo, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class JJSoClient : System.ServiceModel.ClientBase<JJSo>, JJSo
{
    
    public JJSoClient()
    {
    }
    
    public JJSoClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public JJSoClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public JJSoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public JJSoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string GetMessage(string name)
    {
        return base.Channel.GetMessage(name);
    }
    
    public System.Threading.Tasks.Task<string> GetMessageAsync(string name)
    {
        return base.Channel.GetMessageAsync(name);
    }
    
    public prueba.com.JJSo GetPersona(prueba.com.JJSo _persona)
    {
        return base.Channel.GetPersona(_persona);
    }
    
    public System.Threading.Tasks.Task<prueba.com.JJSo> GetPersonaAsync(prueba.com.JJSo _persona)
    {
        return base.Channel.GetPersonaAsync(_persona);
    }
}
