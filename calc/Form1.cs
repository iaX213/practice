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

        private void Operation_Click(object sender, EventArgs e)
        {
            first.Text = first.Text.Replace(".", ",");
            second.Text = second.Text.Replace(".", ",");
            try
            {
                if (first.Text != "") a = Convert.ToDouble(first.Text);
                else a = 0;
                if (second.Text != "") b = Convert.ToDouble(second.Text);
                else b = 0;
                if (a == 0 && b == 0)
                {
                    clearscreen();
                    return;
                }
            }
            catch (FormatException)
            {
                clearscreen();
                result.Text = "ERR";
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
                    if (b == 0)
                    {
                        clearscreen();
                        result.Text = "ERR";
                    }
                    else result.Text = Convert.ToString(a / b);
                    break;
                default:
                    clearscreen();
                    break;
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            clearscreen();
        }

        private void clearscreen()
        {
            result.Text = "";
            first.Text = "";
            second.Text = "";
        }
    }
}
