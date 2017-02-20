using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup20022017
{
    class Program
    {
        static void Main(string[] args)
        {
            //One
            //One();

            //Two
           // Two();

            //Three
            //Three();

            //Four
            //Four();

            Console.Read();
        }
        
        static void One() // One
        {
            int[] Arr = new int[10];
            for (int x = 0; x <= 9;x ++)
            {              
                Console.Write("Enter Integer {0}: ", x+1);
                Arr[x] = int.Parse(Console.ReadLine());
            }
            for(int y = Arr.Length-1; y>= 0; y--)
            {
                Console.WriteLine("Number {0} is {1}", y+1, Arr[y]);
            }
        }

        static void Two() //Two
        {
            int[] Arr = new int[10];
            for (int x = 0; x <= 9; x++)
            {
                Console.Write("Enter Integer {0}: ", x + 1);
                Arr[x] = int.Parse(Console.ReadLine());
            }
            for (int y = Arr.Length - 1; y >= 0; y--)
            {
                if( Arr[y] % 2 != 0)
                Console.WriteLine("Number {0} is {1}", y, Arr[y]);
            }
        }

        static void Three()//Three
        {
            bool asc = true;
            int[] Arr = new int[10];
            for (int x = 0; x <= 9; x++)
            {
                Console.Write("Enter Integer {0}: ", x + 1);
                Arr[x] = int.Parse(Console.ReadLine());
            }
            for (int x = 0; x <=8; x++)
            {
                if (Arr[x] <= Arr[x + 1])
                {
                    continue;
                }
                else
                {
                    asc = false;
                    break;
                }
               
            }
            if (asc == true) { Console.WriteLine("Ascending"); }
            else { Console.WriteLine("Not Ascending"); }
        }

        static void Four()//Four
        {
            for(int x = 1; x<=100; x++)
            {

                if ((x % 5 == 0) && (x % 3 == 0))
                {
                    Console.Write("Coca Cola");
                }
               else if (x % 3 == 0)
                {
                    Console.Write("Coca ");
                }
              else  if (x % 5 == 0)
                {
                    Console.Write("Cola");
                }
                
                else
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
        }
    }
}
