using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032017
{
    class Program
    {
        static void Main(string[] args)
        {

            doShit();

        }

        static int[] getNumbers()
        {
            int[] result = new int[5];
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Enter Number {0}:",i+1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static int getLargest(int[] arr)
        {
            int max = int.MinValue;
            foreach (int i in arr)
            {
                if(i>max)
                {
                    max = i;
                }
            }
            return max;
        }

        static bool isEven(int i)
        {
            if (i %2 == 0)
            {
                return true;
            }
            else { 
            return false;
            }
        }

        static void iAmEven( int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("I am even");
            }
        }

        static int iAmOdd(int i)
        {
            i *=  i;
            return i;
        }

        static void doShit()
        {
            int[] arr = new int[5];
            arr = getNumbers();
            int max = getLargest(arr);
            if(isEven(max))
            {
                iAmEven(max);
            }
            else
            {
                int x = iAmOdd(max);
                Console.WriteLine("I was Odd, now I'm "+x);
            }
            Console.Read();
        }
    }
}
