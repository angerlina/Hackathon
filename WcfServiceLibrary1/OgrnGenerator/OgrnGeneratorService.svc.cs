using System;
using System.Collections.Generic;

namespace OgrnGenerator
{
    public class OgrnGeneratorService : IOgrnGeneratorService
    {
        Exception ex = new Exception("Введенное значение не является 1 или 2");
        private List<int> _countrySubjectSerialNumbers = new List<int>();

        Random rnd = new Random();

        private readonly int[] _jurPriznakNumber = new[]
        {
            1,
            5,
            2,
            6,
            7,
            8,
            9,
            4
        };

        private readonly int[] _ipPriznakNumber = new[]
        {
            3,
            4
        };

        public OgrnGeneratorService()
        {
            _countrySubjectSerialNumbers.Capacity = 100;
            _countrySubjectSerialNumbers.Add(1);
            _countrySubjectSerialNumbers.Add(2);
            _countrySubjectSerialNumbers.Add(3);
            _countrySubjectSerialNumbers.Add(4);
            _countrySubjectSerialNumbers.Add(5);
            _countrySubjectSerialNumbers.Add(6);
            _countrySubjectSerialNumbers.Add(7);
            _countrySubjectSerialNumbers.Add(8);
            _countrySubjectSerialNumbers.Add(9);
            _countrySubjectSerialNumbers.Add(10);
            _countrySubjectSerialNumbers.Add(11);
            _countrySubjectSerialNumbers.Add(12);
            _countrySubjectSerialNumbers.Add(13);
            _countrySubjectSerialNumbers.Add(14);
            _countrySubjectSerialNumbers.Add(15);
            _countrySubjectSerialNumbers.Add(16);
            _countrySubjectSerialNumbers.Add(17);
            _countrySubjectSerialNumbers.Add(18);
            _countrySubjectSerialNumbers.Add(19);
            _countrySubjectSerialNumbers.Add(20);
            _countrySubjectSerialNumbers.Add(21);
            _countrySubjectSerialNumbers.Add(22);
            _countrySubjectSerialNumbers.Add(23);
            _countrySubjectSerialNumbers.Add(24);
            _countrySubjectSerialNumbers.Add(25);
            _countrySubjectSerialNumbers.Add(26);
            _countrySubjectSerialNumbers.Add(27);
            _countrySubjectSerialNumbers.Add(28);
            _countrySubjectSerialNumbers.Add(29);
            _countrySubjectSerialNumbers.Add(30);
            _countrySubjectSerialNumbers.Add(31);
            _countrySubjectSerialNumbers.Add(32);
            _countrySubjectSerialNumbers.Add(33);
            _countrySubjectSerialNumbers.Add(34);
            _countrySubjectSerialNumbers.Add(35);
            _countrySubjectSerialNumbers.Add(36);
            _countrySubjectSerialNumbers.Add(37);
            _countrySubjectSerialNumbers.Add(38);
            _countrySubjectSerialNumbers.Add(39);
            _countrySubjectSerialNumbers.Add(40);
            _countrySubjectSerialNumbers.Add(41);
            _countrySubjectSerialNumbers.Add(42);
            _countrySubjectSerialNumbers.Add(43);
            _countrySubjectSerialNumbers.Add(44);
            _countrySubjectSerialNumbers.Add(45);
            _countrySubjectSerialNumbers.Add(46);
            _countrySubjectSerialNumbers.Add(47);
            _countrySubjectSerialNumbers.Add(48);
            _countrySubjectSerialNumbers.Add(49);
            _countrySubjectSerialNumbers.Add(50);
            _countrySubjectSerialNumbers.Add(51);
            _countrySubjectSerialNumbers.Add(52);
            _countrySubjectSerialNumbers.Add(53);
            _countrySubjectSerialNumbers.Add(54);
            _countrySubjectSerialNumbers.Add(55);
            _countrySubjectSerialNumbers.Add(56);
            _countrySubjectSerialNumbers.Add(57);
            _countrySubjectSerialNumbers.Add(58);
            _countrySubjectSerialNumbers.Add(59);
            _countrySubjectSerialNumbers.Add(60);
            _countrySubjectSerialNumbers.Add(61);
            _countrySubjectSerialNumbers.Add(62);
            _countrySubjectSerialNumbers.Add(63);
            _countrySubjectSerialNumbers.Add(64);
            _countrySubjectSerialNumbers.Add(65);
            _countrySubjectSerialNumbers.Add(66);
            _countrySubjectSerialNumbers.Add(67);
            _countrySubjectSerialNumbers.Add(68);
            _countrySubjectSerialNumbers.Add(69);
            _countrySubjectSerialNumbers.Add(70);
            _countrySubjectSerialNumbers.Add(71);
            _countrySubjectSerialNumbers.Add(72);
            _countrySubjectSerialNumbers.Add(73);
            _countrySubjectSerialNumbers.Add(74);
            _countrySubjectSerialNumbers.Add(75);
            _countrySubjectSerialNumbers.Add(76);
            _countrySubjectSerialNumbers.Add(77);
            _countrySubjectSerialNumbers.Add(78);
            _countrySubjectSerialNumbers.Add(79);
            _countrySubjectSerialNumbers.Add(83);
            _countrySubjectSerialNumbers.Add(86);
            _countrySubjectSerialNumbers.Add(87);
            _countrySubjectSerialNumbers.Add(89);
            _countrySubjectSerialNumbers.Add(91);
            _countrySubjectSerialNumbers.Add(92);
        }

        private string GenerateLastTwoYearDigits()
        {
            int digitsResult = rnd.Next(99);
            return digitsResult.ToString().PadLeft(2, '0');
        }

        private string GenerateRecordNumber()
        {
            int digitsResult = rnd.Next(99999);
            return digitsResult.ToString().PadLeft(5, '0');
        }

        private long GenerateNumberWithoutCheckSum(int param)
        {
            string firstBlock = "";
            string secondBlock = GenerateLastTwoYearDigits();
            int countrySubjArray = _countrySubjectSerialNumbers[rnd.Next(_countrySubjectSerialNumbers.Count) - 1];
            string thirdBlock = countrySubjArray
                                .ToString()
                                .PadLeft(2, '0');
            string forthBlock = thirdBlock;
            string fifthBlock = GenerateRecordNumber();
            if (param == 1)
            {
                firstBlock = _jurPriznakNumber[rnd.Next(_jurPriznakNumber.Length)]
                             .ToString();

            }
            else
            {
                firstBlock = _ipPriznakNumber[rnd.Next(_ipPriznakNumber.Length)]
                             .ToString();
            }

            return Int64.Parse(firstBlock + secondBlock + forthBlock + fifthBlock);
        }

        public string Generate(int intParam)
        {
            if (intParam != 1 & intParam != 2)
            {
                throw ex;
            }
            string param = intParam.ToString();
            long number = GenerateNumberWithoutCheckSum(int.Parse(param));
            string preCheckSum = (number % 11).ToString();
            string checkSum = preCheckSum[preCheckSum.Length - 1].ToString();
            return number.ToString() + checkSum;
        }
    }
}