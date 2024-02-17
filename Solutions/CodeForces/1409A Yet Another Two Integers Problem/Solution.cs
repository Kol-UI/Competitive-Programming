// Yet Another Two Integers Problem


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.YetAnotherTwoIntegersProblem
{
    class Program
    {
        static void Solution()
        {
            int t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                string[] inputs = Console.ReadLine()!.Split();
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);

                int absoluteDifference = Math.Abs(a - b);

                int minimumMoves = (absoluteDifference + 9) / 10;

                Console.WriteLine(minimumMoves);
            }
        }
    }
}