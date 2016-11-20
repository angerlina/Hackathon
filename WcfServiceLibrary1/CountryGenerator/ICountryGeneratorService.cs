using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CountryGenerator
{
    [ServiceContract]
    public interface ICountryGeneratorService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Generate/{value}",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Generate(string value);
    }
}
