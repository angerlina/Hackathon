using System;

namespace LocalityTypeGenerator
{
    public class LocalityTypeGeneratorService : ILocalityTypeGeneratorService
    {
        private string[] _localityTypes = new string[]
        {
            "район",
            "город",
            "посёлок городского типа",
            "рабочий посёлок",
            "курортный посёлок",
            "кишлак",
            "поселковый совет (поссовет)",
            "сельсовет (сельский совет)",
            "сомон",
            "волость",
            "дачный поселковый совет",
            "посёлок сельского типа",
            "населённый пункт",
            "посёлок при станции",
            "железнодорожная станция",
            "село",
            "местечко",
            "деревня",
            "слобода",
            "станция",
            "станица",
            "хутор",
            "улус",
            "разъезд",
            "колхоз",
            "совхоз",
            "зимовье"
        };

        public string Generate()
        {
            Random rnd = new Random();
            int arrayIndex = rnd.Next(_localityTypes.Length);
            return _localityTypes[arrayIndex];
        }
    }
}