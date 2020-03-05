using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAL_frame
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void op_combox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double num1, num2,answer=0;

            num1 = Convert.ToDouble(num1_TextBox.Text);
            num2 = Convert.ToDouble(num2_TextBox.Text);
            switch(op_combox.Text)
            {
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        answer = num1 / num2;
                    }
                    else
                    {
                        result.Text = "Num2 couldn't be zero!";
                    }
                    break;
                default:
                    break;
            }
            result.Text = answer.ToString();
        }

        private void result_Click(object sender, EventArgs e)
        {
            
        }

        private void ans_Click(object sender, EventArgs e)
        {

        }
    }
}
