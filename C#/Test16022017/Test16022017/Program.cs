using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test16022017
{
    class Program
    {
        static void Main(string[] args)
        {
            ////One 
            //Console.Write(canDrive());
            //Console.Read();
            ////Two
            //Console.Write("Total: R" + getPieTotal());
            //Console.Read();
            ////Three
            //getMarkinfo();
            //Console.Read();
            ////Four
            //displayCircle();
            //Console.Read();
            //Five  
           // forloop();
            //Console.Read();
            ////Six
            Buses();
            Console.Read();

        }

        static string canDrive()
        {
            Console.Clear();
            String result;
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Surname: ");
            string sname = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 16)
            {
                 result = "Hello " + name + " " + sname + " you Qualify for a Drivers License";
            }
            else
            {
                 result = "Hello " + name + " " + sname + " you do not qualify for a Drivers License";
            }
            return result;
        }

        static string getPieTotal()
        {
            Console.Clear();
            String result;
            double cost = 12.5;
            Console.Write("How many pies would you like to Purchase: ");
            int num = int.Parse(Console.ReadLine());
            result = (Math.Round(((num * 1.00) * cost),2).ToString()); 
            return result;
        }

        static void getMarkinfo()
        {
            Console.Clear();
            double[] marks = new double[8];
            for (int x = 0; x < 8; x++)
            {
                Console.Write("Enter Mark {0}: ", (x + 1).ToString());
                marks[x] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Lowest Mark is: {0}", marks.Min());
            Console.WriteLine("Highest Mark is: {0}", marks.Max());
            Console.WriteLine("Average Mark is: {0}", marks.Average());
            Console.WriteLine();
            for (int j = 0; j < marks.Length; j++)
            {
                Console.WriteLine("Mark {0} is {1}%", j + 1, marks[j].ToString());
            }
        }

        static void displayCircle()
        {
            Console.Clear();
            Console.Write("Please enter the radius: ");
            double r = double.Parse(Console.ReadLine());
            double a = Math.Round(Math.PI * (r*r),2);
            //2 × π × radius
            double c = Math.Round((Math.PI * 2 * r),2);
            Console.WriteLine("The area is {0} units squared", a.ToString());
            Console.WriteLine("The circumference is {0} units", c.ToString());

        }

        static void forloop()
        {
            Console.Clear();
            for(int x = 1; x <= 5; x++)
            {
                Console.Write("@");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int x = 1; x <= 5; x++)
            {
                for(int y = 1; y<=x; y++)
                { 
                Console.Write("@");
                }
                Console.WriteLine();
            }
        }

        static void Buses()
        {
            int kids = 37;
            int perbus = 15;
            int fullbuses;
            int kidsleft;

            fullbuses = kids / perbus;
            kidsleft = kids % perbus;

            Console.Write("Buses: {0}, kids left: {1}", fullbuses, kidsleft);
        }
    }
}
