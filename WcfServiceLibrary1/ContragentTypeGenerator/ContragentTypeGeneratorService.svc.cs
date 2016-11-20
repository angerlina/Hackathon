using System;

namespace ContragentTypeGenerator
{
    public class ContragentTypeGeneratorService : IContragentTypeGeneratorService
    {
        private string[] _typeList =
        {
            "клиент", "конкурент", "контактное лицо", "подрядчик",
            "партнер", "поставщик", "собственная компания", "сотрудник"

        };

        public string Generate()
        {
            Random rnd = new Random();
            return _typeList[rnd.Next(_typeList.Length - 1)];
        }
    }
}