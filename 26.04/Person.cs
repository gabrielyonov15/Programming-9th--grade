using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _26._04
{
    internal class Person
    {
        public string name;
        public int age;
        public string grad;
      
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public String Grad
        {
            get { return this.grad; }
            set { this.grad = value; }
        }
    }
}