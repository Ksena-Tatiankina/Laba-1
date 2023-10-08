using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary_Student;

namespace Laba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> List_Students = new List<Student>();
        int numbers_students = 0;

        private void button_Enter_Click(object sender, EventArgs e)
        {
            if ((textBox_ID.Text == "") || (textBox_Name.Text == "") || (textBox_major.Text == "") || (textBox_year.Text == "") || (textBox_course.Text == ""))
                MessageBox.Show("Введены не все данные");
            else
            {
                int id = Convert.ToInt32(textBox_ID.Text);
                int year = Convert.ToInt32(textBox_year.Text);
                int course = Convert.ToInt32(textBox_course.Text);
                
                List_Students.Add(new Student(id, textBox_Name.Text, textBox_major.Text, year, course));
                numbers_students++;

                textBox_ID.Clear();
                textBox_Name.Clear();
                textBox_major.Clear();
                textBox_year.Clear();
                textBox_course.Clear();

                MessageBox.Show("Данные внесены");
            }
        }

        private void button_Summer_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(textBox_ID_Find.Text);
            //int k = 0;
            if (textBox_ID_Find.Text == "")
                MessageBox.Show("Введите ID студента");
            else
            {

                for (int i = 0; i < numbers_students; i++)
                {
                    if (currentID == List_Students[i].ID)
                    {
                        //k = i;
                        MessageBox.Show(List_Students[i].PassSession("Летняя"));
                        break;
                    }
                }
            }
            //if (List_Students[k].CurrentCourse <= 4)
                //MessageBox.Show("Студент " + List_Students[k].FullName + " переведен на " + Convert.ToString(List_Students[k].CurrentCourse) + " курс");
           //else
                //MessageBox.Show("Студент " + List_Students[k].FullName + " закончил университет");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(textBox_ID_Find.Text);
            //int k = 0;
            if (textBox_ID_Find.Text == "")
                MessageBox.Show("Введите ID студента");
            else
            {
                if (numbers_students == 0)
                    MessageBox.Show("ID не найдено");
                for (int i = 0; i < numbers_students; i++)
                {

                    if (currentID == List_Students[i].ID)
                    {
                        //k = i;
                        MessageBox.Show(List_Students[i].PassSession("Зимняя"));
                        break;
                    }
                    if (i == numbers_students - 1)
                    {
                        MessageBox.Show("ID не найдено");
                    }
                }
            }
            //MessageBox.Show("Студент " + List_Students[k].FullName + "закрыл зимнюю сессию");
        }

        private void button_full_Inf_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(textBox_ID_Find.Text);
            //int k = 0;
            if (textBox_ID_Find.Text == "")
                MessageBox.Show("Введите ID студента");
            else
            {
                if (numbers_students == 0)
                    MessageBox.Show("ID не найдено");

                for (int i = 0; i < numbers_students; i++)
                {                    
                    if (currentID == List_Students[i].ID)
                    {
                        //k = i;
                        MessageBox.Show(List_Students[i].GetStudentInf());
                        //MessageBox.Show("ID: "+ List_Students[k].ID + ", ФИО: " + List_Students[k].FullName + ", Направление: " + List_Students[k].Major + ", Курс: " + +List_Students[k].CurrentCourse);
                        break;
                    }
                    if (i == numbers_students - 1)
                    {
                        MessageBox.Show("ID не найдено");
                        break;
                    }
                }
            }
        }

        private void button_FIO_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(textBox_ID_Find.Text);
            //int k = 0;
            if (textBox_ID_Find.Text == "")
                MessageBox.Show("Введите ID студента");
            else
            {
                if (numbers_students == 0)
                    MessageBox.Show("ID не найдено");

                for (int i = 0; i < numbers_students; i++)
                {
                    if (currentID == List_Students[i].ID)
                    {
                        //k = i;
                        MessageBox.Show(List_Students[i].GetFullName());                        
                        break;
                    }
                    if (i == numbers_students - 1)
                    {
                        MessageBox.Show("ID не найдено");
                        break;
                    }
                }
            }
        }

        private void button_Credit_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(textBox_ID_Find.Text);            
            if (textBox_ID_Find.Text == "")
                MessageBox.Show("Введите ID студента");
            else
            {
                if (numbers_students == 0)
                    MessageBox.Show("ID не найдено");

                for (int i = 0; i < numbers_students; i++)
                {
                    if (currentID == List_Students[i].ID)
                    {
                        MessageBox.Show(List_Students[i].Dedact());
                        break;
                    }
                    if (i == numbers_students - 1)
                    {
                        MessageBox.Show("ID не найдено");
                        break;
                    }
                }
            }
        }

        private void button_transfer_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(textBox_ID_Find.Text);
            if (textBox_ID_Find.Text == "")
            {
                MessageBox.Show("Введите ID студента");
            }
            else
            {
                if (textBox_transfer.Text == " ")
                    MessageBox.Show("Введите направление для перевода");
                else
                {
                    if (numbers_students == 0)
                        MessageBox.Show("ID не найдено");

                    for (int i = 0; i < numbers_students; i++)
                    {
                        if (currentID == List_Students[i].ID)
                        {
                            MessageBox.Show(List_Students[i].ChangeMajor(textBox_transfer.Text));
                            break;
                        }
                        if (i == numbers_students - 1)
                        {
                            MessageBox.Show("ID не найдено");
                            break;
                        }
                    }
                }
            }
            textBox_transfer.Clear();
        }
    }
}
