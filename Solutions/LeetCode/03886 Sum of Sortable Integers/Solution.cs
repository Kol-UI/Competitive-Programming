// Sum of Sortable Integers
namespace CompetitiveProgramming.LeetCode.SumofSortableIntegers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SortableIntegers(int[] nums)
    {
        int n = nums.Length;
        List<int> fac = new List<int>();

        for (int x = 1; x * x <= n; x++)
        {
            if (n % x == 0)
            {
                fac.Add(x);
                if (n / x != x)
                {
                    fac.Add(n / x);
                }
            }
        }

        int[] target = (int[])nums.Clone();
        Array.Sort(target);

        int ans = 0;
        foreach (int d in fac)
        {
            bool allGood = true;
            for (int left = 0; left < n; left += d)
            {
                int[] sub1 = new int[d];
                int[] sub2 = new int[d];
                Array.Copy(nums, left, sub1, 0, d);
                Array.Copy(target, left, sub2, 0, d);

                if (!Check(sub1, sub2))
                {
                    allGood = false;
                    break;
                }
            }
            if (allGood)
            {
                ans += d;
            }
        }

        return ans;
    }

    private bool Check(int[] nums1, int[] nums2)
    {
        int[] doubled = new int[nums1.Length * 2];
        Array.Copy(nums1, 0, doubled, 0, nums1.Length);
        Array.Copy(nums1, 0, doubled, nums1.Length, nums1.Length);

        return Kmp(doubled, nums2);
    }

    private bool Kmp(int[] text, int[] pattern)
    {
        int n = text.Length, m = pattern.Length;
        int[] pi = new int[m];
        int j = 0;

        for (int i = 1; i < m; i++)
        {
            while (j > 0 && pattern[i] != pattern[j])
            {
                j = pi[j - 1];
            }
            if (pattern[i] == pattern[j])
            {
                j++;
            }
            pi[i] = j;
        }

        j = 0;
        for (int i = 0; i < n; i++)
        {
            while (j > 0 && text[i] != pattern[j])
            {
                j = pi[j - 1];
            }
            if (text[i] == pattern[j])
            {
                j++;
            }
            if (j == m)
            {
                return true;
            }
        }
        return false;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.SortableIntegers([3,1,2]), 3),
            ResultTester.CheckResult<int>(solution.SortableIntegers([7,6,5]), 0),
            ResultTester.CheckResult<int>(solution.SortableIntegers([5,8]), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Sortable Integers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}