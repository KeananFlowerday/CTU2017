using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032017
{
    class Mandarin : Duck
    {


        #region Constructor
        public Mandarin(string name, string habitat, string color, double size)
        {
            Habitat = habitat;
            Name = name;
            Color = color;
            Size = size;
            Alive();
        }

        public Mandarin()
        {
            Alive();
        }

        #endregion
    }
}
