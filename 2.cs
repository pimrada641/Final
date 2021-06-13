using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int amount = int.Parse(Console.ReadLine());
            int[] array = new int[amount];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.Write("Childe's Sort ");
            foreach (int item in array)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            Console.Write("Timmie's Sort ");
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Venti's Sort ");
            Array.Sort<int>(array, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
            Array.Reverse(array);
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Diluc's Sort ");
            Array.Sort<int>(array, delegate (int a, int b) { return b - a; });
            Array.Reverse(array);
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
