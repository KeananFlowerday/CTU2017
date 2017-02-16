using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a Number ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Enter another Number ");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("Answer: " +(x+y));
            //Console.Read();

            //Console.Write("Enter a Number ");
            //double r = double.Parse(Console.ReadLine());
            //double a = Math.PI * Math.Pow(r, 2);
            //Console.Write("Result: " + Math.Round(a, 2));
            //Console.Read();

            string star = "*";
            string space = " ";
            for(int y = 5; y>= 1; y--)
            {
                for(int x = 5; x >= 1; x--)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int y = 1; y <= 4; y++)
            {
                for (int x = 1; x <= y; x++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int y = 1; y >= 5; y++)
            {
                for (int x = 5; x >= y; x--)
                {
                    Console.Write(space);
                }
                for (int x = 1; x <= y; x++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int y = 1; y <= 5; y++)
            {
                for (int x = 1; x <= y; x++)
                {
                    Console.Write(space);
                }
                for (int x = 5; x >= y; x--)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            for (int y = 1; y < 10; y=y+2)
            {
                for (int x = 0; x < 9 - y / 2;  x++)
                {
                   Console.Write(space);
                }
                for (int z = 1; z <= y; z++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
        
            for (int y = 7; y >= 1; y = y - 2)
            {
                for (int x = 0; x < 9 - y / 2; x++)
                {
                    Console.Write(space);
                }
                for (int z = 1; z <= y; z++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Read();

        }
    }
}
