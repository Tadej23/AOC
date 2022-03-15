using System;
using System.IO;




namespace AOC_9
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");

            // Input
            
            String input = File.ReadAllText(@"D:\\FIŠ\\AOC\\AOC_9\\AOC_9.txt");

            int i = 0; 
            int j = 0;
            char[,] heights = null;
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().ToCharArray())
                {
                    heights[i, j] = col;
                    j++;
                }
                i++;
            }


            int height = heights.GetLength(0);
            int width = heights.GetLength(1);


            int lowSum = 0;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    bool left = false;
                    bool right = false;
                    bool up = false;
                    bool down = false;

                    if (x - 1 < 0) { left = true; }
                    else if (heights[x, y] < heights[x - 1, y]) { left = true; }
                    else { continue; }

                    if (x + 1 >= width) { right = true; }
                    else if (heights[x, y] < heights[x + 1, y]) { right = true; }
                    else { continue; }

                    if (y + 1 >= height) { down = true; }
                    else if (heights[x, y] < heights[x, y + 1]) { down = true; }
                    else { continue; }

                    if (y - 1 < 0) { up = true; }
                    else if (heights[x, y] < heights[x, y - 1]){ up = true; }

                    if ((up && down && left && right)== true){ lowSum = lowSum + heights[x, y] + 1; }
                }


                
             }

            Console.WriteLine(lowSum.ToString());
        }
    
    }              
    
}
