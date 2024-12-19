// Max Chunks To Make Sorted

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaxChunksToMakeSorted
{
    public class Solution
    {
        public int MaxChunksToSorted(int[] arr)
        {
            Stack<int> monotonicStack = new Stack<int>();

            foreach (int num in arr)
            {
                if (monotonicStack.Count == 0 || num >= monotonicStack.Peek())
                {
                    monotonicStack.Push(num);
                }
                else
                {
                    int maxInChunk = monotonicStack.Pop();
                    while (monotonicStack.Count > 0 && monotonicStack.Peek() > num)
                    {
                        monotonicStack.Pop();
                    }
                    monotonicStack.Push(maxInChunk);
                }
            }

            return monotonicStack.Count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MaxChunksToSorted(new int[]{4,3,2,1,0}), 1),
                ResultTester.CheckResult<int>(solution.MaxChunksToSorted(new int[]{1,0,2,3,4}), 4),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Chunks To Make Sorted");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}