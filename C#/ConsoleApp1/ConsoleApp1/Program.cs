using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter another Number: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("what operation would you like to do: ");
            string op = Console.ReadLine();
            Console.WriteLine("Answer: " + DoMath(x, y, op));
            Console.Read();
        }

        static string DoMath(int x, int y, string oper)
        {
            string result;
            switch(oper)
            {
                case "+":
                    result = (x + y).ToString();
                    break;

                case "-":
                    result = (x - y).ToString();
                    break;

                case "*":
                    result = (x * y).ToString();
                    break;

                case "/":
                    result = (x / y).ToString();
                    break;

                default: result = "Invalid Operator";
                    break;
            }

            return result;
        }
    }
}
