using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace BureaucraticApparatus.Классы
{
    class Bureaucratic_apparatus
    {
        private Bureaucrat[] bureaucrats; // Массив бюрократов.
        public bool work; // Статус работы аппарата.
        public Thread[] threads; // Массив потоков.
        public Thread queueCntrl; // Поток, отвечающий за очередь.
        public Queue<Citizen> waitingRoom; // Очередь для граждан, которые не обслужены до конца.
        public static StreamWriter swLogger;
        public Random rnd = new Random();
        public static object locker = new object();
        public static object queueLocker = new object();

        // Контроллер очереди.
        public void QueueController()
        {
            while (work)
            {
                for (int i = 0; i < 7; i++)
                {
                    Thread.Sleep(100);

                    // Если в очереди к бюрократу >= 10 чел.
                    if (bureaucrats[i].GetQueueLenght() >= 10)
                    {
                        continue;
                    }
                    // Если в общей очереди есть гражданин - помещаем его в очередь к бюрократу.
                    lock (queueLocker)
                    {
                        if (waitingRoom.Count() > 0 & waitingRoom.Count() <= 100)
                        {
                            swLogger.WriteLine("Гражданин №" + waitingRoom.Peek().GetName().ToString() + " из общей очереди помещен в очередь к бюрократу №" + bureaucrats[i].GetName().ToString());
                            bureaucrats[i].AddCitizen(waitingRoom.Dequeue()); // Поместить гражданина из общей очереди в очередь к бюрократу.
                            continue;
                        }
                    }
                    // С вероятностью 55% генерируем гражданина и помещаем его в очередь к бюрократу.
                    if (rnd.NextDouble() < 0.55)
                    {
                        Citizen citizen = new Citizen();
                        bureaucrats[i].AddCitizen(citizen);
                        lock (locker)
                        {
                            swLogger.WriteLine("Новый гражданин №" + citizen.GetName().ToString() + " помещен в очередь к бюрократу №" + bureaucrats[i].GetName().ToString());
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }

        // Обслуживание граждан.
        public void Work (object _bureaucrat)
        {
            Bureaucrat bureaucrat = (Bureaucrat)_bureaucrat;

            while (work)
            {
                // Если очередь бюрократа пуста.
                if (bureaucrat.GetQueueLenght() == 0)
                {
                    bureaucrat.SetStatus(Status.ожидает);
                    Thread.Sleep(200);
                    continue;
                }
                else
                {
                    Citizen citizen = bureaucrat.PeekCitizen(); // Достаем гражданина из начала очереди.
                    // Бюрократ будет решать вопрос с вероятностью 55%.
                    if (rnd.NextDouble() < 0.55)
                    {
                        bureaucrat.DequeueCitizen(); // Удаляем гражданина из очереди.

                        // Проверяем дела гражданина.
                        for (var i = 0; i < citizen.GetCases().Length; i++)
                        {
                            bureaucrat.SetStatus(Status.обслуживает); // Задаем бюрократу статус.

                            // Проверяем на завершенность дела (если дело завершено - не решаем).
                            if (citizen.GetCases()[i].GetIsDecided())
                            {
                                continue; // Переход на следующее дело.
                            }

                            // С вероятностью 20% гражданин откажется от решения дела.
                            if (rnd.NextDouble() < 0.20)
                            {
                                citizen.GetCases()[i].SetIsDecided(true); // Помечаем дело завершенным.
                                lock (locker)
                                {
                                    swLogger.WriteLine("Гражданин №" + citizen.GetName().ToString() + " отказался от решения дела №" +  i.ToString());
                                    bureaucrat.SetStatus(Status.ожидает); // Задаем бюрократу статус.
                                }
                                continue;
                            }

                            // Проверяем вопросы гражданина по делу.
                            for (var j = 0; j < citizen.GetCases()[i].GetQuestions().Length; j++)
                            {
                                bureaucrat.SetStatus(Status.обслуживает); // Задаем бюрократу статус.

                                // Если решено достаточное количество вопрсов для решения дела.
                                if (j >= citizen.GetCases()[i].GetEnoughNumberQuestions())
                                {
                                    citizen.GetCases()[i].SetIsDecided(true); // Помечаем дело решенным.
                                    lock (locker)
                                    {
                                        swLogger.WriteLine("Бюрократ №" + bureaucrat.GetName() + " решил достаточное количество вопросов, равное " + citizen.GetCases()[i].GetEnoughNumberQuestions() + " для решения дела №" + i.ToString() + " гражданина №" + citizen.GetName().ToString() + ", поэтому дело завершено");
                                    }
                                    bureaucrat.SetStatus(Status.решил); // Задаем бюрократу статус.
                                    Thread.Sleep(200);
                                    break;
                                }

                                // Проверка на наличие среди вопросов дела гражданина тех типов вопросов, которые способен решить бюрократ.
                                if (bureaucrat.GetTypes().Contains(citizen.GetCases()[i].GetQuestions()[j].GetCurrentType()))
                                {
                                    // Если этот вопрос решен - смотрим следующий.
                                    if (citizen.GetCases()[i].GetQuestions()[j].GetIsDecided()) continue;

                                    // Начинаем решать вопрос до истечения времени.
                                    var timeSolveQuestion = 0; // Время решения одного вопроса.
                                    while (true)
                                    {
                                        bureaucrat.SetStatus(Status.обслуживает);
                                        timeSolveQuestion++;

                                        // Добавляем всем гражданам время, проведенное в очереди.
                                        foreach (var citizenInQueue in bureaucrat.GetQueue())
                                        {
                                            citizenInQueue.SetCurrentTimeWait(citizenInQueue.GetCurrentTimeWait() + 1);
                                        }
                                        // Если время решения вопроса кончилось - вопрос решен.
                                        if (bureaucrat.GetTimeToSolveQuestion() == timeSolveQuestion)
                                        {
                                            lock (locker)
                                            {
                                                swLogger.WriteLine("Бюрократ №" + bureaucrat.GetName() + " решил вопрос №" + j.ToString() + " дела №" + i.ToString() + " гражданина №" + citizen.GetName().ToString());
                                            }

                                            citizen.GetCases()[i].GetQuestions()[j].SetIsDecided(true); // Помечаем вопрос как решенный.
                                            bureaucrat.SetStatus(Status.решил);
                                            Thread.Sleep(200);
                                            break;
                                        }
                                        // Если превышено время ожидания решения одного вопроса.
                                        if (timeSolveQuestion >= citizen.GetMaxTimeWaitSolveOneQuestion())
                                        {
                                            lock (queueLocker)
                                            {
                                                // Помещаем гражданина в общую очередь если в ней не более 100 чел.
                                                if (waitingRoom.Count() >= 0 & waitingRoom.Count() < 100)
                                                {
                                                    waitingRoom.Enqueue(citizen);
                                                }
                                                swLogger.WriteLine("Бюрократ №" + bureaucrat.GetName() + " долго решал вопрос №" + j.ToString() + " дела №" + i.ToString() + " гражданина №" + citizen.GetName().ToString() + ", в результате чего гражданин ушёл к другому."); 
                                            }
                                            citizen.GetCases()[i].GetQuestions()[j].SetIsDecided(false); // Помечаем вопрос как не решенный.
                                            bureaucrat.SetStatus(Status.отказал);
                                            Thread.Sleep(200);
                                            break;
                                        }
                                        // Если превышено макс. общее время ожидания гражданина.
                                        if (citizen.GetCurrentTimeWait() >= citizen.GetMaxTimeWait())
                                        {
                                            lock (locker)
                                            {
                                                swLogger.WriteLine("Гражданин №" + citizen.GetName().ToString() + " ушел, так как его макс. время ожидания истекло.");
                                            }
                                            bureaucrat.SetStatus(Status.отказал);
                                            Thread.Sleep(200);
                                            break;
                                        }
                                        Thread.Sleep(200); // Задержка решения вопроса.
                                    }
                                }
                                else
                                {
                                    lock (queueLocker)
                                    {
                                        // Если бюрократ не способен решить вопроса такого типа - помещаем гражданина в общую очередь.
                                        if (waitingRoom.Count() >= 0 & waitingRoom.Count() < 100)
                                        {
                                            waitingRoom.Enqueue(citizen);
                                        }
                                        swLogger.WriteLine("Бюрократ №" + bureaucrat.GetName() + " не сумел решить вопрос №" + j.ToString() + " дела №" + i.ToString() + " гражданина №" + citizen.GetName().ToString() + ", в результате чего гражданин ушёл к другому.");
                                        bureaucrat.SetStatus(Status.ожидает);
                                    }
                                }
                                Thread.Sleep(200); // Задержка между переключениями вопросов.
                            }

                            citizen.GetCases()[i].SetIsDecided(true); // Помечаем дело решеннным.
                            Thread.Sleep(200); // Задержка между переключениями дел.
                        }
                    }
                    else
                    {
                        bureaucrat.SetStatus(Status.отказал);
                        Thread.Sleep(100);
                        lock (queueLocker)
                        {
                            // Если в общей очереди есть место - добавляем гражданина, которому отказали.
                            if (waitingRoom.Count() >= 0 & waitingRoom.Count() < 100)
                            {
                                waitingRoom.Enqueue(citizen);
                                bureaucrat.DequeueCitizen(); // Удаляем гражданина из очереди.
                                swLogger.WriteLine("Бюрократ №" + bureaucrat.GetName() + " отказался от решения вопросов по делу гражданина №" + citizen.GetName().ToString() + ", в результате чего гражданин ушёл к другому.");
                            }
                            // Иначе гражданин уходит вовсе.
                            else
                            {
                                bureaucrat.DequeueCitizen(); // Удаляем гражданина из очереди.
                                swLogger.WriteLine("Гражданин №" + citizen.GetName().ToString() + " ушел, так как в общей очереди не было место.");
                            }
                        }
                    }
                }
                Thread.Sleep(200);
            }
        }

        // Начало работы, создание потоков и инициализация бюрократов.
        public void StartWork()
        {
            work = true;
            bureaucrats = new Bureaucrat[7];
            threads = new Thread[7];
            waitingRoom = new Queue<Citizen>();

            for (int i = 0; i < 7; i++)
            {
                bureaucrats[i] = new Bureaucrat(i + 1);
                threads[i] = new Thread(new ParameterizedThreadStart(Work));
                threads[i].Name = "Bureaucrat" + bureaucrats[i].GetName().ToString();
                threads[i].Start(bureaucrats[i]);
            }

            queueCntrl = new Thread(QueueController);
            queueCntrl.Name = "QueueControllerThread";
            queueCntrl.Start();
        }

        // Завершение работы, закрытие потоков, очистка очередей.
        public void StopWork()
        {
            work = false;
            
            for (var i = 0; i < 7; i++)
            {
                bureaucrats[i].ClearQueue();
                threads[i].Abort();
            }

            queueCntrl.Abort();
            waitingRoom.Clear();
        }

        // Получить статус работы аппарата.
        public string GetApparatusStatus()
        {
            if (work) return "работает";
            return "не работает";
        }

        // Получить массив бюрократов.
        public Bureaucrat[] GetBureaucrats() => bureaucrats;

        public void OpenWriter() => swLogger = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "log.txt"));

        public void CloseWriter() => swLogger.Close();
    }
}