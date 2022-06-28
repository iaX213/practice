using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        double a, b;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OperationClick(object sender, EventArgs e)
        {
            try
            {
               a = Convert.ToDouble(first.Text);
               b = Convert.ToDouble(second.Text);
            }
            catch (FormatException)
            {
                result.Text = "Err";
                first.Text = "";
                second.Text = "";
                return;
            }
            switch (((Button)sender).Name)
            {
                case "additional":
                    result.Text = Convert.ToString(a + b);
                    break;
                case "subtraction":
                    result.Text = Convert.ToString(a - b);
                    break;
                case "multiplication":
                    result.Text = Convert.ToString(a * b);
                    break;
                case "division":
                    result.Text = Convert.ToString(a / b);
                    break;
                default:
                    throw new Exception("Ошибка! Неизвестная операция");
            }
        }

        private void first_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void second_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
