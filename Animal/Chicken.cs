using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Animal
{
    internal class PolChicken
    {
        private string gender;
        private int age;
        public  string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public  int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void izhod()
        {
            Console.WriteLine($"{Age} - {Gender}");
            Console.WriteLine($"Age{Age} Gender{Gender}");
        }
    }
}
        internal class Chicken
    {
        private string colour;
        private double data;
       // private string animal;
      List<string> animal= new List<string>();
    public List<string> Animal
    {
        get { return animal; }
        set { animal = value; }
    }

         public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public  double Data
        {
            get { return data; }
            set { data = value; }
        }
        //public  string Animal
        //{
        //    get { return animal; }
        //    set { animal = value; }
        //}
        public void izhod()
        {
            Console.WriteLine($"{Colour} - {Data} - {animal}");
            Console.WriteLine($"Colour{Colour}  Date{Data} Animal{animal}");
        }

    }