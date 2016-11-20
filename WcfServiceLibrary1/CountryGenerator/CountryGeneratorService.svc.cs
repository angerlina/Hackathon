using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CountryGenerator
{
    public class CountryGeneratorService : ICountryGeneratorService
    {
        private Dictionary<string, string> _countyr = new Dictionary<string, string>();

        public CountryGeneratorService()
        {
            _countyr.Add("ru", "Russia");
            _countyr.Add("de", "German");
            _countyr.Add("fr", "Franch");
            _countyr.Add("ch", "China");
            _countyr.Add("en", "England");
            _countyr.Add("it", "Italy");
            _countyr.Add("sp", "Spanish");
            _countyr.Add("jp", "Japan");

        }

        public string Generate(string value)
        {
            return _countyr[value];
        }

    }
}
