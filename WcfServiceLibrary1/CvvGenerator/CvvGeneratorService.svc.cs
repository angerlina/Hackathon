using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CvvGenerator
{  
    public class CvvGeneratorService : ICvvGeneratorService
    {
        Random r = new Random();
        public string Generate()
        {
            return r.Next(0,999).ToString("D3");
        }
    }
}
