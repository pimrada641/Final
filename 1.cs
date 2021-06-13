using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3,3];
            int c=0;
            for(int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    array[j, i] = int.Parse(Console.ReadLine());
                }
            }

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(array[j,i]);
                }
            }
            Console.WriteLine();

            int newnumber = int.Parse(Console.ReadLine());
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if(newnumber==array[j,i])
                    {
                        Console.WriteLine("The number is available");
                        c = 1;
                    }
                    if (c != 1)
                    {
                        if (array[j, i] == 0)
                        {
                            array[j, i] = newnumber;
                            for (j = 0; j < 3; j++)
                            {
                                Console.WriteLine();
                                for (i = 0; i < 3; i++)
                                {
                                    Console.Write(array[j, i]);
                                }
                            }
                        }
                    } 
                }
            }
        }
    }
}
