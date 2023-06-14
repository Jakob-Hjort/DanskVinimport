﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moderndesign.DVIservice {
    using System.Runtime.Serialization;
    using System;
    using System.Threading.Tasks;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://dvimonitor.azurewebsites.net/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/", ConfigurationName="DVIservice.monitorSoap")]
    public interface monitorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockTemp", ReplyAction="*")]
        double StockTemp();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<double> StockTempAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockHumidity", ReplyAction="*")]
        double StockHumidity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockHumidity", ReplyAction="*")]
        System.Threading.Tasks.Task<double> StockHumidityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorTemp", ReplyAction="*")]
        double OutdoorTemp();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<double> OutdoorTempAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorHumidity", ReplyAction="*")]
        double OutdoorHumidity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorHumidity", ReplyAction="*")]
        System.Threading.Tasks.Task<double> OutdoorHumidityAsync();
        
        // CODEGEN: Generating message contract since element name StockItemsUnderMinResult from namespace http://dvimonitor.azurewebsites.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsUnderMin", ReplyAction="*")]
        Moderndesign.DVIservice.StockItemsUnderMinResponse StockItemsUnderMin(Moderndesign.DVIservice.StockItemsUnderMinRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsUnderMin", ReplyAction="*")]
        System.Threading.Tasks.Task<Moderndesign.DVIservice.StockItemsUnderMinResponse> StockItemsUnderMinAsync(Moderndesign.DVIservice.StockItemsUnderMinRequest request);
        
        // CODEGEN: Generating message contract since element name StockItemsOverMaxResult from namespace http://dvimonitor.azurewebsites.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsOverMax", ReplyAction="*")]
        Moderndesign.DVIservice.StockItemsOverMaxResponse StockItemsOverMax(Moderndesign.DVIservice.StockItemsOverMaxRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsOverMax", ReplyAction="*")]
        System.Threading.Tasks.Task<Moderndesign.DVIservice.StockItemsOverMaxResponse> StockItemsOverMaxAsync(Moderndesign.DVIservice.StockItemsOverMaxRequest request);
        
        // CODEGEN: Generating message contract since element name StockItemsMostSoldResult from namespace http://dvimonitor.azurewebsites.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsMostSold", ReplyAction="*")]
        Moderndesign.DVIservice.StockItemsMostSoldResponse StockItemsMostSold(Moderndesign.DVIservice.StockItemsMostSoldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsMostSold", ReplyAction="*")]
        System.Threading.Tasks.Task<Moderndesign.DVIservice.StockItemsMostSoldResponse> StockItemsMostSoldAsync(Moderndesign.DVIservice.StockItemsMostSoldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsUnderMinRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsUnderMin", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public Moderndesign.DVIservice.StockItemsUnderMinRequestBody Body;
        
        public StockItemsUnderMinRequest() {
        }
        
        public StockItemsUnderMinRequest(Moderndesign.DVIservice.StockItemsUnderMinRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsUnderMinRequestBody {
        
        public StockItemsUnderMinRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsUnderMinResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsUnderMinResponse", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public Moderndesign.DVIservice.StockItemsUnderMinResponseBody Body;
        
        public StockItemsUnderMinResponse() {
        }
        
        public StockItemsUnderMinResponse(Moderndesign.DVIservice.StockItemsUnderMinResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/")]
    public partial class StockItemsUnderMinResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Moderndesign.DVIservice.ArrayOfString StockItemsUnderMinResult;
        
        public StockItemsUnderMinResponseBody() {
        }
        
        public StockItemsUnderMinResponseBody(Moderndesign.DVIservice.ArrayOfString StockItemsUnderMinResult) {
            this.StockItemsUnderMinResult = StockItemsUnderMinResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsOverMaxRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsOverMax", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public Moderndesign.DVIservice.StockItemsOverMaxRequestBody Body;
        
        public StockItemsOverMaxRequest() {
        }
        
        public StockItemsOverMaxRequest(Moderndesign.DVIservice.StockItemsOverMaxRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsOverMaxRequestBody {
        
        public StockItemsOverMaxRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsOverMaxResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsOverMaxResponse", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public Moderndesign.DVIservice.StockItemsOverMaxResponseBody Body;
        
        public StockItemsOverMaxResponse() {
        }
        
        public StockItemsOverMaxResponse(Moderndesign.DVIservice.StockItemsOverMaxResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/")]
    public partial class StockItemsOverMaxResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Moderndesign.DVIservice.ArrayOfString StockItemsOverMaxResult;
        
        public StockItemsOverMaxResponseBody() {
        }
        
        public StockItemsOverMaxResponseBody(Moderndesign.DVIservice.ArrayOfString StockItemsOverMaxResult) {
            this.StockItemsOverMaxResult = StockItemsOverMaxResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsMostSoldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsMostSold", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public Moderndesign.DVIservice.StockItemsMostSoldRequestBody Body;
        
        public StockItemsMostSoldRequest() {
        }
        
        public StockItemsMostSoldRequest(Moderndesign.DVIservice.StockItemsMostSoldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsMostSoldRequestBody {
        
        public StockItemsMostSoldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsMostSoldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsMostSoldResponse", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public Moderndesign.DVIservice.StockItemsMostSoldResponseBody Body;
        
        public StockItemsMostSoldResponse() {
        }
        
        public StockItemsMostSoldResponse(Moderndesign.DVIservice.StockItemsMostSoldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/")]
    public partial class StockItemsMostSoldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Moderndesign.DVIservice.ArrayOfString StockItemsMostSoldResult;
        
        public StockItemsMostSoldResponseBody() {
        }
        
        public StockItemsMostSoldResponseBody(Moderndesign.DVIservice.ArrayOfString StockItemsMostSoldResult) {
            this.StockItemsMostSoldResult = StockItemsMostSoldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface monitorSoapChannel : Moderndesign.DVIservice.monitorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class monitorSoapClient : System.ServiceModel.ClientBase<Moderndesign.DVIservice.monitorSoap>, Moderndesign.DVIservice.monitorSoap {
        
        public monitorSoapClient() {
        }
        
        public monitorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public monitorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public monitorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public monitorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double StockTemp() {
            return base.Channel.StockTemp();
        }
        
        public System.Threading.Tasks.Task<double> StockTempAsync() {
            return base.Channel.StockTempAsync();
        }
        
        public double StockHumidity() {
            return base.Channel.StockHumidity();
        }
        
        public System.Threading.Tasks.Task<double> StockHumidityAsync() {
            return base.Channel.StockHumidityAsync();
        }
        
        public double OutdoorTemp() {
            return base.Channel.OutdoorTemp();
        }
        
        public System.Threading.Tasks.Task<double> OutdoorTempAsync() {
            return base.Channel.OutdoorTempAsync();
        }
        
        public double OutdoorHumidity() {
            return base.Channel.OutdoorHumidity();
        }
        
        public System.Threading.Tasks.Task<double> OutdoorHumidityAsync() {
            return base.Channel.OutdoorHumidityAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Moderndesign.DVIservice.StockItemsUnderMinResponse Moderndesign.DVIservice.monitorSoap.StockItemsUnderMin(Moderndesign.DVIservice.StockItemsUnderMinRequest request) {
            return base.Channel.StockItemsUnderMin(request);
        }
        
        public Moderndesign.DVIservice.ArrayOfString StockItemsUnderMin() {
            Moderndesign.DVIservice.StockItemsUnderMinRequest inValue = new Moderndesign.DVIservice.StockItemsUnderMinRequest();
            inValue.Body = new Moderndesign.DVIservice.StockItemsUnderMinRequestBody();
            Moderndesign.DVIservice.StockItemsUnderMinResponse retVal = ((Moderndesign.DVIservice.monitorSoap)(this)).StockItemsUnderMin(inValue);
            return retVal.Body.StockItemsUnderMinResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Moderndesign.DVIservice.StockItemsUnderMinResponse> Moderndesign.DVIservice.monitorSoap.StockItemsUnderMinAsync(Moderndesign.DVIservice.StockItemsUnderMinRequest request) {
            return base.Channel.StockItemsUnderMinAsync(request);
        }
        
        public System.Threading.Tasks.Task<Moderndesign.DVIservice.StockItemsUnderMinResponse> StockItemsUnderMinAsync() {
            Moderndesign.DVIservice.StockItemsUnderMinRequest inValue = new Moderndesign.DVIservice.StockItemsUnderMinRequest();
            inValue.Body = new Moderndesign.DVIservice.StockItemsUnderMinRequestBody();
            return ((Moderndesign.DVIservice.monitorSoap)(this)).StockItemsUnderMinAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Moderndesign.DVIservice.StockItemsOverMaxResponse Moderndesign.DVIservice.monitorSoap.StockItemsOverMax(Moderndesign.DVIservice.StockItemsOverMaxRequest request) {
            return base.Channel.StockItemsOverMax(request);
        }
        
        public Moderndesign.DVIservice.ArrayOfString StockItemsOverMax() {
            Moderndesign.DVIservice.StockItemsOverMaxRequest inValue = new Moderndesign.DVIservice.StockItemsOverMaxRequest();
            inValue.Body = new Moderndesign.DVIservice.StockItemsOverMaxRequestBody();
            Moderndesign.DVIservice.StockItemsOverMaxResponse retVal = ((Moderndesign.DVIservice.monitorSoap)(this)).StockItemsOverMax(inValue);
            return retVal.Body.StockItemsOverMaxResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Moderndesign.DVIservice.StockItemsOverMaxResponse> Moderndesign.DVIservice.monitorSoap.StockItemsOverMaxAsync(Moderndesign.DVIservice.StockItemsOverMaxRequest request) {
            return base.Channel.StockItemsOverMaxAsync(request);
        }
        
        public System.Threading.Tasks.Task<Moderndesign.DVIservice.StockItemsOverMaxResponse> StockItemsOverMaxAsync() {
            Moderndesign.DVIservice.StockItemsOverMaxRequest inValue = new Moderndesign.DVIservice.StockItemsOverMaxRequest();
            inValue.Body = new Moderndesign.DVIservice.StockItemsOverMaxRequestBody();
            return ((Moderndesign.DVIservice.monitorSoap)(this)).StockItemsOverMaxAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Moderndesign.DVIservice.StockItemsMostSoldResponse Moderndesign.DVIservice.monitorSoap.StockItemsMostSold(Moderndesign.DVIservice.StockItemsMostSoldRequest request) {
            return base.Channel.StockItemsMostSold(request);
        }
        
        public Moderndesign.DVIservice.ArrayOfString StockItemsMostSold() {
            Moderndesign.DVIservice.StockItemsMostSoldRequest inValue = new Moderndesign.DVIservice.StockItemsMostSoldRequest();
            inValue.Body = new Moderndesign.DVIservice.StockItemsMostSoldRequestBody();
            Moderndesign.DVIservice.StockItemsMostSoldResponse retVal = ((Moderndesign.DVIservice.monitorSoap)(this)).StockItemsMostSold(inValue);
            return retVal.Body.StockItemsMostSoldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Moderndesign.DVIservice.StockItemsMostSoldResponse> Moderndesign.DVIservice.monitorSoap.StockItemsMostSoldAsync(Moderndesign.DVIservice.StockItemsMostSoldRequest request) {
            return base.Channel.StockItemsMostSoldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Moderndesign.DVIservice.StockItemsMostSoldResponse> StockItemsMostSoldAsync() {
            Moderndesign.DVIservice.StockItemsMostSoldRequest inValue = new Moderndesign.DVIservice.StockItemsMostSoldRequest();
            inValue.Body = new Moderndesign.DVIservice.StockItemsMostSoldRequestBody();
            return ((Moderndesign.DVIservice.monitorSoap)(this)).StockItemsMostSoldAsync(inValue);
        }

        internal Task<string> GetServerTextAsync()
        {
            throw new NotImplementedException();
        }
    }
}
