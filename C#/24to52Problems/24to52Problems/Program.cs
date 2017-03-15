using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _24to52Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Twenty4
            // Twenty4();

            //Twenty5
            //Twenty5();

            //Twenty6
            //Twenty6();

            Console.Read();
        }

        static void Twenty4()
        {
            Stack nums = new Stack();
            try {
                for (int x = 0; x < 11; x++)
                {
                    Console.Write("Enter number {0}: ", x + 1);
                    nums.Push(int.Parse(Console.ReadLine()));
                }
                int size = nums.Count;
                Console.WriteLine();
                for (int a = 0; a < size; a++)
                {
                    int num = (int)nums.Pop();
                    int numz= num * num;
                    if (numz > 100)
                    {
                        Console.WriteLine("Number is greater than 100");
                    }
                    else
                    {
                        Console.WriteLine("Number is: {0}", numz);
                    }

                }
            }catch(Exception e)
            {
                Console.Write(e.Message);
            }
        }

        static void Twenty5()
        {
            DateTime bday;
            DateTime jan1 = new DateTime(2018,1,1);

            Console.Write("Enter your Birthday in the following format (dd,mm): ");
            string bd = Console.ReadLine();
            string[] bds = bd.Split(',');
            bday = new DateTime(2017,int.Parse(bds[1]) ,int.Parse(bds[0]));
            int x = (int)(jan1 - bday).TotalDays;
            Console.Write(x + " Days from Birthday until January 1st");
        }

        static void Thirty1()
        {
            int[] arrint = { 1, 3, 5, 7, 9 };
            int a = arrint.Max();
            Console.WriteLine("The largest is: {0}", a);
        }

        static void Thirty2()
        {
            int[] arrint = { 1, 3, 5, 7, 9 };
            int a = arrint.Min();
            Console.WriteLine("The smallest is: {0}", a);
        }

        static void Thirty3()
        {
            int[] arrint = { 1, 3, 5, 7, 9 };
            int a = arrint.Max();
            int b = arrint.Min();
            Console.WriteLine("The range is: {0} to {1} ", a, b);
        }

        static void Thirty4()
        {
            int[] arrint = { 1, 3, 5, 7, 9 };
            double a = arrint.Average();
            Console.WriteLine("The mean is: {0}", a);
        }
    }
}
