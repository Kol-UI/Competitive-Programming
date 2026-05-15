// Minimum Number of Operations to Convert Time
namespace CompetitiveProgramming.LeetCode.MinimumNumberofOperationstoConvertTime;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public int ConvertTime(string current, string correct) {
        string[] a=current.Split(":");
        string[] b=correct.Split(":");
        int c=Convert.ToInt32(a[0])*60+Convert.ToInt32(a[1]);
        int d=Convert.ToInt32(b[0])*60+Convert.ToInt32(b[1]);
        int diff=d-c;
        Console.WriteLine(c+"*"+d);
        int count=0;
        while(diff>0)
        {
            if(diff>=60)
            {
                count++;
                diff=diff-60;
            }
            else if(diff>=15)
            {
                count++;
                diff=diff-15;
            }
            else if (diff>=5)
            {
                count++;
                diff=diff-5;
            }
            else
            {
                count++;
                diff=diff-1;
            }
            Console.WriteLine(diff+"*"+count);
        }
        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.ConvertTime("02:30", "04:35"), 3),
            ResultTester.CheckResult<int>(solution.ConvertTime("11:00", "11:01"), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Operations to Convert Time");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}