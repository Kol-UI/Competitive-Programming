// Number of Students Doing Homework at a Given Time
namespace CompetitiveProgramming.LeetCode.NumberofStudentsDoingHomeworkataGivenTime;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
    {
        int count = 0;
        for(int i = 0;i < startTime.Length; i++)
        {
            if(queryTime >= startTime[i] && queryTime <= endTime[i])
            {
                count++;
            }

        }
        return count;
    }
}


public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.BusyStudent(new int[]{1,2,3}, new int[]{3,2,7}, 4), 1),
            ResultTester.CheckResult<int>(solution.BusyStudent(new int[]{4}, new int[]{4}, 4), 1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Students Doing Homework at a Given Time");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}