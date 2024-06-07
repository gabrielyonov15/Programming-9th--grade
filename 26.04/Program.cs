namespace _26._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //Заделяне на памет
            Console.Write("Колко данни ще въвеждаш:");
            int n = int.Parse(Console.ReadLine());
            //Вход 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Как се казваш:");
                person.name = Console.ReadLine();
                Console.WriteLine("На колко години си:");
                person.age = int.Parse(Console.ReadLine());
                Console.WriteLine("Въведи град:");
                person.grad = Console.ReadLine();
                Console.WriteLine($"{person.name} {person.age} {person.grad}");
            }
                for (int i = 0; i < n; i++)
                {
                    if (person.grad == "Sopot")
                    {
                        Console.WriteLine($"{person.name} {person.age} {person.grad}");
                    }
                    else
                    {
                        Console.WriteLine("Ne e ot sopot");
                    }
                }

            }
        }
    }

