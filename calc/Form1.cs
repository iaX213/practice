using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static calc.TwoArgsCalc;
using static calc.TwoArgsInterface;

namespace calc
{
    public partial class Main : Form
    {
        public double res;

        public Main()
        {
            InitializeComponent();
        }

        private void Operation_Click(object sender, EventArgs e)
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
                if (x == 0 && y == 0)
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
                if (x <= 0 || y <= 0 || x == 1)
                {
                    clearscreen();
                    result.Text = "ERR";
                }
            } 
            res = TwoArgsEngine(name);
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
