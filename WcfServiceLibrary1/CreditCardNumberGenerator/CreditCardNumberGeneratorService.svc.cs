using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CreditCardNumberGenerator
{ 
    public class CreditCardNumberGeneratorService : ICreditCardNumberGeneratorService
    {
        public CreditCardNumberGeneratorService()
        {
            _numberList = new List<string>();

            _numberList.AddRange(_arr);
            for (int i = 3528; i < 3589; i++)
            {
                _numberList.Add(i.ToString());
            }
            for (int i = 622126; i < 622925; i++)
            {
                _numberList.Add(i.ToString());
            }
            for (int i = 622126; i < 622925; i++)
            {
                _numberList.Add(i.ToString());
            }
        }
        private Random r = new Random();
        private List<string> _numberList;
        private string[] _arr = { "4", "4026", "417500", "4508", "4844", "4913", "4917", "51", "52", "53", "54", "55",
            "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763", "6304", "6706", "6771", "6709",
            "637", "638", "639", "6011", "65", "54", "36", "300", "301", "302", "303", "304", "305", "34", "37" };

        private string BaseNumber()
        {
            
            var _iin = _numberList[r.Next(0, _numberList.Count - 1)];
            var _str = _iin.ToString().PadRight(6, '0');
            _str += randomNumberFor(9);
            _str += randomNumberFor(r.Next(0, 3));
            int count = _str.Length;
            controlNumber(_str, _str.Length % 2 == 0);
            return _str;
        }

        private string randomNumberFor(int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += r.Next(0, 9);
            }
            return result;

        }

        private string controlNumber(string value, bool even)
        {
            string result = "";
            if (even)
            {
                int number = 0;
                for(int i = 0; i < value.Length; i += 2)
                {
                    if((int.Parse(value)*2) > 9)
                    {
                       // number
                    }
                }
            }
            return result;
        }

        public string Generate()
        {
           return BaseNumber();

        }

    }
}

