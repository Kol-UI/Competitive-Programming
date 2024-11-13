// Count the Number of Fair Pairs

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CounttheNumberofFairPairs
{
    public class Solution {
        public long CountFairPairs(int[] nums, int lower, int upper) {
            Array.Sort(nums); 
            long count = 0;
            
            for (int i = 0; i < nums.Length - 1; i++) {
                int left = i + 1;
                int right = nums.Length - 1;
                int lowIndex = BinarySearch(nums, left, right, lower - nums[i], true);
                int highIndex = BinarySearch(nums, left, right, upper - nums[i], false);
                if (lowIndex != -1 && highIndex != -1 && lowIndex <= highIndex) {
                    count += (highIndex - lowIndex + 1);
                }
            }
            
            return count;
        }
        private int BinarySearch(int[] nums, int left, int right, int target, bool findLower) {
            int result = -1;
            
            while (left <= right) {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] < target) {
                    left = mid + 1;
                } else if (nums[mid] > target) {
                    right = mid - 1;
                } else {
                    result = mid;
                    if (findLower) {
                        right = mid - 1; 
                    } else {
                        left = mid + 1; 
                    }
                }
            }
            
            return findLower ? left : right;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count the Number of Fair Pairs");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}