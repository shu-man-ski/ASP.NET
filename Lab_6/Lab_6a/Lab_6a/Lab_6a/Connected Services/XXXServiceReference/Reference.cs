﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab_6a.XXXServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="XXXServiceReference.XXXServiceSoap")]
    public interface XXXServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        int Sub(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        int Mul(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MulAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetA", ReplyAction="*")]
        void SetA(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetA", ReplyAction="*")]
        System.Threading.Tasks.Task SetAAsync(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetA", ReplyAction="*")]
        int GetA();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetA", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetAAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IncreaseСounter", ReplyAction="*")]
        void IncreaseСounter();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IncreaseСounter", ReplyAction="*")]
        System.Threading.Tasks.Task IncreaseСounterAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetСounterValue", ReplyAction="*")]
        int GetСounterValue();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetСounterValue", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetСounterValueAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XXXServiceSoapChannel : Lab_6a.XXXServiceReference.XXXServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XXXServiceSoapClient : System.ServiceModel.ClientBase<Lab_6a.XXXServiceReference.XXXServiceSoap>, Lab_6a.XXXServiceReference.XXXServiceSoap {
        
        public XXXServiceSoapClient() {
        }
        
        public XXXServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public XXXServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public XXXServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public XXXServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int x, int y) {
            return base.Channel.AddAsync(x, y);
        }
        
        public int Sub(int x, int y) {
            return base.Channel.Sub(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SubAsync(int x, int y) {
            return base.Channel.SubAsync(x, y);
        }
        
        public int Mul(int x, int y) {
            return base.Channel.Mul(x, y);
        }
        
        public System.Threading.Tasks.Task<int> MulAsync(int x, int y) {
            return base.Channel.MulAsync(x, y);
        }
        
        public void SetA(int a) {
            base.Channel.SetA(a);
        }
        
        public System.Threading.Tasks.Task SetAAsync(int a) {
            return base.Channel.SetAAsync(a);
        }
        
        public int GetA() {
            return base.Channel.GetA();
        }
        
        public System.Threading.Tasks.Task<int> GetAAsync() {
            return base.Channel.GetAAsync();
        }
        
        public void IncreaseСounter() {
            base.Channel.IncreaseСounter();
        }
        
        public System.Threading.Tasks.Task IncreaseСounterAsync() {
            return base.Channel.IncreaseСounterAsync();
        }
        
        public int GetСounterValue() {
            return base.Channel.GetСounterValue();
        }
        
        public System.Threading.Tasks.Task<int> GetСounterValueAsync() {
            return base.Channel.GetСounterValueAsync();
        }
    }
}