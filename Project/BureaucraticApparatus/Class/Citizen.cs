using System;
using System.Linq;

namespace BureaucraticApparatus.Классы
{
    class Citizen
    {
        private Case[] cases; // Массив дел гражданина.
        private int maxTimeWait; // Общее максимальное время ожидания (60-501).
        private int currentTimeWait; // Текущее время ожидания.
        private int maxTimeWaitSolveOneQuestion; // Максимальное время ожидания решения одного вопроса (20-61).
        private static int number = 1; // Количество граждан.
        private int name; // Имя гражданина (порядковый номер 1, 2,...).
        private CitizenImage image;
        public Random rnd = new Random();

        public Citizen()
        {
            this.cases = GenerateCases();
            maxTimeWait = rnd.Next(60, 501);
            currentTimeWait = 0;
            maxTimeWaitSolveOneQuestion = rnd.Next(20, 61);
            name = number;
            number++;
            image = (CitizenImage)rnd.Next(1, 8);
        }

        // Создание списка дел для гражданина.
        public Case[] GenerateCases()
        {
            // Создаем и заполняем массив дел (1-5 дел).
            Case[] cases = new Case[rnd.Next(1, 6)];
            for (var j = 0; j < cases.Length; j++)
            {
                // Создаем и заполняем массив вопросов по делу (1-5 вопросов).
                Question[] questions = new Question[rnd.Next(1, 6)];
                QuestType[] types = new QuestType[questions.Length];

                for (var k = 0; k < types.Length; k++)
                {
                    var tmp = (QuestType)rnd.Next(1, 6);
                    while (types.Contains(tmp))
                    {
                        tmp = (QuestType)rnd.Next(1, 6);
                    }
                    types[k] = tmp;
                }
                for (var h = 0; h < questions.Length; h++)
                {
                    questions[h] = new Question(types[h]);
                }
                cases[j] = new Case(questions, rnd.Next(1, 6));
            }
            return cases;
        }

        // Получить массив дел гражданина.
        public Case[] GetCases() => cases;

        // Получить общее максимальное время ожидания.
        public int GetMaxTimeWait() => maxTimeWait;

        // Получить текущее время ожидания.
        public int GetCurrentTimeWait() => currentTimeWait;

        // Задать текущее время ожидания.
        public void SetCurrentTimeWait(int value) => currentTimeWait = value;

        // Получить максимальное время ожидания решения одного вопроса.
        public int GetMaxTimeWaitSolveOneQuestion() => maxTimeWaitSolveOneQuestion;

        // Получить имя гражданина.
        public int GetName() => name;

        // Получить изображение гражданина.
        public CitizenImage GetCitizenImage() => image;
    }

    public enum CitizenImage
    {
        Img1 = 1,
        Img2 = 2,
        Img3 = 3,
        Img4 = 4,
        Img5 = 5,
        Img6 = 6,
        Img7 = 7
    }
}