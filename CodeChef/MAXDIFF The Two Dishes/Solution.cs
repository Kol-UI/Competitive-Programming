// The Two Dishes



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.TheTwoDishes
{
    public class Test
    {
        //public static void Main()
        public static void Solution()
        {
            int T = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < T; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                int N = int.Parse(input[0]);
                int S = int.Parse(input[1]);

                int maxDifference = Math.Min(N, S - N);
                Console.WriteLine(maxDifference);
            }
        }
    }
}