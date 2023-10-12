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

        //внесение данных о студенте
        private void button_Enter_Click(object sender, EventArgs e)
        {
            //проверка на введение всех данных
            if ((textBox_ID.Text == "") || (textBox_Name.Text == "") || (textBox_major.Text == "") || (textBox_year.Text == "") || (textBox_course.Text == ""))
                MessageBox.Show("Введены не все данные");
            else
            {
                if (int.TryParse(textBox_ID.Text, out int id))
                {
                    if (int.TryParse(textBox_year.Text, out int year))
                    {
                        if (int.TryParse(textBox_course.Text, out int course))
                        {
                            if (int.TryParse(textBox_Name.Text, out int name))
                            {
                                MessageBox.Show("Неверный формат значения 'ФИО'");
                            }
                            else
                            {                                
                                bool flag = true;
                                for (int i = 0; i < numbers_students; i++)
                                {
                                    if (id == List_Students[i].ID)
                                    {
                                        flag = false;
                                        MessageBox.Show("Введенное ID занято"); 
                                        break;
                                    }                                    
                                }

                                if (flag)
                                {
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
                        }
                        else
                            MessageBox.Show("Неверный формат значения 'курс' ");
                    }
                    else
                        MessageBox.Show("Неверный формат значения 'год поступления' ");
                }
                else
                    MessageBox.Show("Неверный формат значения 'ID'");
            }
        }

        //закрытие летней сессии
        private void button_Summer_Click(object sender, EventArgs e)
        {
            if (textBox_ID_Find.Text == "")
                MessageBox.Show("Введите ID студента");
            else
            {
                //поиск студента по id
                if (int.TryParse(textBox_ID_Find.Text, out int currentID))
                {
                    for (int i = 0; i < numbers_students; i++)
                    {
                        if (currentID == List_Students[i].ID)
                        {
                            MessageBox.Show(List_Students[i].PassSession("Летняя")); //вызов метода
                            break;
                        }
                        if (i == numbers_students - 1)
                        {
                            MessageBox.Show("ID не найдено");
                        }
                    }
                }
                else
                    MessageBox.Show("Неверный формат ID");
            }            
        }

        //закрытие зимней сессии
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_ID_Find.Text == "")
                MessageBox.Show("Введите ID студента");
            else
            {
                if (int.TryParse(textBox_ID_Find.Text, out int currentID))
                {
                    if (numbers_students == 0)
                        MessageBox.Show("ID не найдено");
                    //поиск студента по id
                    for (int i = 0; i < numbers_students; i++)
                    {
                        if (currentID == List_Students[i].ID)
                        {
                            MessageBox.Show(List_Students[i].PassSession("Зимняя")); //вызов метода
                            break;
                        }
                        if (i == numbers_students - 1)
                        {
                            MessageBox.Show("ID не найдено");
                        }
                    }
                }
                else
                    MessageBox.Show("Неверный формат ID");
            }
        }

        //получение полной информации
        private void button_full_Inf_Click(object sender, EventArgs e)
        {
            if (textBox_ID_Find.Text == "")
                MessageBox.Show("Введите ID студента");
            else
            {
                if (int.TryParse(textBox_ID_Find.Text, out int currentID))
                {
                    if (numbers_students == 0)
                        MessageBox.Show("ID не найдено");
                    //поиск студента по id
                    for (int i = 0; i < numbers_students; i++)
                    {
                        if (currentID == List_Students[i].ID)
                        {
                            MessageBox.Show(List_Students[i].GetStudentInf()); //вызов метода                       
                            break;
                        }
                        if (i == numbers_students - 1)
                        {
                            MessageBox.Show("ID не найдено");
                            break;
                        }
                    }
                }
                else
                    MessageBox.Show("Неверный формат ID");
            }
        }

        //получение ФИО
        private void button_FIO_Click(object sender, EventArgs e)
        {
            if (textBox_ID_Find.Text == "")
                MessageBox.Show("Введите ID студента");
            else
            {
                if (int.TryParse(textBox_ID_Find.Text, out int currentID))
                {
                    if (numbers_students == 0)
                        MessageBox.Show("ID не найдено");

                    for (int i = 0; i < numbers_students; i++)
                    {
                        if (currentID == List_Students[i].ID)
                        {
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
                else
                    MessageBox.Show("Неверный формат ID");
            }
        }

        //отчисление студента
        private void button_Credit_Click(object sender, EventArgs e)
        {            
            if (textBox_ID_Find.Text == "")
                MessageBox.Show("Введите ID студента");
            else
            {
                if (int.TryParse(textBox_ID_Find.Text, out int currentID))
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
                else
                    MessageBox.Show("Неверный формат ID");
            }
        }

        //перевод студента
        private void button_transfer_Click(object sender, EventArgs e)
        {
            if (textBox_ID_Find.Text == "")
            {
                MessageBox.Show("Введите ID студента");
            }
            else
            {
                //проверка на заполненние графы нового направления
                if (textBox_transfer.Text == " ")
                    MessageBox.Show("Введите направление для перевода");
                else
                {
                    if (int.TryParse(textBox_ID_Find.Text, out int currentID))
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
                    else
                        MessageBox.Show("Неверный формат ID");
                }
            }
            textBox_transfer.Clear();
        }
    }
}
