// Reformat The String


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ReformatTheString
{
    public class Solution
    {
        public static string Reformat(string s)
        {
            char[] cArr = s.ToCharArray();
            Array.Sort(cArr);
            int n = s.Length;

            if(n == 1)
                return s;

            if(n%2 == 0)
            {
                int alphaIndex = n/2;
                int numIndex = alphaIndex - 1;
                if(cArr[alphaIndex] < 97 || cArr[numIndex] >= 97)
                    return string.Empty;
            }
            else
            {
                int index = n/2;
                if(cArr[index] >= 97)
                {
                    if(cArr[index-1] >= 97)
                        return string.Empty;
                }
                else
                {
                    if(cArr[index+1] < 97)
                        return string.Empty;
                }
            }

            int i = 0, j = n-1;
            StringBuilder builder = new StringBuilder();
            while(i < j)
            {
                builder.Append(cArr[i++]);
                builder.Append(cArr[j--]);
            }

            string result = builder.ToString();

            if(i == j)
            {
                if(cArr[i] >= 97)
                {
                    if(result[result.Length-1] < 97)
                        result += cArr[i];
                    else
                        result = cArr[i] + result;
                }
                else
                {
                    if(result[result.Length-1] >= 97)
                        result += cArr[i];
                    else
                        result = cArr[i] + result;
                }
            }
                
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.Reformat("a0b1c2"), "0c1b2a"),
                ResultTester.CheckResult<string>(Solution.Reformat("leetcode"), ""),
                ResultTester.CheckResult<string>(Solution.Reformat("1229857369"), ""),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1417");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}