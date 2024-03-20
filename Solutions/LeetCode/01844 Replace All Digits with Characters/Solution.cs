// Replace All Digits with Characters


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ReplaceAllDigitswithCharacters
{
    public class Solution
    {
        public static string ReplaceDigits(string s)
        {
            StringBuilder stringBuilder = new StringBuilder(s);

            var current = stringBuilder[0];

            for(int i = 1;i < stringBuilder.Length; i++)
            {
                if(char.IsDigit(stringBuilder[i]))
                {
                    var replaced = (char)(current + (s[i] - '0'));
                    stringBuilder[i] = replaced;
                }
                else
                {
                    current = stringBuilder[i];
                }
            }
            return stringBuilder.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.ReplaceDigits("a1c1e1"), "abcdef"),
                ResultTester.CheckResult<string>(Solution.ReplaceDigits("a1b2c3d4e"), "abbdcfdhe"),
            };
            return results;
        }
    }
}