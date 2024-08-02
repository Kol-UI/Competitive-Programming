// Redistribute Characters to Make All Strings Equal



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.RedistributeCharacterstoMakeAllStringsEqual
{
    public sealed class Solution 
    {
        public static bool MakeEqual(string[] words) 
        {
            var n = words.Length;
            if(n == 1)
            {
                return true;
            }

            var a = new int[26];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < words[i].Length; j++)
                {
                    a[words[i][j] - 97]++;
                }
            }

            for(int i = 0; i < 26; i++)
            {
                if(a[i] % n != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.MakeEqual(new string[] {"abc","aabc","bc"}), true),
                ResultTester.CheckResult<bool>(Solution.MakeEqual(new string[] {"ab","a"}), false),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("1897");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}