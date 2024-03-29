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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://myuri.org/Simple/IService/Add", ReplyAction="http://myuri.org/Simple/IService/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://myuri.org/Simple/IService/Add", ReplyAction="http://myuri.org/Simple/IService/AddResponse")]
        System.IAsyncResult BeginAdd(double n1, double n2, System.AsyncCallback callback, object asyncState);
        
        double EndAdd(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://myuri.org/Simple/IService/Subtract", ReplyAction="http://myuri.org/Simple/IService/SubtractResponse")]
        double Subtract(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://myuri.org/Simple/IService/Subtract", ReplyAction="http://myuri.org/Simple/IService/SubtractResponse")]
        System.IAsyncResult BeginSubtract(double n1, double n2, System.AsyncCallback callback, object asyncState);
        
        double EndSubtract(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://myuri.org/Simple/IService/Multiply", ReplyAction="http://myuri.org/Simple/IService/MultiplyResponse")]
        double Multiply(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://myuri.org/Simple/IService/Multiply", ReplyAction="http://myuri.org/Simple/IService/MultiplyResponse")]
        System.IAsyncResult BeginMultiply(double n1, double n2, System.AsyncCallback callback, object asyncState);
        
        double EndMultiply(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://myuri.org/Simple/IService/Divide", ReplyAction="http://myuri.org/Simple/IService/DivideResponse")]
        double Divide(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://myuri.org/Simple/IService/Divide", ReplyAction="http://myuri.org/Simple/IService/DivideResponse")]
        System.IAsyncResult BeginDivide(double n1, double n2, System.AsyncCallback callback, object asyncState);
        
        double EndDivide(System.IAsyncResult result);
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
    public partial class AddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public AddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public double Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubtractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SubtractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public double Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MultiplyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public MultiplyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public double Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DivideCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DivideCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public double Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ClientForm.ClientServiceReference.IService>, ClientForm.ClientServiceReference.IService {
        
        private BeginOperationDelegate onBeginGetAuthorDelegate;
        
        private EndOperationDelegate onEndGetAuthorDelegate;
        
        private System.Threading.SendOrPostCallback onGetAuthorCompletedDelegate;
        
        private BeginOperationDelegate onBeginAddDelegate;
        
        private EndOperationDelegate onEndAddDelegate;
        
        private System.Threading.SendOrPostCallback onAddCompletedDelegate;
        
        private BeginOperationDelegate onBeginSubtractDelegate;
        
        private EndOperationDelegate onEndSubtractDelegate;
        
        private System.Threading.SendOrPostCallback onSubtractCompletedDelegate;
        
        private BeginOperationDelegate onBeginMultiplyDelegate;
        
        private EndOperationDelegate onEndMultiplyDelegate;
        
        private System.Threading.SendOrPostCallback onMultiplyCompletedDelegate;
        
        private BeginOperationDelegate onBeginDivideDelegate;
        
        private EndOperationDelegate onEndDivideDelegate;
        
        private System.Threading.SendOrPostCallback onDivideCompletedDelegate;
        
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
        
        public event System.EventHandler<AddCompletedEventArgs> AddCompleted;
        
        public event System.EventHandler<SubtractCompletedEventArgs> SubtractCompleted;
        
        public event System.EventHandler<MultiplyCompletedEventArgs> MultiplyCompleted;
        
        public event System.EventHandler<DivideCompletedEventArgs> DivideCompleted;
        
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
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginAdd(double n1, double n2, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAdd(n1, n2, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public double EndAdd(System.IAsyncResult result) {
            return base.Channel.EndAdd(result);
        }
        
        private System.IAsyncResult OnBeginAdd(object[] inValues, System.AsyncCallback callback, object asyncState) {
            double n1 = ((double)(inValues[0]));
            double n2 = ((double)(inValues[1]));
            return this.BeginAdd(n1, n2, callback, asyncState);
        }
        
        private object[] OnEndAdd(System.IAsyncResult result) {
            double retVal = this.EndAdd(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAddCompleted(object state) {
            if ((this.AddCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddCompleted(this, new AddCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddAsync(double n1, double n2) {
            this.AddAsync(n1, n2, null);
        }
        
        public void AddAsync(double n1, double n2, object userState) {
            if ((this.onBeginAddDelegate == null)) {
                this.onBeginAddDelegate = new BeginOperationDelegate(this.OnBeginAdd);
            }
            if ((this.onEndAddDelegate == null)) {
                this.onEndAddDelegate = new EndOperationDelegate(this.OnEndAdd);
            }
            if ((this.onAddCompletedDelegate == null)) {
                this.onAddCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddCompleted);
            }
            base.InvokeAsync(this.onBeginAddDelegate, new object[] {
                        n1,
                        n2}, this.onEndAddDelegate, this.onAddCompletedDelegate, userState);
        }
        
        public double Subtract(double n1, double n2) {
            return base.Channel.Subtract(n1, n2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginSubtract(double n1, double n2, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSubtract(n1, n2, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public double EndSubtract(System.IAsyncResult result) {
            return base.Channel.EndSubtract(result);
        }
        
        private System.IAsyncResult OnBeginSubtract(object[] inValues, System.AsyncCallback callback, object asyncState) {
            double n1 = ((double)(inValues[0]));
            double n2 = ((double)(inValues[1]));
            return this.BeginSubtract(n1, n2, callback, asyncState);
        }
        
        private object[] OnEndSubtract(System.IAsyncResult result) {
            double retVal = this.EndSubtract(result);
            return new object[] {
                    retVal};
        }
        
        private void OnSubtractCompleted(object state) {
            if ((this.SubtractCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SubtractCompleted(this, new SubtractCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SubtractAsync(double n1, double n2) {
            this.SubtractAsync(n1, n2, null);
        }
        
        public void SubtractAsync(double n1, double n2, object userState) {
            if ((this.onBeginSubtractDelegate == null)) {
                this.onBeginSubtractDelegate = new BeginOperationDelegate(this.OnBeginSubtract);
            }
            if ((this.onEndSubtractDelegate == null)) {
                this.onEndSubtractDelegate = new EndOperationDelegate(this.OnEndSubtract);
            }
            if ((this.onSubtractCompletedDelegate == null)) {
                this.onSubtractCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSubtractCompleted);
            }
            base.InvokeAsync(this.onBeginSubtractDelegate, new object[] {
                        n1,
                        n2}, this.onEndSubtractDelegate, this.onSubtractCompletedDelegate, userState);
        }
        
        public double Multiply(double n1, double n2) {
            return base.Channel.Multiply(n1, n2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginMultiply(double n1, double n2, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginMultiply(n1, n2, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public double EndMultiply(System.IAsyncResult result) {
            return base.Channel.EndMultiply(result);
        }
        
        private System.IAsyncResult OnBeginMultiply(object[] inValues, System.AsyncCallback callback, object asyncState) {
            double n1 = ((double)(inValues[0]));
            double n2 = ((double)(inValues[1]));
            return this.BeginMultiply(n1, n2, callback, asyncState);
        }
        
        private object[] OnEndMultiply(System.IAsyncResult result) {
            double retVal = this.EndMultiply(result);
            return new object[] {
                    retVal};
        }
        
        private void OnMultiplyCompleted(object state) {
            if ((this.MultiplyCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.MultiplyCompleted(this, new MultiplyCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void MultiplyAsync(double n1, double n2) {
            this.MultiplyAsync(n1, n2, null);
        }
        
        public void MultiplyAsync(double n1, double n2, object userState) {
            if ((this.onBeginMultiplyDelegate == null)) {
                this.onBeginMultiplyDelegate = new BeginOperationDelegate(this.OnBeginMultiply);
            }
            if ((this.onEndMultiplyDelegate == null)) {
                this.onEndMultiplyDelegate = new EndOperationDelegate(this.OnEndMultiply);
            }
            if ((this.onMultiplyCompletedDelegate == null)) {
                this.onMultiplyCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnMultiplyCompleted);
            }
            base.InvokeAsync(this.onBeginMultiplyDelegate, new object[] {
                        n1,
                        n2}, this.onEndMultiplyDelegate, this.onMultiplyCompletedDelegate, userState);
        }
        
        public double Divide(double n1, double n2) {
            return base.Channel.Divide(n1, n2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDivide(double n1, double n2, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDivide(n1, n2, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public double EndDivide(System.IAsyncResult result) {
            return base.Channel.EndDivide(result);
        }
        
        private System.IAsyncResult OnBeginDivide(object[] inValues, System.AsyncCallback callback, object asyncState) {
            double n1 = ((double)(inValues[0]));
            double n2 = ((double)(inValues[1]));
            return this.BeginDivide(n1, n2, callback, asyncState);
        }
        
        private object[] OnEndDivide(System.IAsyncResult result) {
            double retVal = this.EndDivide(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDivideCompleted(object state) {
            if ((this.DivideCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DivideCompleted(this, new DivideCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DivideAsync(double n1, double n2) {
            this.DivideAsync(n1, n2, null);
        }
        
        public void DivideAsync(double n1, double n2, object userState) {
            if ((this.onBeginDivideDelegate == null)) {
                this.onBeginDivideDelegate = new BeginOperationDelegate(this.OnBeginDivide);
            }
            if ((this.onEndDivideDelegate == null)) {
                this.onEndDivideDelegate = new EndOperationDelegate(this.OnEndDivide);
            }
            if ((this.onDivideCompletedDelegate == null)) {
                this.onDivideCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDivideCompleted);
            }
            base.InvokeAsync(this.onBeginDivideDelegate, new object[] {
                        n1,
                        n2}, this.onEndDivideDelegate, this.onDivideCompletedDelegate, userState);
        }
    }
}
