﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteASPNET.reniecsome {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="reniecsome.wsReniecSoap")]
    public interface wsReniecSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarDNI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet BuscarDNI(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarDNI", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarDNIAsync(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarDireccion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet BuscarDireccion(string direccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarDireccion", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarDireccionAsync(string direccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSlistado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet WSlistado();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSlistado", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> WSlistadoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsReniecSoapChannel : ClienteASPNET.reniecsome.wsReniecSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsReniecSoapClient : System.ServiceModel.ClientBase<ClienteASPNET.reniecsome.wsReniecSoap>, ClienteASPNET.reniecsome.wsReniecSoap {
        
        public wsReniecSoapClient() {
        }
        
        public wsReniecSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsReniecSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsReniecSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsReniecSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet BuscarDNI(string dni) {
            return base.Channel.BuscarDNI(dni);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarDNIAsync(string dni) {
            return base.Channel.BuscarDNIAsync(dni);
        }
        
        public System.Data.DataSet BuscarDireccion(string direccion) {
            return base.Channel.BuscarDireccion(direccion);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarDireccionAsync(string direccion) {
            return base.Channel.BuscarDireccionAsync(direccion);
        }
        
        public System.Data.DataSet WSlistado() {
            return base.Channel.WSlistado();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> WSlistadoAsync() {
            return base.Channel.WSlistadoAsync();
        }
    }
}
