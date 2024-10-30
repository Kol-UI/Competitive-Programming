// Minimum Number of Removals to Make Mountain Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofRemovalstoMakeMountainArray
{
    public class Solution
    {
        private List<int> LisLength(int[] v)
        {
            List<int> lis = new List<int> { v[0] };
            List<int> lisLen = new List<int>(new int[v.Length]);
            
            for (int i = 0; i < v.Length; i++)
            {
                lisLen[i] = 1;
            }

            for (int i = 1; i < v.Length; i++)
            {
                if (v[i] > lis[lis.Count - 1])
                {
                    lis.Add(v[i]);
                }
                else
                {
                    int index = lis.BinarySearch(v[i]);
                    if (index < 0)
                    {
                        index = ~index;
                    }
                    lis[index] = v[i];
                }
                lisLen[i] = lis.Count;
            }
            return lisLen;
        }

        public int MinimumMountainRemovals(int[] nums)
        {
            int n = nums.Length;
            
            List<int> lis = LisLength(nums);
            
            Array.Reverse(nums);
            List<int> lds = LisLength(nums);
            lds.Reverse();
            Array.Reverse(nums);
            
            int removals = int.MaxValue;
            
            for (int i = 0; i < n; i++)
            {
                if (lis[i] > 1 && lds[i] > 1)
                {
                    removals = Math.Min(removals, n + 1 - lis[i] - lds[i]);
                }
            }
            
            return removals;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MinimumMountainRemovals(new int[]{1,3,1}), 0),
                ResultTester.CheckResult<int>(solution.MinimumMountainRemovals(new int[]{2,1,1,5,6,2,3,1}), 3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Removals to Make Mountain Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}