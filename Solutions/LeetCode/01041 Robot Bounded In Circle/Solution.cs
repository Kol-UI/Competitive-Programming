// Robot Bounded In Circle

/*
On an infinite plane, a robot initially stands at (0, 0) and faces north. Note that:

The north direction is the positive direction of the y-axis.
The south direction is the negative direction of the y-axis.
The east direction is the positive direction of the x-axis.
The west direction is the negative direction of the x-axis.
The robot can receive one of three instructions:

"G": go straight 1 unit.
"L": turn 90 degrees to the left (i.e., anti-clockwise direction).
"R": turn 90 degrees to the right (i.e., clockwise direction).
The robot performs the instructions given in order, and repeats them forever.

Return true if and only if there exists a circle in the plane such that the robot never leaves the circle.

 

Example 1:

Input: instructions = "GGLLGG"
Output: true
Explanation: The robot is initially at (0, 0) facing the north direction.
"G": move one step. Position: (0, 1). Direction: North.
"G": move one step. Position: (0, 2). Direction: North.
"L": turn 90 degrees anti-clockwise. Position: (0, 2). Direction: West.
"L": turn 90 degrees anti-clockwise. Position: (0, 2). Direction: South.
"G": move one step. Position: (0, 1). Direction: South.
"G": move one step. Position: (0, 0). Direction: South.
Repeating the instructions, the robot goes into the cycle: (0, 0) --> (0, 1) --> (0, 2) --> (0, 1) --> (0, 0).
Based on that, we return true.

Example 2:

Input: instructions = "GG"
Output: false
Explanation: The robot is initially at (0, 0) facing the north direction.
"G": move one step. Position: (0, 1). Direction: North.
"G": move one step. Position: (0, 2). Direction: North.
Repeating the instructions, keeps advancing in the north direction and does not go into cycles.
Based on that, we return false.

Example 3:

Input: instructions = "GL"
Output: true
Explanation: The robot is initially at (0, 0) facing the north direction.
"G": move one step. Position: (0, 1). Direction: North.
"L": turn 90 degrees anti-clockwise. Position: (0, 1). Direction: West.
"G": move one step. Position: (-1, 1). Direction: West.
"L": turn 90 degrees anti-clockwise. Position: (-1, 1). Direction: South.
"G": move one step. Position: (-1, 0). Direction: South.
"L": turn 90 degrees anti-clockwise. Position: (-1, 0). Direction: East.
"G": move one step. Position: (0, 0). Direction: East.
"L": turn 90 degrees anti-clockwise. Position: (0, 0). Direction: North.
Repeating the instructions, the robot goes into the cycle: (0, 0) --> (0, 1) --> (-1, 1) --> (-1, 0) --> (0, 0).
Based on that, we return true.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RobotBoundedInCircle
{
    public class Solution
    {
        public static bool IsRobotBounded(string instructions)
        {
            int[] dx = new int[] {0, 1, 0 , -1};
            int[] dy = new int[] {1, 0, -1, 0};
            int idx = 0;
            
            int x = 0;
            int y = 0;
            
            foreach (char ch in instructions) 
            {
                if (ch == 'L') idx = (idx + 3) % 4;
                else if (ch == 'R') idx = (idx + 1) % 4;
                else 
                {
                    x += dx[idx];
                    y += dy[idx];
                }
            }
            
            return (x == 0 && y == 0) || idx > 0;
        }
    }

    public class Test
    {
        public static bool[] TestRobotBoundedInCircle()
        {
            string instructions1 = "GGLLGG";
            string instructions2 = "GG";
            string instructions3 = "GL";

            bool result1 = Solution.IsRobotBounded(instructions1);
            bool result2 = Solution.IsRobotBounded(instructions2);
            bool result3 = Solution.IsRobotBounded(instructions3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, true),
                ResultTester.CheckResult<bool>(result2, false),
                ResultTester.CheckResult<bool>(result3, true)
            };

            return results;
        }
    }
}