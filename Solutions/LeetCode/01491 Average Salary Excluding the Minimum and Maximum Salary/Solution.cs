// Average Salary Excluding the Minimum and Maximum Salary

/*
You are given an array of unique integers salary where salary[i] is the salary of the ith employee.

Return the average salary of employees excluding the minimum and maximum salary. Answers within 10-5 of the actual answer will be accepted.

 

Example 1:

Input: salary = [4000,3000,1000,2000]
Output: 2500.00000
Explanation: Minimum salary and maximum salary are 1000 and 4000 respectively.
Average salary excluding minimum and maximum salary is (2000+3000) / 2 = 2500

Example 2:

Input: salary = [1000,2000,3000]
Output: 2000.00000
Explanation: Minimum salary and maximum salary are 1000 and 3000 respectively.
Average salary excluding minimum and maximum salary is (2000) / 1 = 2000
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AverageSalaryExcludingtheMinimumandMaximumSalary
{
    public class Solution
    {
        // Returns the average of all the elements of the array except the smallest and largest element.
        public static double Average(int[] salary)
        {
            return salary.OrderBy(s => s).Take(salary.Length - 1).Skip(1).Average();
        }
        /*
        The OrderBy method sorts the elements of the input array salary in ascending order.
        The Take method then returns the first salary.Length - 1 elements of the sorted array, effectively excluding the largest element.
        The Skip method skips the first element of the remaining array, effectively excluding the smallest element.
        The Average method calculates the average of the remaining elements in the array.
        */
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] salary1_1491 = {4000,3000,1000,2000};
            double result1_1491 = Solution.Average(salary1_1491);

            // Case 2
            int[] salary2_1491 = {1000,2000,3000};
            double result2_1491 = Solution.Average(salary2_1491);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(result1_1491, 2500.00000),
                ResultTester.CheckResult<double>(result2_1491, 2000.00000),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("1491");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}