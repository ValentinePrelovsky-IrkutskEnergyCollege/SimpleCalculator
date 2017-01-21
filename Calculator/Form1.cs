using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double a = 0, b = 0, c = 0;// наши числа
        const string TITLE = "Калькулятор";

        public Form1()
        {
            InitializeComponent();
        }
        public void get(string op)
        {
                try
                {
                    // попытка найти числа в полях
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);

                    // найдём операцию и поместим её результат в соотвествующую переменную
                    if (op == "+") c = a + b;
                    if (op == "-") c = a - b;
                    if (op == "*") c = a * b;
                    if (op == "/") c = a / b;
                }
                catch (DivideByZeroException eDivZero) // в случае деления на ноль предупреждаем
                {
                    MessageBox.Show("На нуль делить нельзя!", TITLE);
                }
                catch (Exception ex) // если посложнее, просто дадим знать об этом
                {
                    MessageBox.Show("Что-то пошло не так!", TITLE);
                }
                finally 
                {
                    // в любом случае выводим результат в нужное окошко
                    textBox3.Text = Convert.ToString(c);
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // если в полях что-то есть, пытаемся посчитать
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                get("+");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // если в полях что-то есть, пытаемся посчитать
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                get("-");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // если в полях что-то есть, пытаемся посчитать
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                get("*");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // если в полях что-то есть, пытаемся посчитать
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                get("/");
            }
        }
    }
}
