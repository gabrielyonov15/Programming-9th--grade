namespace _13._5
{
    internal class Program
    {
        internal class Poleta
        {
           public static string Name { get;set; }
            public static string Data { get; set; }
            public static double VkaraniPari { get; set; }  
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Kolko duchi che vivejdach");
            int n = int.Parse(Console.ReadLine());
            string[] name = new string[n];
            string[] date = new string[n];
            double[] vkaraniPari = new double[n];
            for (int i = 0; i < n; i++)

            {
                Console.WriteLine("Vivedi ime");
                Poleta.Name = Console.ReadLine();
                name[i] = Poleta.Name;
                Console.WriteLine("Vivedi data");
                Poleta.Data = Console.ReadLine();
                date[i] = Poleta.Data;
                Console.WriteLine("Vivedi pari");
                Poleta.VkaraniPari = double.Parse(Console.ReadLine());
                vkaraniPari[i] = Poleta.VkaraniPari;

            }
            for (int i = 0; i < n; i++)

            {
                Console.WriteLine($"Ime:{name[i]} Data:{date[i]} vkaraniPari:{vkaraniPari[i]}");
            }

            }
    }
}
