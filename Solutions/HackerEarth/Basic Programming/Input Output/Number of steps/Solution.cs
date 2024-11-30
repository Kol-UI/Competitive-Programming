// Number of steps
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.Numberofsteps
{
    public class Solution
    {
        /*
        static public void MainSolution()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long result = Solve(n, a, b);
            Console.WriteLine(result);
        }
        */

        public static long Solve(int n, int[] a, int[] b)
        {
            long count = 0;
            int minA = a.Min();

            for (int i = 0; i < n;)
            {
                if (a[i] >= b[i])
                {
                    while (a[i] > minA)
                    {
                        a[i] -= b[i];
                        count++;
                    }
                }

                if (a[i] < minA)
                {
                    minA = a[i];
                    i = 0;
                }
                else if (a[i] != minA)
                {
                    return -1;
                }
                else
                {
                    i++;
                }
            }

            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int n1 = 4;
            int[] a1 = { 10, 20, 30, 40 };
            int[] b1 = { 5, 2, 3, 4 };
            long expected1 = 32;

            int n2 = 3;
            int[] a2 = { 8, 5, 6 };
            int[] b2 = { 2, 2, 2 };
            long expected2 = -1;
            
            int n3 = 3;
            int[] a3 = { 10, 20, 30 };
            int[] b3 = { 3, 4, 5 };
            long expected3 = -1;
            
            int n4 = 2;
            int[] a4 = { 1, 1 };
            int[] b4 = { 2, 3 };
            long expected4 = 0;
            
            int n5 = 1;
            int[] a5 = { 100 };
            int[] b5 = { 1 };
            long expected5 = 0;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Solution.Solve(n1, a1, b1), expected1),
                ResultTester.CheckResult<long>(Solution.Solve(n2, a2, b2), expected2),
                ResultTester.CheckResult<long>(Solution.Solve(n3, a3, b3), expected3),
                ResultTester.CheckResult<long>(Solution.Solve(n4, a4, b4), expected4),
                ResultTester.CheckResult<long>(Solution.Solve(n5, a5, b5), expected5),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of steps");
            ResultTester.CheckCurrentSolution(ProblemOrigin.HackerEarth, ProblemCategory.MediumHE, Test.TestCases());
        }
    }
}