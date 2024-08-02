// Delete Characters to Make Fancy String

using System.Text;
using System.Text.RegularExpressions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DeleteCharacterstoMakeFancyString
{
    public class Solution 
    {
        public static string MakeFancyString(string s)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(s[0]);

            int count = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (sb[sb.Length - 1] == s[i])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count < 3)
                {
                    sb.Append(s[i]);        
                }
            }

            return sb.ToString();      
        }

        public static string MakeFancyStringRegex(string s)
        {
            var pattern = @"(\w)\1*";
            var regExp = new Regex(pattern);
            var results = regExp.Matches(s).Select(x => x.Value).ToList();

            for (int i = 0; i < results.Count; i++)
            {
                if (results[i].Length > 2)
                {
                    results[i] = results[i].Substring(0, 2);
                }
            }

            return String.Join("", results);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.MakeFancyString("leeetcode"), "leetcode"),
                ResultTester.CheckResult<string>(Solution.MakeFancyString("aaabaaaa"), "aabaa"),
                ResultTester.CheckResult<string>(Solution.MakeFancyString("aab"), "aab"),
                ResultTester.CheckResult<string>(Solution.MakeFancyStringRegex("leeetcode"), "leetcode"),
                ResultTester.CheckResult<string>(Solution.MakeFancyStringRegex("aaabaaaa"), "aabaa"),
                ResultTester.CheckResult<string>(Solution.MakeFancyStringRegex("aab"), "aab"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("1957");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}