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
        static int Row, Col;
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
            // Sixteen();

            //Seventeen
            //  Seventeen();

            //Eighteen
            //  Eighteen();

            //Nineteen
            Nineteen();

            //Twenty
            //Twenty();

            //Twenty1
            //Twenty1();

            //Twenty2
            //Remember a Floating point is added with a , and not a .
            //Twenty2();

            // Twenty3
            // I only did it with loops cuz fuck it
           // Twenty3();

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
            for (int x = 1; x <= 10; x++)
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
            for (int x = 1; x <= 5; x++)
            {
                for (int y = 1; y <= 5; y++)
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
                for (int x = 0; x <= 4; x++)
                {
                    Console.Write("Enter mark {0}: ", x + 1);
                    marks[x] = double.Parse(Console.ReadLine());
                }
                //get average and display
                Console.Write(" The average mark is: {0}", Math.Round(marks.Average(), 2).ToString());

            }
            catch (IndexOutOfRangeException e)
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
            Console.Write("Markup: {0}", Math.Round(r, 2));
        }

        static void Ten()
        {
            Console.WriteLine("Celcius" + "\t" + "Farenheit");
            for (int c = 0; c <= 100; c++)
            {
                double f = Math.Round((c * 9.0 / 5.0) + 32, 2);
                Console.WriteLine(c + "\t" + f);
            }
        }

        static void Eleven()
        {
            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= x; y++)
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
                while (y <= x)
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
                switch ((char)char.Parse(s))
                {
                    case 'a':
                        Console.Write(s.ToUpper());
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

                    default:
                        Console.Write("Error!");
                        break;

                }
            }
        }

        static void Fourteen()
        {
            Console.Write("Enter the sumto number 'n':");
            int n = int.Parse(Console.ReadLine());
            double ans1 = 0;
            sum1(ref ans1, n);
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

        static double sum2(int n)
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

            double ans = max(a, b);
            double ans2 = max(a, b, c);
            Console.Write(ans + " " + ans2);
        }

        static double max(double p, double q)
        {
            if (p < q)
            {
                return q;
            }
            else if (p > q)
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
            try
            {
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
                    end = ("It is " + hr + " O' Clock");
                }
                else if (15 > min && min > 0)
                {
                    end = ("It is " + m + " minutes past " + hr + " " + am);
                }
                else if (15 == min)
                {
                    end = ("It is quarter past " + hr + " " + am);
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
                    end = ("It is " + (60 - min).ToWords().ToUpper() + " minutes to " + (hour + 1).ToWords().ToUpper() + " " + am);
                }
                else if (min == 45)
                {
                    end = ("It is quarter to " + (hour + 1).ToWords().ToUpper() + " " + am);
                }
                else if (60 > min && min > 45)
                {
                    end = ("It is " + (60 - min).ToWords().ToUpper() + " minutes to " + (hour + 1).ToWords().ToUpper() + " " + am);
                }

                Console.Write(end);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Seventeen()
        {
            for (int x = 1; x <= 9; x += 2)
            {
                for (int y = 1; y <= x; y++)
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
                for (int x = 0; x < ((11 - (y)) / 2); x++)
                {
                    if (y == 9) break;
                    Console.Write(space);
                }
                for (int z = 1; z <= y; z++)
                {
                    Console.Write(star);
                }
                for (int x = 0; x < 7 - y; x++)
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
                for (int x = 0; x < (11 - y) / 2; x++)
                {
                    Console.Write(space);
                }
                for (int z = 1; z <= y; z++)
                {
                    Console.Write(star);
                }
                for (int x = 0; x < 7 - y; x++)
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

        static void Nineteen()
        {
            int ctop;
            int cleft = 1;
            string text;
            Console.WriteLine("Please Enter the string you want to print");
            text = Console.ReadLine();
            foreach (char choice in text)
            {
                ctop = 3;
                Console.SetCursorPosition(cleft, ctop);


                switch (choice)
                {
                    case 'a':
                    case 'A':
                        A(cleft, ctop);
                        break;

                    case 'b':
                    case 'B':
                        B(cleft, ctop);
                        break;

                    case 'c':
                    case 'C':
                        C(cleft, ctop);
                        break;

                    case 'd':
                    case 'D':
                        D(cleft, ctop);
                        break;

                    case 'e':
                    case 'E':
                        E(cleft, ctop);
                        break;

                    case 'f':
                    case 'F':
                        F(cleft, ctop);
                        break;

                    case 'g':
                    case 'G':
                        G(cleft, ctop);
                        break;

                    case 'h':
                    case 'H':
                        H(cleft, ctop);
                        break;

                    case 'i':
                    case 'I':
                        I(cleft, ctop);
                        break;

                    case 'j':
                    case 'J':
                        J(cleft, ctop);
                        break;

                    case 'k':
                    case 'K':
                        K(cleft, ctop);
                        break;

                    case 'l':
                    case 'L':
                        L(cleft, ctop);
                        break;

                    case 'm':
                    case 'M':
                        M(cleft, ctop);
                        break;

                    case 'n':
                    case 'N':
                        N(cleft, ctop);
                        break;

                    case 'o':
                    case 'O':
                        O(cleft, ctop);
                        break;

                    case 'p':
                    case 'P':
                        P(cleft, ctop);
                        break;

                    case 'q':
                    case 'Q':
                        Q(cleft, ctop);
                        break;

                    case 'r':
                    case 'R':
                        R(cleft, ctop);
                        break;

                    case 's':
                    case 'S':
                        S(cleft, ctop);
                        break;

                    case 't':
                    case 'T':
                        T(cleft, ctop);
                        break;

                    case 'u':
                    case 'U':
                        U(cleft, ctop);
                        break;

                    case 'v':
                    case 'V':
                        V(cleft, ctop);
                        break;

                    case 'w':
                    case 'W':
                        W(cleft, ctop);
                        break;

                    case 'x':
                    case 'X':
                        X(cleft, ctop);
                        break;

                    case 'y':
                    case 'Y':
                        Y(cleft, ctop);
                        break;

                    case 'z':
                    case 'Z':
                        Z(cleft, ctop);
                        break;
                }
                cleft += 8;
            }
        }

        static void A(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (((Col == 1 || Col == 5) && Row != 0) || ((Row == 0 || Row == 3) && (Col > 1 && Col < 5)))
                        Console.Write("A");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void B(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (Col == 1 || ((Row == 0 || Row == 3 || Row == 6) && (Col < 5 && Col > 1)) || (Col == 5 && (Row != 0 && Row != 3 && Row != 6)))
                        Console.Write("B");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void C(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if ((Col == 1 && (Row != 0 && Row != 6)) || ((Row == 0 || Row == 6) && (Col > 1 && Col < 5)) || (Col == 5 && (Row == 1 || Row == 5)))
                        Console.Write("C");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void D(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (Col == 1 || ((Row == 0 || Row == 6) && (Col > 1 && Col < 5)) || (Col == 5 && Row != 0 && Row != 6))
                        Console.Write("D");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void E(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (Col == 1 || ((Row == 0 || Row == 6) && (Col > 1 && Col < 6)) || (Row == 3 && Col > 1 && Col < 5))
                        Console.Write("E");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void F(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (Col == 1 || (Row == 0 && Col > 1 && Col < 6) || (Row == 3 && Col > 1 && Col < 5))
                        Console.Write("F");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void G(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if ((Col == 1 && Row != 0 && Row != 6) || ((Row == 0 || Row == 6) && Col > 1 && Col < 5) || (Row == 3 && Col > 2 && Col < 6) || (Col == 5 && Row != 0 && Row != 2 && Row != 6))
                        Console.Write("G");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void H(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if ((Col == 1 || Col == 5) || (Row == 3 && Col > 1 && Col < 6))
                        Console.Write("H");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void I(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (Col == 3 || (Row == 0 && Col > 0 && Col < 6) || (Row == 6 && Col > 0 && Col < 6))
                        Console.Write("I");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void J(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if ((Col == 4 && Row != 6) || (Row == 0 && Col > 2 && Col < 6) || (Row == 6 && Col == 3) || (Row == 5 && Col == 2))
                        Console.Write("J");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void K(int cleft, int ctop)
        {
            int i, j;
            j = 5;
            i = 0;
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {

                    if (Col == 1 || ((Row == Col + 1) && Col != 0))
                    {
                        Console.Write("K");
                    }
                    else if (Row == i && Col == j)
                    {
                        Console.Write("K");
                        i++;
                        j--;
                    }
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void L(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (Col == 1 || (Row == 6 && Col != 0 && Col < 6))
                        Console.Write("L");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void M(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (Col == 1 || Col == 5 || (Row == 2 && (Col == 2 || Col == 4)) || (Row == 3 && Col == 3))
                        Console.Write("M");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void N(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (Col == 1 || Col == 5 || (Row == Col && Col != 0 && Col != 6))
                        Console.Write("N");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void O(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (((Col == 1 || Col == 5) && Row != 0 && Row != 6) || ((Row == 0 || Row == 6) && Col > 1 && Col < 5))
                        Console.Write("O");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void P(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (Col == 1 || ((Row == 0 || Row == 3) && Col > 0 && Col < 5) || ((Col == 5 || Col == 1) && (Row == 1 || Row == 2)))
                        Console.Write("P");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void Q(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if ((Col == 1 && Row != 0 && Row != 6) || (Row == 0 && Col > 1 && Col < 5) || (Col == 5 && Row != 0 && Row != 5) || (Row == 6 && Col > 1 && Col < 4) || (Col == Row - 1 && Row > 3))
                        Console.Write("Q");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void R(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (Col == 1 || ((Row == 0 || Row == 3) && Col > 1 && Col < 5) || (Col == 5 && Row != 0 && Row < 3) || (Col == Row - 1 && Row > 2))
                        Console.Write("R");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void S(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (((Row == 0 || Row == 3 || Row == 6) && Col > 1 && Col < 5) || (Col == 1 && (Row == 1 || Row == 2 || Row == 6)) || (Col == 5 && (Row == 0 || Row == 4 || Row == 5)))
                        Console.Write("S");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void T(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (Col == 3 || (Row == 0 && Col > 0 && Col < 6))
                        Console.Write("T");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void U(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (((Col == 1 || Col == 5) && Row != 6) || (Row == 6 && Col > 1 && Col < 5))
                        Console.Write("U");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void V(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (((Col == 1 || Col == 5) && Row < 5) || (Row == 6 && Col == 3) || (Row == 5 && (Col == 2 || Col == 4)))
                        Console.Write("V");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void W(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (((Col == 1 || Col == 5) && Row < 6) || ((Row == 5 || Row == 4) && Col == 3) || (Row == 6 && (Col == 2 || Col == 4)))
                        Console.Write("W");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void X(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (((Col == 1 || Col == 5) && (Row > 4 || Row < 2)) || Row == Col && Col > 0 && Col < 6 || (Col == 2 && Row == 4) || (Col == 4 && Row == 2))
                        Console.Write("X");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void Y(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (((Col == 1 || Col == 5) && Row < 2) || Row == Col && Col > 0 && Col < 4 || (Col == 4 && Row == 2) || ((Col == 3) && Row > 3))
                        Console.Write("Y");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }
        static void Z(int cleft, int ctop)
        {
            for (Row = 0; Row < 7; Row++)
            {
                for (Col = 0; Col < 7; Col++)
                {
                    if (((Row == 0 || Row == 6) && Col >= 0 && Col <= 6) || Row + Col == 6)
                        Console.Write("Z");
                    else
                        Console.Write(" ");
                }
                ctop++;
                Console.SetCursorPosition(cleft, ctop);
            }
        }

        static void Twenty()
        {
            Console.Write("Enter a Sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Random rnd = new Random();
            string[] MyRandomArray = words.OrderBy(x => rnd.Next()).ToArray();
            foreach (string word in MyRandomArray)
            {
                Console.Write(word + " ");
            }



        }

        static void Twenty1()
        {
            Console.Write("Enter a String: ");
            string a = Console.ReadLine();
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            string b = new string(charArray);
            Console.WriteLine(b);
        }

        static void Twenty2()
        {
            float[] nums = new float[3];
            try
            {
                for (int x = 0; x <3; x++)
            {
               
                Console.Write("Enter number {0}: ", x+1);
                nums[x] = float.Parse(Console.ReadLine());
                    
                }
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            Console.Write(Math.Round(nums.Average(),2));
        }

        static void Twenty3()
        {
            try
            {
                int[] x = new int[5];
                for(int a = 0; a < 5 ; a++)
                {
                    Console.Write("Enter number {0}: ", a+1);
                    x[a] = int.Parse(Console.ReadLine());
                }
                foreach(int y in x) {
                    Console.Write("{0}: "+ "\t", y);
                    for (int b = 0; b<y;b++)
                {
                        Console.Write("*");
                }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }

}

