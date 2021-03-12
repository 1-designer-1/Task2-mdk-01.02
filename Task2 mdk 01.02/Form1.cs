using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskLib;

namespace Task2_mdk_01._02
{
    public partial class Form1 : Form
    {
        Class1 Class1 = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент: Серегин Денис\n" +
                "Вариант 11\n" +
                "Задание: " +
                "Даны прямоугольное отверстие размером x на y и кирпич с гранями a, b, c. Составить " +
                "программу для определения возможности прохождения кирпича через заданное отверстие.",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ответToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber = Convert.ToInt32(textBox1.Text);  // гранями a
                int secondNumber = Convert.ToInt32(textBox2.Text); // гранями b
                int thirdNumber = Convert.ToInt32(textBox3.Text); //гранями  c
                int longPort = Convert.ToInt32(textBox4.Text); // размером отверстия х
                int widthPort = Convert.ToInt32(textBox5.Text); // размером отверстия  у
                if (Class1.Check(firstNumber, secondNumber, thirdNumber, longPort, widthPort) == true)
                {
                    textBox6.Text = "Kирпича проходит через заданное отверстие";
                }
                else textBox6.Text = "Kирпича не проходит через заданное отверстие";
            }
            catch { MessageBox.Show("Введите число", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error); }










        }




    }
}
