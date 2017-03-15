using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celcius" + "\t" + "\t" + "Fahrenheit");
            for (int celc = 0; celc <= 100; celc++)
            {
                double far = Math.Round(((celc * 9.00) / 5) + 32, 2);
                Console.WriteLine(celc + "\t"+ "\t" + far);
            }
            Console.Read();
        }
    }
}
