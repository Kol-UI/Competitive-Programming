// How Many Numbers Are Smaller Than the Current Number

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.HowManyNumbersAreSmallerThantheCurrentNumber
{
    public class Solution
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums) 
        {
            int[] smallerCounts = new int[nums.Length];
            
            for(int i = 0; i < nums.Length; i++)
            { 
                int count = 0;
                for(int j = 0; j < nums.Length; j++)
                { 
                    if(nums[i] > nums[j])
                    { 
                        count++;
                    }
                }
                smallerCounts[i] = count;
            }
            
            return smallerCounts;
        }
    }

    public class SolutionBruteForce
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums) 
        {
            int n = nums.Length;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (nums[j] < nums[i])
                        count++;
                }
                result[i] = count;
            }

            return result;
        }
    }

    public class SolutionSortMap
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums) 
        {
            int n = nums.Length;
            int[] sorted = (int[])nums.Clone();
            Array.Sort(sorted);
            Dictionary<int, int> firstIndex = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (!firstIndex.ContainsKey(sorted[i]))
                {
                    firstIndex[sorted[i]] = i;
                }
            }

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = firstIndex[nums[i]];
            }

            return result;
        }
    }

    public class SolutionCountSort
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums) 
        {
            int[] count = new int[101];

            foreach (int num in nums)
            {
                count[num]++;
            }

            for (int i = 1; i <= 100; i++)
            {
                count[i] += count[i - 1];
            }

            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    result[i] = 0;
                else
                    result[i] = count[nums[i] - 1];
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.SmallerNumbersThanCurrent(new int[]{8,1,2,2,3}), new int[]{4,0,1,1,3}),
                ResultTester.CheckResult<int[]>(Solution.SmallerNumbersThanCurrent(new int[]{6,5,4,8}), new int[]{2,1,0,3}),
                ResultTester.CheckResult<int[]>(Solution.SmallerNumbersThanCurrent(new int[]{7,7,7,7}), new int[]{0,0,0,0}),
                ResultTester.CheckResult<int[]>(SolutionBruteForce.SmallerNumbersThanCurrent(new int[]{8,1,2,2,3}), new int[]{4,0,1,1,3}),
                ResultTester.CheckResult<int[]>(SolutionBruteForce.SmallerNumbersThanCurrent(new int[]{6,5,4,8}), new int[]{2,1,0,3}),
                ResultTester.CheckResult<int[]>(SolutionBruteForce.SmallerNumbersThanCurrent(new int[]{7,7,7,7}), new int[]{0,0,0,0}),
                ResultTester.CheckResult<int[]>(SolutionSortMap.SmallerNumbersThanCurrent(new int[]{8,1,2,2,3}), new int[]{4,0,1,1,3}),
                ResultTester.CheckResult<int[]>(SolutionSortMap.SmallerNumbersThanCurrent(new int[]{6,5,4,8}), new int[]{2,1,0,3}),
                ResultTester.CheckResult<int[]>(SolutionSortMap.SmallerNumbersThanCurrent(new int[]{7,7,7,7}), new int[]{0,0,0,0}),
                ResultTester.CheckResult<int[]>(SolutionCountSort.SmallerNumbersThanCurrent(new int[]{8,1,2,2,3}), new int[]{4,0,1,1,3}),
                ResultTester.CheckResult<int[]>(SolutionCountSort.SmallerNumbersThanCurrent(new int[]{6,5,4,8}), new int[]{2,1,0,3}),
                ResultTester.CheckResult<int[]>(SolutionCountSort.SmallerNumbersThanCurrent(new int[]{7,7,7,7}), new int[]{0,0,0,0}),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("How Many Numbers Are Smaller Than the Current Number");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}