using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chicken A = new Chicken();
            PolChicken B = new PolChicken();
            List<string> animal = new List<string>();
            Console.WriteLine("N");
            int n = int.Parse(Console.ReadLine());
            //Zadelqne na pamet
            int [] age = new int[n];
            double[] data = new double[n];
            //Vhod
            Console.WriteLine("vhod");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Colour");
                A.Colour = Console.ReadLine();
                Console.WriteLine("Data");
                data[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Animal");
                animal.Add(Console.ReadLine());  
                Console.WriteLine("Age");
                age[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Gender");
                B.Gender = Console.ReadLine();
                //izhod
                Console.WriteLine("izhod");
                //normalen izhod
                Console.WriteLine("normalen izhod");
                Console.WriteLine($"{A.Colour} - {data[i]} - {animal[i]}");
                Console.WriteLine($"{age[i]} - {B.Gender}");
                //izhod s podobavacho izrechenie
                Console.WriteLine("izhod s podobavacho izrechenie");
                Console.WriteLine($"Colour{A.Colour}  Date{data[i]} Animal{animal[i]}");
                Console.WriteLine($"Age{age[i]} Gender{B.Gender}");
            }
            //ako animal e red da izvede jivotnoto
            Console.WriteLine("ako animal e red da izvede jivotnoto");
            for (int i = 0; i < n; i++)
            {
                if (A.Colour == "red")
                {
                    Console.WriteLine($"{animal[i]}");
                }
            }
            //ako gender e male da izvede pola
            Console.WriteLine("ako gender e male da izvede pola");
            for (int i = 0; i < n; i++)
            {
                if (B.Gender == "male")
                {
                    Console.WriteLine(B.Gender);
                }
            }
            //sortirane po data ot nai malko do nai golqmo
            Console.WriteLine("sortirane po data ot nai malko do nai golqmo");
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - 1; j++)
                {
                    if (data[j] > data[j + 1]) 
                    {
                        double swapVar = data[j];
                        data[j]= data[j+1];
                        data[j + 1] = swapVar;
                    }
                 }
            }
            for(int i = 0;i<n;i++)
            {
                Console.WriteLine(data[i]);
            }
            //sortirane po godini ot nai malko do nai golqmo 
            Console.WriteLine("sortirane po godini ot nai malko do nai golqmo");
            for (int i = 0; i < age.Length - 1; i++)
            {
                for (int j = 0; j < age.Length - 1; j++)
                {
                    if (age[j] > age[j + 1])
                    {
                        int swapVar = age[j];
                        age[j] = age[j + 1];
                        age[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(age[i]);
            }
        }
    }
}