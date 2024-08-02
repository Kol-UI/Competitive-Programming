// Robot Return to Origin

/*
There is a robot starting at the position (0, 0), the origin, on a 2D plane. Given a sequence of its moves, judge if this robot ends up at (0, 0) after it completes its moves.

You are given a string moves that represents the move sequence of the robot where moves[i] represents its ith move. Valid moves are 'R' (right), 'L' (left), 'U' (up), and 'D' (down).

Return true if the robot returns to the origin after it finishes all of its moves, or false otherwise.

Note: The way that the robot is "facing" is irrelevant. 'R' will always make the robot move to the right once, 'L' will always make it move left, etc. Also, assume that the magnitude of the robot's movement is the same for each move.

 

Example 1:

Input: moves = "UD"
Output: true
Explanation: The robot moves up once, and then down once. All moves have the same magnitude, so it ended up at the origin where it started. Therefore, we return true.

Example 2:

Input: moves = "LL"
Output: false
Explanation: The robot moves left twice. It ends up two "moves" to the left of the origin. We return false because it is not at the origin at the end of its moves.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RobotReturntoOrigin
{
    public class Solution
    {
        public static bool JudgeCircle(string moves)
        {
            return moves.Count(x => x == 'L') == moves.Count(x => x == 'R')
                && moves.Count(x => x == 'U') == moves.Count(x => x == 'D');
        }
    }

    public class Test
    {
        public static bool[] TestRobotReturntoOrigin()
        {
            string moves1 = "UD";
            string moves2 = "LL";
            bool result1 = LeetCode.RobotReturntoOrigin.Solution.JudgeCircle(moves1);
            bool result2 = LeetCode.RobotReturntoOrigin.Solution.JudgeCircle(moves2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, true),
                ResultTester.CheckResult<bool>(result2, false)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Robot Return to Origin");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestRobotReturntoOrigin());
        }
    }
}