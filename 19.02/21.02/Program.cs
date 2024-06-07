namespace _21._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne na pamet
            int n = int.Parse(Console.ReadLine());
            string[] bukvi = new string[n];
            //vhod
            for (int i = 0; i < n; i++)
            {
                bukvi[i] = Console.ReadLine();
            }
            //izhod
            for (int i = n-1 ; i >= 0; i--)
            {
                Console.WriteLine(bukvi[i]);
            }
            //izhod2
            //for (int i = 1; i < 2; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}
        }
    }
}
