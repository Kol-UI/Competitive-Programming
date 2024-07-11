// Reverse Substrings Between Each Pair of Parentheses
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ReverseSubstringsBetweenEachPairofParentheses
{
    public class Solution
    {
        public static string ReverseParentheses(string s)
        {
            Stack<int> Stack = new();
            char[] result = s.ToCharArray();
            
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (c == '(') Stack.Push(i);

                else if (c == ')')
                {
                    for(int l = Stack.Pop()+1, r = i - 1; l < r;l++,r--)
                    {
                        var tempo = result[l];
                        result[l] = result[r];
                        result[r] = tempo;
                    }
                }
            }

            return new string(result.Where(c => c != ')' && c != '(').ToArray());
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.ReverseParentheses("(abcd)"), "dcba"),
                ResultTester.CheckResult<string>(Solution.ReverseParentheses("(u(love)i)"), "iloveu"),
                ResultTester.CheckResult<string>(Solution.ReverseParentheses("(ed(et(oc))el)"), "leetcode"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Title");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}