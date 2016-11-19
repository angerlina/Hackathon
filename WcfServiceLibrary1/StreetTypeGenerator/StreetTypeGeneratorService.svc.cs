using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StreetTypeGenerator
{
    public class StreetTypeGeneratorService : IStreetTypeGeneratorService
    {
        private List<string> streetTypeList = new List<string>();

        public StreetTypeGeneratorService()
        {
            streetTypeList.Add("Аллея");
            streetTypeList.Add("Бульвар");
            streetTypeList.Add("Набережная");
            streetTypeList.Add("Переулок");
            streetTypeList.Add("Площадь");
            streetTypeList.Add("Проезд");
            streetTypeList.Add("Просека");
            streetTypeList.Add("Проспекты");
            streetTypeList.Add("Тупики");
            streetTypeList.Add("Шоссе");
            streetTypeList.Add("Улица");
            streetTypeList.Add("Авеню");
            streetTypeList.Add("Взвоз");
            streetTypeList.Add("Дорожка");
            streetTypeList.Add("Корниш");
            streetTypeList.Add("Линия");
            streetTypeList.Add("Магистраль");
            streetTypeList.Add("Магистральная улица");
            streetTypeList.Add("Педвей");
            streetTypeList.Add("Проспкт");
            streetTypeList.Add("Разъезд");
            streetTypeList.Add("Тракт");
            streetTypeList.Add("Трамвайно-пешеходная улица");
            streetTypeList.Add("Тупик");
            streetTypeList.Add("Эспланада");
        }

        public string Generate()
        {
            Random rnd = new Random();
            int listIndex = rnd.Next(streetTypeList.Count - 1);
            return streetTypeList[listIndex];
        }
    }
}
