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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/Consultas_con_I", ReplyAction="http://tempuri.org/I_DB/Consultas_con_IResponse")]
        PolizaUI.Svc_DataBase.Consultas_con_IResponse Consultas_con_I(PolizaUI.Svc_DataBase.Consultas_con_IRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/Consultas_con_I", ReplyAction="http://tempuri.org/I_DB/Consultas_con_IResponse")]
        System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.Consultas_con_IResponse> Consultas_con_IAsync(PolizaUI.Svc_DataBase.Consultas_con_IRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/Login", ReplyAction="http://tempuri.org/I_DB/LoginResponse")]
        PolizaUI.Svc_DataBase.LoginResponse Login(PolizaUI.Svc_DataBase.LoginRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_DB/Login", ReplyAction="http://tempuri.org/I_DB/LoginResponse")]
        System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.LoginResponse> LoginAsync(PolizaUI.Svc_DataBase.LoginRequest request);
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
        public System.Data.SqlDbType DBType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string sValor;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string sMsjError;
        
        public FiltrarDatosRequest() {
        }
        
        public FiltrarDatosRequest(string sNombreSP, string sNombreParametro, System.Data.SqlDbType DBType, string sValor, string sMsjError) {
            this.sNombreSP = sNombreSP;
            this.sNombreParametro = sNombreParametro;
            this.DBType = DBType;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Login", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string sNombreSP;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.Data.DataTable dtParametros;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string sMsjError;
        
        public LoginRequest() {
        }
        
        public LoginRequest(string sNombreSP, System.Data.DataTable dtParametros, string sMsjError) {
            this.sNombreSP = sNombreSP;
            this.dtParametros = dtParametros;
            this.sMsjError = sMsjError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoginResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int LoginResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string sMsjError;
        
        public LoginResponse() {
        }
        
        public LoginResponse(int LoginResult, string sMsjError) {
            this.LoginResult = LoginResult;
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
        
        public System.Data.DataTable FiltrarDatos(string sNombreSP, string sNombreParametro, System.Data.SqlDbType DBType, string sValor, ref string sMsjError) {
            PolizaUI.Svc_DataBase.FiltrarDatosRequest inValue = new PolizaUI.Svc_DataBase.FiltrarDatosRequest();
            inValue.sNombreSP = sNombreSP;
            inValue.sNombreParametro = sNombreParametro;
            inValue.DBType = DBType;
            inValue.sValor = sValor;
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
        PolizaUI.Svc_DataBase.Consultas_con_IResponse PolizaUI.Svc_DataBase.I_DB.Consultas_con_I(PolizaUI.Svc_DataBase.Consultas_con_IRequest request) {
            return base.Channel.Consultas_con_I(request);
        }
        
        public bool Consultas_con_I(string sNombreSP, System.Data.DataTable dtParametros, ref int iValorScalar, ref string sMsjError) {
            PolizaUI.Svc_DataBase.Consultas_con_IRequest inValue = new PolizaUI.Svc_DataBase.Consultas_con_IRequest();
            inValue.sNombreSP = sNombreSP;
            inValue.dtParametros = dtParametros;
            inValue.iValorScalar = iValorScalar;
            inValue.sMsjError = sMsjError;
            PolizaUI.Svc_DataBase.Consultas_con_IResponse retVal = ((PolizaUI.Svc_DataBase.I_DB)(this)).Consultas_con_I(inValue);
            iValorScalar = retVal.iValorScalar;
            sMsjError = retVal.sMsjError;
            return retVal.Consultas_con_IResult;
        }
        
        public System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.Consultas_con_IResponse> Consultas_con_IAsync(PolizaUI.Svc_DataBase.Consultas_con_IRequest request) {
            return base.Channel.Consultas_con_IAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PolizaUI.Svc_DataBase.LoginResponse PolizaUI.Svc_DataBase.I_DB.Login(PolizaUI.Svc_DataBase.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public int Login(string sNombreSP, System.Data.DataTable dtParametros, ref string sMsjError) {
            PolizaUI.Svc_DataBase.LoginRequest inValue = new PolizaUI.Svc_DataBase.LoginRequest();
            inValue.sNombreSP = sNombreSP;
            inValue.dtParametros = dtParametros;
            inValue.sMsjError = sMsjError;
            PolizaUI.Svc_DataBase.LoginResponse retVal = ((PolizaUI.Svc_DataBase.I_DB)(this)).Login(inValue);
            sMsjError = retVal.sMsjError;
            return retVal.LoginResult;
        }
        
        public System.Threading.Tasks.Task<PolizaUI.Svc_DataBase.LoginResponse> LoginAsync(PolizaUI.Svc_DataBase.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
    }
}
