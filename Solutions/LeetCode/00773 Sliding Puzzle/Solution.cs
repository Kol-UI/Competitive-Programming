// Sliding Puzzle

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SlidingPuzzle
{
    public class Solution
    {
        public int SlidingPuzzle(int[][] board)
        {
            string goal = "123450";
            string initial = string.Join("", board[0]) + string.Join("", board[1]);
            if (initial == goal) return 0;

            int[][] moves = new int[][]
            {
                new int[] {1, 3},
                new int[] {0, 2, 4},
                new int[] {1, 5},
                new int[] {0, 4},
                new int[] {1, 3, 5},
                new int[] {2, 4}
            };

            Queue<string> states = new Queue<string>();
            HashSet<string> seen = new HashSet<string>();
            states.Enqueue(initial);
            seen.Add(initial);
            int depth = 0;

            while (states.Count > 0)
            {
                int count = states.Count;
                for (int i = 0; i < count; i++)
                {
                    string current = states.Dequeue();
                    if (current == goal) return depth;

                    int zeroIndex = current.IndexOf('0');
                    foreach (int next in moves[zeroIndex])
                    {
                        char[] swapped = current.ToCharArray();
                        swapped[zeroIndex] = swapped[next];
                        swapped[next] = '0';
                        string nextState = new string(swapped);

                        if (!seen.Contains(nextState))
                        {
                            seen.Add(nextState);
                            states.Enqueue(nextState);
                        }
                    }
                }
                depth++;
            }
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            int[][] array1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 0, 5 }
            };

            int[][] array2 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 5, 4, 0 }
            };

            int[][] array3 = new int[][]
            {
                new int[] { 4, 1, 2 },
                new int[] { 5, 0, 3 }
            };


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.SlidingPuzzle(array1), 1),
                ResultTester.CheckResult<int>(solution.SlidingPuzzle(array2), -1),                
                ResultTester.CheckResult<int>(solution.SlidingPuzzle(array3), 5),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sliding Puzzle");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}