﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientCUI.LoginServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginServiceReference.ILoginService")]
    public interface ILoginService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/CheckCredentials", ReplyAction="http://tempuri.org/ILoginService/CheckCredentialsResponse")]
        string CheckCredentials(ServerWCF.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/CheckCredentials", ReplyAction="http://tempuri.org/ILoginService/CheckCredentialsResponse")]
        System.Threading.Tasks.Task<string> CheckCredentialsAsync(ServerWCF.User u);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginServiceChannel : ClientCUI.LoginServiceReference.ILoginService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginServiceClient : System.ServiceModel.ClientBase<ClientCUI.LoginServiceReference.ILoginService>, ClientCUI.LoginServiceReference.ILoginService {
        
        public LoginServiceClient() {
        }
        
        public LoginServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CheckCredentials(ServerWCF.User u) {
            return base.Channel.CheckCredentials(u);
        }
        
        public System.Threading.Tasks.Task<string> CheckCredentialsAsync(ServerWCF.User u) {
            return base.Channel.CheckCredentialsAsync(u);
        }
    }
}
