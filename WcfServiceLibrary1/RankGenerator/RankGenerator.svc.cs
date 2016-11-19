using System;
using System.Collections.Generic;

namespace RankGenerator
{
    public class RankGenerator
    {
        private List<string> rankList = new List<string>();

        public RankGenerator()
        {
            rankList.Add("Рядовой (курсант)");
            rankList.Add("Ефрейтор");
            rankList.Add("Младший сержант");
            rankList.Add("Сержант");
            rankList.Add("Старший сержант");
            rankList.Add("Старшина");
            rankList.Add("Прапорщик");
            rankList.Add("Старший прапорщик");
            rankList.Add("Младший лейтенант");
            rankList.Add("Лейтенант");
            rankList.Add("Старший лейтенант");
            rankList.Add("Капитан");
            rankList.Add("Майор");
            rankList.Add("Подполковник");
            rankList.Add("Полковник");
            rankList.Add("Генерал-майор");
            rankList.Add("Генерал-лейтенант");
            rankList.Add("Генерал-полковник");
            rankList.Add("Генерал армии");
            rankList.Add("Маршал Российской Федерации");
            rankList.Add("Матрос (курсант)");
            rankList.Add("Старший матрос");
            rankList.Add("Старшина 2 статьи");
            rankList.Add("Старшина 1 статьи");
            rankList.Add("Главный старшина");
            rankList.Add("Главный корабельный старшина");
            rankList.Add("Мичман");
            rankList.Add("Старший мичман");
            rankList.Add("Младший лейтенант");
            rankList.Add("Лейтенант");
            rankList.Add("Старший лейтенант");
            rankList.Add("Капитан-лейтенант");
            rankList.Add("Капитан 3 ранга");
            rankList.Add("Капитан 2 ранга");
            rankList.Add("Капитан 1 ранга");
            rankList.Add("Контр-адмирал");
            rankList.Add("Вице-адмирал");
            rankList.Add("Адмирал");
            rankList.Add("Адмирал флота");
        }

        public string ReturnRandomRank()
        {
            Random rnd = new Random();
            int listIndex = rnd.Next(rankList.Capacity - 1);
            return rankList[listIndex];
        }
    }
}