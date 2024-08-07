// Baseball Game

/*
You are keeping the scores for a baseball game with strange rules. At the beginning of the game, you start with an empty record.

You are given a list of strings operations, where operations[i] is the ith operation you must apply to the record and is one of the following:

An integer x.
Record a new score of x.
'+'.
Record a new score that is the sum of the previous two scores.
'D'.
Record a new score that is the double of the previous score.
'C'.
Invalidate the previous score, removing it from the record.
Return the sum of all the scores on the record after applying all the operations.

The test cases are generated such that the answer and all intermediate calculations fit in a 32-bit integer and that all operations are valid.

 

Example 1:

Input: ops = ["5","2","C","D","+"]
Output: 30
Explanation:
"5" - Add 5 to the record, record is now [5].
"2" - Add 2 to the record, record is now [5, 2].
"C" - Invalidate and remove the previous score, record is now [5].
"D" - Add 2 * 5 = 10 to the record, record is now [5, 10].
"+" - Add 5 + 10 = 15 to the record, record is now [5, 10, 15].
The total sum is 5 + 10 + 15 = 30.

Example 2:

Input: ops = ["5","-2","4","C","D","9","+","+"]
Output: 27
Explanation:
"5" - Add 5 to the record, record is now [5].
"-2" - Add -2 to the record, record is now [5, -2].
"4" - Add 4 to the record, record is now [5, -2, 4].
"C" - Invalidate and remove the previous score, record is now [5, -2].
"D" - Add 2 * -2 = -4 to the record, record is now [5, -2, -4].
"9" - Add 9 to the record, record is now [5, -2, -4, 9].
"+" - Add -4 + 9 = 5 to the record, record is now [5, -2, -4, 9, 5].
"+" - Add 9 + 5 = 14 to the record, record is now [5, -2, -4, 9, 5, 14].
The total sum is 5 + -2 + -4 + 9 + 5 + 14 = 27.

Example 3:

Input: ops = ["1","C"]
Output: 0
Explanation:
"1" - Add 1 to the record, record is now [1].
"C" - Invalidate and remove the previous score, record is now [].
Since the record is empty, the total sum is 0.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BaseballGame
{
    public class Solution
    {
        public static int CalPoints(string[] operations)
        {
            List<int> record = new(operations.Length);
            int result = 0;
            foreach (var op in operations)
            {
                int stepResult;
                switch (op[0])
                {
                    case '+':
                        stepResult = record[^1] + record[^2];
                        record.Add(stepResult);
                        break;

                    case 'D':
                        stepResult = record[^1] * 2;
                        record.Add(stepResult);
                        break;

                    case 'C':
                        stepResult = -record[^1];
                        record.RemoveAt(record.Count - 1);
                        break;

                    default:
                        stepResult = Int32.Parse(op);
                        record.Add(stepResult);
                        break;
                }
                result += stepResult;
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestBaseballGame()
        {
            string[] ops1 = {"5","-2","4","C","D","9","+","+"};
            string[] ops2 = {"1","C"};
            int result1_682 = Solution.CalPoints(ops1);
            int result2_682 = Solution.CalPoints(ops2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_682, 27),
                ResultTester.CheckResult<int>(result2_682, 0),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Baseball Game");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestBaseballGame());
        }
    }
}