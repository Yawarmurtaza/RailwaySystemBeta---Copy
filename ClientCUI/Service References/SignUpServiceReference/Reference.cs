﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientCUI.SignUpServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SignUpServiceReference.ISignUpService")]
    public interface ISignUpService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISignUpService/AddUser", ReplyAction="http://tempuri.org/ISignUpService/AddUserResponse")]
        string AddUser(ServerWCF.User u, string userType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISignUpService/AddUser", ReplyAction="http://tempuri.org/ISignUpService/AddUserResponse")]
        System.Threading.Tasks.Task<string> AddUserAsync(ServerWCF.User u, string userType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISignUpServiceChannel : ClientCUI.SignUpServiceReference.ISignUpService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SignUpServiceClient : System.ServiceModel.ClientBase<ClientCUI.SignUpServiceReference.ISignUpService>, ClientCUI.SignUpServiceReference.ISignUpService {
        
        public SignUpServiceClient() {
        }
        
        public SignUpServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SignUpServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SignUpServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SignUpServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddUser(ServerWCF.User u, string userType) {
            return base.Channel.AddUser(u, userType);
        }
        
        public System.Threading.Tasks.Task<string> AddUserAsync(ServerWCF.User u, string userType) {
            return base.Channel.AddUserAsync(u, userType);
        }
    }
}
