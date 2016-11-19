using System;
using System.Collections.Generic;

namespace WhomPassportIssuedGenerator
{
    public class WhomPassportIssuedGeneratorService : IWhomPassportIssuedGeneratorService
    {
        private string[] departments =
        {
            "Отделом Внутренних Дел",
            "Управлением Внутренних Дел",
            "Районным Отделением Внутренних Дел",
            "Паспортным столом",
            "Федеральной Миграционной службой"
        };

        private string[] blocks =
        {
            "Промышленного района",
            "Кировского района",
            "Советского района",
            "Октябрьского района",
            "Железнодорожного района",
            "Красноглинского района",
            "Куйбышевского района",
            "Ленинского района",
            "Самарского района"
        };

        private string[] cities =
        {
            "города Самары",
            "города Тольятти",
            "города Ульяновска"
        };

        Random rndm = new Random();

        private int GetRandomStringArrayIndex(string[] array)
        {
            return rndm.Next(array.Length);
        }

        public string Generate()
        {
            string department = departments[GetRandomStringArrayIndex(departments)];
            string block = blocks[GetRandomStringArrayIndex(blocks)];
            string city = cities[GetRandomStringArrayIndex(cities)];
            return "Паспорт выдан:" + " " + department + ' ' + block + ' ' + city;
        }
    }
}