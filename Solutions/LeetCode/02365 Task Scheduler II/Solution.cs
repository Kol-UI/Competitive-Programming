// Task Scheduler II
namespace CompetitiveProgramming.LeetCode.TaskSchedulerII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long TaskSchedulerII(int[] tasks, int space)
    {
        Dictionary<int, long> map = new ();
        long days = 0;

        for(int i = 0; i < tasks.Length; i ++)
        {
            days ++;

            if(map.ContainsKey(tasks[i]) == false)
            {
                map.Add(tasks[i], days);
            }
            else
            {
                if(map[tasks[i]] + space >= days)
                {                                
                    days = map[tasks[i]] + space + 1;                    
                }   

                map[tasks[i]] = days;
            }
        }

        return days;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Task Scheduler II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}