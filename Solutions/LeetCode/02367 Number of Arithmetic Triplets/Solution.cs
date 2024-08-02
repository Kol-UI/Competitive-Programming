// Number of Arithmetic Triplets



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofArithmeticTriplets
{
    public class Solution
    {
        public static int ArithmeticTriplets(int[] nums, int diff)
        {
            int count = 0;
            var set = new HashSet<int>();
            for(int i = 0; i< nums.Length; i++)
            {
                if(set.Contains(nums[i] - diff))
                    if(set.Contains(nums[i] - diff - diff)) count++;
                
                set.Add(nums[i]);
            }
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.ArithmeticTriplets(new int[]{0,1,4,6,7,10}, 3), 2),
                ResultTester.CheckResult<int>(Solution.ArithmeticTriplets(new int[]{4,5,6,7,8,9}, 2), 2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2367");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}