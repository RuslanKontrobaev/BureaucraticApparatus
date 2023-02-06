
namespace BureaucraticApparatus
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.button_start = new System.Windows.Forms.Button();
            this.labelBur1 = new System.Windows.Forms.Label();
            this.labelBur2 = new System.Windows.Forms.Label();
            this.labelBur3 = new System.Windows.Forms.Label();
            this.labelBur4 = new System.Windows.Forms.Label();
            this.labelBur5 = new System.Windows.Forms.Label();
            this.labelBur6 = new System.Windows.Forms.Label();
            this.labelBur7 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ApparatusStatusLabel = new System.Windows.Forms.Label();
            this.labelWaitingRoomCountCitizens = new System.Windows.Forms.Label();
            this.groupBoxApparatusState = new System.Windows.Forms.GroupBox();
            this.groupBoxBureaucrats = new System.Windows.Forms.GroupBox();
            this.pictureBoxBur1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBur3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBur4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBur5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBur6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBur7 = new System.Windows.Forms.PictureBox();
            this.groupBoxCitizens = new System.Windows.Forms.GroupBox();
            this.pictureBoxBur2 = new System.Windows.Forms.PictureBox();
            this.groupBoxApparatusState.SuspendLayout();
            this.groupBoxBureaucrats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.Location = new System.Drawing.Point(8, 13);
            this.button_start.Margin = new System.Windows.Forms.Padding(4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(165, 72);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Запуск";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // labelBur1
            // 
            this.labelBur1.AutoSize = true;
            this.labelBur1.Location = new System.Drawing.Point(6, 22);
            this.labelBur1.Name = "labelBur1";
            this.labelBur1.Size = new System.Drawing.Size(17, 19);
            this.labelBur1.TabIndex = 7;
            this.labelBur1.Text = "1";
            // 
            // labelBur2
            // 
            this.labelBur2.AutoSize = true;
            this.labelBur2.Location = new System.Drawing.Point(170, 22);
            this.labelBur2.Name = "labelBur2";
            this.labelBur2.Size = new System.Drawing.Size(17, 19);
            this.labelBur2.TabIndex = 20;
            this.labelBur2.Text = "2";
            // 
            // labelBur3
            // 
            this.labelBur3.AutoSize = true;
            this.labelBur3.Location = new System.Drawing.Point(336, 21);
            this.labelBur3.Name = "labelBur3";
            this.labelBur3.Size = new System.Drawing.Size(17, 19);
            this.labelBur3.TabIndex = 8;
            this.labelBur3.Text = "3";
            // 
            // labelBur4
            // 
            this.labelBur4.AutoSize = true;
            this.labelBur4.Location = new System.Drawing.Point(505, 22);
            this.labelBur4.Name = "labelBur4";
            this.labelBur4.Size = new System.Drawing.Size(17, 19);
            this.labelBur4.TabIndex = 8;
            this.labelBur4.Text = "4";
            // 
            // labelBur5
            // 
            this.labelBur5.AutoSize = true;
            this.labelBur5.Location = new System.Drawing.Point(671, 22);
            this.labelBur5.Name = "labelBur5";
            this.labelBur5.Size = new System.Drawing.Size(17, 19);
            this.labelBur5.TabIndex = 21;
            this.labelBur5.Text = "5";
            // 
            // labelBur6
            // 
            this.labelBur6.AutoSize = true;
            this.labelBur6.Location = new System.Drawing.Point(841, 22);
            this.labelBur6.Name = "labelBur6";
            this.labelBur6.Size = new System.Drawing.Size(17, 19);
            this.labelBur6.TabIndex = 22;
            this.labelBur6.Text = "6";
            // 
            // labelBur7
            // 
            this.labelBur7.AutoSize = true;
            this.labelBur7.Location = new System.Drawing.Point(1003, 22);
            this.labelBur7.Name = "labelBur7";
            this.labelBur7.Size = new System.Drawing.Size(17, 19);
            this.labelBur7.TabIndex = 23;
            this.labelBur7.Text = "7";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ApparatusStatusLabel
            // 
            this.ApparatusStatusLabel.AutoSize = true;
            this.ApparatusStatusLabel.Location = new System.Drawing.Point(6, 22);
            this.ApparatusStatusLabel.Name = "ApparatusStatusLabel";
            this.ApparatusStatusLabel.Size = new System.Drawing.Size(58, 19);
            this.ApparatusStatusLabel.TabIndex = 26;
            this.ApparatusStatusLabel.Text = "Статус:";
            // 
            // labelWaitingRoomCountCitizens
            // 
            this.labelWaitingRoomCountCitizens.AutoSize = true;
            this.labelWaitingRoomCountCitizens.Location = new System.Drawing.Point(6, 45);
            this.labelWaitingRoomCountCitizens.Name = "labelWaitingRoomCountCitizens";
            this.labelWaitingRoomCountCitizens.Size = new System.Drawing.Size(107, 19);
            this.labelWaitingRoomCountCitizens.TabIndex = 34;
            this.labelWaitingRoomCountCitizens.Text = "Зал ожидания:";
            // 
            // groupBoxApparatusState
            // 
            this.groupBoxApparatusState.Controls.Add(this.ApparatusStatusLabel);
            this.groupBoxApparatusState.Controls.Add(this.labelWaitingRoomCountCitizens);
            this.groupBoxApparatusState.Location = new System.Drawing.Point(182, 12);
            this.groupBoxApparatusState.Name = "groupBoxApparatusState";
            this.groupBoxApparatusState.Size = new System.Drawing.Size(995, 73);
            this.groupBoxApparatusState.TabIndex = 35;
            this.groupBoxApparatusState.TabStop = false;
            this.groupBoxApparatusState.Text = "Состояние аппарата";
            // 
            // groupBoxBureaucrats
            // 
            this.groupBoxBureaucrats.Controls.Add(this.pictureBoxBur1);
            this.groupBoxBureaucrats.Controls.Add(this.pictureBoxBur2);
            this.groupBoxBureaucrats.Controls.Add(this.pictureBoxBur3);
            this.groupBoxBureaucrats.Controls.Add(this.pictureBoxBur4);
            this.groupBoxBureaucrats.Controls.Add(this.pictureBoxBur5);
            this.groupBoxBureaucrats.Controls.Add(this.pictureBoxBur6);
            this.groupBoxBureaucrats.Controls.Add(this.pictureBoxBur7);
            this.groupBoxBureaucrats.Controls.Add(this.labelBur1);
            this.groupBoxBureaucrats.Controls.Add(this.labelBur2);
            this.groupBoxBureaucrats.Controls.Add(this.labelBur7);
            this.groupBoxBureaucrats.Controls.Add(this.labelBur3);
            this.groupBoxBureaucrats.Controls.Add(this.labelBur6);
            this.groupBoxBureaucrats.Controls.Add(this.labelBur4);
            this.groupBoxBureaucrats.Controls.Add(this.labelBur5);
            this.groupBoxBureaucrats.Location = new System.Drawing.Point(8, 92);
            this.groupBoxBureaucrats.Name = "groupBoxBureaucrats";
            this.groupBoxBureaucrats.Size = new System.Drawing.Size(1169, 291);
            this.groupBoxBureaucrats.TabIndex = 36;
            this.groupBoxBureaucrats.TabStop = false;
            this.groupBoxBureaucrats.Text = "Бюрократы";
            // 
            // pictureBoxBur1
            // 
            this.pictureBoxBur1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBur1.Image = global::BureaucraticApparatus.Properties.Resources.Bureaucrat;
            this.pictureBoxBur1.Location = new System.Drawing.Point(7, 44);
            this.pictureBoxBur1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBur1.Name = "pictureBoxBur1";
            this.pictureBoxBur1.Size = new System.Drawing.Size(158, 162);
            this.pictureBoxBur1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBur1.TabIndex = 4;
            this.pictureBoxBur1.TabStop = false;
            // 
            // pictureBoxBur3
            // 
            this.pictureBoxBur3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBur3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur3.Image")));
            this.pictureBoxBur3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur3.InitialImage")));
            this.pictureBoxBur3.Location = new System.Drawing.Point(339, 44);
            this.pictureBoxBur3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBur3.Name = "pictureBoxBur3";
            this.pictureBoxBur3.Size = new System.Drawing.Size(158, 162);
            this.pictureBoxBur3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBur3.TabIndex = 6;
            this.pictureBoxBur3.TabStop = false;
            // 
            // pictureBoxBur4
            // 
            this.pictureBoxBur4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBur4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur4.Image")));
            this.pictureBoxBur4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur4.InitialImage")));
            this.pictureBoxBur4.Location = new System.Drawing.Point(505, 44);
            this.pictureBoxBur4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBur4.Name = "pictureBoxBur4";
            this.pictureBoxBur4.Size = new System.Drawing.Size(158, 162);
            this.pictureBoxBur4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBur4.TabIndex = 7;
            this.pictureBoxBur4.TabStop = false;
            // 
            // pictureBoxBur5
            // 
            this.pictureBoxBur5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBur5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur5.Image")));
            this.pictureBoxBur5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur5.InitialImage")));
            this.pictureBoxBur5.Location = new System.Drawing.Point(671, 44);
            this.pictureBoxBur5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBur5.Name = "pictureBoxBur5";
            this.pictureBoxBur5.Size = new System.Drawing.Size(158, 162);
            this.pictureBoxBur5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBur5.TabIndex = 8;
            this.pictureBoxBur5.TabStop = false;
            // 
            // pictureBoxBur6
            // 
            this.pictureBoxBur6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBur6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur6.Image")));
            this.pictureBoxBur6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur6.InitialImage")));
            this.pictureBoxBur6.Location = new System.Drawing.Point(837, 44);
            this.pictureBoxBur6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBur6.Name = "pictureBoxBur6";
            this.pictureBoxBur6.Size = new System.Drawing.Size(158, 162);
            this.pictureBoxBur6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBur6.TabIndex = 9;
            this.pictureBoxBur6.TabStop = false;
            // 
            // pictureBoxBur7
            // 
            this.pictureBoxBur7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBur7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur7.Image")));
            this.pictureBoxBur7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur7.InitialImage")));
            this.pictureBoxBur7.Location = new System.Drawing.Point(1003, 44);
            this.pictureBoxBur7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBur7.Name = "pictureBoxBur7";
            this.pictureBoxBur7.Size = new System.Drawing.Size(158, 162);
            this.pictureBoxBur7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBur7.TabIndex = 10;
            this.pictureBoxBur7.TabStop = false;
            // 
            // groupBoxCitizens
            // 
            this.groupBoxCitizens.Location = new System.Drawing.Point(8, 389);
            this.groupBoxCitizens.Name = "groupBoxCitizens";
            this.groupBoxCitizens.Size = new System.Drawing.Size(1169, 200);
            this.groupBoxCitizens.TabIndex = 37;
            this.groupBoxCitizens.TabStop = false;
            this.groupBoxCitizens.Text = "Граждане";
            // 
            // pictureBoxBur2
            // 
            this.pictureBoxBur2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBur2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur2.Image")));
            this.pictureBoxBur2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBur2.InitialImage")));
            this.pictureBoxBur2.Location = new System.Drawing.Point(173, 44);
            this.pictureBoxBur2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBur2.Name = "pictureBoxBur2";
            this.pictureBoxBur2.Size = new System.Drawing.Size(158, 162);
            this.pictureBoxBur2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBur2.TabIndex = 5;
            this.pictureBoxBur2.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 597);
            this.Controls.Add(this.groupBoxCitizens);
            this.Controls.Add(this.groupBoxApparatusState);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBoxBureaucrats);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бюрократический аппарат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBoxApparatusState.ResumeLayout(false);
            this.groupBoxApparatusState.PerformLayout();
            this.groupBoxBureaucrats.ResumeLayout(false);
            this.groupBoxBureaucrats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBur2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxBur7;
        private System.Windows.Forms.PictureBox pictureBoxBur6;
        private System.Windows.Forms.PictureBox pictureBoxBur5;
        private System.Windows.Forms.PictureBox pictureBoxBur4;
        private System.Windows.Forms.PictureBox pictureBoxBur3;
        private System.Windows.Forms.PictureBox pictureBoxBur1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label labelBur1;
        private System.Windows.Forms.Label labelBur2;
        private System.Windows.Forms.Label labelBur3;
        private System.Windows.Forms.Label labelBur4;
        private System.Windows.Forms.Label labelBur5;
        private System.Windows.Forms.Label labelBur6;
        private System.Windows.Forms.Label labelBur7;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label ApparatusStatusLabel;
        private System.Windows.Forms.Label labelWaitingRoomCountCitizens;
        private System.Windows.Forms.GroupBox groupBoxApparatusState;
        private System.Windows.Forms.GroupBox groupBoxBureaucrats;
        private System.Windows.Forms.GroupBox groupBoxCitizens;
        private System.Windows.Forms.PictureBox pictureBoxBur2;
    }
}