using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BureaucraticApparatus.Классы;

namespace BureaucraticApparatus
{
    public partial class Form : System.Windows.Forms.Form
    {
        /* Бюрократический аппарат: граждане обращаются с делами к бюрократам, решающим
           определенные типы вопросов, а те решают их неопределенное время или отсылают к
           другим; если долго решают, то граждане уходят к другим и т.д. каждое дело
           заканчивается только после решения определенного количества вопросов разного типа
           или отказом гражданина от решения дела. */

        Bureaucratic_apparatus bureaucratic_Apparatus;
        List<Label> listLbQueues; // Лист label'ы для показа длины очереди бюрократа.
        List<Label> listLbStatuses; // label'ы для показа статуса бюрократа.
        List<PictureBox> listPbCitizens; // Изображения граждан.

        public Form()
        {
            InitializeComponent();
            bureaucratic_Apparatus = new Bureaucratic_apparatus();
            listLbQueues = new List<Label>();
            listLbStatuses = new List<Label>();
            listPbCitizens = new List<PictureBox>();
            bureaucratic_Apparatus.work = false;
            timer.Interval = 500;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                if (bureaucratic_Apparatus.GetBureaucrats()[i].GetQueueLenght() > 0)
                {
                    CitizenImage image = bureaucratic_Apparatus.GetBureaucrats()[i].GetQueue().Peek().GetCitizenImage();
                    listPbCitizens[i].Image = GetCitizenImage(image);
                }
                else
                {
                    listPbCitizens[i].Image = null;
                }
                listLbQueues[i].Text = "Очередь: " + bureaucratic_Apparatus.GetBureaucrats()[i].GetQueueLenght() + " чел.";
                listLbStatuses[i].Text = "Статус: " + bureaucratic_Apparatus.GetBureaucrats()[i].GetStatus().ToString();

            }

            ApparatusStatusLabel.Text = "Статус: " + bureaucratic_Apparatus.GetApparatusStatus();
            labelWaitingRoomCountCitizens.Text = "Зал ожидания: " + bureaucratic_Apparatus.waitingRoom.Count() + " чел.";
        }

        private Image GetCitizenImage(CitizenImage image)
        {
            switch (image)
            {
                case CitizenImage.Img1:
                    return Properties.Resources.Citizen_1;
                case CitizenImage.Img2:
                    return Properties.Resources.Citizen_2;
                case CitizenImage.Img3:
                    return Properties.Resources.Citizen_3;
                case CitizenImage.Img4:
                    return Properties.Resources.Citizen_4;
                case CitizenImage.Img5:
                    return Properties.Resources.Citizen_5;
                case CitizenImage.Img6:
                    return Properties.Resources.Citizen_6;
                case CitizenImage.Img7:
                    return Properties.Resources.Citizen_7;
                default:
                    return null;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (!bureaucratic_Apparatus.work)
            { 
                timer.Enabled = true;
                bureaucratic_Apparatus.StartWork();
                button_start.Text = "Остановить";
                ApparatusStatusLabel.Text = "Статус: работает";
                labelWaitingRoomCountCitizens.Text = "Зал ожидания: 0 чел.";
                foreach (var lb in listLbStatuses)
                {
                    lb.Text = "Статус: " + Status.ожидает;
                }
            }
            else
            {
                timer.Enabled = false;
                bureaucratic_Apparatus.StopWork();
                button_start.Text = "Запустить";
                ApparatusStatusLabel.Text = "Статус: не работает";
                labelWaitingRoomCountCitizens.Text = "Зал ожидания:";
                foreach (var lb in listLbStatuses)
                {
                    lb.Text = "Статус:";
                }
                foreach (var lb in listLbQueues)
                {
                    lb.Text = "Очередь:";
                }
                foreach (var pb in listPbCitizens)
                {
                    pb.Image = null;
                }
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            bureaucratic_Apparatus.StopWork();
            bureaucratic_Apparatus.CloseWriter();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            var xPos = 7;
            for (var i = 0; i < 7; i++)
            {
                // Для вывода количества человек в очереди.
                Label label = new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(xPos, 220),
                    Name = "labelQueue" + i.ToString(),
                    Text = "Очередь: 0 чел."
                };
                groupBoxBureaucrats.Controls.Add(label);
                listLbQueues.Add(label);

                // Для вывода статуса обслуживания.
                label = new Label
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(xPos, 240),
                    Name = "labelStatus" + i.ToString(),
                    Text = "Статус: " + Status.остановлен
                };
                groupBoxBureaucrats.Controls.Add(label);
                listLbStatuses.Add(label);

                // Для вывода изображений граждан.
                PictureBox pb = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new System.Drawing.Size(158, 162),
                    Location = new System.Drawing.Point(xPos, 29),
                    Name = "PictureBox" + i.ToString(),
                    BorderStyle = BorderStyle.Fixed3D
                };
                groupBoxCitizens.Controls.Add(pb);
                listPbCitizens.Add(pb);
                xPos += 166;
            }

            bureaucratic_Apparatus.OpenWriter();
        }
    }
}