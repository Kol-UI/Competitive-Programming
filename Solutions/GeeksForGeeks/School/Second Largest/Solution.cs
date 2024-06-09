using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.School.SecondLargest
{
	public class Solution
	{
        public static int PrintSecondLargest(int[] arr, int n)
        {
            Array.Sort(arr);
            int result = 0;
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] != arr[n - 1])
                {
                    result = arr[i];
                    break;
                }
            }
            
            if (result == 0)
            {
                return -1;
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestSecondLargest()
        {
            // Case 1
            int[] case1_PrintSecondLargest = { 12, 35, 1, 10, 34, 1 };
            int NCase1_PrintSecondLargest = 6;
            int case1_PrintSecondLargestResult = Solution.PrintSecondLargest(case1_PrintSecondLargest, NCase1_PrintSecondLargest);

            // Case 2
            int[] case2_PrintSecondLargest = { 10, 5, 10 };
            int NCase2_PrintSecondLargest = 3;
            int case2_PrintSecondLargestResult = Solution.PrintSecondLargest(case2_PrintSecondLargest, NCase2_PrintSecondLargest);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(case1_PrintSecondLargestResult, 34),
                ResultTester.CheckResult<int>(case2_PrintSecondLargestResult, 5)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Second Largest");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.SchoolGFG, Test.TestSecondLargest());
        }
    }
}