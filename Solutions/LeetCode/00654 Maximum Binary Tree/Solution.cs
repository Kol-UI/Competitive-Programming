// Maximum Binary Tree
namespace CompetitiveProgramming.LeetCode.MaximumBinaryTree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#pragma warning disable CS8603
public class Solution
{
    public TreeNode ConstructMaximumBinaryTree(int[] nums)
    {
        if (nums.Length == 0)
            return null;

        var maxArrayValueIndex = GetMaxValueIndex(nums);
        var leftArray = nums[..maxArrayValueIndex];
        var rightArray = nums[(maxArrayValueIndex + 1)..];
        var node = new TreeNode(
            nums[maxArrayValueIndex],
            left: ConstructMaximumBinaryTree(leftArray),
            right: ConstructMaximumBinaryTree(rightArray));

        return node;
    }

    int GetMaxValueIndex(int[] nums)
    {
        var max = nums[0];
        var index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (max < nums[i])
            {
                max = nums[i];
                index = i;
            }
        }

        return index;
    }
}
#pragma warning restore CS8603

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Binary Tree");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}