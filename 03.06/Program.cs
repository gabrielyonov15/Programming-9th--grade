namespace _03._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadelqne na pamet
            Class1 A = new Class1();
            Class2 B = new Class2();
            Class3 C = new Class3();
            Console.WriteLine("Kolko danni che vivejdah");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double cena1 = 0;
            double[] cena = new double[n];
            //Vhod
            for (int i = 0; i < n ;i++)
            {
                Console.WriteLine("Category:");
                A.Category = Console.ReadLine();
                Console.WriteLine("BroiHora:");
                A.Broi = int.Parse(Console.ReadLine()) ;
                Console.WriteLine("Number:");
                A.Number= int.Parse(Console.ReadLine()) ;
                Console.WriteLine("VidPiza:");
                B.VidPiza = Console.ReadLine();
                Console.WriteLine("BroiPiza:");
                B.Broi = int.Parse(Console.ReadLine());
                Console.WriteLine("Rasmer:");
                B.Rasmer = Console.ReadLine();
                //Console.WriteLine("Cena:");
                //cena[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("NachinNaPlachane:");
                C.NachinNaPlachane = Console.ReadLine();
                //Izhod
                Console.WriteLine("Izhod 1");
                Console.WriteLine($"Category:{A.Category} Broi:{A.Broi} Number:{A.Number}");
                Console.WriteLine($"VidPiza:{B.VidPiza} Broi:{B.Broi} Rasmer:{B.Rasmer}");
                Console.WriteLine($"Cena:{cena[i]} NachinNaPlachane:{C.NachinNaPlachane}");
            }
            ////Izhod
            //Console.WriteLine("Izhod 1");
            //for (int i = 0; i <n; i++)
            //{
            //    Console.WriteLine($"Category:{A.Category} Broi:{A.Broi} Number:{A.Number}");
            //    Console.WriteLine($"VidPiza:{B.VidPiza} Broi:{B.Broi} Rasmer:{B.Rasmer}");
            //    Console.WriteLine($"Cena:{cena[i]} NachinNaPlachane:{C.NachinNaPlachane}");
            //}
            //Izvajdane na sumata i nomer na masata i izvirchvane na if proverki
            Console.WriteLine("Izhod 2");
            for (int i = 0; i < n; i++)
            {
                sum = cena[i] * B.broi;
                Console.WriteLine($"Suma:{sum} NomerNaMasata:{A.Number}");
            }
            //Izvajdane na Izvajdane na broi piza i vid piza i izvirshvane na if proverki
            Console.WriteLine("Izhod 3");
            for (int i = 0;i<n;i++)
            {
                if(B.Rasmer == "malka")
                {

                    cena[i] = 10 * B.Broi;
                    Console.WriteLine($"BroiPizza:{B.Broi} VidPiza:{B.VidPiza} Cena:{cena[i]}");
                }
                else
                    if(B.Rasmer =="Golqma")
                {
                    cena[i] = 15 * B.Broi;
                    Console.WriteLine($"BroiHora:{A.Broi} sednale na masa s nomer {A.Number} Cena:{cena[i]}");
                }
            }
            //Izvajdame nomer na maca i cena na piza i izvirshvane na if proverki
            Console.WriteLine("Izhod 4");
            for (int i = 0;i<n;i++)
            {
                if(A.Number >=5)
                {
                    Console.WriteLine($"NomerNaMaca:{A.Number} cenaNaPitzata:{cena[i]}");
                }
            }
            //sortirane po cena
            Console.WriteLine("Izhod 5");
            for (int i = 0;i<cena.Length-1;i++)
            {
                for(int j = 0;j<cena.Length-1;j++)
                {
                    if (cena[j] > cena[j+1])
                    {
                        double swapVar = cena[j];
                        cena[j] = cena[j + 1];
                        cena[j + 1] = swapVar;
                    }
                }
            }
            for(int i = 0;i<n;i++)
            {
                Console.WriteLine(cena[i]);
            }
        }
    }
}
