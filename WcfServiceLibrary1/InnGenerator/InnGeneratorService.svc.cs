using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace InnGenerator
{
    public class InnGeneratorService : IInnGeneratorService
    {
        private List<string> _regionCodes = new List<string>();
        private List<string> _taxCodes = new List<string>();

        private Random r = new Random();

        public string Generate(string value)
        {
            string result = "";
            if ("individual".Equals(value) || "entity".Equals(value))
            {
                AddRegion();
                AddTax();

                result += _regionCodes[r.Next(0, _regionCodes.Count - 1)];
                result += _taxCodes[r.Next(0, _taxCodes.Count - 1)];
            }
            if ("individual".Equals(value))
            {
                result += RandomNumber(6);
                int[] massInt = ParseStringInArrayInt(result);

                int number = 7 * massInt[0] + 2 * massInt[1] + 4 * massInt[2] + 10 * massInt[3] + 3 * massInt[4];
                number += 5 * massInt[5] + 9 * massInt[6] + 4 * massInt[7] + 6 * massInt[8];
                if (massInt.Length == 10)
                {
                    number += 8 * massInt[9];
                }
                result += (number % 11) % 10;
                massInt = ParseStringInArrayInt(result);
                number = 3 * massInt[0] + 7 * massInt[1] + 2 * massInt[2] + 4 * massInt[3] + 10 * massInt[4] + 3 * massInt[5];
                number += 5 * massInt[6] + 9 * massInt[7] + 4 * massInt[8] + 6 * massInt[9] + 8 * massInt[10];
                if (massInt.Length == 11)
                {
                    number += 8 * massInt[10];
                }
                result += (number % 11) % 10;
            }
            if ("entity".Equals(value))
            {
                result += RandomNumber(5);

                int[] massInt = ParseStringInArrayInt(result);
                int number = 2 * massInt[0] + 4 * massInt[1] + 10 * massInt[2] + 3 * massInt[3] + 5 * massInt[4];
                number += 9 * massInt[5] + 4 * massInt[6] + 6 * massInt[7];
                if (massInt.Length == 10)
                {
                    number += 8 * massInt[8];
                }
                result += (number % 11) % 10;
            }

            return result;
        }

        private int[] ParseStringInArrayInt(string value)
        {
            int[] massInt = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                massInt[i] = int.Parse(value[i].ToString());
            }
            return massInt;

        }
        private void AddRegion()
        {
            for (int i = 1; i < 100; i++)
            {
                _regionCodes.Add(i.ToString());
            }
            string[] n = { "102", "113", "116", "121", "125", "138", "150", "190", "152", "154", "159", "161", "163", "164", "173", "174", "177", "199", "197", "198" };
            _regionCodes.AddRange(n.ToList());
        }

        private void AddTax()
        {
            for (int i = 1; i < 78; i++)
            {
                _taxCodes.Add(i.ToString());
            }
            string[] n = { "82", "83", "86", "87", "89", "92", "95" };
            _taxCodes.AddRange(n.ToList());
        }


        private string RandomNumber(int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += r.Next(0, 9);
            }
            return result;
        }
    }
}