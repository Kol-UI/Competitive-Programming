// Split the Array


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SplittheArray
{
    public class Solution 
    {
        public static bool IsPossibleToSplit(int[] nums) 
        {
            Dictionary<int,int> numberOccurrences = new();

            foreach(int num in nums)
            {
                if(numberOccurrences.ContainsKey(num))
                    numberOccurrences[num]++;
                else
                    numberOccurrences[num] = 1;
                
                if(numberOccurrences[num] > 2)
                    return false;
            }

            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsPossibleToSplit(new int[]{1,1,1,1}), false),
                ResultTester.CheckResult<bool>(Solution.IsPossibleToSplit(new int[]{1,1,2,2,3,4}), true),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Split the Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}