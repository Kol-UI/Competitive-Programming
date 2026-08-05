// Remove Methods From Project
namespace CompetitiveProgramming.LeetCode.RemoveMethodsFromProject;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<int> RemainingMethods(int n, int k, int[][] invocations)
    {
        var g = new Dictionary<int, List<int>>();
        foreach(var arr in invocations)
        {
            var (a,b) = (arr[0], arr[1]);
            if (g.TryGetValue(a, out var list))
                list.Add(b);
            else 
                g.Add(a,[b]);
        }
        var h = new HashSet<int>(Enumerable.Range(0,n));
        var q = new Queue<int>();
        q.Enqueue(k); h.Remove(k);
        while (q.Count > 0)
        {
            var x = q.Dequeue();
            if (g.TryGetValue(x, out var list))
            {
                foreach(var v in list) 
                    if(h.Contains(v))
                    {
                        q.Enqueue(v);
                        h.Remove(v);
                    }
            }
        }
        foreach(var arr in invocations)
        {
            var (a,b) = (arr[0], arr[1]);
            if (h.Contains(a) && !h.Contains(b))
                return Enumerable.Range(0,n).ToArray();
        }
        return h.ToArray();
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Remove Methods From Project");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}