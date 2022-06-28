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

        private void additional_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(first.Text);
            b = Convert.ToDouble(second.Text);
            result.Text = Convert.ToString(a + b);
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(first.Text);
            b = Convert.ToDouble(second.Text);
            result.Text = Convert.ToString(a - b);
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(first.Text);
            b = Convert.ToDouble(second.Text);
            result.Text = Convert.ToString(a - b);
        }

        private void division_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(first.Text);
            b = Convert.ToDouble(second.Text);
            result.Text = Convert.ToString(a / b);
        }

        private void first_TextChanged(object sender, EventArgs e)
        {

        }

        private void second_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
