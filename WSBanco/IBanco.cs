using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WSBanco
{
    [ServiceContract]
    public interface IBanco
    {
        //<!--http://localhost:22661/Banco.svc/ordenesPago/1/1/soles-->
        [WebInvoke(Method = "GET", UriTemplate = "/ordenesPago/{idBanc}/{idSuc}/{TipMon}",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [OperationContract]
        List<BE.BEOrdenPago> ordenesPago(string idBanc, string idSuc, string TipMon);




        //<!--http://localhost:22661/Banco.svc/Obtenersucursal/1-->
        [WebInvoke(Method = "GET", UriTemplate = "/obtenerSucursal/{idBanc}",
        ResponseFormat = WebMessageFormat.Xml,
        BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [OperationContract]
        List<BE.BESucursal> obtenerSucursal(string idBanc);
    }
}
