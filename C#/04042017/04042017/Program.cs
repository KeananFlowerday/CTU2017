using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04042017
{
    class Program
    {
        static void Main(string[] args)
        {
            Muslim Achmed = new Muslim("Achmed", 24);
            Muslim Riyhaad = new Muslim();
            Riyhaad.Name = "Riyhaad";
            Riyhaad.Age = 22;
            Riyhaad.displayone();
            Achmed.display();
            Riyhaad.kaboom();
            Riyhaad.display();


            Muslim Sideeq = new Muslim("Sideeq", 40);
            Sideeq.display();
            Muslim.bigkaboom(Sideeq, Achmed);
            Achmed.displayone();
            Sideeq.display();
            Console.ReadLine();
           
        }
    }
}
