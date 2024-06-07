namespace ZAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadelqne na pamet
            double[] pari = new double[2];
            string[] vidZakuska = new string[2];  
            //vhod
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Vivedi pari:");
                pari[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Vivedi zakuska");
                vidZakuska[i] = Console.ReadLine();
            }
            //izhod
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{vidZakuska[i]} / {pari[i]}");
            }

        }
    }
}
