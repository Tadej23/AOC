using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace AOC_9
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");

            // Input

            // String input = @"D:\\FIŠ\\AOC\\AOC_9\\AOC_9.txt";

            var input = File.ReadAllLines(@"D:\\FIŠ\\AOC\\AOC_9\\AOC_9.txt");

            int[,] heights = new int[input.Length, input[0].ToCharArray().Length];
            

            for (var y = 0; y < input.Length; y++)
            {
                for (var x = 0; x < input[y].ToCharArray().Length; x++)
                {
                    heights[y, x] = int.Parse(input[y].ToCharArray()[x].ToString());
                }
            }



            int height = heights.GetLength(0);
            int width = heights.GetLength(1);


            int lowSum = 0;
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    bool left = false;
                    bool right = false;
                    bool up = false;
                    bool down = false;

                    if (x - 1 < 0) { up = true; }
                    else if (heights[x, y] < heights[x - 1, y]) { up = true; }
                    else { continue; }

                    if (x + 1 >= height) { down = true; }
                    else if (heights[x, y] < heights[x + 1, y]) { down = true; }
                    else { continue; }

                    if (y + 1 >= width) { right = true; }
                    else if (heights[x, y] < heights[x, y + 1]) { right = true; }
                    else { continue; }

                    if (y - 1 < 0) { left = true; }
                    else if (heights[x, y] < heights[x, y - 1]){ left = true; }

                    if ((up && down && left && right)== true){ lowSum = lowSum + heights[x, y] + 1; }
                }


                
             }

            Console.WriteLine(lowSum.ToString());
        }
    
    }              
    
}
