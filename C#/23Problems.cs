using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace _23Problems
{
    class Program
    {
        static void Main(string[] args)
        {

            //Basic Usage:
            //Uncomment any function call to test and see the function in action. 
            //Each Question is in its own method for ease of reading and use.
            //One
            //HelloWorld();

            //Two
            //Star();

            //Three
            // Stars();

            //Four
            // Four();

            //Five
            //Five();

            //Six
            // Six();

            //Seven
            //Seven();

            //Eight
            //Eight();

            //Nine
            //Nine()

            //Ten
            // Ten();

            //Eleven
            // Eleven();

            //Twelve
            //   Twelve();

            //Thirteen
            //Thirteen();

            //Fourteen
            //  Fourteen();


            //Fifteen
            //Fifteen();

            //Sixteen
            //  Sixteen();

            //Seventeen
            //  Seventeen();

            //Eighteen
            Eighteen();




            Console.Read();
        }


        static void HelloWorld()
        {
            //Prints the String "Hello World"
            Console.Clear();
            Console.Write("Hello World");
        }

        static void Star() 
        {
            //Prints **********
            Console.Clear();
            for (int x = 1; x<=10; x++)
            {
                 Console.Write("*");
            }
        }
        static void Stars()
        {
            //Prints
            //*
            //*
            //*
            //*
            //*
            //*
            //*
            //*
            //*
            //*
            Console.Clear();
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine("*");
            }
        }

        static void Four()
        {
            //use for loops to print 
            //*****
            //*****
            //*****
            //*****
            //*****
            Console.Clear();
            for(int x = 1; x<=5; x++)
            {
                for(int y = 1; y<= 5; y++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

        }

        static void Five()
        {
            //2 variables, print one then two, swap values of vars and print it again
            //declare
            Console.Clear();
            string x = "Hello", y = "World", temp;
            //display
            Console.Write(x + " " + y);
            Console.WriteLine();
            //swap variables below
            temp = x;
            x = y;
            y = temp;
            //display
            Console.Write(x + " " + y);

        }

        static void Six()
        {
            //calculate and display the average of 4 tests
            Console.Clear();
            //declare array
            double[] marks = new double[4];
            //get values
            try
            {
                for(int x = 0; x<=4; x++)
                {
                    Console.Write("Enter mark {0}: ", x+1);
                    marks[x] = double.Parse(Console.ReadLine());
                }
                //get average and display
                Console.Write(" The average mark is: {0}", Math.Round(marks.Average(), 2).ToString());

            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void Seven()
        {
            //Calculate the area of any square or rectangle in Metres
            Console.Clear();
            Console.Write("Enter the Length: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Enter the Breadth: ");
            int b = int.Parse(Console.ReadLine());
            int sa = l * b;
            Console.WriteLine("Surface Area: {0} Square Metres", sa);
        }

        static void Eight()
        {
            //calculate the volume of a sphere given the radius
            Console.Write("Enter a Radius: ");
            double r = double.Parse(Console.ReadLine());
            double result = (4.0 / 3.0) * Math.PI * Math.Pow(r, 2);
            Console.Write("Volume: {0} meters cubed", result);
        }

        static void Nine()
        {
            Console.Write("Enter the Base value: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter the Increased value: ");
            double i = double.Parse(Console.ReadLine());

            double r = (i / b) * 100.0;
            Console.Write("Markup: {0}", Math.Round(r,2));
        }

        static void Ten()
        {
            Console.WriteLine("Celcius" + "\t"+ "Farenheit");
            for (int c = 0; c<= 100; c++)
            {
                double f = Math.Round((c * 9.0 / 5.0) + 32,2);
                Console.WriteLine(c + "\t"+ f);
            }
        }
        
        static void Eleven()
        {
            for(int x = 1; x <= 10; x++)
            {
                for(int y = 1; y<=x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Twelve()
        {
            for (int x = 1; x <= 10; x++)
            {
                int y = 1;
                while( y<=x)
                {
                    Console.Write("*");
                    y++;
                }
                Console.WriteLine();
            }
        }

      static void Thirteen()
        {
            Console.Write("Enter a Vowel: ");
            String s = Console.ReadLine().ToLower();
            if (s.Length != 1)
            {
                Console.Write("Error!");
            }
            else
            {
                switch((char)char.Parse(s))
                {
                    case 'a': Console.Write(s.ToUpper());
                        break;
                    case 'e':
                        Console.Write(s.ToUpper());
                        break;
                    case 'i':
                        Console.Write(s.ToUpper());
                        break;
                    case 'o':
                        Console.Write(s.ToUpper());
                        break;
                    case 'u':
                        Console.Write(s.ToUpper());
                        break;

                    default: Console.Write("Error!");
                        break;

                }
            }
        }

        static void Fourteen()
        {
            Console.Write("Enter the sumto number 'n':");
            int n = int.Parse(Console.ReadLine());
            double ans1 = 0;
            sum1(ref ans1,n);
            double ans2 = sum2(n);
            Console.WriteLine("Sum1: {0}", ans1);
            Console.WriteLine("Sum2: {0}", ans2);
        }

        static void sum1(ref double sum, int n)
        {

            for (int i = 1; i <= n; i++)
            {
                sum += (1.0 / i);
            }
        }

        static double sum2( int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (1.0 / i);
            }

            return sum;
        }

        static void Fifteen()
        {
            double a = 2, b = 4, c = 6;

            double ans = max(a,b);
            double ans2 = max(a, b,c);
            Console.Write(ans +" "+ ans2);
        }

        static double max( double p, double q)
        {
            if (p <q)
            {
                return q;
                    }
            else if ( p>q)
            {
                return p;
            }
            else
            {
                return 0;
            }

        }

        static double max(double p, double q, double r)
        {


            if (p > q && p > r) return p;
            else if (q > p && q > r) return q;
            else if (r > p && r > q) return r;
            else return 0;
            
        }

        static void Sixteen()
        {
            try { 
            Console.Write("Enter the Time (in 24Hr format): ");
            DateTime dt = DateTime.Parse(Console.ReadLine());
                int hour = dt.Hour;
                int min = dt.Minute;
                string am = null;
                if (hour > 12)
                {
                    am = "pm";
                    hour -= 12;
                }
                else
                {
                    am = "am";
                }


                string hr = hour.ToWords().ToUpper();
                string m = min.ToWords().ToUpper();

                string end = null;

                if (min == 0)
                {
                    end = ("It is "+hr+" O' Clock");
                }
                else if (15>min&&min>0 )
                {
                    end = ("It is "+m+" minutes past "+ hr+" "+ am);
                }
                else if (15 ==min)
                {
                    end = ("It is quarter past " + hr + " "+ am);
                }
                else if (30 > min && min > 15)
                {
                    end = ("It is " + m + " minutes past " + hr + " " + am);
                }
                else if (min == 30)
                {
                    end = ("It is half past  " + hr + " " + am);
                }
                else if (45 > min && min > 30)
                {
                    end = ("It is " + m + " minutes to " + hr + " " + am);
                }
                else if (min == 45)
                {
                    end = ("It is quarter to " + (hour +1).ToWords().ToUpper() + " " + am);
                }
                else if (60 > min && min > 45)
                {
                    end = ("It is " + m + " minutes to " + hr + " " + am);
                }

                Console.Write(end);

            }
            catch ( Exception e)
            {
                Console.WriteLine(e.Message);
            }
         }

        static void Seventeen()
        {
            for(int x = 1; x <=9; x += 2)
            { 
                for (int y = 1; y<= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Eighteen()
        {
            string star = "*";
            string space = " ";
          
          
          

          
            for (int y = 1; y < 10; y = y + 2)
            {
                for (int x = 0; x < ((11- (y) )/2); x++)
                {
                    if (y == 9) break; 
                    Console.Write(space);
                }
                for (int z = 1; z <= y; z++)
                {
                    Console.Write(star);
                }
                for (int x = 0; x <7 - y ; x++)
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
                for (int x = 0; x < (11- y )/2; x++)
                {
                    Console.Write(space);
                }
                for (int z = 1; z <= y; z++)
                {
                    Console.Write(star);
                }
                for (int x = 0; x <7- y; x++)
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
          
        }
    }
}
