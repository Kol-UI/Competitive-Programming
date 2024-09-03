// Sum of Digits of String After Convert

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SumofDigitsofStringAfterConvert
{
    public class Solution
    {
        public int GetLucky(string s, int k)
        {
            string numericString = ConvertStringToAlphabetPosition(s);

            int result = SumOfDigits(numericString);

            for (int i = 1; i < k; i++)
            {
                result = SumOfDigits(result.ToString());
            }

            return result;
        }

        private static string ConvertStringToAlphabetPosition(string s)
        {
            string numericString = "";
            foreach (char letter in s)
            {
                numericString += GetAlphabetIndex(letter).ToString();
            }
            return numericString;
        }

        private static int GetAlphabetIndex(char inputChar)
        {
            char lowerChar = char.ToLower(inputChar);
            return lowerChar - 'a' + 1;
        }

        private static int SumOfDigits(string numericString)
        {
            int sum = 0;
            foreach (char digit in numericString)
            {
                sum += digit - '0';
            }
            return sum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.GetLucky("iiii", 1), 36),
                ResultTester.CheckResult<int>(solution.GetLucky("leetcode", 2), 6),
                ResultTester.CheckResult<int>(solution.GetLucky("zbax", 2), 8),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Digits of String After Convert");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}