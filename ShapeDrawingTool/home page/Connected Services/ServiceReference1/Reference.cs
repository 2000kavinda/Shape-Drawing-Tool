﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace home_page.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Circle", ReplyAction="*")]
        double Circle(int r, int g);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Circle", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CircleAsync(int r, int g);
        
        // CODEGEN: Generating message contract since element name inputText from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/abc", ReplyAction="*")]
        home_page.ServiceReference1.abcResponse abc(home_page.ServiceReference1.abcRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/abc", ReplyAction="*")]
        System.Threading.Tasks.Task<home_page.ServiceReference1.abcResponse> abcAsync(home_page.ServiceReference1.abcRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class abcRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="abc", Namespace="http://tempuri.org/", Order=0)]
        public home_page.ServiceReference1.abcRequestBody Body;
        
        public abcRequest() {
        }
        
        public abcRequest(home_page.ServiceReference1.abcRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class abcRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string inputText;
        
        public abcRequestBody() {
        }
        
        public abcRequestBody(string inputText) {
            this.inputText = inputText;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class abcResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="abcResponse", Namespace="http://tempuri.org/", Order=0)]
        public home_page.ServiceReference1.abcResponseBody Body;
        
        public abcResponse() {
        }
        
        public abcResponse(home_page.ServiceReference1.abcResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class abcResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string abcResult;
        
        public abcResponseBody() {
        }
        
        public abcResponseBody(string abcResult) {
            this.abcResult = abcResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : home_page.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<home_page.ServiceReference1.WebService1Soap>, home_page.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Circle(int r, int g) {
            return base.Channel.Circle(r, g);
        }
        
        public System.Threading.Tasks.Task<double> CircleAsync(int r, int g) {
            return base.Channel.CircleAsync(r, g);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        home_page.ServiceReference1.abcResponse home_page.ServiceReference1.WebService1Soap.abc(home_page.ServiceReference1.abcRequest request) {
            return base.Channel.abc(request);
        }
        
        public string abc(string inputText) {
            home_page.ServiceReference1.abcRequest inValue = new home_page.ServiceReference1.abcRequest();
            inValue.Body = new home_page.ServiceReference1.abcRequestBody();
            inValue.Body.inputText = inputText;
            home_page.ServiceReference1.abcResponse retVal = ((home_page.ServiceReference1.WebService1Soap)(this)).abc(inValue);
            return retVal.Body.abcResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<home_page.ServiceReference1.abcResponse> home_page.ServiceReference1.WebService1Soap.abcAsync(home_page.ServiceReference1.abcRequest request) {
            return base.Channel.abcAsync(request);
        }
        
        public System.Threading.Tasks.Task<home_page.ServiceReference1.abcResponse> abcAsync(string inputText) {
            home_page.ServiceReference1.abcRequest inValue = new home_page.ServiceReference1.abcRequest();
            inValue.Body = new home_page.ServiceReference1.abcRequestBody();
            inValue.Body.inputText = inputText;
            return ((home_page.ServiceReference1.WebService1Soap)(this)).abcAsync(inValue);
        }
    }
}
