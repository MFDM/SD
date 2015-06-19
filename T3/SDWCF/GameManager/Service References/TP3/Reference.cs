﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameManager.TP3 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TP3.IGamePlayer")]
    public interface IGamePlayer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGamePlayer/SetPlay", ReplyAction="http://tempuri.org/IGamePlayer/SetPlayResponse")]
        string SetPlay(int n1, int n2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGamePlayerChannel : GameManager.TP3.IGamePlayer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GamePlayerClient : System.ServiceModel.ClientBase<GameManager.TP3.IGamePlayer>, GameManager.TP3.IGamePlayer {
        
        public GamePlayerClient() {
        }
        
        public GamePlayerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GamePlayerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GamePlayerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GamePlayerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SetPlay(int n1, int n2) {
            return base.Channel.SetPlay(n1, n2);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TP3.IGameManager")]
    public interface IGameManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameManager/StartGame", ReplyAction="http://tempuri.org/IGameManager/StartGameResponse")]
        void StartGame(int n1, int n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameManager/EndGame", ReplyAction="http://tempuri.org/IGameManager/EndGameResponse")]
        void EndGame();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameManagerChannel : GameManager.TP3.IGameManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameManagerClient : System.ServiceModel.ClientBase<GameManager.TP3.IGameManager>, GameManager.TP3.IGameManager {
        
        public GameManagerClient() {
        }
        
        public GameManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GameManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void StartGame(int n1, int n2) {
            base.Channel.StartGame(n1, n2);
        }
        
        public void EndGame() {
            base.Channel.EndGame();
        }
    }
}