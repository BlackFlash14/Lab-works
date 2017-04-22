using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCalculator
{
    public partial class AYMcalc : Form
    {

        double number = 0;
        string action = "";
        bool digit_pressed = false;
        bool DigitClicked = false;
        double memory = 0;
        public AYMcalc()
        {
            InitializeComponent();
        }
        private void digit_Click(object sender, EventArgs e)
        {
            DigitClicked = true;
            if (display.Text == "0" && DigitClicked == true)
            {
                display.Clear();
            }
            else if (digit_pressed)
            {
                display.Clear();
                digit_pressed = false;
            }
            Button btn = sender as Button;
            display.Text += btn.Text;
        }
        private void result_Click(object sender, EventArgs e)
        {
            if (action == "-")
            {
                number = number - (double.Parse(display.Text));
                display.Text = number.ToString();
            }
            if (action == "+")
            {
                number = number + (double.Parse(display.Text));
                display.Text = number.ToString();
            }
            if (action == "/")
            {
                number = number / (double.Parse(display.Text));
                display.Text = number.ToString();
            }
            if (action == "x")
            {
                number = number * (double.Parse(display.Text));
                display.Text = number.ToString();
            }

            if (action == "%")
            {
                number = (number * 100) / (double.Parse(display.Text));
                display.Text = number.ToString();
            }
            if (action == "x^2")
            {
                number = (Math.Pow(number, 2));
                display.Text = number.ToString();
            }
            if (action == "1/x")
            {
                number = 1 / number;
                display.Text = number.ToString();
            }
            if (action == "√")
            {
                number = (Math.Sqrt(number));
                display.Text = number.ToString();
            }
            if (action == "M+")
            {
                number = number + memory;
                display.Text = number.ToString();
            }
            if (action == "M-")
            {
                number = number - memory;
                display.Text = number.ToString();
            }
        }
        private void Ms_Click(object sender, EventArgs e)
        {
            memory = double.Parse(display.Text);
        }
        private void MC_Click(object sender, EventArgs e)
        {
                memory = 0;
            }
        private void MR_Click(object sender, EventArgs e)
        {
            number = memory ;
            display.Text = number.ToString();
        }
        private void PlusMinus_Click(object sender, EventArgs e)
        {
            number = (number * (-1));
            display.Text = number.ToString();
        }
        private void operands(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            number = double.Parse(display.Text);
            action = btn.Text;
            digit_pressed = true;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            display.Clear();
            display.Text = "0";
        }
    }
}
