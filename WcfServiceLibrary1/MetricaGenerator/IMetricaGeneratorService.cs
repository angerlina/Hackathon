using System.ServiceModel;
using System.ServiceModel.Web;

namespace MetricaGenerator
{
    [ServiceContract]
    public interface IMetricaGeneratorService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Generate",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Generate();
    }
}
