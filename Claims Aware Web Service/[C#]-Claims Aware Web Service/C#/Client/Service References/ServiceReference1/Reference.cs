﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17376
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IClaimsAwareWebService")]
    public interface IClaimsAwareWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClaimsAwareWebService/ComputeResponse", ReplyAction="http://tempuri.org/IClaimsAwareWebService/ComputeResponseResponse")]
        string ComputeResponse(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClaimsAwareWebService/ComputeResponse", ReplyAction="http://tempuri.org/IClaimsAwareWebService/ComputeResponseResponse")]
        System.Threading.Tasks.Task<string> ComputeResponseAsync(string input);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClaimsAwareWebServiceChannel : Client.ServiceReference1.IClaimsAwareWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClaimsAwareWebServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IClaimsAwareWebService>, Client.ServiceReference1.IClaimsAwareWebService {
        
        public ClaimsAwareWebServiceClient() {
        }
        
        public ClaimsAwareWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClaimsAwareWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClaimsAwareWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClaimsAwareWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ComputeResponse(string input) {
            return base.Channel.ComputeResponse(input);
        }
        
        public System.Threading.Tasks.Task<string> ComputeResponseAsync(string input) {
            return base.Channel.ComputeResponseAsync(input);
        }
    }
}