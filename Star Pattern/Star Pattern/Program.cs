using System;

namespace Star_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patternHeight = 4;

            for(int i = 1; i <= patternHeight; i++)
            {
                //print the spaces of stars
                for(int j = 1; j <= patternHeight - i; j++)
                {
                    Console.Write(" ");
                }
                //this loop will print star after the space
                for(int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                //below console.writeline is used to move to the next line and print other row stars
                Console.WriteLine();
            }
        }
    }
}
