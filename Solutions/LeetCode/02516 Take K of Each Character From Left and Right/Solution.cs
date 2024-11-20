// Take K of Each Character From Left and Right
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TakeKofEachCharacterFromLeftandRight
{
    public class Solution
    {
        public int TakeCharacters(string s, int k)
        {
            int stringLength = s.Length;
            int check = 3;
            if (stringLength < check * k)
                return -1;

            int startIndex = 0;
            int endIndex = stringLength - 1;
            int countA = 0, countB = 0, countC = 0;

            for (startIndex = 0; startIndex <= endIndex; startIndex++)
            {
                switch (s[startIndex])
                {
                    case 'a': countA++; break;
                    case 'b': countB++; break;
                    case 'c': countC++; break;
                }
                if (countA >= k && countB >= k && countC >= k) break;
            }

            if (countA < k || countB < k || countC < k)
                return -1;

            int minLength = startIndex + 1;

            while (startIndex >= 0)
            {
                switch (s[startIndex])
                {
                    case 'a': countA--; break;
                    case 'b': countB--; break;
                    case 'c': countC--; break;
                }
                startIndex--;

                while (endIndex >= startIndex && (countA < k || countB < k || countC < k))
                {
                    switch (s[endIndex])
                    {
                        case 'a': countA++; break;
                        case 'b': countB++; break;
                        case 'c': countC++; break;
                    }
                    endIndex--;
                }

                minLength = Math.Min(minLength, startIndex + stringLength - endIndex);
            }

            return minLength;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.TakeCharacters("aabaaaacaabc", 2), 8),
                ResultTester.CheckResult<int>(solution.TakeCharacters("a", 1), -1)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Take K of Each Character From Left and Right");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}