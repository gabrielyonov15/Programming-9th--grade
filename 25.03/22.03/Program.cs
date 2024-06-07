namespace _22._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] name = new string[n];
            int[] nomer = new int[n];
            string[] predmet = new string[n];
            double[] ocenka = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Vivedi ime");
                name[i] = Console.ReadLine();
                Console.WriteLine("Vivedi nomer");
                nomer[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Vivedi predmet");
                predmet[i] = Console.ReadLine();
                Console.WriteLine("Vivedi ocenka");
                ocenka[i] = double.Parse(Console.ReadLine());
            }
            //izhod 1
            Console.WriteLine("izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{name[i]}/{nomer[i]}/{predmet[i]}/{ocenka[i]}");
            }
            //izhod 2
            Console.WriteLine("izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"AZ {name[i]} s nomer v klas: {nomer[i]} po predmet {predmet[i]} imam {ocenka[i]}");
            }
            //izhod 3
            Console.WriteLine("izhod 2");
            for (int i = 0; i < n; i++)
            {

                if (ocenka[i] >= 5.25)
                {
                    Console.WriteLine($"AZ {name[i]} s nomer v klas: {nomer[i]} po predmet {predmet[i]} imam {ocenka[i]}");

                }

            }
            //izhod 4
            Console.WriteLine("izhod 3");
            for (int i = 0; i < n - 1; i++)
            {

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (ocenka[j] > ocenka[j + 1])
                    {
                        double swapVar = ocenka[j];
                        ocenka[j] = ocenka[j + 1];
                        ocenka[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(String.Join(" ", ocenka));
            }
            Console.WriteLine("izhod 4");
            for (int i = 0; i < n; i++)
            {
                if (name[i] == "Genadi")
                {
                    if (nomer[i] >= 5 && nomer[i] <= 10)
                    {
                        Console.WriteLine($"Ime {name[i]} i nomera mu e {nomer[i]}");
                    }
                    // Console.WriteLine($"Ime {name[i]} i nomera mu e {nomer[i]}");
                    else
                    {
                        Console.WriteLine($"Ime {name[i]} i nomera mu e {nomer[i]}");
                    }
                }
            }
            //else
            //{
            //    Console.WriteLine($"Ime {name[i]} i nomera mu e {nomer[i]}");
            //}

            //Console.WriteLine("izhod 5");
            //for (int i = 0; i < n; i++)
            //{
            //    if (name[i] == name[i + 1])
            //    {
            //        for (int j = 0; j < n - 1; j++)
            //        {

            //            for (int b = 0; b < n - 1 - i; b++)
            //            {
            //                if (nomer[j] < nomer[j + 1])
            //                {
            //                    int swapVar = nomer[j];
            //                    nomer[j] = nomer[j + 1];
            //                    nomer[j + 1] = swapVar;
            //                }
            //            }
            //        }
            //    }
            //    for (int c = 0; c < n; c++)
            //    {
            //        Console.WriteLine(String.Join(" ", nomer));
            //    }
            //}
            Console.WriteLine("izhod 6");
             for (int i = 0; i < n - 1; i++)
             {
                   for (int j = 0; j< n - 1 - i; j++)
                   {
                       if (String.Compare(predmet[j] , predmet[j + 1]) > 0)
                       {
                          string swapVar = predmet[j];
                          predmet[j] = predmet[j + 1];
                          predmet[j + 1] = swapVar;
                       }
                           
                   }
             }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(String.Join(" ", predmet));
            }

        }
    }
}
    

