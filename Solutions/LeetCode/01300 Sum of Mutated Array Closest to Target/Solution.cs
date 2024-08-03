// Sum of Mutated Array Closest to Target

/*
Given an integer array arr and a target value target, return the integer value such that when we change all the integers larger than value in the given array to be equal to value, the sum of the array gets as close as possible (in absolute difference) to target.

In case of a tie, return the minimum such integer.

Notice that the answer is not neccesarilly a number from arr.

 

Example 1:

Input: arr = [4,9,3], target = 10
Output: 3
Explanation: When using 3 arr converts to [3, 3, 3] which sums 9 and that's the optimal answer.

Example 2:

Input: arr = [2,3,5], target = 10
Output: 5

Example 3:

Input: arr = [60864,25176,27249,21296,20204], target = 56803
Output: 11361
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SumofMutatedArrayClosesttoTarget
{
    public class Solution
    {
        public static int FindBestValue(int[] arr, int target)
        {
            int low = 1;
            int high = arr.Max();

            while(low < high)
            {
                int mid = low + (high - low) / 2;
                int temp = CalculateSum(arr, mid);

                if(temp <= target)
                    low = mid + 1;
                else
                    high = mid;
            }

            return Math.Abs(target - CalculateSum(arr, low - 1)) <= Math.Abs(target - CalculateSum(arr, low)) ? low - 1 : low;
        }

        public static int CalculateSum(int[] arr, int num)
        {
            int sum = 0;

            for(int i = 0; i < arr.Length; i++) 
                sum += Math.Min(num, arr[i]);

            return sum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] arr1 = {4,9,3};
            int[] arr2 = {2,3,5};
            int[] arr3 = {60864,25176,27249,21296,20204};
            int target1 = 10;
            int target2 = 10;
            int target3 = 56803;
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindBestValue(arr1, target1), 3),
                ResultTester.CheckResult<int>(Solution.FindBestValue(arr2, target2), 5),
                ResultTester.CheckResult<int>(Solution.FindBestValue(arr3, target3), 11361),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Sum of Mutated Array Closest to Target");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}