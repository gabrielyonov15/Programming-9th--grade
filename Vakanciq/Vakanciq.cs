using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vakanciq
{
    internal class Vakanciq
    {
        private string name;
        private string destinqciq;
        private int dniZaPochivka;
        private string izpit;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Destinqciq
        {
            get { return destinqciq; }
            set { destinqciq = value; }
        }
        public int DniZaPochivka
        {
            get { return dniZaPochivka; }
            set { dniZaPochivka = value; }
        }
        public string Izpit
        {
            get { return izpit; }
            set { izpit = value; }
        }

    }
}
