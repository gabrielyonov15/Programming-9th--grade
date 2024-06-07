namespace _19._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne na pamet 
            int[] nomer = new int[5];
            string[] ime = new string[5];
            //vhod
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Vivedi nomer");
                nomer[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Vivedi ime");
                ime[i] = Console.ReadLine();
            }
            //izhod
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{ime[i]} {nomer[i]}");
            }
            //izhod 2 
            for (int i = 0; i < 5; i++)
            {
                if (i > 3)
                {
                    Console.WriteLine(nomer[i]);
                }

            }
            //izhod 3 
            Console.Write("Vivedi kakvo ime da tircq:");
            string name = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{ime[i]} {nomer[i]}");
                if (ime[i] == "Ivan")
                {
                    Console.WriteLine($"{ime} {nomer}");
                }
                else
                {
                    Console.WriteLine("Eror");
                }
            }
        }
    }
}
