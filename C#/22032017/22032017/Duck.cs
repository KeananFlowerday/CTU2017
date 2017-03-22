using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032017
{
    class Duck : Bird
    {

        #region Constructors
        //Constructors

        public Duck(string name, string habitat, string color, double size)
        {
            Habitat = habitat;
            Name = name;
            Color = color;
            Size = size;
            Alive();
        }

        public Duck()
        {
            Alive();
        }
        #endregion

        #region methods
        public  void Sound()
        {
            Console.WriteLine("Quack!");
        }

        public void Sound(string sound)
        {
            Console.WriteLine("Quack! "+sound+ " Quack!");
        }
        #endregion


    }
}
