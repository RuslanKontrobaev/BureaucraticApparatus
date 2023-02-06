
using System;
using System.Collections.Generic;
using System.Linq;

namespace BureaucraticApparatus.Классы
{
    class Bureaucrat
    {
        private QuestType[] types; // Типы вопросов, которые может решать бюрократ (3-5).
        private Queue<Citizen> queueCitizens; // Очередь граждан (не более 10 человек). 
        private int timeToSolveQuestion; // Неопределённое время, решения вопроса (5-20 мин). 
        private Status status; // Определяет текущий статус бюрократа.
        private int name; // Имя бюрократа (порядковый номер 1, 2,...).
        public Random rnd = new Random();

        public Bureaucrat(int name)
        {
            types = GenerateQuestTypes();
            queueCitizens = new Queue<Citizen>();
            timeToSolveQuestion = rnd.Next(5, 21);
            status = Status.ожидает;
            this.name = name;
        }

        // Создание типов вопросов, которые сможет решать бюрократ.
        public QuestType[] GenerateQuestTypes()
        {
            QuestType[] types = new QuestType[rnd.Next(3, 6)];
            for (var j = 0; j < types.Length; j++)
            {
                var tmp = (QuestType)rnd.Next(1, 6);
                while (types.Contains(tmp))
                {
                    tmp = (QuestType)rnd.Next(1, 6);
                }
                types[j] = tmp;
            }
            return types;
        }

        // Получить очередь бюрократа.
        public Queue<Citizen> GetQueue() => queueCitizens;

        // Добавить гражданина в конец очереди.
        public void AddCitizen(Citizen citizen) => queueCitizens.Enqueue(citizen);

        // Получить гражданина из начала очереди.
        public Citizen PeekCitizen() => queueCitizens.Peek();

        // Удалить гражданина из начала очереди.
        public void DequeueCitizen() => queueCitizens.Dequeue();

        // Получить длину очереди.
        public int GetQueueLenght() => queueCitizens.Count();

        // Очистить очередь.
        public void ClearQueue() => queueCitizens.Clear();

        // Получить статус.
        public Status GetStatus() => status;

        // Задать статус.
        public void SetStatus(Status value) => status = value;

        // Получить типы вопросов, которые может решать бюрократ.
        public QuestType[] GetTypes() => types;

        // Получить время решения вопроса.
        public int GetTimeToSolveQuestion() => timeToSolveQuestion;

        // Задать время решения вопроса.
        public void SetTimeToSolveQuestion(int value) => timeToSolveQuestion = value;

        // Получить имя бюрократа.
        public int GetName() => name;
    }
}

public enum Status
{
    ожидает,
    обслуживает,
    решил,
    отказал,
    остановлен
}