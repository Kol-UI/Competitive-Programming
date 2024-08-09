// Capitalize the Title

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CapitalizetheTitle
{
    public class Solution 
    {
        public static string CapitalizeTitle(string title) 
        {
            string[] words = title.Split();

            for (int i = 0; i < words.Length; i++) 
            {
                words[i] = words[i].ToLower();

                if (words[i].Length > 2) 
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }

            return string.Join(" ", words).Trim();   
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.CapitalizeTitle("capiTalIze tHe titLe"), "Capitalize The Title"),
                ResultTester.CheckResult<string>(Solution.CapitalizeTitle("First leTTeR of EACH Word"), "First Letter of Each Word"),
                ResultTester.CheckResult<string>(Solution.CapitalizeTitle("i lOve leetcode"), "i Love Leetcode")
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Capitalize the Title");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}