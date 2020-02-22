
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {

        double firstNum;
        double secondNum;
        double tempNum;
        double result;
        char oper;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDouble(lblDisplay.Text);

            switch (oper)
            {
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
                case '/':
                    result = firstNum / secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                case '%':
                    result = firstNum % secondNum;
                    break;
            }
            lblDisplay.Text = Convert.ToString(result);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "0.0")
            {
                lblDisplay.Text = "1";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "0.0")
            {
                lblDisplay.Text = "2";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "0.0")
            {
                lblDisplay.Text = "3";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "0.0")
            {
                lblDisplay.Text = "4";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "0.0")
            {
                lblDisplay.Text = "5";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "0.0")
            {
                lblDisplay.Text = "6";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "0.0")
            {
                lblDisplay.Text = "7";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "0.0")
            {
                lblDisplay.Text = "8";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "0.0")
            {
                lblDisplay.Text = "9";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "9";
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            lblDisplay.Text = "0";
        }


        private void btnDec_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "0.0")
            {
                lblDisplay.Text = "0.0";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + ".";
            }
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            tempNum = Convert.ToDouble(lblDisplay.Text) * -1.0;
            lblDisplay.Text = Convert.ToString(tempNum);
        }

        private void btnFrac_Click(object sender, EventArgs e)
        {
            tempNum = Convert.ToDouble(lblDisplay.Text)/100.0;
            lblDisplay.Text = Convert.ToString(tempNum);
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            oper = '%';
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            oper = '+';
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            oper = '-';
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            oper = '*';
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            oper = '/';
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            tempNum = (Convert.ToDouble(lblDisplay.Text) * Convert.ToDouble(lblDisplay.Text) * Convert.ToDouble(lblDisplay.Text));
            lblDisplay.Text = Convert.ToString(tempNum);
        }

        private void btnCbRT_Click(object sender, EventArgs e)
        {
            tempNum = (Math.Ceiling(Math.Pow(Convert.ToDouble(lblDisplay.Text), (double) 1/3)));
            lblDisplay.Text = Convert.ToString(tempNum);
        }
        private void btnSq_Click(object sender, EventArgs e)
        {
            tempNum = (Convert.ToDouble(lblDisplay.Text) * Convert.ToDouble(lblDisplay.Text));
            lblDisplay.Text = Convert.ToString(tempNum);
        }

        private void btnSqRT_Click(object sender, EventArgs e)
        {
            tempNum = (Math.Sqrt(Convert.ToDouble(lblDisplay.Text)));
            lblDisplay.Text = Convert.ToString(tempNum);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || lblDisplay.Text == "0.0")
            {
                lblDisplay.Text = "0";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + "0";
            }
        }
    }
}
