using System;

namespace SnilsGenerator
{

    public class SnilsGeneratorService : ISnilsGeneratorService
    {
        Random _rnd = new Random();
        private string _numbers = "";
        private int _k = 9;
        private int _sum = 0;

        private string GetNumber()
        {
            var number = _rnd.Next(0, 999).ToString("D3");
            _numbers += number;
            return number;
  
        }

        private int GetSum()
        {
            
           for (int i = 0; i < 9; i++)
            {
                _sum += int.Parse(_numbers[i].ToString()) * _k;
                _k--;
            }
           if (_sum == 100 || _sum == 101)
            {
                _sum = 0;
            }
            if (_sum > 101)
            {
                _sum = _sum % 101;
            }
            return _sum;
        }

        public string Generate()
        {
            return $"{GetNumber()}-{GetNumber()}-{GetNumber()} {GetSum():D2}";
        }

    }
}
