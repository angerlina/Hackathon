using System;

namespace SexGenerator
{
    public class SexGeneratorService : ISexGeneratorService
    {
        Random r = new Random();
        private string[][] _arr = new string[][] { new string[] {"мужской", "женский"},
                                                   new string[] {"male", "female"},
                                                   new string[] { "männlich", "weiblich" },
                                                   new string[] { "mâle", "femelle" },
                                                   new string[] { "男性", "女性" }};
       
        public string Generate(string value)
        {
            value = value.ToLower();
          switch (value)
            {
                case "ru": return _arr[0][r.Next(1)];
                case "en": return _arr[1][r.Next(1)];
                case "de": return _arr[2][r.Next(1)];
                case "fr": return _arr[3][r.Next(1)];
                case "ch": return _arr[4][r.Next(1)];
                default: return "incorrect parametr";

            }
        }
    }
}
