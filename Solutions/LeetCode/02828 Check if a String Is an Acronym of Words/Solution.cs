// Check if a String Is an Acronym of Words



using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CheckifaStringIsanAcronymofWords
{
    public class Solution
    {
        public static bool IsAcronym(IList<string> words, string s)
        {
            if (words.Count == 0)
            {
                return false; 
            }

            StringBuilder acronymBuilder = new StringBuilder();

            foreach (string word in words)
            {
                acronymBuilder.Append(word[0]);
            }

            string acronym = acronymBuilder.ToString();

            return acronym.Equals(s);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsAcronym(new string[] {"alice","bob","charlie"}, "abc"), true),
                ResultTester.CheckResult<bool>(Solution.IsAcronym(new string[] {"an","apple"}, "a"), false),
                ResultTester.CheckResult<bool>(Solution.IsAcronym(new string[] {"never","gonna","give","up","on","you"}, "ngguoy"), true),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2828");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}