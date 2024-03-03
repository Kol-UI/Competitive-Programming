// Occurrences After Bigram


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.OccurrencesAfterBigram
{
    public class Solution
    {
        public static string[] FindOcurrences(string text, string first, string second)
        {
            string[] splitedText = text.Split(" ");

            List<string> result = new List<string>();

            for (int i = 0; i < splitedText.Count() - 1; i++)
            {
                if (splitedText[i] == first && splitedText[i + 1] == second && i + 2 <= splitedText.Length - 1)
                {
                    result.Add(splitedText[i + 2]);
                }
            }

            return result.ToArray();    
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string[]>(Solution.FindOcurrences("alice is a good girl she is a good student", "a", "good"), new string[]{"girl","student"}),
                ResultTester.CheckResult<string[]>(Solution.FindOcurrences("we will we will rock you", "we", "will"), new string[]{"we","rock"}),
            };
            return results;
        }
    }
}