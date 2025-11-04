// Choose K Elements With Maximum Sum
namespace CompetitiveProgramming.LeetCode.ChooseKElementsWithMaximumSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

public class Solution
{
    record R(int index, int num1, int num2);

    public long[] FindMaxSum(int[] nums1, int[] nums2, int k)
    {
        int n = nums1.Length;
        long[] sums = new long[n];

        R[] rs = nums1
            .Select((n, i) => new R(i, n, nums2[i]))
            .OrderBy(r => r.num1)
            .ToArray();

        PriorityQueue<int, int> pq = new();
        long sum = 0;

        for (int i = 1; i < n; i++)
        {
            int val = rs[i - 1].num2;
            pq.Enqueue(val, val);
            sum += val;
            if (pq.Count > k)
            {
                sum -= pq.Dequeue();
            }

            if (rs[i].num1 == rs[i - 1].num1)
            {
                sums[rs[i].index] = sums[rs[i - 1].index];
            }
            else
            {
                sums[rs[i].index] = sum;
            }
        }

        return sums;
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Choose K Elements With Maximum Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}