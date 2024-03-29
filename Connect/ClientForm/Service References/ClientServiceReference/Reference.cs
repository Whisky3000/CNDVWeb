﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientForm.ClientServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://myuri.org/Simple", ConfigurationName="ClientServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://myuri.org/Simple/IService/GetAuthor", ReplyAction="http://myuri.org/Simple/IService/GetAuthorResponse")]
        string GetAuthor();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://myuri.org/Simple/IService/GetAuthor", ReplyAction="http://myuri.org/Simple/IService/GetAuthorResponse")]
        System.IAsyncResult BeginGetAuthor(System.AsyncCallback callback, object asyncState);
        
        string EndGetAuthor(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ClientForm.ClientServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAuthorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAuthorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ClientForm.ClientServiceReference.IService>, ClientForm.ClientServiceReference.IService {
        
        private BeginOperationDelegate onBeginGetAuthorDelegate;
        
        private EndOperationDelegate onEndGetAuthorDelegate;
        
        private System.Threading.SendOrPostCallback onGetAuthorCompletedDelegate;
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetAuthorCompletedEventArgs> GetAuthorCompleted;
        
        public string GetAuthor() {
            return base.Channel.GetAuthor();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAuthor(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAuthor(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetAuthor(System.IAsyncResult result) {
            return base.Channel.EndGetAuthor(result);
        }
        
        private System.IAsyncResult OnBeginGetAuthor(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAuthor(callback, asyncState);
        }
        
        private object[] OnEndGetAuthor(System.IAsyncResult result) {
            string retVal = this.EndGetAuthor(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAuthorCompleted(object state) {
            if ((this.GetAuthorCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAuthorCompleted(this, new GetAuthorCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAuthorAsync() {
            this.GetAuthorAsync(null);
        }
        
        public void GetAuthorAsync(object userState) {
            if ((this.onBeginGetAuthorDelegate == null)) {
                this.onBeginGetAuthorDelegate = new BeginOperationDelegate(this.OnBeginGetAuthor);
            }
            if ((this.onEndGetAuthorDelegate == null)) {
                this.onEndGetAuthorDelegate = new EndOperationDelegate(this.OnEndGetAuthor);
            }
            if ((this.onGetAuthorCompletedDelegate == null)) {
                this.onGetAuthorCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAuthorCompleted);
            }
            base.InvokeAsync(this.onBeginGetAuthorDelegate, null, this.onEndGetAuthorDelegate, this.onGetAuthorCompletedDelegate, userState);
        }
    }
}
