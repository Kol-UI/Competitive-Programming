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

        //public static void Main()
        public static void Solution2()
        {
            long t = long.Parse(Console.ReadLine()!);

            while (t-- > 0)
            {
                string[] inputs = Console.ReadLine()!.Split();
                long n = long.Parse(inputs[0]);
                long s = long.Parse(inputs[1]);

                long result = (s < n) ? s : (2 * n - s);
                Console.WriteLine(result);
            }
        }
    }
}