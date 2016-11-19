using System.ServiceModel;
using System.ServiceModel.Web;

namespace EmailGenerator
{
    [ServiceContract]
    public interface IEmailGeneratorService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Generate/{value}",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Generate(string value);
    }
}
