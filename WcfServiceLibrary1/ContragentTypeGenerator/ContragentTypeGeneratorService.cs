using System;

namespace ContragentTypeGenerator
{
    public class ContragentTypeGeneratorService
    {
        private string[] _typeList =
        {
            "Организация",
            "Физическое лицо",
            "Предприниматель",
            "Филиал"
        };

        public string Generate()
        {
            Random rnd = new Random();
            return _typeList[rnd.Next(_typeList.Length - 1)];
        }
    }
}