﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PolizaUI.Svc_DataBase {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Svc_DataBase.I_DB")]
    public interface I_DB {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/ListarDatos", ReplyAction="http://tempuri.org/I_DB/ListarDatosResponse")]
        PolizaUI.Svc_DataBase.ListarDatosResponse ListarDatos(PolizaUI.Svc_DataBase.ListarDatosRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/ListarDatos", ReplyAction="http://tempuri.org/I_DB/ListarDatosResponse")]
        System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.ListarDatosResponse> ListarDatosAsync(PolizaUI.Svc_DataBase.ListarDatosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/FiltrarDatos", ReplyAction="http://tempuri.org/I_DB/FiltrarDatosResponse")]
        PolizaUI.Svc_DataBase.FiltrarDatosResponse FiltrarDatos(PolizaUI.Svc_DataBase.FiltrarDatosRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/FiltrarDatos", ReplyAction="http://tempuri.org/I_DB/FiltrarDatosResponse")]
        System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.FiltrarDatosResponse> FiltrarDatosAsync(PolizaUI.Svc_DataBase.FiltrarDatosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/Consultas_sin_I", ReplyAction="http://tempuri.org/I_DB/Consultas_sin_IResponse")]
        PolizaUI.Svc_DataBase.Consultas_sin_IResponse Consultas_sin_I(PolizaUI.Svc_DataBase.Consultas_sin_IRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/Consultas_sin_I", ReplyAction="http://tempuri.org/I_DB/Consultas_sin_IResponse")]
        System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.Consultas_sin_IResponse> Consultas_sin_IAsync(PolizaUI.Svc_DataBase.Consultas_sin_IRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/Consuultas_con_I", ReplyAction="http://tempuri.org/I_DB/Consuultas_con_IResponse")]
        PolizaUI.Svc_DataBase.Consuultas_con_IResponse Consuultas_con_I(PolizaUI.Svc_DataBase.Consuultas_con_IRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/Consuultas_con_I", ReplyAction="http://tempuri.org/I_DB/Consuultas_con_IResponse")]
        System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.Consuultas_con_IResponse> Consuultas_con_IAsync(PolizaUI.Svc_DataBase.Consuultas_con_IRequest request);
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
        public string sMsjError;
        
        public FiltrarDatosRequest() {
        }
        
        public FiltrarDatosRequest(string sNombreSP, string sNombreParametro, string sMsjError) {
            this.sNombreSP = sNombreSP;
            this.sNombreParametro = sNombreParametro;
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="Consuultas_con_I", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Consuultas_con_IRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string sNombreSP;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.Data.DataTable dtParametros;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string sValorScalar;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string sMsjError;
        
        public Consuultas_con_IRequest() {
        }
        
        public Consuultas_con_IRequest(string sNombreSP, System.Data.DataTable dtParametros, string sValorScalar, string sMsjError) {
            this.sNombreSP = sNombreSP;
            this.dtParametros = dtParametros;
            this.sValorScalar = sValorScalar;
            this.sMsjError = sMsjError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Consuultas_con_IResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Consuultas_con_IResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Consuultas_con_IResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string sValorScalar;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string sMsjError;
        
        public Consuultas_con_IResponse() {
        }
        
        public Consuultas_con_IResponse(string Consuultas_con_IResult, string sValorScalar, string sMsjError) {
            this.Consuultas_con_IResult = Consuultas_con_IResult;
            this.sValorScalar = sValorScalar;
            this.sMsjError = sMsjError;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface I_DBChannel : PolizaUI.Svc_DataBase.I_DB, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class I_DBClient : System.ServiceModel.ClientBase<PolizaUI.Svc_DataBase.I_DB>, PolizaUI.Svc_DataBase.I_DB {
        
        public I_DBClient() {
        }
        
        public I_DBClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public I_DBClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public I_DBClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public I_DBClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PolizaUI.Svc_DataBase.ListarDatosResponse PolizaUI.Svc_DataBase.I_DB.ListarDatos(PolizaUI.Svc_DataBase.ListarDatosRequest request) {
            return base.Channel.ListarDatos(request);
        }
        
        public System.Data.DataTable ListarDatos(string sNombreSP, ref string sMsjError) {
            PolizaUI.Svc_DataBase.ListarDatosRequest inValue = new PolizaUI.Svc_DataBase.ListarDatosRequest();
            inValue.sNombreSP = sNombreSP;
            inValue.sMsjError = sMsjError;
            PolizaUI.Svc_DataBase.ListarDatosResponse retVal = ((PolizaUI.Svc_DataBase.I_DB)(this)).ListarDatos(inValue);
            sMsjError = retVal.sMsjError;
            return retVal.ListarDatosResult;
        }
        
        public System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.ListarDatosResponse> ListarDatosAsync(PolizaUI.Svc_DataBase.ListarDatosRequest request) {
            return base.Channel.ListarDatosAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PolizaUI.Svc_DataBase.FiltrarDatosResponse PolizaUI.Svc_DataBase.I_DB.FiltrarDatos(PolizaUI.Svc_DataBase.FiltrarDatosRequest request) {
            return base.Channel.FiltrarDatos(request);
        }
        
        public System.Data.DataTable FiltrarDatos(string sNombreSP, string sNombreParametro, ref string sMsjError) {
            PolizaUI.Svc_DataBase.FiltrarDatosRequest inValue = new PolizaUI.Svc_DataBase.FiltrarDatosRequest();
            inValue.sNombreSP = sNombreSP;
            inValue.sNombreParametro = sNombreParametro;
            inValue.sMsjError = sMsjError;
            PolizaUI.Svc_DataBase.FiltrarDatosResponse retVal = ((PolizaUI.Svc_DataBase.I_DB)(this)).FiltrarDatos(inValue);
            sMsjError = retVal.sMsjError;
            return retVal.FiltrarDatosResult;
        }
        
        public System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.FiltrarDatosResponse> FiltrarDatosAsync(PolizaUI.Svc_DataBase.FiltrarDatosRequest request) {
            return base.Channel.FiltrarDatosAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PolizaUI.Svc_DataBase.Consultas_sin_IResponse PolizaUI.Svc_DataBase.I_DB.Consultas_sin_I(PolizaUI.Svc_DataBase.Consultas_sin_IRequest request) {
            return base.Channel.Consultas_sin_I(request);
        }
        
        public bool Consultas_sin_I(string sNombreSP, System.Data.DataTable dtParametros, ref string sMsjError) {
            PolizaUI.Svc_DataBase.Consultas_sin_IRequest inValue = new PolizaUI.Svc_DataBase.Consultas_sin_IRequest();
            inValue.sNombreSP = sNombreSP;
            inValue.dtParametros = dtParametros;
            inValue.sMsjError = sMsjError;
            PolizaUI.Svc_DataBase.Consultas_sin_IResponse retVal = ((PolizaUI.Svc_DataBase.I_DB)(this)).Consultas_sin_I(inValue);
            sMsjError = retVal.sMsjError;
            return retVal.Consultas_sin_IResult;
        }
        
        public System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.Consultas_sin_IResponse> Consultas_sin_IAsync(PolizaUI.Svc_DataBase.Consultas_sin_IRequest request) {
            return base.Channel.Consultas_sin_IAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PolizaUI.Svc_DataBase.Consuultas_con_IResponse PolizaUI.Svc_DataBase.I_DB.Consuultas_con_I(PolizaUI.Svc_DataBase.Consuultas_con_IRequest request) {
            return base.Channel.Consuultas_con_I(request);
        }
        
        public string Consuultas_con_I(string sNombreSP, System.Data.DataTable dtParametros, ref string sValorScalar, ref string sMsjError) {
            PolizaUI.Svc_DataBase.Consuultas_con_IRequest inValue = new PolizaUI.Svc_DataBase.Consuultas_con_IRequest();
            inValue.sNombreSP = sNombreSP;
            inValue.dtParametros = dtParametros;
            inValue.sValorScalar = sValorScalar;
            inValue.sMsjError = sMsjError;
            PolizaUI.Svc_DataBase.Consuultas_con_IResponse retVal = ((PolizaUI.Svc_DataBase.I_DB)(this)).Consuultas_con_I(inValue);
            sValorScalar = retVal.sValorScalar;
            sMsjError = retVal.sMsjError;
            return retVal.Consuultas_con_IResult;
        }
        
        public System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.Consuultas_con_IResponse> Consuultas_con_IAsync(PolizaUI.Svc_DataBase.Consuultas_con_IRequest request) {
            return base.Channel.Consuultas_con_IAsync(request);
        }
    }
}