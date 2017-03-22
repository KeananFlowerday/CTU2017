using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032017
{
    class Rubber : Duck
    {

        #region Constructor
        public Rubber(string name, string habitat, string color, double size)
        {
            Habitat = habitat;
            Name = name;
            Color = color;
            Size = size;
            Kill();
        }

        public Rubber()
        {
            Kill();
        }

        #endregion
        #region Methods
        public void Sound()
        {
            Console.WriteLine("Squeek!");
        }

        public void Fly()
        {
            Console.WriteLine("*Floats*");
        }
        #endregion
    }
}
