// Adjacent Increasing Subarrays Detection I
namespace CompetitiveProgramming.LeetCode.AdjacentIncreasingSubarraysDetectionI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool HasIncreasingSubarrays(IList<int> nums, int k)
    {
        for(int i = k;i < nums.Count; i++)
        {
            int j = i - k + 1, l = i + 1, m = 1;
            bool found = true;

            while(l < nums.Count && m < k)
            {
                if(nums[j] <= nums[j-1] || nums[l] <= nums[l-1])
                {
                    found = false;
                    break;
                }

                j++;
                l++;
                m++;
            }

            if(found && m == k)
            {
                return true;
            }
        }

        return false;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Adjacent Increasing Subarrays Detection I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}