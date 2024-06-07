

namespace _31._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvtoMoto A = new AvtoMoto();
            int n = int.Parse(Console.ReadLine());
            string[] category = new string[n];
            int[] tires = new int[n];
            int[] regNumber = new int[n];
            for(int i = 0; i < n; i++)
            {
               // Console.WriteLine("Category:");
                category[i] ="A";
                Console.WriteLine("Tires:");
                tires[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("RegNumber:");
                regNumber[i] = int.Parse(Console.ReadLine());
                if (tires[i] == 2)
                {
                    category[i] = "A";
                    Console.WriteLine($"Category:{category[i]} Tires:{tires[i]}");
                    // Console.WriteLine($"Category:{category[i]} RegNumber:{regNumber[i]}");
                }
                else
                {
                    category[i] = "B";
                    Console.WriteLine($"Category:{category[i]} Tires:{tires[i]}");
                    // Console.WriteLine($"Category:{category[i]} RegNumber:{regNumber[i]}");
                }
                Console.WriteLine($"Category:{category[i]} RegNumber:{regNumber[i]}");
                // if (tires[i] == 2)
                // {
                //     Console.WriteLine($"Category:{category[i]} Tires:{tires[i]}");
                // }
                // else
                // {
                //     Console.WriteLine($"Category:{category[i]} Tires:{tires[i]}");
                // }
                // //Console.WriteLine($"Category:{category[i]} Tires:{tires[i]}");
                //// Console.WriteLine($"Category:{category[i]} RegNumber:{regNumber[i]}");
            }
            //for(int i =0;i< n; i++)
            //{
            //   Console.WriteLine($"Category:{category[i]} RegNumber:{regNumber[i]}");
            //}
            //IntroduceYourself();
            //IntroduceYourself1();
            //A.IntroduceYourself();
            //A.IntroduceYourself1();
        }

        //private static void IntroduceYourself1()
        //{
        //    throw new NotImplementedException();
        //}

        //private static void IntroduceYourself()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
