using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.IO;
using System.Net;


namespace WcfService6
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://" + "localhost:8000/";
            ServiceHost host = new ServiceHost(typeof(Service1), new Uri(baseAddress));

            host.AddServiceEndpoint(typeof(IService1), new WebHttpBinding(), "").Behaviors.Add(new WebHttpBehavior());
            host.Open();
            //HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(baseAddress + "/Generate/ss");
            //req.Method = "GET";


        }
    }
}