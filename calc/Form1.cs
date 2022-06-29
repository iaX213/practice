using System;
using System.Windows.Forms;
using static calc.TwoArgsCalc;
using static calc.OneArgCalc;

namespace calc
{
    public partial class Main : Form
    {
        public double res;

        public Main()
        {
            InitializeComponent();
        }

        private void TwoArgClick(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;

            first.Text = first.Text.Replace(".", ",");
            second.Text = second.Text.Replace(".", ",");
            try
            {
                if (first.Text != "") x = Convert.ToDouble(first.Text);
                else x = 0;
                if (second.Text != "") y = Convert.ToDouble(second.Text);
                else y = 0;
            }
            catch (FormatException)
            {
                clearscreen();
                result.Text = "ERR";
                return;
            }

            if (name == "division")
            {
                if (first.Text == "" && second.Text == "")
                {
                    clearscreen();
                    return;
                }
                else if (y == 0)
                {
                    clearscreen();
                    result.Text = "ERR";
                    return;
                }
            }
            if (name == "logxy")
            {
                if (first.Text == "" && second.Text == "")
                {
                    clearscreen();
                    return;
                }
                else if (x <= 0 || y <= 0 || x == 1)
                {
                    clearscreen();
                    result.Text = "ERR";
                    return;
                }
            } 
            res = TwoArgsEngine(name);
            result.Text = Convert.ToString(res);
        }

        private void OneArgClick(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;

            first.Text = first.Text.Replace(".", ",");
            second.Text = "";
            try
            {
                if (first.Text != "") ox = Convert.ToDouble(first.Text);
                else ox = 0;
            }
            catch (FormatException)
            {
                clearscreen();
                result.Text = "ERR";
                return;
            }

            if (name == "ln" || name == "lg")
            {
                if (first.Text == "")
                {
                    clearscreen();
                    return;
                }
                else if (ox <= 0)
                {
                    clearscreen();
                    result.Text = "ERR";
                    return;
                }
            }
            if (name == "ctg")
            {
                if (first.Text == "")
                {
                    clearscreen();
                    return;
                }
                else if (OneArgEngine("sin") == 0)
                {
                    clearscreen();
                    result.Text = "ERR";
                    return;
                }
            }
            if (name == "tg")
            {
                if (first.Text == "")
                {
                    clearscreen();
                    return;
                }
                else if (OneArgEngine("cos") == 0)
                {
                    clearscreen();
                    result.Text = "ERR";
                    return;
                }
            }

            res = OneArgEngine(name);
            result.Text = Convert.ToString(res);
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
