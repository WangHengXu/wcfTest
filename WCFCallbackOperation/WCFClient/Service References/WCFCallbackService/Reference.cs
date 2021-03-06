﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClient.WCFCallbackService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://cnblog.com/zhili/", ConfigurationName="WCFCallbackService.ICalculator", CallbackContract=typeof(WCFClient.WCFCallbackService.ICalculatorCallback))]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://cnblog.com/zhili/ICalculator/Multiple")]
        void Multiple(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://cnblog.com/zhili/ICalculator/Multiple")]
        System.Threading.Tasks.Task MultipleAsync(double a, double b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://cnblog.com/zhili/ICalculator/DisplayResult")]
        void DisplayResult(double x, double y, double result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : WCFClient.WCFCallbackService.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.DuplexClientBase<WCFClient.WCFCallbackService.ICalculator>, WCFClient.WCFCallbackService.ICalculator {
        
        public CalculatorClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CalculatorClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CalculatorClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Multiple(double a, double b) {
            base.Channel.Multiple(a, b);
        }
        
        public System.Threading.Tasks.Task MultipleAsync(double a, double b) {
            return base.Channel.MultipleAsync(a, b);
        }
    }
}
