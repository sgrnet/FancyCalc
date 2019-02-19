using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            return a + b;
        }


        public double Subtract(int a, int b)
        {
            //throw new NotImplementedException();
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            if (expression is null) throw new ArgumentNullException();
            double result;
            char ch = expression[0];
            string num1="", num2 = "", act = "";

            for (int i = 0; i < expression.Length; i++)
            {
                ch = (char)expression[i];
                switch (ch)
                {
                    case '+':
                        act = "+";
                        break;
                    case '-':
                        act = "-";
                        break;
                    case '*':
                        act = "*";
                        break;
                    default:
                        break;
                }
                if (act == "")
                {
                if (char.IsDigit(ch)) { num1 = num1 + ch; }; 
                }
                else
                {
                if (char.IsDigit(ch)) { num2 = num2 + ch; }; 
                }
            }
            switch (act)
            {
                case "+":
                    result = Add(int.Parse(num1), int.Parse(num2));
                    break;
                case "-":
                    result = Subtract(int.Parse(num1), int.Parse(num2));
                    break;
                default:
                    result = Multiply(int.Parse(num1), int.Parse(num2));
                    break;
            }

            return result;
        }
    }
}
