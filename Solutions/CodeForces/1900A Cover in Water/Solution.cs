// Cover in Water


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.CoverinWater
{

    class Program
    {
        //static void Main()
        static void Solution()
        {
            int t = int.Parse(Console.ReadLine()!);
            while (t-- > 0)
            {
                SolveCase();
            }
        }

        static void SolveCase()
        {
            int n = int.Parse(Console.ReadLine()!);
            string s = Console.ReadLine()!;
            int waterCount = 0, consecutiveWaterCount = 0, maxConsecutiveWaterCount = 0;

            foreach (char c in s)
            {
                if (c == '.')
                {
                    waterCount++;
                    consecutiveWaterCount++;
                }
                if (c == '#')
                {
                    maxConsecutiveWaterCount = Math.Max(maxConsecutiveWaterCount, consecutiveWaterCount);
                    consecutiveWaterCount = 0;
                }
            }

            maxConsecutiveWaterCount = Math.Max(consecutiveWaterCount, maxConsecutiveWaterCount);

            if (waterCount == 0)
                Console.WriteLine(0);
            else if (maxConsecutiveWaterCount > 2)
                Console.WriteLine(2);
            else
                Console.WriteLine(waterCount);
        }
    }
}