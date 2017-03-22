using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double[]> fun = makeList();
            showarray(fun);

           
            Console.ReadKey();
        }

        static double[][] makearray()
        {
            double[][] foo = new double[3][];
            foo[0] = new double[1];
            foo[1] = new double[2];
            foo[2] = new double[3];

            for (int i = 0; i < foo.Length; i++)
            {
                for (int j = 0; j < foo[i].Length; j++)
                {
                    foo[i][j] = j*Math.PI;
                }

            }
            return foo;
        }

        static void showarray(double[][]foo)
        {
          

            for (int i = 0; i < foo.Length; i++)
            {
                for (int j = 0; j < foo[i].Length; j++)
                {
                    Console.WriteLine("Array[{0}][{1}] = {2}", i , j , foo[i][j].ToString());
                }

            }
            
        }

        static List<double[]> makeList()
        {
            List<double[]> foo = new List<double[]>(); 
            foo.Add(new double[1]);
            foo.Add(new double[2]);
            foo.Add(new double[3]);

            for (int i = 0; i < foo.Capacity-1; i++)
            {
                for (int j = 0; j < foo[i].Length; j++)
                {
                    foo[i][j] = j * Math.PI;
                }

            }
            return foo;
        }

        static void showarray(List<double[]> foo)
        {


            for (int i = 0; i < foo.Capacity-1; i++)
            {
                for (int j = 0; j < foo[i].Length; j++)
                {
                    Console.WriteLine("List[{0}][{1}] = {2}", i, j, foo[i][j].ToString());
                }

            }

        }

    }
    }

