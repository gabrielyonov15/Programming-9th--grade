using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Data
    {
        private string breakfast;
        private int count;
        private string drinks;
        private int number;
        public String Breakfast
        {
            get { return breakfast; }
            set { breakfast = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public String Drinks
        {
            get { return drinks; }
            set { drinks = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine("Ти днес си ял {0} и ядох {1} пъти.", breakfast, count);
        }

    }
}
