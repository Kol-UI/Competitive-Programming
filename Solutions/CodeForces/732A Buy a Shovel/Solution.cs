// Buy a Shovel



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.BuyaShovel
{
    public class Problem
    {
        public static int MinShovels(int k, int r)
        {
            int shovels = 1;
            while (true)
            {
                if ((k * shovels) % 10 == 0 || (k * shovels - r) % 10 == 0)
                {
                    break;
                }
                shovels++;
            }
            return shovels;
        }

        //public static void Main(string[] args)
        public static void Solution()
        {
            string[] inputs = Console.ReadLine()!.Split(' ');
            int k = int.Parse(inputs[0]);
            int r = int.Parse(inputs[1]);

            int minShovels = MinShovels(k, r);
            Console.WriteLine(minShovels);
        }
    }

    public class Test
    {
        public static int Solution(int k, int r)
        {
            int shovels = 1;
            while (true)
            {
                if ((k * shovels) % 10 == 0 || (k * shovels - r) % 10 == 0)
                {
                    break;
                }
                shovels++;
            }
            return shovels;
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Test.Solution(7, 2), 6),
                ResultTester.CheckResult<int>(Test.Solution(13, 17), 9),
                ResultTester.CheckResult<int>(Test.Solution(1, 100), 10),
                ResultTester.CheckResult<int>(Test.Solution(100, 2), 1),
                ResultTester.CheckResult<int>(Test.Solution(5, 2), 2),
                ResultTester.CheckResult<int>(Test.Solution(239, 10), 10),
            };
            return results;
        }
    }
}