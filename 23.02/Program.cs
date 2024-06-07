namespace _23._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne na pamet
            string[] predmet = new string[3];
            double[] chas = new double[3];
            //vhod
            Console.WriteLine("vhod");
            for (int i = 0;i < 3; i++)
            {
                Console.WriteLine("Vivedi predmet:");
                predmet[i]= Console.ReadLine();
                Console.WriteLine("Vivedi chas:");
                chas[i]=double.Parse(Console.ReadLine());
            }
            //izhod
            Console.WriteLine("izhod");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(predmet[i]);
                Console.WriteLine(chas[i]);
            }
            //izhod 2 
            Console.WriteLine("izhod2");
            for (int i = 0; i < 3; i++)
            {
                if (chas[i]>=4)
                {
                    Console.WriteLine(chas[i]);
                }
            }
            //izhod 3 
            Array.Sort(chas);    
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(chas[i]);
            }
            //Izhod 4
            Array.Sort(predmet);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(predmet[i]);

            }
            //izhod 5
            Array.Reverse(predmet);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(predmet[i]);
            }
            //izhod 6
            string text = Console.ReadLine();
            string novPredmet = "Matematika";
            for (int i = 0; i < 3; i++)
            {
                if (predmet[i] == novPredmet)
                {
                    Console.WriteLine(predmet[i]);
                    Console.WriteLine(chas[i]);
                }
            }
            //izhod 7 
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(novPredmet[1]);
                Console.WriteLine(chas[1]);


            }
        }
    }
}
