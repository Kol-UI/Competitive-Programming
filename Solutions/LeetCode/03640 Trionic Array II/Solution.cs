// Trionic Array II
namespace CompetitiveProgramming.LeetCode.TrionicArrayII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaxSumTrionic(int[] nums)
    {
        int a = 0, state = 0, la = -1;
        long maxsm = long.MinValue, sm = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                if (state == 3) maxsm = Math.Max(maxsm, sm);
                state = 0;
                la = i;
                a = i;
                sm = nums[i];
                continue;
            }
            if (nums[i] < nums[i - 1])
            {
                switch (state)
                {
                    case 3:
                        {
                            a = la;
                            while (a < i - 2 && nums[a] < 0)
                                a++;
                            maxsm = Math.Max(maxsm, sm);
                            sm = 0;
                            for (int x = a; x <= i; x++)
                                sm += nums[x];
                            state = 2;
                            break;
                        }
                    case 2:
                        {
                            sm += nums[i];
                            break;
                        }
                    case 1:
                        {
                            sm += nums[i];
                            state = 2;
                            break;
                        }
                    case 0:
                        {
                            la = i;
                            a = i;
                            sm = nums[i];
                            break;
                        }
                }
                continue;
            }
            if (nums[i] > nums[i - 1])
            {
                switch (state)
                {
                    case 0:
                        la = i - 1;
                        sm += nums[i];
                        a = i - 1;
                        state = 1;
                        break;
                    case 1:
                        sm += nums[i];
                        while (i - a > 1 && nums[a] < 0)
                            sm -= nums[a++];
                        break;
                    case 2:
                        la = i - 1;
                        sm += nums[i];
                        maxsm = Math.Max(sm, maxsm);
                        state = 3;
                        break;
                    case 3:
                        sm += nums[i];
                        maxsm = Math.Max(sm, maxsm);
                        break;
                }
            }
        }
        if (state == 3) maxsm = Math.Max(sm, maxsm);
        return maxsm;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MaxSumTrionic([0,-2,-1,-3,0,2,-1]), -4),
            ResultTester.CheckResult<long>(solution.MaxSumTrionic([1,4,2,7]), 14)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Trionic Array II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}