namespace _25._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
            string[] vidPitie = new string[n];
            int[] kolichestvo = new int[n]; 
            int[] broika= new int[n]; 
            string[] p =new string[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Vivedi vid pitie");
                vidPitie[i] = Console.ReadLine();
                Console.WriteLine("Vivedi kolichestvo");
                kolichestvo[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Vivedi broiki");
                broika[i]=int.Parse(Console.ReadLine());    
            }
            Console.WriteLine("Izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ti imach {vidPitie[i]} samo {broika[i]} ");
            }
            Console.WriteLine("Izhod 2");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tvoite {kolichestvo[i]} litri samo {kolichestvo[i]*1000} mililitri ");
            }
            Console.WriteLine("Izhod 3");
            for (int i = 0; i < n; i++)
            {
                if (broika[i] > 2)
                {
                    Console.WriteLine($"{vidPitie[i]}");
                }
            }
            Console.WriteLine("Izhod 4");
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n - 1-i; j++)
                {
                    if (broika[j] > broika[j+1])
                    {
                        int swapVar = broika[j];
                        broika[j] = broika[j + 1];
                        broika[j+1] = swapVar;  

                    }
                }
             }
            for(int i=0; i < n;i++)
            {
                Console.WriteLine(String.Join(" ",broika));
            }
            Console.WriteLine("Izhod 5");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ще въвеждаме ли данни");
                p[i] = Console.ReadLine();
                if (p[i] == "Da")
                {
                    Console.WriteLine("Vivedi broi kolko piti iskach da te pita");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vivedi vid pitie");
                    vidPitie[i] = Console.ReadLine();
                    Console.WriteLine("Vivedi kolichestvo");
                    kolichestvo[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vivedi broiki");
                    broika[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{vidPitie[i]}/{kolichestvo[i]}/{broika[i]}");

                }
                else
                if (p[i]=="Ne")
                {
                    Console.WriteLine("Няма да въвеждаме");
                }
            }
        }
    }
}
