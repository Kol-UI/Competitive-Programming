// High-Access Employees
namespace CompetitiveProgramming.LeetCode.HighAccessEmployees;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<string> FindHighAccessEmployees(IList<IList<string>> access_times)
    {
        var dic = CreateDictionary(access_times);
        var result = new List<string>();
        foreach (var item in dic)
        {
            if (IsHighAccess(item.Value)) result.Add(item.Key);
        }
        return result;
    }
    private bool IsHighAccess(List<int[]> times)
    {
        for (int i = 0; i < times.Count - 2; i++)
        {
            if (IsLessThenHour(times[i + 2], times[i])) return true;
        }
        return false;
    }
    private bool IsLessThenHour(int[] time1, int[] time0)
    {
        if (time0[0] + 1 == time1[0])
        {
            return time0[1] > time1[1];
        }
        if (time0[0] == time1[0])
        {
            return true;
        }
        return false;
    }
    private Dictionary<string, List<int[]>> CreateDictionary(IList<IList<string>> access_times)
    {
        var aux = new Dictionary<string, List<int[]>>();
        for (int i = 0; i < access_times.Count; i++)
        {
            if (!aux.ContainsKey(access_times[i][0])) aux.Add(access_times[i][0], new List<int[]>());
            aux[access_times[i][0]].Add(ParesulteTime(access_times[i][1]));
        }
        var result = new Dictionary<string, List<int[]>>();
        foreach (var item in aux)
        {
            var value = item.Value.OrderBy(p => p[0]).ThenBy(p => p[1]).ToList();
            result.Add(item.Key, value);
        }
        return result;
    }
    private int[] ParesulteTime(string access_time)
    {
        return new[] { Convert.ToInt32(access_time.Substring(0, 2)), Convert.ToInt32(access_time.Substring(2, 2)) };
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("High-Access Employees");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}