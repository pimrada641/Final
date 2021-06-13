using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = new string[5];
            for(int i=0;i<5;i++)
            {
                file[i] = ""; 
            }
            int input = 0;
            while (input != 3)
            {
                Console.WriteLine("Please input a number from 0 - 3 to choose the following menu.");
                Console.WriteLine("[0] Show all recent files\n[1] Open new file\n[2] Open recent file\n[3] Exit");
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    Console.WriteLine("[0] {0}\n[1] {1}\n[2] {2}\n[3] {3}\n[4] {4}",file[0], file[1], file[2], file[3], file[4]);
                }
                else if (input == 1)
                {
                    string filename = Console.ReadLine(); 
                    for (int i = 4; i>=1; i--)
                    {
                        file[i] = file[i-1];
                    }
                    file[0] = filename;
                }
                else if (input == 2)
                {
                    int filenum = int.Parse(Console.ReadLine());
                    if (file[filenum] == "")
                    {
                        Console.WriteLine("No recent file.");
                    }
                    else
                    for (int i = 4; i >= 1; i--)
                        {
                            file[i] = file[i - 1];
                        }
                    file[0] = file[filenum+1];
                }
                else if (input == 3)
                {
                }
                else Console.WriteLine("Invalid menu number.");
            }
            
        }
    }
}
