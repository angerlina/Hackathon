using System;

namespace KppGenerator { 
    public class KppGeneratorService : IKppGeneratorService
    {
        Random rnd = new Random();

        private string GenerateCodeTaxService()
        {
            return rnd
                .Next(1000, 9999)
                .ToString();
        }
        private string GenerateReason()
        {
            return rnd
                .Next(1, 99)
                .ToString()
                .PadLeft(2, '0');
        }

        private string GenerateSerialNumber()
        {
            return rnd
                .Next(999)
                .ToString()
                .PadLeft(3, '0');
        }

        public string Generate()
        {
            return GenerateCodeTaxService() + GenerateReason() + GenerateSerialNumber();
        }
    }
}