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
    public partial class Main : Form
    {
        private static double a, b;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OperationClick(object sender, EventArgs e)
        {
            first.Text = first.Text.Replace(".", ",");
            second.Text = second.Text.Replace(".", ",");
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

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = "";
            first.Text = "";
            second.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
