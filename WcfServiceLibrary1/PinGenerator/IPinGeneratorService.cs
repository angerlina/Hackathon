using System.ServiceModel;
using System.ServiceModel.Web;

namespace PinGenerator
{
    [ServiceContract]
    public interface IPinGeneratorService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Generate",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Generate();
    }
}
