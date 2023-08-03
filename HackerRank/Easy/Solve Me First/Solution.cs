// Solve Me First


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.SolveMeFirst
{
    public class Solution 
    {
        public static int solveMeFirst(int a, int b) 
        { 
            return a + b;
        }

        /*
        static void Main(String[] args)
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1,val2);
            Console.WriteLine(sum);
        }
        */
    }

    public class Test
    {
        public static bool[] TestSolveMeFirst()
        {
            int result = Solution.solveMeFirst(2, 3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result, 5)
            };
            return results;
        }
    }
}
