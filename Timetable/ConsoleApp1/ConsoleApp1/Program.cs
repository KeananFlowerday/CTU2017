using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            DateTime dt = DateTime.Today;
            if (dt.ToString("ddd") == "Sun")
            {
              dt =  dt.AddDays(1);
            }
            else if (dt.ToString("ddd") == "Sat")
            {
               dt = dt.AddDays(2);
            }
            Console.WriteLine(dt.ToString("ddd"));
            Console.WriteLine();

            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader("C:/Users/Keanan/documents/visual studio 2017/Projects/ConsoleApp1/ConsoleApp1/txt/" + dt.ToString("ddd")+".txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] lines = line.Split(',');
                Console.WriteLine(String.Format("{0,-15} | {1,-20} | {2,8}", lines[0], lines[1], lines[2]));
                
                counter++;
            }

            file.Close();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            Console.Read();

        }
    }
}
