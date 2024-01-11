// Apple And Orange


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.AppleAndOrange
{
    public class Solution
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleCount = CountFruitsOnHouse(s, t, a, apples);
            int orangeCount = CountFruitsOnHouse(s, t, b, oranges);

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }

        public static int CountFruitsOnHouse(int s, int t, int treePosition, List<int> fruits)
        {
            int count = 0;
            foreach (int fruitDistance in fruits)
            {
                int fruitPosition = treePosition + fruitDistance;
                if (fruitPosition >= s && fruitPosition <= t)
                {
                    count++;
                }
            }
            return count;
        }
    }
}