// Vasya the Hipster



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.VasyatheHipster
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            string[] inputs = Console.ReadLine()!.Split();
            int redSocks = int.Parse(inputs[0]);
            int blueSocks = int.Parse(inputs[1]);

            int daysWearingDifferentSocks = Math.Min(redSocks, blueSocks);
            int daysWearingSameSocks = (Math.Max(redSocks, blueSocks) - daysWearingDifferentSocks) / 2;

            Console.WriteLine($"{daysWearingDifferentSocks} {daysWearingSameSocks}");
        }
    }

    public class Test
    {
        public static int[] Solution(int redSocks, int blueSocks)
        {
            int daysWearingDifferentSocks = Math.Min(redSocks, blueSocks);
            int daysWearingSameSocks = (Math.Max(redSocks, blueSocks) - daysWearingDifferentSocks) / 2;

            return new int[] { daysWearingDifferentSocks, daysWearingSameSocks };
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Test.Solution(3, 5), new int[] { 3, 1 }),
                ResultTester.CheckResult<int[]>(Test.Solution(7, 4), new int[] { 4, 1 }),
                ResultTester.CheckResult<int[]>(Test.Solution(0, 0), new int[] { 0, 0 }),
                ResultTester.CheckResult<int[]>(Test.Solution(10, 10), new int[] { 10, 0 }),
                ResultTester.CheckResult<int[]>(Test.Solution(3, 5), new int[] { 3, 1 }),
            };
            return results;
        }
    }
}