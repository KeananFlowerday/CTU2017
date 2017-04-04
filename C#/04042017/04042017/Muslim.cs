using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04042017
{
    class Muslim
    {
        private string name;
        private int age;
        private bool isAlive;
        private static int numalive;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool IsAlive { get => isAlive; set => isAlive = value; }
        public static int Numalive { get => numalive; set => numalive = value; }


        public Muslim()
        {
            this.IsAlive = true;
            Numalive++;
        }
        public Muslim(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.isAlive = true;
            Numalive++;
        }

        static public void bigkaboom(Muslim a, Muslim b)
        {
            Console.WriteLine("kaboom".ToUpper());
            a.IsAlive = false;
            b.IsAlive = false;
            Numalive -=2;

        }
        public void kaboom()
        {
            Console.WriteLine("kaboom");
            this.IsAlive = false;
            Numalive--;
            
        }

        public void display()
        {
            string a;
            if (this.IsAlive == true)
            {
                a = "Alive";  
            }
            else
            {
                a = "Dead";
            }
            Console.WriteLine(this.Name + " is " + a);
            Console.WriteLine( "There are {0} Terrorist(s) Alive", Numalive);
        }
        public void displayone()
        {
            string a;
            if (this.IsAlive == true)
            {
                a = "Alive";
            }
            else
            {
                a = "Dead";
            }
            Console.WriteLine(this.Name + " is " + a);
           
        }
    }
}
