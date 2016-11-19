using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SexGenerator
{
    [ServiceContract]
    public interface ISexGeneratorService
    {
        [OperationContract]   
        [WebInvoke(Method = "GET", UriTemplate = "/Generate/{lang}",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Generate(string lang);  
    }
}
