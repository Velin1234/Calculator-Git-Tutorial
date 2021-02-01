using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Git_Tutorial_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void btn_clear_Click(object sender, EventArgs e)
        {
            number1_box.Text = "";
            number2_box.Text = "";
            result_box.Text = "";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1_box.Text);
            double number2 = Convert.ToDouble(number2_box.Text);
            var result = number1 + number2;
            result_box.Text =$"Equals =  {result} ";
        }

        private void btn_substract_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1_box.Text);
            double number2 = Convert.ToDouble(number2_box.Text);
            var result = number1 - number2;
            result_box.Text = $"Equals =  {result} ";
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1_box.Text);
            double number2 = Convert.ToDouble(number2_box.Text);
            var result = number1 * number2;
            result_box.Text = $"Equals =  {result} ";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1_box.Text);
            double number2 = Convert.ToDouble(number2_box.Text);
            var result = number1 / number2;
            if (number2 == 0)
            {
                result_box.Text = "Can't Divide by 0";
            }
            else
            {
                result_box.Text = $"Equals =  {result:f2} ";
            }
            
        }

        private void btn_minOrMax_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1_box.Text);
            double number2 = Convert.ToDouble(number2_box.Text);
            if (number1 > number2)
            {
                result_box.Text = $"{number1} is Bigger than {number2}";
            }
            else
            {
                result_box.Text = $"{number2} is Bigger than {number1}";
            }
        }
    }
}
