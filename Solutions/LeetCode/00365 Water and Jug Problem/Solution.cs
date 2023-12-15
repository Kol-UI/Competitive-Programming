// Water and Jug Problem

/*
You are given two jugs with capacities jug1Capacity and jug2Capacity liters. There is an infinite amount of water supply available. Determine whether it is possible to measure exactly targetCapacity liters using these two jugs.

If targetCapacity liters of water are measurable, you must have targetCapacity liters of water contained within one or both buckets by the end.

Operations allowed:

Fill any of the jugs with water.
Empty any of the jugs.
Pour water from one jug into another till the other jug is completely full, or the first jug itself is empty.
 

Example 1:

Input: jug1Capacity = 3, jug2Capacity = 5, targetCapacity = 4
Output: true
Explanation: The famous Die Hard example 

Example 2:

Input: jug1Capacity = 2, jug2Capacity = 6, targetCapacity = 5
Output: false

Example 3:

Input: jug1Capacity = 1, jug2Capacity = 2, targetCapacity = 3
Output: true
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.WaterandJugProblem
{
    public class Solution
    {
        public static bool CanMeasureWater(int jug1Capacity, int jug2Capacity, int targetCapacity)
        {
            HashSet<string> map = new HashSet<string>();
            Queue<int[]> q = new Queue<int[]>();
            int[] jc = new int[]{jug1Capacity, jug2Capacity};
            q.Enqueue(jc);
            
            while (q.Count > 0)
            {
                int[] rem = q.Dequeue();
                int v1 = rem[0];
                int v2 = rem[1];

                if (v1 == targetCapacity || v2 == targetCapacity || v1 + v2 == targetCapacity )
                {
                    return true;
                }

                string key = "" + v1 + v2;
                if (map.Contains(key)) continue;

                map.Add(key);

                q.Enqueue(new int[]{jug1Capacity, v2});
                q.Enqueue(new int[]{v1, jug2Capacity});
                q.Enqueue(new int[]{0, v2});
                q.Enqueue(new int[]{v1, 0});

                if (v2 < jug2Capacity && v1 > 0)
                {
                    int diff = jug2Capacity - v2;
                    if (v1 >= diff)
                    {
                        int remV1 = v1 - diff;
                        q.Enqueue(new int[]{remV1, jug2Capacity});
                    }
                    else
                    {
                        q.Enqueue(new int[]{0, v2 + v1});
                    }
                }
                if (v1 < jug1Capacity && v2 > 0)
                {
                    int diff = jug1Capacity - v1;
                    if (v2 >= diff)
                    {
                        int remV2 = v2 - diff;
                        q.Enqueue(new int[]{jug1Capacity, remV2});
                    }
                    else
                    {
                        q.Enqueue(new int[]{v2 + v1, 0});
                    }
                }

            }

            return false;
        }
    }

    public class Test
    {
        public static bool[] TestWaterandJugProblem()
        {
            int jug1Capacity1 = 3; int jug2Capacity1 = 5; int targetCapacity1 = 4;
            int jug1Capacity2 = 2; int jug2Capacity2 = 6; int targetCapacity2 = 5;
            int jug1Capacity3 = 1; int jug2Capacity3 = 2; int targetCapacity3 = 3;
            bool result1 = Solution.CanMeasureWater(jug1Capacity1, jug2Capacity1, targetCapacity1);
            bool result2 = Solution.CanMeasureWater(jug1Capacity2, jug2Capacity2, targetCapacity2);
            bool result3 = Solution.CanMeasureWater(jug1Capacity3, jug2Capacity3, targetCapacity3);
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