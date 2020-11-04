using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        TextBox input;

        String firstNumber = "";
        String secondNumber = "";
        bool flag = false;
        char operatorSign = ' ';
        bool errorFlag = false;

        CalculateInterface calculator = new CalculateInterfaceImpl();

        public Calculator()
        {
            InitializeComponent();
            createInput();
            createButtons();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void createInput()
        {
            input = new TextBox();
            input.SetBounds(10, 20, 235, 30);
            input.ReadOnly = true;
            this.Controls.Add(input);

        }

        private void createButtons()
        {
            int count = 0;
            int firstPos = 10;
            int secondPos = 50;

            String[] buttonArray = {"√", "x2", "C", "/", "7", "8", "9", "*", "4", "5", "6", "-",
            "1", "2", "3", "+", "+/-", "0", ".", "="};

            for (int i = 0; i < buttonArray.Length; i++)
            {
                Button button = new Button
                {
                    Text = buttonArray[i]
                };
                count++;
                if (count != 4)
                {
                    button.SetBounds(firstPos, secondPos, 55, 35);
                    firstPos += 60;
                }
                else
                {
                    button.SetBounds(firstPos, secondPos, 55, 35);
                    count = 0;
                    secondPos += 50;
                    firstPos = 10;
                }
                button.Click += buttonClick;
                this.Controls.Add(button);
            }
        }
        private void buttonClick(object sender, EventArgs e)
        {
            var value = (sender as Button)?.Text;
            WriteInput(value);
        }

        private void WriteInput(string value)
        {
            try
            {
                if (errorFlag)
                {
                    input.Text = "";
                    errorFlag = false;
                }

                Regex regex = new Regex(@"^[0-9]*$");
                Match match = regex.Match(value);

                if (match.Success)
                {
                    if (!(input.Text == "0"))
                    {
                        if (!this.flag)
                        {
                            if (firstNumber == "0" & value == "0")
                            {
                                input.Text = value;
                            }
                            else
                            {
                                this.firstNumber += value;
                                input.Text = input.Text + value;
                            }
                        }
                        else
                        {
                            if (secondNumber == "0" & value == "0")
                            {
                                input.Text = this.firstNumber + this.operatorSign + value;
                            }
                            else
                            {
                                this.secondNumber += value;
                                input.Text = input.Text + value;
                            }
                        }
                    }
                    else
                    {
                        input.Text = "";
                        WriteInput(value);
                        this.flag = false;
                    }
                }
                else
                {
                    switch (value)
                    {
                        case "+":
                            writeOperator('+');
                            break;
                        case "*":
                            writeOperator('*');
                            break;
                        case "-":
                            writeOperator('-');
                            break;
                        case "/":
                            writeOperator('/');
                            break;
                        case ".":
                            writeDecimal();
                            break;
                        case "x2":
                            calculator.setFirstNumber(firstNumber);
                            input.Text = calculator.square().ToString();
                            this.firstNumber = calculator.square().ToString();
                            break;
                        case "=":
                            sendData();
                            this.operatorSign = ' ';
                            break;
                        case "√":
                            calculator.setFirstNumber(firstNumber);
                            input.Text = calculator.sqrtNumber().ToString();
                            this.firstNumber = calculator.sqrtNumber().ToString();
                            break;
                        case "C":
                            clearAll();
                            break;
                        case "+/-":
                            Negate();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                input.Text = "";
                errorFlag = true;
            }
        }

        private void sendData()
        {
            calculator.setFirstNumber(firstNumber);
            calculator.setSecondNumber(secondNumber);
            calculator.setOperator(operatorSign);
            input.Text = calculator.calculate().ToString();
            this.flag = false;
            this.secondNumber = "";
            this.firstNumber = calculator.calculate().ToString();
        }
        private void clearAll()
        {
            firstNumber = "";
            secondNumber = "";
            input.Text = "";
            operatorSign = ' ';
            flag = false;
        }

        void Negate()
        {
            if (this.operatorSign == ' ')
            {
                if (this.firstNumber.Contains("-"))
                {
                    this.firstNumber = this.firstNumber.Replace("-", "");
                }
                else
                {
                    this.firstNumber = "-" + this.firstNumber;
                }
                input.Text = firstNumber;
            }
            else
            {
                if (this.secondNumber.Contains("-"))
                {
                    this.secondNumber = this.secondNumber.Replace("-", "");
                }
                else
                {
                    this.secondNumber = "-" + this.secondNumber;
                }
                input.Text = this.firstNumber + this.operatorSign + this.secondNumber;
            }
        }

        private void writeDecimal()
        {
            if (this.operatorSign == ' ')
            {
                if (!this.firstNumber.Contains(".")
                        && this.firstNumber.Length > 0)
                {
                    this.firstNumber += '.';
                    this.addDot();
                }
            }
            else
            {
                if (!this.secondNumber.Contains(".")
                        && this.secondNumber.Length > 0)
                {
                    this.secondNumber += '.';
                    this.addDot();
                }
            }
        }

        private void addDot()
        {
            input.Text = input.Text + '.';
        }

        private void writeOperator(char requestedOperator)
        {
            this.operatorSign = requestedOperator;

            if (!this.flag && input.TextLength != 0)
            {
                input.Text = input.Text + this.operatorSign;
                this.flag = true;
            }
            if (this.secondNumber.Length == 0)
            {
                input.Text = input.Text.Substring(0, input.Text.Length - 1);
                input.Text = input.Text + this.operatorSign;
                this.flag = true;
            }
        }

    }
}

