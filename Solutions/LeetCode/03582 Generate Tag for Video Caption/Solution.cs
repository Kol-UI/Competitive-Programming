// Generate Tag for Video Caption
namespace CompetitiveProgramming.LeetCode.GenerateTagforVideoCaption;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string GenerateTag(string c)
    {
        var sb = new StringBuilder();
        sb.Append('#');
        var firstWord = true;
        var inWord = false;
        for (int i = 0; i < c.Length; i++)
        {
            var l = c[i];
            if (l == ' ')
            {
                inWord = false;
                continue;
            }

            if (inWord)
            {
                sb.Append(char.ToLower(l));
            }
            else
            {
                if (firstWord)
                {
                    firstWord = false;
                    sb.Append(char.ToLower(l));
                }
                else
                {
                    sb.Append(char.ToUpper(l));
                }
            }
            inWord = true;
            if (sb.Length == 100)
                break;
        }

        return sb.ToString();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.GenerateTag("Leetcode daily streak achieved"), "#leetcodeDailyStreakAchieved"),
            ResultTester.CheckResult<string>(solution.GenerateTag("can I Go There"), "#canIGoThere"),
            ResultTester.CheckResult<string>(solution.GenerateTag("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh"), "#hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Generate Tag for Video Caption");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}