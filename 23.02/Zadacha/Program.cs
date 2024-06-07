namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int[] number = new int[5];
            //vhod
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Vivedi chisla");
                number[i] = int.Parse(Console.ReadLine());
            }
            //izxod 1
            for (int i = 0; i < 5 ; i++)
            {
                Console.WriteLine(number[i]);
            }
            //izhod 2
            Console.WriteLine("Izhod bez posleden element");
            for (int i = 4; i < 3; i++)
            {
                Console.WriteLine(number[i]);



            }
            //izhod 3

            //for (int r = 1; r < k; r++)
            //{
            //    int i = 0;
            //    for (i = (i + r) % 5; i < 5 - 1; i++)
            //    {
            //sum[i] = 0;
            //sum[i] = (i + r) % n + sum[i];
            //Console.WriteLine(number[r]);
            //  }

            // }

        }
    }
}
