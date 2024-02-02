// Sequential Digits


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SequentialDigits
{
    public class Solution
    {
        public static IList<int> SequentialDigits(int low, int high)
        {
            List<int> result = new List<int>();
            string digits = "123456789";
            int maxDigits = high.ToString().Length;

            for (int length = 2; length <= maxDigits; length++)
            {
                for (int i = 0; i <= digits.Length - length; i++)
                {
                    string substring = digits.Substring(i, length);
                    int num = int.Parse(substring);

                    if (num >= low && num <= high)
                    {
                        result.Add(num);
                    }
                }
            }

            result.Sort();
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.SequentialDigits(100, 300), new List<int> { 123, 234 }),
                ResultTester.CheckResult<IList<int>>(Solution.SequentialDigits(1000, 13000), new List<int> { 1234, 2345, 3456, 4567, 5678, 6789, 12345 }),
            };

            return results;
        }
    }
}