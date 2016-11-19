using System;

namespace MetricaGenerator
{
    public class MetricaGeneratorService
    {
        Random rnd = new Random();

        private string _romeNumbers = "IVXCMCD";

        private string _cyrrilicChars = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЫЭЮЯ";

        private char GetRandomRomeNumber()
        {
            int romeStringIndex = rnd.Next(_romeNumbers.Length - 1);
            return _romeNumbers[romeStringIndex];
        }

        private string GetRandomCyrrylicString()
        {
            int cyrrilicStringIndex = rnd.Next(_cyrrilicChars.Length - 1);
            int cyrrilicStringIndex2 = rnd.Next(_cyrrilicChars.Length - 1);
            return _cyrrilicChars[cyrrilicStringIndex].ToString()
                   + _cyrrilicChars[cyrrilicStringIndex2].ToString();
        }

        private string GetRandomSixDigitsNumber()
        {
            return rnd.Next(999999).ToString("D6");
        }

        public string Generate()
        {
            return $"{GetRandomRomeNumber()}-{GetRandomCyrrylicString()} {GetRandomSixDigitsNumber()}";
        }
    }
}