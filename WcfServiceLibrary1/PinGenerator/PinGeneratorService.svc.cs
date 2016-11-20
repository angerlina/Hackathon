using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PinGenerator
{
    
    public class PinGeneratorService : IPinGeneratorService
    {
        Random r = new Random();
        public string Generate()
        {
            return r.Next(9999).ToString("D4");
        }
    }
}
