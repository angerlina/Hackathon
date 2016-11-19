using System;
using System.Collections.Generic;

namespace StreetTypeGenerator
{
    public class StreetTypeGeneratorService : IStreetTypeGeneratorService
    {
        private List<string> _streetTypeList = new List<string>();

        public StreetTypeGeneratorService()
        {
            _streetTypeList.Add("Аллея");
            _streetTypeList.Add("Бульвар");
            _streetTypeList.Add("Набережная");
            _streetTypeList.Add("Переулок");
            _streetTypeList.Add("Площадь");
            _streetTypeList.Add("Проезд");
            _streetTypeList.Add("Просека");
            _streetTypeList.Add("Проспекты");
            _streetTypeList.Add("Тупики");
            _streetTypeList.Add("Шоссе");
            _streetTypeList.Add("Улица");
            _streetTypeList.Add("Авеню");
            _streetTypeList.Add("Взвоз");
            _streetTypeList.Add("Дорожка");
            _streetTypeList.Add("Корниш");
            _streetTypeList.Add("Линия");
            _streetTypeList.Add("Магистраль");
            _streetTypeList.Add("Магистральная улица");
            _streetTypeList.Add("Педвей");
            _streetTypeList.Add("Проспкт");
            _streetTypeList.Add("Разъезд");
            _streetTypeList.Add("Тракт");
            _streetTypeList.Add("Трамвайно-пешеходная улица");
            _streetTypeList.Add("Тупик");
            _streetTypeList.Add("Эспланада");
        }

        public string Generate()
        {
            Random rnd = new Random();
            int listIndex = rnd.Next(_streetTypeList.Count - 1);
            return _streetTypeList[listIndex];
        }
    }
}
