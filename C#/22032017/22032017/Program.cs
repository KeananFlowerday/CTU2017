using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032017
{
    class Program
    {
        static void Main(string[] args)
        {
            Mandarin m = new Mandarin("Chi Long Qua","PRC","Black",250);
            Penguin p = new Penguin("Edd", "Canada", "White",100);
            Rubber r = new Rubber("Squeeky", "USA", "Yellow", 10);
            p.Fly();
            p.Sound();
            p.Showinfo();

            m.Sound();
            m.Sound("Hello, it's Me!");
            m.Fly();
            m.Showinfo();

            r.Fly();
            r.Sound();
            r.Showinfo();
            Console.ReadLine();
        }
    }
}
