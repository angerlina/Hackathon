﻿using System.ServiceModel;
using System.ServiceModel.Web;

namespace KppGenerator
{
    [ServiceContract]
    public interface IKppGeneratorService
    {

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Generate",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Generate();
    }
}
