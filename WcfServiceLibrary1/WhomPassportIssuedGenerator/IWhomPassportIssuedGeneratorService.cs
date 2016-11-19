using System.ServiceModel;
using System.ServiceModel.Web;

namespace WhomPassportIssuedGenerator
{
    [ServiceContract]
    public interface IWhomPassportIssuedGeneratorService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Generate",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Generate();
    }
}
