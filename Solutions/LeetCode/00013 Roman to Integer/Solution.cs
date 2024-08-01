// Roman to Integer
using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RomantoInteger
{
    public class Solution
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && map[s[i]] < map[s[i+1]])
                {
                    result -= map[s[i]];
                }
                else
                {
                    result += map[s[i]];
                }
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestRomantoInteger()
        {
            // Case 1
            int Case1_13 = LeetCode.RomantoInteger.Solution.RomanToInt("III");

            // Case 2
            int Case2_13 = LeetCode.RomantoInteger.Solution.RomanToInt("LVIII");            

            // Case 3
            int Case3_13 = LeetCode.RomantoInteger.Solution.RomanToInt("MCMXCIV");
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_13, 3),
                ResultTester.CheckResult<int>(Case2_13, 58),
                ResultTester.CheckResult<int>(Case3_13, 1994)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Roman to Integer");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestRomantoInteger());
        }
    }
}