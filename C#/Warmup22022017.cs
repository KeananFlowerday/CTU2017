using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace WarmUP22022017
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            int a = 1000;
            foreach(int x in getFactors(a))
            {
                Console.WriteLine(x);
            }
            stop.Stop();
            Console.WriteLine("Time Elapsed:"+stop.ElapsedMilliseconds+ "ms");
            Console.Read();
        }

        static double getMin( int length)
        {
            double min = double.MaxValue;
            for (int x = 1; x <=length; x++)
            {
                Console.Write("Enter Number {0}:",x);
                double temp = double.Parse(Console.ReadLine());
                if (temp < min)
                    min = temp;
            }
            return min;
        }

         static double getVolume( double r)
        {
            double temp = Math.Pow(r, 3);
            temp = temp * Math.PI;
            double V = temp *( 4.00/ 3.00);

            return Math.Round(V,2);
        }

        static int[] reversenumbers(int[] Arr)
        {
              Array.Reverse(Arr);
              return Arr;
        }

        static void display(int[] Arr)
        {
            try
            {
                int y = Arr.Length;
                foreach(int x in Arr)
                {
                    Console.WriteLine("Number {0} is {1}",y,x);
                    y--;
                }
            }catch(Exception e)
            {
                Console.Write(e.Message);
            }

        }

        static List<int> getFactors(int x)
        {
            List<int> list = new List<int>();
            list.Add(1);
            if (x %2 ==0) list.Add(2) ;
            for(int y = 3; y <= x/2; y++)
            {
                if (x%y == 0)
                {
                    list.Add(y);
                }
            }
            list.Add(x);
            return list;
        }

    }
}
