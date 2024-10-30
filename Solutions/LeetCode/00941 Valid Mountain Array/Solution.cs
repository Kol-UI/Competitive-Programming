// Valid Mountain Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ValidMountainArray
{
    public class Solution
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
            {
                return false;
            }

            int i = 0;
            while (i < arr.Length - 1 && arr[i] < arr[i + 1]) 
            {
                i++;
            }
            if (i == 0 || i == arr.Length - 1) 
            {
                return false;
            }
            while (i < arr.Length - 1 && arr[i] > arr[i + 1]) 
            {
                i++;
            }

            return i == arr.Length - 1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(solution.ValidMountainArray(new int[]{2,1}), false),
                ResultTester.CheckResult<bool>(solution.ValidMountainArray(new int[]{3,5,5}), false),
                ResultTester.CheckResult<bool>(solution.ValidMountainArray(new int[]{0,3,2,1}), true),
                ResultTester.CheckResult<bool>(solution.ValidMountainArray(new int[]{0,2,3,4,5,2,1,0}), true),
                ResultTester.CheckResult<bool>(solution.ValidMountainArray(new int[]{0,2,3,3,5,2,1,0}), false),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Title");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}