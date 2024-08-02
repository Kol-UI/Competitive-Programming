// Continuous Subarray Sum


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ContinuousSubarraySum
{
    public class Solution
    {
        public static bool CheckSubarraySum(int[] nums, int k)
        {
            var hash = new Dictionary<int, int>();
            hash.Add(0, -1); 
            int a = 0;
            for(int j = 0; j< nums.Length; j++)
            {
                var sum = a + nums[j];
                
                int remainderToFind = sum % k;
                
                if(hash.TryGetValue(remainderToFind, out int foundIndex) && Math.Abs(foundIndex - j) >= 2)
                {
                    return true;
                }
                a = sum;
                if(!hash.TryGetValue(remainderToFind,out int _))
                    hash.Add(remainderToFind, j);
            }
            
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.CheckSubarraySum(new int[]{23,2,4,6,7}, 6), true),
                ResultTester.CheckResult<bool>(Solution.CheckSubarraySum(new int[]{23,2,6,4,7}, 6), true),
                ResultTester.CheckResult<bool>(Solution.CheckSubarraySum(new int[]{23,2,6,4,7}, 13), false),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Continuous Subarray Sum");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}