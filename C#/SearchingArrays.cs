using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork22022017
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] Names = {"Tongai", "Keanan", "Qaanita", "Michael",  };
            
            Console.Write("Enter the name you are looking for: ");
            String n = Console.ReadLine();

            if (findname(n, Names))
            {
                Console.Write("name found");
            }
            else
                Console.Write("name not found");
            Console.Read();
        }

        static bool findname( string n, string[] Names)
        {
           string a= n.ToLower();
            bool found = false;
            foreach (string s in Names)
            {
              string b =  s.ToLower();
                if (b.Contains(a))
                {
                    found = true;
                } 
             }
            if (found == true)
            {
                return true;
            }
            else return false;
        }
    }
}
