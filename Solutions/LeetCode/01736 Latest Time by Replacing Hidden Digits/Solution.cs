// Latest Time by Replacing Hidden Digits
namespace CompetitiveProgramming.LeetCode.LatestTimebyReplacingHiddenDigits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string MaximumTime(string time)
    {
        char t0;
        char t1;
        char t2;
        char t3;

        if (time[0] == '?')
        {
            if (time[1] == '?')
            {
                t0 = '2';
                t1 = '3';
            }
            else
            {
                t0 = time[1] > '3' ? '1' : '2';
                t1 = time[1];
            }
        }
        else
        {
            t0 = time[0];
            t1 = (time[1] == '?' ? (time[0] == '2' ? '3' : '9') : time[1]);
        }

        t2 = time[3] == '?' ? '5' : time[3];
        t3 = time[4] == '?' ? '9' : time[4];

        return $"{t0}{t1}:{t2}{t3}";
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        string time1 = "2?:?0";
        string time2 = "0?:3?";
        string time3 = "1?:22";
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(solution.MaximumTime(time1), "23:50"),
            ResultTester.CheckResult<string>(solution.MaximumTime(time2), "09:39"),
            ResultTester.CheckResult<string>(solution.MaximumTime(time3), "19:22"),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Latest Time by Replacing Hidden Digits");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}