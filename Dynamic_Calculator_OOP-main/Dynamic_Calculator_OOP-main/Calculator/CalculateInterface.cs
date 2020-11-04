using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface CalculateInterface
    {
        void setFirstNumber(String number);

        void setSecondNumber(String number);

        void setOperator(char reqOperator);

        float getFirstNumber();

        char getOperator();

        float getSecondNumber();

        float calculate();

        float sum();

        float product();

        float divide();

        float decrease();

        float sqrtNumber();

        float square();
    }
}
