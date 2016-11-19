using System.ServiceModel;
using System.ServiceModel.Web;

namespace CvvGenerator
{
    [ServiceContract]
    public interface ICvvGeneratorService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Generate",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Generate();
    }
}
