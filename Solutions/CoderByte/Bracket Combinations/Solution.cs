// Bracket Combinations

// Have the function BracketCombinations(num) read num which will be an integer greater than or equal to zero, and return the number of valid combinations that can be formed with num pairs of parentheses. For example, if the input is 3, then the possible combinations of 3 pairs of parenthesis, namely: ()()(), are ()()(), ()(()), (())(), ((())), and (()()). There are 5 total combinations when the input is 3, so your program should return 5.

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CoderByte.BracketCombinations
{
    class Solution
    {
        public static int BracketCombinations(int num) 
        {
            if (num <= 1) 
            {
                return 1;
            }

            int[] dp = new int[num + 1];
            dp[0] = 1;

            for (int i = 1; i <= num; i++) 
            {
                for (int j = 0; j < i; j++) 
                {
                    dp[i] += dp[j] * dp[i - j - 1];
                }
            }

            return dp[num];
        }

        /*
        static void Main()
        { 
            // keep this function call here
            Console.WriteLine(BracketCombinations(Console.ReadLine()));
        }
        */
    }


    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.BracketCombinations(8), 1430),
                ResultTester.CheckResult<int>(Solution.BracketCombinations(2), 2),
                ResultTester.CheckResult<int>(Solution.BracketCombinations(3), 5),
                ResultTester.CheckResult<int>(Solution.BracketCombinations(1), 1),
                ResultTester.CheckResult<int>(Solution.BracketCombinations(4), 14),
                ResultTester.CheckResult<int>(Solution.BracketCombinations(6), 132),
                ResultTester.CheckResult<int>(Solution.BracketCombinations(7), 429),
                ResultTester.CheckResult<int>(Solution.BracketCombinations(10), 16796),
                ResultTester.CheckResult<int>(Solution.BracketCombinations(9), 4862),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bracket Combinations");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CoderByte, ProblemCategory.HardCB, Test.TestCases());
        }
    }
}