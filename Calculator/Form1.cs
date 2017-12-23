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
    public partial class Calculator : Form
    {
        private double Val_Number = 0;
        private String Operator = null;


        public Calculator()
        {
            InitializeComponent();
        }

        private void Num_click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            if (textBoxResult.Text == "0" ||
                textBoxResult.Text == "+" ||
                textBoxResult.Text == "-" ||
                textBoxResult.Text == "×"||
                textBoxResult.Text == "÷"||
                textBoxResult.Text == "%"  )
                textBoxResult.Clear();
            if (button.Text == "." && textBoxResult.TextLength == 0)
                textBoxResult.Text = "0";
            textBoxResult.Text =textBoxResult.Text+ button.Text;
        }

        private void opeerator_click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            Val_Number = Double.Parse(textBoxResult.Text);
            Operator = button.Text;
            textBoxResult.Text = button.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            Val_Number = 0;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length == 1)
                textBoxResult.Text = "0";
            else
                textBoxResult.Text=textBoxResult.Text.Remove(textBoxResult.Text.Length-1,1);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (Operator)
            {
                case "+":
                    {
                        Val_Number += Double.Parse(textBoxResult.Text);
                        textBoxResult.Text = Val_Number.ToString();
                        break;
                    }
                case "-":
                    {
                        Val_Number -= Double.Parse(textBoxResult.Text);
                        textBoxResult.Text = Val_Number.ToString();
                        break;
                    }
                case "×":
                    {
                        Val_Number *= Double.Parse(textBoxResult.Text);
                        textBoxResult.Text = Val_Number.ToString();
                        break;
                    }
                case "÷":
                    {
                        Val_Number /= Double.Parse(textBoxResult.Text);
                        textBoxResult.Text = Val_Number.ToString();
                        break;
                    }
                case "%":
                    {
                        Val_Number %= Double.Parse(textBoxResult.Text);
                        textBoxResult.Text = Val_Number.ToString();
                        break;
                    }

                default: break;
            }

        }
    }
}
