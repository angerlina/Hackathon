using System;

namespace CvvGenerator
{  
    public class CvvGeneratorService : ICvvGeneratorService
    {
        Random r = new Random();
        public string Generate()
        {
            return r.Next(0,999).ToString("D3");
        }
    }
}
