using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._05
{
    internal class AvtoMoto
    {
        public string category;
        public int tires;
        public int regNumber;
        //public AvtoMoto(string category, int tires, int regNumber)
        //{
        //    this.category = category;
        //    this.tires = tires;
        //    this.regNumber = regNumber;
        //}
        public String Category
        { 
            get { return category; }
            set {  category = value; }
        }
        public int Tires    
        {
            get { return tires; }
            set { tires = value; }
        }
        public int RegNumber
        {
            get { return regNumber; }
            set { regNumber = value; }
        }

        public void IntroduceYourself()
        {
            if (tires ==2)
            {
                category = "A";
                Console.WriteLine($"Category:{category} Tires:{tires}");
            }
            else
            {
                category = "B";
                Console.WriteLine($"Category:{category} Tires:{tires}");
            }
        }
        public void IntroduceYourself1()
        {
            Console.WriteLine($"Category:{category} RegNumber:{regNumber}");
        }

    }
}
