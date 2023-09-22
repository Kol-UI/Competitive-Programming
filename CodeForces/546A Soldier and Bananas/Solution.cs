// Soldier and Bananas


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.SoldierandBananas
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string[] input = Console.ReadLine()!.Split();
            int k = int.Parse(input[0]);
            long n = long.Parse(input[1]);
            int w = int.Parse(input[2]);

            long totalCost = 0;
            for (int i = 1; i <= w; i++)
            {
                totalCost += i * k;
            }

            long borrowAmount = Math.Max(0, totalCost - n);

            Console.WriteLine(borrowAmount);
        }
    }
}