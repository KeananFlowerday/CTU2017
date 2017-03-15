using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork20170220
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = 0, b = 0;
                bool cont = false;
                Char charVal;
                bool num1 = false;
                //double ans = add2numbers(10, 10);
                //Console.Write("Result is {0}", ans);
                //add2numbers2(10, 10);
                char response = 'y';
                while (response == 'y')
                {
                    while (num1 == false)
                    {
                        Console.Write("Enter the first Number: ");
                        if (Double.TryParse(Console.ReadLine().ToString(), out a))
                            num1 = true;
                        else
                        {

                            Console.WriteLine("Not a Valid Number, Try again");
                        }
                    }
                    num1 = false;


                    while (num1 == false)
                    {
                        Console.Write("Enter the second Number: ");
                        if (Double.TryParse(Console.ReadLine().ToString(), out b))
                            num1 = true;
                        else
                        {

                            Console.WriteLine("Not a Valid Number, Try again");
                        }
                    }
                    num1 = false;
                    double result = add2numbers(a, b);
                    Console.WriteLine("Result: {0}", result);
                    while (cont == false)
                    {
                        Console.Write("Do you want to continue(Y/N)");
                        cont = Char.TryParse(Console.ReadLine().ToString().ToLower(), out charVal);
                        if (cont == true)
                        {
                            response = charVal;

                        }
                        else
                        {
                            Console.WriteLine("That is not a valid input, try again");
                        }
                    }
                    cont = false;
                }
            }
            catch (Exception e) { Console.Write(e.Message); }

            // Console.Read();
        }

        private static double add2numbers(double x1, double x2)//Returns a double to Main
        {
            double result = x1 + x2;
            return result;
        }

        private static void add2numbers2(double x1, double x2)//Prints result Directly, no return
        {
            double result = x1 + x2;
            Console.Write("Result is {0}", result);
        }

        static void displayCircle()
        {
            Console.Clear();
            Console.Write("Please enter the radius: ");
            double r = double.Parse(Console.ReadLine());
            double a = Math.Round(Math.PI * (r * r), 2);
            //2 × π × radius
            double c = Math.Round((Math.PI * 2 * r), 2);
            Console.WriteLine("The area is {0} units squared", a.ToString());
            Console.WriteLine("The circumference is {0} units", c.ToString());
        }

    }
}
