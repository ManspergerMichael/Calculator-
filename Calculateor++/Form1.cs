using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculateor__
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operateorClicked = "";
        bool isOperateorClicked = false;



        public Form1()
        {
            InitializeComponent();
        }

        private void Click_button(object sender, EventArgs e)
        {
            //removes 0 from result box when a button is clicked
            if (Result.Text == "0" || (isOperateorClicked)){Result.Clear();}

            isOperateorClicked = false;

            //creates button object from the sender paramater
            Button button = (Button)sender;
            if (button.Text == ".")//IF decimal point button clicked
            {
                if (!Result.Text.Contains("."))//if result text dosen't contain a decimal point
                {
                    Result.Text = Result.Text + button.Text;//concatinate string weith decimal point
                }
            }
            else
            {
                Result.Text = Result.Text + button.Text;
            }
                

            //uses the buttons text value to concactinate to the result string
            //Result.Text = Result.Text + button.Text;
        }

        private void Operateor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue !=0)
            {
                btnCalc.PerformClick();
                operateorClicked = button.Text;
                isOperateorClicked = true;
            }
            else
            {
                operateorClicked = button.Text;
                resultValue = Double.Parse(Result.Text);
                isOperateorClicked = true;
            }
            operateorClicked = button.Text;
            resultValue = Double.Parse(Result.Text);
            isOperateorClicked = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            resultValue = 0;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            switch (operateorClicked)
            {
                case "+":
                    Result.Text = (resultValue + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (resultValue - Double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (resultValue * Double.Parse(Result.Text)).ToString();
                    break;
                case "÷":
                    Result.Text = (resultValue / Double.Parse(Result.Text)).ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
