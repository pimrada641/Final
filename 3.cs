using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = new double[6];
            double sum=0;
            for (int i = 0; i < input.Length; i++)
            {
                string ans = Console.ReadLine();
                if (ans != "End")
                {
                    input[i] = double.Parse(ans);
                    sum += double.Parse(ans);
                }
                else if (ans == "End")
                {
                    while (ans != "0")
                    {
                        Array.Sort(input);
                        Console.Write("Mode : ");
                        string mode = Console.ReadLine();
                        if (mode == "FindMax")
                        {
                            Array.Reverse(input);
                            Console.WriteLine(input[0]);
                            ans = "0";
                        }
                        else if (mode == "FindMin")
                        {
                            //Array.Reverse(input);
                            Console.WriteLine(input[0]);
                            ans = "0";
                        }
                        else if (mode == "FindMean")
                        {
                            double mean = sum / (double)input.Length;
                            Console.WriteLine(mean);
                            ans = "0";
                        }
                        else
                        {
                            Console.WriteLine("Invalid mode");
                        }
                    }
                }
            }
        }
    }
}
