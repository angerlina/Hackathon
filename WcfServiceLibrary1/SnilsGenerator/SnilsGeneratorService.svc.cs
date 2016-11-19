using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SnilsGenerator
{

    public class SnilsGeneratorService : ISnilsGeneratorService
    {
        private Random _rnd = new Random();
        private string _numbers = "";
        private int k = 9;
        private int sum = 0;

        private string GetNumber()
        {
            var number = _rnd.Next(0, 999).ToString("D3");
            _numbers+=number;
            return number;
  
        }

        private int GetSum()
        {
            
           for (int i=0; i<9; i++)
            {
                sum+= int.Parse(_numbers[i].ToString()) * k;
                k--;
            }
           if (sum == 100 || sum == 101)
            {
                sum = 0;
            }
            if (sum > 101)
            {
                sum = sum%101;
            }
            return sum;
        }

        public string Generate()
        {
            return String.Format("{0}-{1}-{2} {3}", GetNumber(), GetNumber(), GetNumber(), GetSum().ToString("D2"));
        }

    }
}
