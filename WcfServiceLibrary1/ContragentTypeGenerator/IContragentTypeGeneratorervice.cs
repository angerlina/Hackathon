using System.ServiceModel;
using System.ServiceModel.Web;

namespace ContragentTypeGenerator
{
    [ServiceContract]
    public interface IContragentTypeGeneratorService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Generate",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Generate();
    }
}
