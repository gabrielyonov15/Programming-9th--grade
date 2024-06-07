namespace _15._05
{
    
    internal class Program
    {
        internal class Adress 
        {
            public static string NaselenoMqsto { get; set; }
            public static string Street { get; set; }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Vivedi kolko piti che vivejdah");
            int n = int.Parse(Console.ReadLine());
            string[] naselenoMqsto = new string[n];
            string[] street = new string[n];
            string[] name = new string[n];
            string[] lastName = new string[n];
            int[] nomerNaKartata = new int[n];
            double[] vkaraniPari = new double[n];
            double[] lixva = new double[n];
            double[] iztegleniPari=new double[n];
            double[] b = new double[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Naseleno mqsto");
                naselenoMqsto[i]= Console.ReadLine();
                Console.WriteLine("Ulitsa");
                street[i] = Console.ReadLine();
                Console.WriteLine("Ime:");
                name[i] = Console.ReadLine();
                Console.WriteLine("LastName:");
                lastName[i] = Console.ReadLine();
                Console.WriteLine("NomerNaKartatat:");
                nomerNaKartata[i] =int.Parse(Console.ReadLine());
                Console.WriteLine("VkaraniPari:");
                vkaraniPari[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Lixva:");
                lixva[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("IztegleniPari:");
                iztegleniPari[i] = double.Parse(Console.ReadLine());
                b[i] = 0.00;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"NaselenoMqsto:{naselenoMqsto[i]} Street:{street[i]} name:{name[i]} lastName:{lastName[i]} nomerNaKartata:{nomerNaKartata[i]} vkaraniPari:{vkaraniPari[i]} lixva:{lixva[i]} iztegleniPari{iztegleniPari[i]}  ");
                Console.WriteLine("Lixva");
                b[i] = lixva[i] * 0.01 * vkaraniPari[i];
                Console.WriteLine($"Za kraq na meseca parite ti sa {vkaraniPari[i]}lv + {b[i]}%lixva");
                Console.WriteLine($"Obcho {Math.Abs(vkaraniPari[i] +b[i])}");
            }
        }
    }
}
