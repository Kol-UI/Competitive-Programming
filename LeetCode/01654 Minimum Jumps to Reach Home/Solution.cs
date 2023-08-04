// Minimum Jumps to Reach Home

/*
A certain bug's home is on the x-axis at position x. Help them get there from position 0.

The bug jumps according to the following rules:

It can jump exactly a positions forward (to the right).
It can jump exactly b positions backward (to the left).
It cannot jump backward twice in a row.
It cannot jump to any forbidden positions.
The bug may jump forward beyond its home, but it cannot jump to positions numbered with negative integers.

Given an array of integers forbidden, where forbidden[i] means that the bug cannot jump to the position forbidden[i], and integers a, b, and x, return the minimum number of jumps needed for the bug to reach its home. If there is no possible sequence of jumps that lands the bug on position x, return -1.

 

Example 1:

Input: forbidden = [14,4,18,1,15], a = 3, b = 15, x = 9
Output: 3
Explanation: 3 jumps forward (0 -> 3 -> 6 -> 9) will get the bug home.

Example 2:

Input: forbidden = [8,3,16,6,12,20], a = 15, b = 13, x = 11
Output: -1

Example 3:

Input: forbidden = [1,6,2,14,5,17,4], a = 16, b = 9, x = 7
Output: 2
Explanation: One jump forward (0 -> 16) then one jump backward (16 -> 7) will get the bug home.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumJumpstoReachHome
{
    public class Point
    {
        public int val{get;set;}
        public int dir{get;set;}
        public Point(int val , int dir)
        {
            this.val = val;
            this.dir = dir;
        }
    }

    public class Solution 
    {
        public static int MinimumJumps(int[] forbidden, int a, int b, int x) 
        {
            if(x == 0) return 0;
            int jumps = 0;

            HashSet<string> visited = new HashSet<string>();
            Queue<Point> q = new Queue<Point>();

            q.Enqueue(new Point(0,0));
            visited.Add(0 + "-" + 0);
            jumps++;

            while(q.Count != 0)
            {
                int size = q.Count;
                for(int i = 0; i < size; i++)
                {
                    Point p = q.Dequeue();
                    int next_a = p.val + a;
                    if(next_a == x) return jumps;
                    if(next_a >= 0 && next_a <= 8000 && !Array.Exists(forbidden, v => v == next_a) && !visited.Contains(next_a + "-" + 1))
                    {
                        visited.Add(next_a + "-" + 1);
                        q.Enqueue(new Point(next_a, 1));
                    }
                    if(p.dir == 1)
                    {
                        int next_b = p.val-b;
                        if(next_b == x) return jumps;
                        if(next_b >= 0 && next_b <= 8000 && !Array.Exists(forbidden, v => v == next_b) && !visited.Contains(next_b + "-" + 0))
                        {
                            visited.Add(next_a + "-" + 0);
                            q.Enqueue(new Point(next_b, 0));
                        }
                    }
                }
                jumps++;
            }
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] forbidden1 = {14,4,18,1,15}; int a1 = 3; int b1 = 15; int x1 = 9;
            int[] forbidden2 = {8,3,16,6,12,20}; int a2 = 15; int b2 = 13; int x2 = 11;
            int[] forbidden3 = {1,6,2,14,5,17,4}; int a3 = 16; int b3 = 9; int x3 = 7;
            int result1 = Solution.MinimumJumps(forbidden1, a1, b1, x1);
            int result2 = Solution.MinimumJumps(forbidden2, a2, b2, x2);
            int result3 = Solution.MinimumJumps(forbidden3, a3, b3, x3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, -1),
                ResultTester.CheckResult<int>(result3, 2)
            };
            return results;
        }
    }
}