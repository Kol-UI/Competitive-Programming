// Kth Distinct String in an Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KthDistinctStringinanArray
{
    public class Solution
    {
        public string KthDistinct(string[] arr, int k)
        {
            var frequencyMap = new Dictionary<string, int>();
            var distinctStrings = new List<string>();

            foreach (string str in arr)
            {
                if (!frequencyMap.ContainsKey(str))
                {
                    frequencyMap[str] = 0;
                    distinctStrings.Add(str);
                }
                frequencyMap[str]++;
            }

            foreach (string str in distinctStrings)
            {
                if (frequencyMap[str] == 1)
                {
                    k--;
                    if (k == 0)
                    {
                        return str;
                    }
                }
            }

            return string.Empty;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Distinct String in an Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}