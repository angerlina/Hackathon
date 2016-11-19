﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RankGenerator
{

    [ServiceContract]
    public interface IRankGeneratorService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Generate",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Generate();

    }


}