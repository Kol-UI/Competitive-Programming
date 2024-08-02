// Open the Lock

/*
You have a lock in front of you with 4 circular wheels. Each wheel has 10 slots: '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'. The wheels can rotate freely and wrap around: for example we can turn '9' to be '0', or '0' to be '9'. Each move consists of turning one wheel one slot.

The lock initially starts at '0000', a string representing the state of the 4 wheels.

You are given a list of deadends dead ends, meaning if the lock displays any of these codes, the wheels of the lock will stop turning and you will be unable to open it.

Given a target representing the value of the wheels that will unlock the lock, return the minimum total number of turns required to open the lock, or -1 if it is impossible.

 

Example 1:

Input: deadends = ["0201","0101","0102","1212","2002"], target = "0202"
Output: 6
Explanation: 
A sequence of valid moves would be "0000" -> "1000" -> "1100" -> "1200" -> "1201" -> "1202" -> "0202".
Note that a sequence like "0000" -> "0001" -> "0002" -> "0102" -> "0202" would be invalid,
because the wheels of the lock become stuck after the display becomes the dead end "0102".

Example 2:

Input: deadends = ["8888"], target = "0009"
Output: 1
Explanation: We can turn the last wheel in reverse to move from "0000" -> "0009".

Example 3:

Input: deadends = ["8887","8889","8878","8898","8788","8988","7888","9888"], target = "8888"
Output: -1
Explanation: We cannot reach the target without getting stuck.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.OpentheLock
{
    public class Solution
    {
        public static int OpenLock(string[] deadends, string target)
        {
            var visited = new HashSet<int>();
            int targetNum = int.Parse(target);
            var deadendsNum = deadends.Select(int.Parse).ToHashSet();

            var queue = new Queue<(int, int)>();
            queue.Enqueue((0, 0));

            while (queue.Any())
            {
                (int num, int level) = queue.Dequeue();

                if (num == targetNum)
                {
                    return level;
                }

                if (visited.Contains(num)) continue;
                if (deadendsNum.Contains(num)) continue;

                visited.Add(num);

                foreach (int neighbour in WheelHelper.GetNeighbours(num))
                {
                    queue.Enqueue((neighbour, level + 1));
                }
            }

            return -1;
        }
    }

    public static class WheelHelper
    {
        private const int Size = 4;
        private const string StringFormat = "0000";

        public static IEnumerable<int> GetNeighbours(int x)
        {
            var digits = Destruct(x);
            var output = new int[Size];

            for (int i = 0; i < Size; i++)
            {
                Rewrite(digits, output);

                output[i] = output[i] == 9 ? 0 : output[i] + 1;

                yield return Construct(output);
            }

            for (int i = 0; i < Size; i++)
            {
                Rewrite(digits, output);

                output[i] = output[i] == 0 ? 9 : output[i] - 1;

                yield return Construct(output);
            }
        }

        public static int[] Destruct(int x)
        {
            return x.ToString(StringFormat).Select(c => c - '0').ToArray();
        }

        public static int Construct(int[] copy)
        {
            return copy
                .Select((x, i) => x * (int)Math.Pow(10, Size - i - 1))
                .Aggregate((x, y) => x + y);
        }

        private static void Rewrite(int[] src, int[] dest)
        {
            for (int i = 0; i < src.Length; i++)
            {
                dest[i] = src[i];
            }
        }
    }

    public class Test
    {
        public static bool[] TestOpentheLock()
        {
            string[] deadends1 = {"0201","0101","0102","1212","2002"};
            string target1 = "0202";
            string[] deadends2 = {"8888"};
            string target2 = "0009";
            string[] deadends3 = {"8887","8889","8878","8898","8788","8988","7888","9888"};
            string target3 = "8888";
            int result1 = Solution.OpenLock(deadends1, target1);
            int result2 = Solution.OpenLock(deadends2, target2);
            int result3 = Solution.OpenLock(deadends3, target3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 6),
                ResultTester.CheckResult<int>(result2, 1),
                ResultTester.CheckResult<int>(result3, -1)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Open the Lock");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestOpentheLock());
        }
    }
}