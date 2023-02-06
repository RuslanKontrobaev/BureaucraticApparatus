namespace BureaucraticApparatus.Классы
{
    class Case
    {
        private Question[] questions; // Массив вопросов по делу.
        private int enoughNumberQuestions; // Достаточное количество вопросов для завершения одного дела (1-5).
        private bool isDecided; // Статус решения дела (если дело решено или гражданин отказался от дела).

        public Case(Question[] questions, int enoughNumberQuestions)
        {
            this.questions = questions;
            this.enoughNumberQuestions = enoughNumberQuestions;
            isDecided = false;
        }

        // Получить массив вопросов по делу.
        public Question[] GetQuestions() => questions;

        // Получить достаточное количество вопросов для завершения одного дела.
        public int GetEnoughNumberQuestions() => enoughNumberQuestions;

        // Получить статус решения дела.
        public bool GetIsDecided() => isDecided;

        // Задать статус решения дела.
        public void SetIsDecided(bool value) => isDecided = value;
    }
}