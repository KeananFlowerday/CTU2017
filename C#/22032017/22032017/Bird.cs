using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032017
{
    class Bird
    {
        #region properties
        //properties
        private string habitat;
        private string name;
        private string color;
        private double size;
        private bool isDead;
        #endregion

        #region getset
        //getters and setters
        public string Habitat
        {
            get => habitat;
            set => habitat = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Color
        {
            get => color;
            set => color = value;
        }
        public double Size
        {
            get => size;
            set => size = value;
        }
        public bool IsDead
        {
            get => isDead;
            set => isDead = value;
        }

        #endregion

        #region Constructors
        //Constructors

        public Bird(string name, string habitat, string color, double size)
        {
            this.habitat = habitat;
            this.name = name;
            this.color = color;
            this.size = size;
            Alive();
        }

        public Bird()
        {
            Alive();
        }
        #endregion

        #region Methods
        //behaviours
        public void Alive()
        {
            //Something here
            this.isDead = false;
        }
        public void Kill()
        {
            //Something here
            this.isDead = true;
        }

        public void Sound()
        {
            //Something here
            Console.WriteLine("*Awkward Silence Intensifies*");
        }

        public void Fly()
        {
            //Something here
            Console.WriteLine("I am Flying!");
        }

        public void Showinfo()
        {
            Console.WriteLine();
            Console.WriteLine("Name    : {0}", this.Name);
            Console.WriteLine("Habitat : {0}", this.Habitat);
            Console.WriteLine("Color   : {0}", this.Color);
            Console.WriteLine("Size    : {0}", this.Size);
            Console.WriteLine();
        }
        #endregion
    }
}
