//namespace _18._03
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            List<int> list = new List<int>();
//            //list.RemoveAt(2);
//            //list.Insert(3, 2);
//            //Console.WriteLine(String.Join(" ", list));
//            //vhod
//            for (int i = 0; i < n; i++)
//            {
//                list.Add(int.Parse(Console.ReadLine()));

//            }
//            //izhod
//            for (int index = 0; index < list.Count; index++)
//            {
//                Console.WriteLine($"list[{index}] = {list[index]}");
//            }

//            //izhod 2 
//            Console.WriteLine("izhod 2");
//            for (int index = 0; index < list.Count - 1; index++)
//            {
//                if (list[index] < 0)
//                {
//                    list.RemoveAt(index);
//                    index--;
//                }
//                Console.WriteLine($"list[{index + 1}] = {list[index]}");
//            }
//            //izhod 3
//            Console.WriteLine("izhod 3");
//            for (int index = 0; index < n-1; index++)
//            {
//                if (list[index] != list[n-1])
//                {//da
//                    //list.RemoveAt(index);
//                    //index--;
//                    Console.WriteLine(list[index]);
//                }
//                //ne

//            }
//            //izhod4
//            Console.WriteLine("izhod 4");
//            list.RemoveAt(2);
//            for (int index = 0; index < n-1; index++)
//            {

//                Console.WriteLine(String.Join(" ", list));
//                //Console.WriteLine(list);
//            }
//            //izhod 5
//            Console.WriteLine("izhod 5");

//            for (int index = 0; index < n - 1; index++)
//            {
//                list.Insert(3, 2);
//                Console.WriteLine(String.Join(" ", list));
//                //Console.WriteLine(list);
//            }
//            //izhod 6
//            Console.WriteLine("izhod 6");
//            for (int i = 0;i<list.Count-1;i++)
//            {
//                for(int j = 0;j<list.Count-1;i++)
//                {
//                    if (list[j] < list[j+1])
//                    {
//                        int swapVar = list[j];
//                        list[j] = list[j+1];
//                        list[j+1]= swapVar;
//                    }
//                    Console.WriteLine(String.Join(" ",list));
//                }
//            }


//        }
//    }
//}
int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
// vhod
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Vivedi chislo:");
    list.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine("Izhod 1");
// izhod 1
for (int index = 0; index < list.Count; index++)
{
    Console.WriteLine($"list[{index}] = {list[index]}");
}
// izhod 2 
Console.WriteLine("izhod 2");
for (int index = 0; index < list.Count; index++)
{
    if (list[index] < 0)
    {
        list.RemoveAt(index);
        index--;
    }
}
for (int index = 0; index < list.Count; index++)
{
    Console.WriteLine($"list[{index}] = {list[index]}");
}
//izhod 3
Console.WriteLine("Izhod 3");
for (int index = 0; index < list.Count; index++)
{
    if (list[index] != list[list.Count - 1])
    {
        Console.WriteLine(list[index]);
    }
}
// izhod 4
Console.WriteLine("Izhod 4");
list.RemoveAt(2);
for (int index = 0; index < list.Count; index++)
{
    Console.WriteLine(list[index]);
}
// izhod 5
Console.WriteLine("Izhod 5");
for (int index = 0; index < list.Count; index++)
{

    list.RemoveAt(3);
    list.Add(2);
    Console.WriteLine(String.Join(" ", list));
}
// izhod 6
Console.WriteLine("Izhod 6");
for (int i = 0; i < list.Count - 1; i++)
{
    for (int j = 0; j < list.Count - 1; j++)
    {
        if (list[j] < list[j + 1])
        {
            int swapVar = list[j];
            list[j] = list[j + 1];
            list[j + 1] = swapVar;
        }
    }
    Console.WriteLine(String.Join(" ", list));
}






