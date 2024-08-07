﻿using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumRoundstoCompleteAllTasks
{
    public class Solution
    {
        //You are given a 0-indexed integer array tasks, where tasks[i] represents the difficulty level of a task.
        //In each round, you can complete either 2 or 3 tasks of the same difficulty level.

        //Return the minimum rounds required to complete all the tasks, or -1 if it is not possible to complete all the tasks.

        //Example 1:

        //Input: tasks = [2, 2, 3, 3, 2, 4, 4, 4, 4, 4]
        //Output: 4
        //Explanation: To complete all the tasks, a possible plan is:
        //- In the first round, you complete 3 tasks of difficulty level 2. 
        //- In the second round, you complete 2 tasks of difficulty level 3. 
        //- In the third round, you complete 3 tasks of difficulty level 4. 
        //- In the fourth round, you complete 2 tasks of difficulty level 4.  
        //It can be shown that all the tasks cannot be completed in fewer than 4 rounds, so the answer is 4.

        //Example 2:

        //Input: tasks = [2, 3, 3]
        //Output: -1
        //Explanation: There is only 1 task of difficulty level 2, but in each round, you can only complete either 2 or 3 tasks of the same difficulty level. Hence, you cannot complete all the tasks, and the answer is -1.


        public static int MinimumRounds(int[] tasks)
        {
            var groups = tasks.GroupBy(t => t).Select(t => t.Count());
            var rounds = 0;
            foreach (var count in groups)
            {
                if (count == 1) return -1;
                rounds += (count % 3) switch
                {
                    0 => count / 3,
                    1 => 2 + (count - 4) / 3,
                    2 => 1 + (count - 2) / 3,
                    _ => throw new ArgumentException("Other")
                };
            }
            return rounds;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] tasks1_2244 = {2, 2, 3, 3, 2, 4, 4, 4, 4, 4};
            int[] tasks2_2244 = {2, 3, 3};

            int result1_2244 = Solution.MinimumRounds(tasks1_2244);
            int result2_2244 = Solution.MinimumRounds(tasks2_2244);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_2244, 4),
                ResultTester.CheckResult<int>(result2_2244, -1)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Rounds to Complete All Tasks");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}