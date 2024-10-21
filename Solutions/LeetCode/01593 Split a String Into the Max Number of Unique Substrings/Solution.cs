// Split a String Into the Max Number of Unique Substrings

using System.Numerics;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SplitaStringIntotheMaxNumberofUniqueSubstrings
{
    public class Solution 
    {
        public int MaxUniqueSplit(string s)
        {
            int result = 0;

            HashSet<string> hs = new();

            for (int mask = 0; mask < (1 << s.Length); mask++)
            {
                int count = BitOperations.PopCount((uint)mask);

                if (count <= result)
                    continue;

                hs.Clear();

                bool ok = true;
                int start = 0;

                for (int i = 0; i < s.Length && ok; ++i) 
                    if ((mask & (1 << i)) != 0)
                    {
                        ok = hs.Add(s.Substring(start, i - start + 1));
                        start = i + 1;
                    }

                if (ok && hs.Add(s.Substring(start)))
                    result = count;
            }   

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            var solution = new Solution();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MaxUniqueSplit("ababccc"), 5),
                ResultTester.CheckResult<int>(solution.MaxUniqueSplit("aba"), 2),
                ResultTester.CheckResult<int>(solution.MaxUniqueSplit("aa"), 1)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Split a String Into the Max Number of Unique Substrings");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}