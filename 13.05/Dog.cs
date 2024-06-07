using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._05
{
    internal class Dog
    {
        static int dogCount;

        private string name;
        private int age;
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            dogCount += 1;
        }
        public void Bark()
        {
            Console.WriteLine("wow-wow");
        }
        public void Bark1()
        {
            Console.WriteLine("mql");
        }
        public void PrintInfo()
        {
            Console.WriteLine("Dog's name:"+ this.name + "; age:"+ this.age + "; Obajda se sas: ");
            this.Bark();
           
        }
        public void PrintInfo1()

        {
            Console.WriteLine("Cat's name:" + this.name + "; age:" + this.age + "; Obajda se sas: ");
            this.Bark1();
        }
    }

    
}
