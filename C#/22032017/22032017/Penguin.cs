using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032017
{
    class Penguin : Bird
    {

        #region Constructors
        //Constructors

        public Penguin(string name, string habitat, string color, double size)
        {
           Habitat = habitat;
            Name = name;
            Color = color;
            Size = size;
            Alive();
        }

        public Penguin()
        {
            Alive();
        }
        #endregion


        #region methods
        public void Fly()
        {
            Console.WriteLine("I am Swimming!");
        }
        #endregion




    }
}
