// GCD Sort of an Array
namespace CompetitiveProgramming.LeetCode.GCDSortofanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool GcdSort(int[] nums)
    {
        int max = nums.Max();
        UnionFind uf = new UnionFind(max + 1);

        foreach (int num in nums)
        {
            foreach (int factor in GetPrimeFactors(num))
            {
                uf.Union(num, factor);
            }
        }

        int[] sorted = nums.OrderBy(x => x).ToArray();
        for (int i = 0; i < nums.Length; i++)
        {
            if (uf.Find(nums[i]) != uf.Find(sorted[i]))
                return false;
        }

        return true;
    }

    private List<int> GetPrimeFactors(int num)
    {
        List<int> factors = new List<int>();
        int d = 2;
        while (d * d <= num)
        {
            if (num % d == 0)
            {
                factors.Add(d);
                while (num % d == 0) num /= d;
            }
            d++;
        }
        if (num > 1) factors.Add(num);
        return factors;
    }

    class UnionFind
    {
        private int[] parent;

        public UnionFind(int n)
        {
            parent = Enumerable.Range(0, n).ToArray();
        }

        public int Find(int x)
        {
            if (parent[x] != x)
                parent[x] = Find(parent[x]);
            return parent[x];
        }

        public void Union(int x, int y)
        {
            int px = Find(x), py = Find(y);
            if (px != py) parent[py] = px;
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
            ResultTester.CheckResult<bool>(solution.GcdSort([7,21,3]), true),
            ResultTester.CheckResult<bool>(solution.GcdSort([5,2,6,2]), false),
            ResultTester.CheckResult<bool>(solution.GcdSort([10,5,9,3,15]), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("GCD Sort of an Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}