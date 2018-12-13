using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class formcalculater : Form
    {
        public formcalculater()
        {
            InitializeComponent();
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(firstnumber.Text);
            double num2 = Convert.ToDouble(secondnumber.Text);
            result.Text = Convert.ToString(Class1.Add(num1, num2));
        }//addition method

        private void Substarction_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(firstnumber.Text);
            double num2 = Convert.ToDouble(secondnumber.Text);
            result.Text = Convert.ToString(Class1.Substract(num1, num2));
        }//method substraction

        private void Division_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(firstnumber.Text);
            double num2 = Convert.ToDouble(secondnumber.Text);
            result.Text = Convert.ToString(Class1.Divisi(num1, num2));
        }//method Division

        private void Multiplication_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(firstnumber.Text);
            double num2 = Convert.ToDouble(secondnumber.Text);
            result.Text = Convert.ToString(Class1.Multipli(num1, num2));
        }//method multiplication

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
