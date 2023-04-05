using System;
using System.Windows.Forms;

namespace kalkulacak
{
    public partial class Form1 : Form
    {
        private double operand1 = 0.0;
        private string currentOperator = "";

        public Form1()
        {
            InitializeComponent();
        { 

        }

        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            operand1 = 0.0;
            currentOperator = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double operand2 = double.Parse(textBox1.Text);
            double result = 0.0;

            switch (currentOperator)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    result = operand1 / operand2;
                    break;
            }

            textBox1.Text = result.ToString();
            operand1 = result;
            currentOperator = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            currentOperator = "+";
            operand1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            currentOperator = "-";
            operand1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            currentOperator = "*";
            operand1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            currentOperator = "*";
            operand1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }
    }
}
