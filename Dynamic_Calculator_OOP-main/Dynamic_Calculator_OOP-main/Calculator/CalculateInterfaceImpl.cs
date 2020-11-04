using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculateInterfaceImpl : CalculateInterface
    {
        float firstNumber = 0;
        float secondNumber = 0;
        char operatorSign = ' ';


        public void setFirstNumber(String number)
        {
            float convertedNumber = float.Parse(number);
            this.firstNumber = convertedNumber;
        }


        public void setSecondNumber(String number)
        {
            float convertedNumber = float.Parse(number);
            this.secondNumber = convertedNumber;
        }


        public void setOperator(char reqOperator)
        {
            this.operatorSign = reqOperator;
        }

        public float getFirstNumber() => firstNumber;

        public char getOperator() => operatorSign;


        public float getSecondNumber() => secondNumber;


        public float calculate()
        {
            try
            {
                switch (this.operatorSign)
                {
                    case '+':
                        this.firstNumber = sum();
                        this.secondNumber = 0;
                        break;
                    case '/':
                        this.firstNumber = divide();
                        this.secondNumber = 1;
                        break;
                    case '*':
                        this.firstNumber = product();
                        this.secondNumber = 1;
                        break;
                    case '-':
                        this.firstNumber = decrease();
                        this.secondNumber = 0;
                        break;
                }
            }
            catch (Exception e)
            {
                this.firstNumber = 0;
            }

            return this.firstNumber;
        }


        public float sum() => firstNumber + secondNumber;


        public float product() => firstNumber * secondNumber;


        public float divide()
        {
            if (this.secondNumber == 0)
            {
                return 0;
            }
            else
            {
                return this.firstNumber / this.secondNumber;
            }
        }


        public float decrease() => firstNumber - secondNumber;


        public float square() => firstNumber * firstNumber;


        public float sqrtNumber() => (float)Math.Sqrt(firstNumber);
    }
}
