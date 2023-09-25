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
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
                MessageBox.Show("Введены не все данные");
            else
            {
                int year = Convert.ToInt32(textBox3.Text);
                int course = Convert.ToInt32(textBox4.Text);
                //Student student = new Student(numbers_students, textBox1.Text, textBox2.Text, year, course)
                List_Students.Add(new Student(numbers_students, textBox1.Text, textBox2.Text, year, course));
                numbers_students++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                MessageBox.Show("Данные внесены");
            }
                
            
        }
    }
}
