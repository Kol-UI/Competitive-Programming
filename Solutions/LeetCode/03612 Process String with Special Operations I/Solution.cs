// Process String with Special Operations I
namespace CompetitiveProgramming.LeetCode.ProcessStringwithSpecialOperationsI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System.Text;

public class Solution
{
    public string ProcessStr(string s)
    {
        var sb = new StringBuilder(s.Length << 1);

        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            switch (c)
            {
                case '*':
                    if (sb.Length > 0)
                    {
                        sb.Length--;
                    }
                    break;
                case '#':
                    sb.Append(sb);
                    break;
                case '%':
                    {
                        var length = sb.Length >> 1;
                        for (int j = 0; j < length; j++)
                        {
                            var l = j+1;
                            var tmp = sb[^l];
                            sb[^l] = sb[j];
                            sb[j] = tmp;
                        }

                        break;
                    }

                default:
                    sb.Append(c);
                    break;
            }
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
            ResultTester.CheckResult<string>(solution.ProcessStr("a#b%*"), "ba"),
            ResultTester.CheckResult<string>(solution.ProcessStr("z*#"), ""),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Process String with Special Operations I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}