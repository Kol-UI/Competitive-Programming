// Remove One Element to Make the Array Strictly Increasing
namespace CompetitiveProgramming.LeetCode.RemoveOneElementtoMaketheArrayStrictlyIncreasing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CanBeIncreasing(int[] nums)
    {
        int k = 0;
        while(k < nums.Length)
        {
            int[] removedArray = RemoveOneItem(nums, k);
            if(IsIncreasing(removedArray)) return true;
            k++;
        };

        return false;
    }

    public int[] RemoveOneItem(int[] nums, int index)
    {
        List<int> arr = new List<int>();
        for(int i =0; i < nums.Length; i++)
        {
            if(i != index) arr.Add(nums[i]);
        }

        return arr.ToArray();
    }

    public bool IsIncreasing(int[] nums)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[j] <= nums[i]) return false;
            }
        }

        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.CanBeIncreasing(new int[]{1,2,10,5,7}), true),
            ResultTester.CheckResult<bool>(solution.CanBeIncreasing(new int[]{2,3,1,2}), false),
            ResultTester.CheckResult<bool>(solution.CanBeIncreasing(new int[]{1,1,1}), false),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Remove One Element to Make the Array Strictly Increasing");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}