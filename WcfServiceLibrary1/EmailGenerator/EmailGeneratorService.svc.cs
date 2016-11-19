using System;

namespace EmailGenerator
{
    public class EmailGeneratorService : IEmailGeneratorService
    {
        private readonly string _abc = "abcdefghijklmnopqrstuvwxyz1234567890_-.";

        private string GenerateNameWithoutDomain()
        {
            Random rnd = new Random();
            int emailLength = rnd.Next(20);
            string name = "";
            for (int i = 0; i < emailLength; i++)
            {
                int index = rnd.Next(1, _abc.Length);
                name += _abc[index];
            }
            return name;
        }



        public string Generate(string domain)
        {
            return String.Format("{0}@{1}", GenerateNameWithoutDomain(), domain);
        }
    }
}