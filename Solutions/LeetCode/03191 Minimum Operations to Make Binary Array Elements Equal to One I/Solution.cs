// Minimum Operations to Make Binary Array Elements Equal to One I
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoMakeBinaryArrayElementsEqualtoOneI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public int MinOperations(int[] nums) {
        int n = nums.Length;
        int operations = 0;

        for (int i = 0; i <= n - 3; i++) {
            if (nums[i] == 0) {
                nums[i] ^= 1;
                nums[i + 1] ^= 1;
                nums[i + 2] ^= 1;
                operations++;
            }
        }

        foreach (int num in nums) {
            if (num == 0) return -1;
        }

        return operations;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Make Binary Array Elements Equal to One I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}