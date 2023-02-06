namespace BureaucraticApparatus.Классы
{
    class Question
    {
        private QuestType currentType; // Тип вопроса.
        private bool isDecided; // Статус вопроса (решен/не решен).

        public Question(QuestType сurrentType)
        {
            currentType = сurrentType;
            isDecided = false;
        }

        // Получить тип вопроса.
        public QuestType GetCurrentType() => currentType;

        // Задать тип вопроса.
        public void SetCurrentType(QuestType value) => currentType = value;

        // Получить статус вопроса.
        public bool GetIsDecided() => isDecided;

        // Задать статус вопроса.
        public void SetIsDecided(bool value) => isDecided = value;
    }

    // Типы вопросов, которые могут быть.
    public enum QuestType
    {
        Type1 = 1,
        Type2 = 2,
        Type3 = 3,
        Type4 = 4,
        Type5 = 5
    }
}