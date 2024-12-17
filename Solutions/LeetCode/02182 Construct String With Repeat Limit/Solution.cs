// Construct String With Repeat Limit
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
using System.Text;
namespace CompetitiveProgramming.LeetCode.ConstructStringWithRepeatLimit
{
    public class Solution
    {
        public string RepeatLimitedString(string s, int repeatLimit)
        {
            int[] freq = new int[26];
            foreach (char c in s)
            {
                freq[c - 'a']++;
            }

            StringBuilder result = new StringBuilder();
            int prevChar = -1;

            while (true)
            {
                int currChar = FindLargestChar(freq, prevChar);
                if (currChar == -1) break;

                int count = Math.Min(freq[currChar], repeatLimit);
                result.Append((char)(currChar + 'a'), count);
                freq[currChar] -= count;

                if (freq[currChar] > 0)
                {
                    int nextChar = FindLargestChar(freq, currChar);
                    if (nextChar == -1) break;

                    result.Append((char)(nextChar + 'a'));
                    freq[nextChar]--;
                }
            }

            return result.ToString();
        }

        private int FindLargestChar(int[] freq, int excludeChar)
        {
            for (int i = 25; i >= 0; i--)
            {
                if (freq[i] > 0 && i != excludeChar)
                {
                    return i;
                }
            }
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(solution.RepeatLimitedString("cczazcc", 3), "zzcccac"),
                ResultTester.CheckResult<string>(solution.RepeatLimitedString("aababab", 2), "bbabaa"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Construct String With Repeat Limit");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}