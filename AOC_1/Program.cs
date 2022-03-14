using System;
using System.IO;

namespace AOC_1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hello World!");
        //How many measurements are larger than the previous measurement?
        //Input
        string[] lines = File.ReadAllLines("D:\\FIŠ\\AOC\\AOC_1\\AOC_1.txt");
        int[] linesInt = Array.ConvertAll(lines, int.Parse);

        int numOfincreased = 0;

        for (int i=1; i<linesInt.Length; i++)
            {
                if (linesInt[i] > linesInt[i - 1]){ numOfincreased++;  }  
            }
            Console.WriteLine("Rezultat:" + numOfincreased.ToString()); 


        }
    }
}
