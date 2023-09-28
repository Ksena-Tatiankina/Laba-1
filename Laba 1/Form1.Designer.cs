
namespace Laba_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_major = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_course = new System.Windows.Forms.TextBox();
            this.button_Enter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ID_Find = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.button_Summer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(202, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Внесение данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(93, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(207, 118);
            this.textBox_Name.Multiline = true;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(279, 34);
            this.textBox_Name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(55, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Направление";
            // 
            // textBox_major
            // 
            this.textBox_major.Location = new System.Drawing.Point(207, 182);
            this.textBox_major.Name = "textBox_major";
            this.textBox_major.Size = new System.Drawing.Size(279, 22);
            this.textBox_major.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Год поступления";
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(207, 239);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(279, 22);
            this.textBox_year.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(93, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Курс";
            // 
            // textBox_course
            // 
            this.textBox_course.Location = new System.Drawing.Point(207, 291);
            this.textBox_course.Name = "textBox_course";
            this.textBox_course.Size = new System.Drawing.Size(279, 22);
            this.textBox_course.TabIndex = 8;
            // 
            // button_Enter
            // 
            this.button_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Enter.Location = new System.Drawing.Point(224, 343);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(116, 36);
            this.button_Enter.TabIndex = 9;
            this.button_Enter.Text = "Внести";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(171, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Данные о студентах";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(55, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Введите ID студента";
            // 
            // textBox_ID_Find
            // 
            this.textBox_ID_Find.Location = new System.Drawing.Point(269, 468);
            this.textBox_ID_Find.Name = "textBox_ID_Find";
            this.textBox_ID_Find.Size = new System.Drawing.Size(223, 22);
            this.textBox_ID_Find.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(109, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(207, 64);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(279, 22);
            this.textBox_ID.TabIndex = 14;
            // 
            // button_Summer
            // 
            this.button_Summer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Summer.Location = new System.Drawing.Point(59, 521);
            this.button_Summer.Name = "button_Summer";
            this.button_Summer.Size = new System.Drawing.Size(257, 41);
            this.button_Summer.TabIndex = 15;
            this.button_Summer.Text = "Закрыть летнюю сессию";
            this.button_Summer.UseVisualStyleBackColor = true;
            this.button_Summer.Click += new System.EventHandler(this.button_Summer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 758);
            this.Controls.Add(this.button_Summer);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_ID_Find);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.textBox_course);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_major);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_major;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_course;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ID_Find;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button button_Summer;
    }
}

