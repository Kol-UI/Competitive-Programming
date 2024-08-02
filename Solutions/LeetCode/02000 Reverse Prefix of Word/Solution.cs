// Reverse Prefix of Word


using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ReversePrefixofWord
{
    public class Solution
    {
        public static string ReversePrefix(string word, char ch)
        {
            StringBuilder stringBuilder = new();
            if(word.Contains(ch))
            {
                int index = word.IndexOf(ch);
                for(int i = index; i >= 0; i--)
                {
                    stringBuilder.Append(word[i]);
                }
                
                stringBuilder.Append(word.Substring(index+1));
            }
            else
            {
                return word;
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
                ResultTester.CheckResult<string>(Solution.ReversePrefix("abcdefd", 'd'), "dcbaefd"),
                ResultTester.CheckResult<string>(Solution.ReversePrefix("xyxzxe", 'z'), "zxyxxe"),
                ResultTester.CheckResult<string>(Solution.ReversePrefix("abcd", 'z'), "abcd"),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2000");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}