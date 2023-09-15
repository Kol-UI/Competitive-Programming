// Task Scheduler

/*
Given a characters array tasks, representing the tasks a CPU needs to do, where each letter represents a different task. Tasks could be done in any order. Each task is done in one unit of time. For each unit of time, the CPU could complete either one task or just be idle.

However, there is a non-negative integer n that represents the cooldown period between two same tasks (the same letter in the array), that is that there must be at least n units of time between any two same tasks.

Return the least number of units of times that the CPU will take to finish all the given tasks.

 

Example 1:

Input: tasks = ["A","A","A","B","B","B"], n = 2
Output: 8
Explanation: 
A -> B -> idle -> A -> B -> idle -> A -> B
There is at least 2 units of time between any two same tasks.


Example 2:

Input: tasks = ["A","A","A","B","B","B"], n = 0
Output: 6
Explanation: On this case any permutation of size 6 would work since n = 0.
["A","A","A","B","B","B"]
["A","B","A","B","A","B"]
["B","B","B","A","A","A"]
...
And so on.


Example 3:

Input: tasks = ["A","A","A","A","A","A","B","C","D","E","F","G"], n = 2
Output: 16
Explanation: 
One possible solution is
A -> B -> C -> A -> D -> E -> A -> F -> G -> A -> idle -> idle -> A -> idle -> idle -> A
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.TaskScheduler
{
    public class Solution
    {
        public static int LeastInterval(char[] tasks, int n) 
        {
            if (n == 0 || tasks == null || tasks.Length == 0)
            {
                return tasks?.Length ?? 0;
            }

            var map = tasks
                    .GroupBy(it => it)
                    .Select(it => (0, Count: it.Count()))
                    .OrderByDescending(it => it.Count);

            var workQueue = new PriorityQueue<int, int>(map, Comparer<int>.Create((l, r) => r - l));
            var idleQueue = new Queue<(int count, int next)>();

            var time = 0;
            while (workQueue.Count > 0 || idleQueue.Any())
            {
                time++;
                if (workQueue.TryDequeue(out _, out var count) && count > 1)
                {
                    idleQueue.Enqueue((--count, time + n));
                }

                if (idleQueue.Any() && idleQueue.Peek().next == time)
                {
                    workQueue.Enqueue(0, idleQueue.Dequeue().count);
                }
            }

            return time;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            char[] tasks1 = {'A','A','A','B','B','B'};
            char[] tasks2 = {'A','A','A','B','B','B'};
            char[] tasks3 = {'A','A','A','A','A','A','B','C','D','E','F','G'};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LeastInterval(tasks1, 2), 8),
                ResultTester.CheckResult<int>(Solution.LeastInterval(tasks2, 0), 6),
                ResultTester.CheckResult<int>(Solution.LeastInterval(tasks3, 2), 16),
            };
            return results;
        }
    }
}