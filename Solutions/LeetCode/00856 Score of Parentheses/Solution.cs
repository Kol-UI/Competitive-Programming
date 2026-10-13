// Score of Parentheses
namespace CompetitiveProgramming.LeetCode.ScoreofParentheses;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ScoreOfParentheses(string s)
    {
        int i = 0;
        return dfs(true);

        int dfs(bool isRoot)
        {
            int score = 0;

            while (i < s.Length)
            {
                if (s[i] is '(')
                {
                    i++;
                    if (isRoot)
                    {
                        score += dfs(false);
                    }
                    else
                    {
                        score += 2 * dfs(false);
                    }
                }
                else
                {
                    i++;
                    break;
                }
            }

            return score == 0 ? 1 : score;
        }
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.ScoreOfParentheses("()"), 1),
            ResultTester.CheckResult<int>(solution.ScoreOfParentheses("(())"), 2),
            ResultTester.CheckResult<int>(solution.ScoreOfParentheses("()()"), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Score of Parentheses");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}