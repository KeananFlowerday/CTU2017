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
            //double min = double.MaxValue;
            //string mini = "";
            //for (int i = 1; i <= 5; i++) { 
            //Console.Write("Enter Mark {0}: ",i);
            //double x = double.Parse(Console.ReadLine());
            //if (x < min) { min = x;  mini = i.ToString(); }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Lowest mark is mark {0} at {1}", mini, min.ToString());
            //Console.Read();

            double[] marks = new double[5];
            for (int x = 0; x <= 5; x++)
            {
                Console.Write("Enter Mark {0}: ", (x+1).ToString());
                marks[x] = double.Parse(Console.ReadLine());
            }
            Console.Write("Lowest Mark is: {0}", marks.Min());
            Console.WriteLine();
            for(int j = 0; j < marks.Length; j++)
            {
                Console.WriteLine("Mark {0} is {1}%",j+1,marks[j].ToString());
            }
            
            Console.Read();            
        }
    }
}
