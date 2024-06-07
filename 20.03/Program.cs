using System.Collections.Generic;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _20._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //int number = int.MaxValue;
            //List<int> start = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //List<int> length = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int start = nums[0];
            int length = nums[0];
            int bestLength = nums[0];
            int startLength = nums[0];
            //int number = int.MaxValue;
            Console.WriteLine("izhod1");
            for (int index = 0; index < nums.Count; index++)
            {
                if (nums[index] % 2 == 0)
                {
                    Console.WriteLine(nums[index]);
                }
            }
            Console.WriteLine("izhod2");

            for (int index = 0; index < nums.Count; index++)
            {
                if (nums[index] == start)
                {
                    length++;
                    Console.WriteLine(length);
                }
                //else
                //{
                //    start = nums[index];
                //    length = 0;
                //    Console.WriteLine(length);
                //}
                for (int i = 0; i < nums.Count; i++)
                {
                    if (length > bestLength)
                    {
                        Console.WriteLine($"{bestLength}/{startLength}");
                    }
                }
            }
            Console.WriteLine("Izhod 3");
            for (int index = 0; index < nums.Count; index++)
            {
                if (nums[index] < 0)
                    Console.WriteLine(nums[index]);
            }

            Console.WriteLine("Izhod 4");
            for (int index = 0; index < nums.Count; index++)
            {
                int min = nums[0];
                if (min > nums[index++])
                {
                    min = nums[0];
                }
                else
                {
                    min = nums[index];
                }
                Console.WriteLine(nums[index]);
            }

        }


    }
}

