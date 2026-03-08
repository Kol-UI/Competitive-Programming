// Check if it is Possible to Split Array
namespace CompetitiveProgramming.LeetCode.CheckifitisPossibletoSplitArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CanSplitArray(IList<int> nums, int m)
    {
        var dic = new Dictionary<(int index0, int index1), bool>();
        var (leftSums, rightSums) = CalculateSums(nums);
        var result = CanSplitArray((0, nums.Count - 1), dic, leftSums, rightSums, m);
        return result;
    }

    private bool CanSplitArray((int index0, int index1) key, Dictionary<(int index0, int index1), bool> dic, int[] leftSums, int[] rightSums, int m)
    {
        if (dic.ContainsKey(key)) return dic[key];
        if (key.index0 == key.index1)
        {
            if (!dic.ContainsKey(key)) dic.Add(key, true);
            return true;
        }
        for (int i = key.index0 + 1; i <= key.index1; i++)
        {
            if (IsOKSubarray(key.index0, i - 1, leftSums, rightSums, m) && IsOKSubarray(i, key.index1, leftSums, rightSums, m))
            {
                var result = CanSplitArray((key.index0, i - 1), dic, leftSums, rightSums, m) && CanSplitArray((i, key.index1), dic, leftSums, rightSums, m);
                if (result)
                {
                    if (!dic.ContainsKey(key)) dic.Add(key, true);
                    return true;
                }
            }
        }
        if (!dic.ContainsKey(key)) dic.Add(key, false);
        return false;
    }

    private bool IsOKSubarray(int index0, int index1, int[] leftSums, int[] rightSums, int m)
    {
        if (index0 == index1) return true;
        var totalSum = rightSums[0];
        var sum = totalSum;
        if (0 <= index0 - 1) sum -= leftSums[index0 - 1];
        if (index1 + 1 < rightSums.Length) sum -= rightSums[index1 + 1];
        var result = sum >= m;
        return result;
    }

    private (int[] leftSums, int[] rightSums) CalculateSums(IList<int> nums)
    {
        var leftSums = new int[nums.Count];
        leftSums[0] = nums[0];
        for (int i = 1; i < nums.Count; i++)
        {
            leftSums[i] = leftSums[i - 1] + nums[i];
        }
        var rightSums = new int[nums.Count];
        rightSums[rightSums.Length - 1] = nums[nums.Count - 1];
        for (int i = rightSums.Length - 2; i >= 0; i--)
        {
            rightSums[i] = rightSums[i + 1] + nums[i];
        }
        return (leftSums, rightSums);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.CanSplitArray([2, 2, 1], 4), true),
            ResultTester.CheckResult<bool>(solution.CanSplitArray([2, 1, 3], 5), false),
            ResultTester.CheckResult<bool>(solution.CanSplitArray([2, 3, 3, 2, 3], 6), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if it is Possible to Split Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}