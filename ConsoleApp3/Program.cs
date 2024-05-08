namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data A = new Data();
            Console.WriteLine("Какво яде днес?:");
            A.Breakfast = Console.ReadLine();
            Console.WriteLine("Колко пъти яде?");
            A.Count = int.Parse(Console.ReadLine());
            Console.WriteLine("Ти пи ли?");
            A.Drinks = Console.ReadLine();
            A.Number = int.Parse(Console.ReadLine());
            A.IntroduceYourself();
            if (A.Count > 5)
            {
                A.Count = A.Count * 5;
                Console.WriteLine("Ти си ял " ,+ A.Count + "пъти.");
            }
            else
            {
                Console.WriteLine("Бройката ти е под 5.");
            }
            A.IntroduceYourself();
            if (A.Drinks == "Да")
            {
                switch (A.Number)
                {
                    case 0: Console.WriteLine("Мартини"); break;
                    case 1: Console.WriteLine("Водка"); break;
                    case 2: Console.WriteLine("Вода"); break;
                    case 3: Console.WriteLine("Уиски"); break;
                }
                if (A.Number == 0)
                {
                    Console.WriteLine("Мартини");
                }
                else
                if (A.Number == 1)
                {
                    Console.WriteLine("Водка");
                }
                else
                if (A.Number == 2)
                {
                    Console.WriteLine("Вода");
                }
                else
                if (A.Number == 3)
                {
                    Console.WriteLine("Уиски");
                }
            }
            else
            {
                Console.WriteLine("Лек ден!");
            }
            A.IntroduceYourself();
        }
    }
}

