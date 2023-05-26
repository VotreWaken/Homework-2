using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Expression: ");
            string expression = Console.ReadLine();
            int result = Calculate(expression);
            Console.WriteLine($"Result: {result}");
            Console.Read();
        }

        static int Calculate(string expression)
        {
            int result = 0;
            int currentNumber = 0;
            char currentOperation = '+';

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                if (Char.IsDigit(c))
                {
                    currentNumber = currentNumber * 10 + (c - '0');
                }

                if (!Char.IsDigit(c) || i == expression.Length - 1)
                {
                    if (currentOperation == '+')
                    {
                        result += currentNumber;
                    }
                    else if (currentOperation == '-')
                    {
                        result -= currentNumber;
                    }

                    currentNumber = 0;
                    currentOperation = c;
                }
            }

            return result;
        }
        /*
        static void Calculate(string expression)
        {
            DataTable dt = new DataTable();
            int answer = (int)dt.Compute(expression, "");
        }
        */
    }
}
