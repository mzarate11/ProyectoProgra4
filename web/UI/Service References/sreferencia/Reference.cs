﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI.sreferencia {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="sreferencia.Iservicio")]
    public interface Iservicio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iservicio/ListarDatos", ReplyAction="http://tempuri.org/Iservicio/ListarDatosResponse")]
        UI.sreferencia.ListarDatosResponse ListarDatos(UI.sreferencia.ListarDatosRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iservicio/ListarDatos", ReplyAction="http://tempuri.org/Iservicio/ListarDatosResponse")]
        System.Threading.Tasks.Task<UI.sreferencia.ListarDatosResponse> ListarDatosAsync(UI.sreferencia.ListarDatosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iservicio/FiltrarDatos", ReplyAction="http://tempuri.org/Iservicio/FiltrarDatosResponse")]
        UI.sreferencia.FiltrarDatosResponse FiltrarDatos(UI.sreferencia.FiltrarDatosRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iservicio/FiltrarDatos", ReplyAction="http://tempuri.org/Iservicio/FiltrarDatosResponse")]
        System.Threading.Tasks.Task<UI.sreferencia.FiltrarDatosResponse> FiltrarDatosAsync(UI.sreferencia.FiltrarDatosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iservicio/Consultas_sin_I", ReplyAction="http://tempuri.org/Iservicio/Consultas_sin_IResponse")]
        UI.sreferencia.Consultas_sin_IResponse Consultas_sin_I(UI.sreferencia.Consultas_sin_IRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iservicio/Consultas_sin_I", ReplyAction="http://tempuri.org/Iservicio/Consultas_sin_IResponse")]
        System.Threading.Tasks.Task<UI.sreferencia.Consultas_sin_IResponse> Consultas_sin_IAsync(UI.sreferencia.Consultas_sin_IRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iservicio/Consultas_con_I", ReplyAction="http://tempuri.org/Iservicio/Consultas_con_IResponse")]
        UI.sreferencia.Consultas_con_IResponse Consultas_con_I(UI.sreferencia.Consultas_con_IRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iservicio/Consultas_con_I", ReplyAction="http://tempuri.org/Iservicio/Consultas_con_IResponse")]
        System.Threading.Tasks.Task<UI.sreferencia.Consultas_con_IResponse> Consultas_con_IAsync(UI.sreferencia.Consultas_con_IRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListarDatos", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ListarDatosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string sNombreSP;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string sMsjError;
        
        public ListarDatosRequest() {
        }
        
        public ListarDatosRequest(string sNombreSP, string sMsjError) {
            this.sNombreSP = sNombreSP;
            this.sMsjError = sMsjError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListarDatosResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ListarDatosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataTable ListarDatosResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string sMsjError;
        
        public ListarDatosResponse() {
        }
        
        public ListarDatosResponse(System.Data.DataTable ListarDatosResult, string sMsjError) {
            this.ListarDatosResult = ListarDatosResult;
            this.sMsjError = sMsjError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FiltrarDatos", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FiltrarDatosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string sNombreSP;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string sNombreParametro;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public System.Data.SqlDbType DBTypr;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string sValor;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string sMsjError;
        
        public FiltrarDatosRequest() {
        }
        
        public FiltrarDatosRequest(string sNombreSP, string sNombreParametro, System.Data.SqlDbType DBTypr, string sValor, string sMsjError) {
            this.sNombreSP = sNombreSP;
            this.sNombreParametro = sNombreParametro;
            this.DBTypr = DBTypr;
            this.sValor = sValor;
            this.sMsjError = sMsjError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FiltrarDatosResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FiltrarDatosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataTable FiltrarDatosResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string sMsjError;
        
        public FiltrarDatosResponse() {
        }
        
        public FiltrarDatosResponse(System.Data.DataTable FiltrarDatosResult, string sMsjError) {
            this.FiltrarDatosResult = FiltrarDatosResult;
            this.sMsjError = sMsjError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Consultas_sin_I", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Consultas_sin_IRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string sNombreSP;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.Data.DataTable dtParametros;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string sMsjError;
        
        public Consultas_sin_IRequest() {
        }
        
        public Consultas_sin_IRequest(string sNombreSP, System.Data.DataTable dtParametros, string sMsjError) {
            this.sNombreSP = sNombreSP;
            this.dtParametros = dtParametros;
            this.sMsjError = sMsjError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Consultas_sin_IResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Consultas_sin_IResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool Consultas_sin_IResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string sMsjError;
        
        public Consultas_sin_IResponse() {
        }
        
        public Consultas_sin_IResponse(bool Consultas_sin_IResult, string sMsjError) {
            this.Consultas_sin_IResult = Consultas_sin_IResult;
            this.sMsjError = sMsjError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Consultas_con_I", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Consultas_con_IRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string sNombreSP;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.Data.DataTable dtParametros;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int iValorScalar;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string sMsjError;
        
        public Consultas_con_IRequest() {
        }
        
        public Consultas_con_IRequest(string sNombreSP, System.Data.DataTable dtParametros, int iValorScalar, string sMsjError) {
            this.sNombreSP = sNombreSP;
            this.dtParametros = dtParametros;
            this.iValorScalar = iValorScalar;
            this.sMsjError = sMsjError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Consultas_con_IResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Consultas_con_IResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool Consultas_con_IResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int iValorScalar;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string sMsjError;
        
        public Consultas_con_IResponse() {
        }
        
        public Consultas_con_IResponse(bool Consultas_con_IResult, int iValorScalar, string sMsjError) {
            this.Consultas_con_IResult = Consultas_con_IResult;
            this.iValorScalar = iValorScalar;
            this.sMsjError = sMsjError;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IservicioChannel : UI.sreferencia.Iservicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IservicioClient : System.ServiceModel.ClientBase<UI.sreferencia.Iservicio>, UI.sreferencia.Iservicio {
        
        public IservicioClient() {
        }
        
        public IservicioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IservicioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IservicioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IservicioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UI.sreferencia.ListarDatosResponse UI.sreferencia.Iservicio.ListarDatos(UI.sreferencia.ListarDatosRequest request) {
            return base.Channel.ListarDatos(request);
        }
        
        public System.Data.DataTable ListarDatos(string sNombreSP, ref string sMsjError) {
            UI.sreferencia.ListarDatosRequest inValue = new UI.sreferencia.ListarDatosRequest();
            inValue.sNombreSP = sNombreSP;
            inValue.sMsjError = sMsjError;
            UI.sreferencia.ListarDatosResponse retVal = ((UI.sreferencia.Iservicio)(this)).ListarDatos(inValue);
            sMsjError = retVal.sMsjError;
            return retVal.ListarDatosResult;
        }
        
        public System.Threading.Tasks.Task<UI.sreferencia.ListarDatosResponse> ListarDatosAsync(UI.sreferencia.ListarDatosRequest request) {
            return base.Channel.ListarDatosAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UI.sreferencia.FiltrarDatosResponse UI.sreferencia.Iservicio.FiltrarDatos(UI.sreferencia.FiltrarDatosRequest request) {
            return base.Channel.FiltrarDatos(request);
        }
        
        public System.Data.DataTable FiltrarDatos(string sNombreSP, string sNombreParametro, System.Data.SqlDbType DBTypr, string sValor, ref string sMsjError) {
            UI.sreferencia.FiltrarDatosRequest inValue = new UI.sreferencia.FiltrarDatosRequest();
            inValue.sNombreSP = sNombreSP;
            inValue.sNombreParametro = sNombreParametro;
            inValue.DBTypr = DBTypr;
            inValue.sValor = sValor;
            inValue.sMsjError = sMsjError;
            UI.sreferencia.FiltrarDatosResponse retVal = ((UI.sreferencia.Iservicio)(this)).FiltrarDatos(inValue);
            sMsjError = retVal.sMsjError;
            return retVal.FiltrarDatosResult;
        }
        
        public System.Threading.Tasks.Task<UI.sreferencia.FiltrarDatosResponse> FiltrarDatosAsync(UI.sreferencia.FiltrarDatosRequest request) {
            return base.Channel.FiltrarDatosAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UI.sreferencia.Consultas_sin_IResponse UI.sreferencia.Iservicio.Consultas_sin_I(UI.sreferencia.Consultas_sin_IRequest request) {
            return base.Channel.Consultas_sin_I(request);
        }
        
        public bool Consultas_sin_I(string sNombreSP, System.Data.DataTable dtParametros, ref string sMsjError) {
            UI.sreferencia.Consultas_sin_IRequest inValue = new UI.sreferencia.Consultas_sin_IRequest();
            inValue.sNombreSP = sNombreSP;
            inValue.dtParametros = dtParametros;
            inValue.sMsjError = sMsjError;
            UI.sreferencia.Consultas_sin_IResponse retVal = ((UI.sreferencia.Iservicio)(this)).Consultas_sin_I(inValue);
            sMsjError = retVal.sMsjError;
            return retVal.Consultas_sin_IResult;
        }
        
        public System.Threading.Tasks.Task<UI.sreferencia.Consultas_sin_IResponse> Consultas_sin_IAsync(UI.sreferencia.Consultas_sin_IRequest request) {
            return base.Channel.Consultas_sin_IAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UI.sreferencia.Consultas_con_IResponse UI.sreferencia.Iservicio.Consultas_con_I(UI.sreferencia.Consultas_con_IRequest request) {
            return base.Channel.Consultas_con_I(request);
        }
        
        public bool Consultas_con_I(string sNombreSP, System.Data.DataTable dtParametros, ref int iValorScalar, ref string sMsjError) {
            UI.sreferencia.Consultas_con_IRequest inValue = new UI.sreferencia.Consultas_con_IRequest();
            inValue.sNombreSP = sNombreSP;
            inValue.dtParametros = dtParametros;
            inValue.iValorScalar = iValorScalar;
            inValue.sMsjError = sMsjError;
            UI.sreferencia.Consultas_con_IResponse retVal = ((UI.sreferencia.Iservicio)(this)).Consultas_con_I(inValue);
            iValorScalar = retVal.iValorScalar;
            sMsjError = retVal.sMsjError;
            return retVal.Consultas_con_IResult;
        }
        
        public System.Threading.Tasks.Task<UI.sreferencia.Consultas_con_IResponse> Consultas_con_IAsync(UI.sreferencia.Consultas_con_IRequest request) {
            return base.Channel.Consultas_con_IAsync(request);
        }
    }
}
