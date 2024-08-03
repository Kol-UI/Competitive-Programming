// Time Needed to Inform All Employees

/*
A company has n employees with a unique ID for each employee from 0 to n - 1. The head of the company is the one with headID.

Each employee has one direct manager given in the manager array where manager[i] is the direct manager of the i-th employee, manager[headID] = -1. Also, it is guaranteed that the subordination relationships have a tree structure.

The head of the company wants to inform all the company employees of an urgent piece of news. He will inform his direct subordinates, and they will inform their subordinates, and so on until all employees know about the urgent news.

The i-th employee needs informTime[i] minutes to inform all of his direct subordinates (i.e., After informTime[i] minutes, all his direct subordinates can start spreading the news).

Return the number of minutes needed to inform all the employees about the urgent news.

 

Example 1:

Input: n = 1, headID = 0, manager = [-1], informTime = [0]
Output: 0
Explanation: The head of the company is the only employee in the company.

Example 2:


Input: n = 6, headID = 2, manager = [2,2,-1,2,2,2], informTime = [0,0,1,0,0,0]
Output: 1
Explanation: The head of the company with id = 2 is the direct manager of all the employees in the company and needs 1 minute to inform them all.
The tree structure of the employees in the company is shown.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TimeNeededtoInformAllEmployees
{
    public class Solution
    {
        public static int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            cache = new int[n];
            for(int i = 0; i < n; i++)
                cache[i] = -1;
            
            int answer = Int32.MinValue;
            
            for(int i = 0; i < n; i++)
                answer = Math.Max(answer, MaxTime(i, manager, informTime));
            
            return answer;
        }

        private static int[] cache = {};

        private static int MaxTime(int i, int[] manager, int[] informTime)
        {
            if(cache[i] != -1)
                return cache[i];
            
            int emp = manager[i];
            
            if(emp != -1)
                cache[i] = informTime[emp] + MaxTime(emp, manager, informTime);
            else
                cache[i] = 0;
            
            return cache[i];
        }
    }

    public class Test
    {
        public static bool[] TestTimeNeededtoInformAllEmployees()
        {
            int n1 = 1;
            int headID1 = 0;
            int[] manager1 = {-1};
            int[] informTime1 = {0};

            int n2 = 6;
            int headID2 = 2;
            int[] manager2 = {2,2,-1,2,2,2};
            int[] informTime2 = {0,0,1,0,0,0};

            int result1 = Solution.NumOfMinutes(n1, headID1, manager1, informTime1);
            int result2 = Solution.NumOfMinutes(n2, headID2, manager2, informTime2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 0),
                ResultTester.CheckResult<int>(result2, 1)
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
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestTimeNeededtoInformAllEmployees());
        }
    }
}