namespace Vakanciq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vakanciq A = new Vakanciq();
            int n = int.Parse(Console.ReadLine());
            int[] dniZaPochivki = new int[n];
            string[] name = new string[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Name:");
                name[i] = Console.ReadLine();
                Console.WriteLine("Destinqciq:");
                A.Destinqciq = Console.ReadLine();
                Console.WriteLine("DniZaPochivki:");
                dniZaPochivki[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Izpit:");
                A.Izpit = Console.ReadLine();
                Console.WriteLine($"Name:{name[i]} Destinqciq:{A.Destinqciq} DniZaPochivka:{dniZaPochivki[i]} Izpit:{A.Izpit}");
            }
            Console.WriteLine("Izhod 1");
            for(int i = 0;i<n;i++)
            {
                Console.WriteLine($"Name:{name[i]} Destinqciq:{A.Destinqciq} DniZaPochivka:{dniZaPochivki[i]} Izpit:{A.Izpit}");
            }
            Console.WriteLine("Izhod 2");
            for (int i = 0; i < n;i++)
            {
                Console.WriteLine($"Name:{name[i]}-");
            }
            Console.WriteLine("Izhod 3");
            for (int i = 0; i < n; i++)
            {
                if(A.Izpit == "Da")
                {
                    Console.WriteLine("Kolko izpita imash");
                    int kolkoIzpit = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Imam {kolkoIzpit} izpita");
                }
                else
                {
                    Console.WriteLine("Priqtna pochivka");
                }
            }
            Console.WriteLine("Izhod 4");
            for (int i = 0;i<n;i++) 
            { 
                if(A.Destinqciq != "Sopot")
                {
                    Console.WriteLine($"{A.Destinqciq}");
                }
            }
            Console.WriteLine("Izhod 5");
            for (int i = 0;i < name.Length-1;i++)
            {
                for(int j = 0; j < name.Length-1;j++)
                {
                    if (String.Compare(name[j] , name[j+1])<0)
                    {
                        string swapVar = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = swapVar;
                    }
                }
            }
            for(int i = 0;i<n;i++)
            {
                Console.WriteLine(String.Join(" ", name[i]));
            }
            Console.WriteLine("Izhod 6");
            for (int i = 0; i < dniZaPochivki.Length - 1; i++)
            {
                for (int j = 0; j < dniZaPochivki.Length - 1; j++)
                {
                    if (dniZaPochivki[j] < dniZaPochivki[j + 1])
                    {
                        int swapVar = dniZaPochivki[j];
                        dniZaPochivki[j] = dniZaPochivki[j + 1];
                        dniZaPochivki[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(String.Join(" ", dniZaPochivki[i]));
            }



        }
    }
}
