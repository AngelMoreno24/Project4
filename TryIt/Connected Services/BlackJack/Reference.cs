﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryIt.BlackJack {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BlackJack.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DealCards", ReplyAction="http://tempuri.org/IService1/DealCardsResponse")]
        string DealCards();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DealCards", ReplyAction="http://tempuri.org/IService1/DealCardsResponse")]
        System.Threading.Tasks.Task<string> DealCardsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Play", ReplyAction="http://tempuri.org/IService1/PlayResponse")]
        string Play(string action, string state);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Play", ReplyAction="http://tempuri.org/IService1/PlayResponse")]
        System.Threading.Tasks.Task<string> PlayAsync(string action, string state);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Cards", ReplyAction="http://tempuri.org/IService1/CardsResponse")]
        string Cards();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Cards", ReplyAction="http://tempuri.org/IService1/CardsResponse")]
        System.Threading.Tasks.Task<string> CardsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TryIt.BlackJack.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TryIt.BlackJack.IService1>, TryIt.BlackJack.IService1 {
        
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
        
        public string DealCards() {
            return base.Channel.DealCards();
        }
        
        public System.Threading.Tasks.Task<string> DealCardsAsync() {
            return base.Channel.DealCardsAsync();
        }
        
        public string Play(string action, string state) {
            return base.Channel.Play(action, state);
        }
        
        public System.Threading.Tasks.Task<string> PlayAsync(string action, string state) {
            return base.Channel.PlayAsync(action, state);
        }
        
        public string Cards() {
            return base.Channel.Cards();
        }
        
        public System.Threading.Tasks.Task<string> CardsAsync() {
            return base.Channel.CardsAsync();
        }
    }
}
