using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _03._06
{
    internal class Class1
    {
        public string category;
        public int broi;
        public int number;
        public String Category
        {
            set { category = value; }
            get { return category; }
        }
        public int Broi
        {
            set { broi = value; }
            get { return broi; }
        }
        public int Number
        {
            set { number = value; }
            get { return number; }
        }
    }
}
