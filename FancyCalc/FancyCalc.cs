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
            string[] expr = expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double result = 0; ;
            for (int i = 1; i < expr.Length - 1; i++)
            {
                switch (expr[i])
                {
                    case "+":
                        result = Add(int.Parse(expr[i - 1]), int.Parse(expr[i + 1]));
                        break;
                    case "-":
                        result = Subtract(int.Parse(expr[i - 1]), int.Parse(expr[i + 1]));
                        break;
                    default:
                        result = Multiply(int.Parse(expr[i - 1]), int.Parse(expr[i + 1]));
                        break;
                }
                //Console.WriteLine(s);
            }
            return result;

        }
    }
}
