using System;

namespace CadastreGenerator
{
    public class CadastreGeneratorService : ICadastreGeneratorService
    {
        Random rnd = new Random();

        private string GenerateRegionNumber()
        {
            return rnd
                .Next(1, 99)
                .ToString()
                .PadLeft(2, '0');
        }

        private string GenerateAdministrativeDistrict()
        {
            return rnd
                .Next(1, 99)
                .ToString()
                .PadLeft(2, '0');
        }

        private string GenerateCadastreQuarter()
        {
            return rnd
                .Next(999999, 9999999)
                .ToString();
        }

        private string GenerateCadastreArea()
        {
            return rnd
                .Next(01, 99)
                .ToString()
                .PadLeft(2, '0');
        }

        public string Generate()
        {
            return GenerateRegionNumber()
                   + ":"
                   + GenerateAdministrativeDistrict()
                   + ":"
                   + GenerateCadastreQuarter()
                   + ":"
                   + GenerateCadastreArea();
        }
    }
}