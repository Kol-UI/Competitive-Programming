// Maximum Number of Tasks You Can Assign
namespace CompetitiveProgramming.LeetCode.MaximumNumberofTasksYouCanAssign;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxTaskAssign(int[] taskRequirements, int[] workerStrengths, int availablePills, int pillStrengthBoost)
    {
        Array.Sort(taskRequirements, (a, b) => b.CompareTo(a));    
        Array.Sort(workerStrengths, (a, b) => b.CompareTo(a));     

        int taskIndex = 0;
        int workerIndex = 0;
        int pillWorkerPointer = 0;
        int completedTasks = 0;
        bool scanningDown = true;

        var pillQueue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        while (taskIndex < taskRequirements.Length)
        {
            while (workerIndex < workerStrengths.Length && workerStrengths[workerIndex] == -1) 
                workerIndex++;

            if (workerIndex >= workerStrengths.Length)
            {
                if (pillQueue.Count > 0 && pillQueue.Peek() >= taskRequirements[taskIndex])
                {
                    pillQueue.Dequeue();
                    completedTasks++;
                }
            }
            else if (workerStrengths[workerIndex] >= taskRequirements[taskIndex])
            {
                workerStrengths[workerIndex] = -1;
                workerIndex++;
                completedTasks++;
            }
            else
            {
                if (scanningDown)
                {
                    while (pillWorkerPointer < workerStrengths.Length &&
                           (workerStrengths[pillWorkerPointer] == -1 || workerStrengths[pillWorkerPointer] + pillStrengthBoost >= taskRequirements[taskIndex]))
                    {
                        pillWorkerPointer++;
                    }

                    if (pillWorkerPointer == workerStrengths.Length)
                    {
                        scanningDown = false;
                        pillWorkerPointer = workerStrengths.Length - 1;
                    }
                }

                while (pillWorkerPointer >= workerStrengths.Length || 
                      (pillWorkerPointer > workerIndex && 
                      (workerStrengths[pillWorkerPointer] == -1 || workerStrengths[pillWorkerPointer] + pillStrengthBoost < taskRequirements[taskIndex])))
                {
                    pillWorkerPointer--;
                }

                if (pillQueue.Count >= availablePills && pillQueue.Count > 0 && pillQueue.Peek() >= taskRequirements[taskIndex])
                {
                    pillQueue.Dequeue();
                    completedTasks++;
                }
                else if (pillWorkerPointer >= 0 && workerStrengths[pillWorkerPointer] + pillStrengthBoost >= taskRequirements[taskIndex])
                {
                    pillQueue.Enqueue(workerStrengths[pillWorkerPointer], workerStrengths[pillWorkerPointer]);
                    workerStrengths[pillWorkerPointer] = -1;
                    pillWorkerPointer = scanningDown ? pillWorkerPointer - 1 : pillWorkerPointer + 1;
                }
                else if (pillQueue.Count > 0 && pillQueue.Peek() >= taskRequirements[taskIndex])
                {
                    pillQueue.Dequeue();
                    completedTasks++;
                }
            }

            taskIndex++;
            pillWorkerPointer = Math.Max(pillWorkerPointer, workerIndex);
        }

        return completedTasks + Math.Min(pillQueue.Count, availablePills);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Tasks You Can Assign");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}