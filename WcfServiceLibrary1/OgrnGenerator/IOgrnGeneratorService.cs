using System.ServiceModel;
using System.ServiceModel.Web;

namespace OgrnGenerator
{  
    [ServiceContract]
    public interface IOgrnGeneratorService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Generate/{value}",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Generate(string value);
    }
}
