﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfTestClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IFileService")]
    public interface IFileService {
        
        // CODEGEN: 消息 UpFile 的包装名称(UpFile)以后生成的消息协定与默认值(UpLoadFile)不匹配
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/UpLoadFile", ReplyAction="http://tempuri.org/IFileService/UpLoadFileResponse")]
        WcfTestClient.ServiceReference1.UpFileResult UpLoadFile(WcfTestClient.ServiceReference1.UpFile request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/UpLoadFile", ReplyAction="http://tempuri.org/IFileService/UpLoadFileResponse")]
        System.Threading.Tasks.Task<WcfTestClient.ServiceReference1.UpFileResult> UpLoadFileAsync(WcfTestClient.ServiceReference1.UpFile request);
        
        // CODEGEN: 消息 DownFile 的包装名称(DownFile)以后生成的消息协定与默认值(DownLoadFile)不匹配
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/DownLoadFile", ReplyAction="http://tempuri.org/IFileService/DownLoadFileResponse")]
        WcfTestClient.ServiceReference1.DownFileResult DownLoadFile(WcfTestClient.ServiceReference1.DownFile request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/DownLoadFile", ReplyAction="http://tempuri.org/IFileService/DownLoadFileResponse")]
        System.Threading.Tasks.Task<WcfTestClient.ServiceReference1.DownFileResult> DownLoadFileAsync(WcfTestClient.ServiceReference1.DownFile request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/ClientConnect", ReplyAction="http://tempuri.org/IFileService/ClientConnectResponse")]
        void ClientConnect(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/ClientConnect", ReplyAction="http://tempuri.org/IFileService/ClientConnectResponse")]
        System.Threading.Tasks.Task ClientConnectAsync(string str);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpFile", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpFile {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long FileSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream FileStream;
        
        public UpFile() {
        }
        
        public UpFile(string FileName, long FileSize, System.IO.Stream FileStream) {
            this.FileName = FileName;
            this.FileSize = FileSize;
            this.FileStream = FileStream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpFileResult", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpFileResult {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool IsSuccess;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Message;
        
        public UpFileResult() {
        }
        
        public UpFileResult(bool IsSuccess, string Message) {
            this.IsSuccess = IsSuccess;
            this.Message = Message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownFile", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownFile {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        public DownFile() {
        }
        
        public DownFile(string FileName) {
            this.FileName = FileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownFileResult", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownFileResult {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long FileSize;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool IsSuccess;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Message;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream FileStream;
        
        public DownFileResult() {
        }
        
        public DownFileResult(long FileSize, bool IsSuccess, string Message, System.IO.Stream FileStream) {
            this.FileSize = FileSize;
            this.IsSuccess = IsSuccess;
            this.Message = Message;
            this.FileStream = FileStream;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileServiceChannel : WcfTestClient.ServiceReference1.IFileService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileServiceClient : System.ServiceModel.ClientBase<WcfTestClient.ServiceReference1.IFileService>, WcfTestClient.ServiceReference1.IFileService {
        
        public FileServiceClient() {
        }
        
        public FileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfTestClient.ServiceReference1.UpFileResult WcfTestClient.ServiceReference1.IFileService.UpLoadFile(WcfTestClient.ServiceReference1.UpFile request) {
            return base.Channel.UpLoadFile(request);
        }
        
        public bool UpLoadFile(string FileName, long FileSize, System.IO.Stream FileStream, out string Message) {
            WcfTestClient.ServiceReference1.UpFile inValue = new WcfTestClient.ServiceReference1.UpFile();
            inValue.FileName = FileName;
            inValue.FileSize = FileSize;
            inValue.FileStream = FileStream;
            WcfTestClient.ServiceReference1.UpFileResult retVal = ((WcfTestClient.ServiceReference1.IFileService)(this)).UpLoadFile(inValue);
            Message = retVal.Message;
            return retVal.IsSuccess;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WcfTestClient.ServiceReference1.UpFileResult> WcfTestClient.ServiceReference1.IFileService.UpLoadFileAsync(WcfTestClient.ServiceReference1.UpFile request) {
            return base.Channel.UpLoadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<WcfTestClient.ServiceReference1.UpFileResult> UpLoadFileAsync(string FileName, long FileSize, System.IO.Stream FileStream) {
            WcfTestClient.ServiceReference1.UpFile inValue = new WcfTestClient.ServiceReference1.UpFile();
            inValue.FileName = FileName;
            inValue.FileSize = FileSize;
            inValue.FileStream = FileStream;
            return ((WcfTestClient.ServiceReference1.IFileService)(this)).UpLoadFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfTestClient.ServiceReference1.DownFileResult WcfTestClient.ServiceReference1.IFileService.DownLoadFile(WcfTestClient.ServiceReference1.DownFile request) {
            return base.Channel.DownLoadFile(request);
        }
        
        public long DownLoadFile(string FileName, out bool IsSuccess, out string Message, out System.IO.Stream FileStream) {
            WcfTestClient.ServiceReference1.DownFile inValue = new WcfTestClient.ServiceReference1.DownFile();
            inValue.FileName = FileName;
            WcfTestClient.ServiceReference1.DownFileResult retVal = ((WcfTestClient.ServiceReference1.IFileService)(this)).DownLoadFile(inValue);
            IsSuccess = retVal.IsSuccess;
            Message = retVal.Message;
            FileStream = retVal.FileStream;
            return retVal.FileSize;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WcfTestClient.ServiceReference1.DownFileResult> WcfTestClient.ServiceReference1.IFileService.DownLoadFileAsync(WcfTestClient.ServiceReference1.DownFile request) {
            return base.Channel.DownLoadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<WcfTestClient.ServiceReference1.DownFileResult> DownLoadFileAsync(string FileName) {
            WcfTestClient.ServiceReference1.DownFile inValue = new WcfTestClient.ServiceReference1.DownFile();
            inValue.FileName = FileName;
            return ((WcfTestClient.ServiceReference1.IFileService)(this)).DownLoadFileAsync(inValue);
        }
        
        public void ClientConnect(string str) {
            base.Channel.ClientConnect(str);
        }
        
        public System.Threading.Tasks.Task ClientConnectAsync(string str) {
            return base.Channel.ClientConnectAsync(str);
        }
    }
}
