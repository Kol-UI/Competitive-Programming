// Reverse Only Letters

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
using System.Text;

namespace CompetitiveProgramming.LeetCode.ReverseOnlyLetters
{
    public class Solution
    {
        public string ReverseOnlyLetters(string s) 
        {
            StringBuilder b = new(s.Length);

            for (int i = s.Length - 1; i >= 0; i--)
            {
                while (b.Length < s.Length && !IsLetter(s[b.Length])) b.Append(s[b.Length]);

                if (IsLetter(s[i])) b.Append(s[i]);

                while (b.Length < s.Length && !IsLetter(s[b.Length])) b.Append(s[b.Length]);
            }

            return b.ToString();
        }

        private static bool IsLetter(in char ch) => (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z');
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(solution.ReverseOnlyLetters("ab-cd"), "dc-ba"),
                ResultTester.CheckResult<string>(solution.ReverseOnlyLetters("a-bC-dEf-ghIj"), "j-Ih-gfE-dCba"),
                ResultTester.CheckResult<string>(solution.ReverseOnlyLetters("Test1ng-Leet=code-Q!"), "Qedo1ct-eeLg=ntse-T!"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Only Letters");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}