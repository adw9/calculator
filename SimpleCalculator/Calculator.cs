using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        //Number Storage
        double num1;
        double num2;
        double num3;    
        String operation;
        bool error;





        public Calculator()
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            error = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorCheck();
            numberBox.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorCheck();
            numberBox.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errorCheck();
            numberBox.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            errorCheck();
            numberBox.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            errorCheck();
            numberBox.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            errorCheck();
            numberBox.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            errorCheck();
            numberBox.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            errorCheck();
            numberBox.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            errorCheck();
            numberBox.Text += '9';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            errorCheck();
            numberBox.Text += '0';
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            errorCheck();
            numberBox.Text += '.';
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            if (error) return;


            num1 = Double.Parse(numberBox.Text);
            numberBox.Text = "";
            operation = "+";
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            if (error) return;

            num1 = Double.Parse(numberBox.Text);
            numberBox.Text = "";
            operation = "-";

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (error) return;

            num1 = Double.Parse(numberBox.Text);
            numberBox.Text = "";
            operation = "X";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (error) return;
            num1 = Double.Parse(numberBox.Text);
            numberBox.Text = "";
            operation = "/";
        }


        //Contains the actual operation run
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if(operation == null || error)
            {
                return; 
            }

            num2 = Double.Parse(numberBox.Text);

            switch (operation)
            {
                case "+":
                    num3 = num1 + num2;
                    num1 = 0;
                    num2 = 0;

                    numberBox.Text = num3.ToString();
                    break;

                case "-":
                    num3 = num1 - num2;
                    num1 = 0;
                    num2 = 0;

                    numberBox.Text = num3.ToString();
                    break;
                case "X":
                    num3 = num1 * num2;
                    num1 = 0;
                    num2 = 0;

                    numberBox.Text = num3.ToString();
                    break;
                case "/":

                    if(num2 == 0)
                    {
                        num1 = 0;
                        num2 = 0;
                        numberBox.Text = "Error";
                        error = true;
                        return;
                    }

                    num3 = num1 / num2;
                    num1 = 0;
                    num2 = 0;

                    numberBox.Text = num3.ToString();
                    break;
            }

            num3 = 0;

        }

        private void errorCheck()
        {
            if (error)
            {
                numberBox.Text = "";
                error = false;
            }
        }

    }
}
