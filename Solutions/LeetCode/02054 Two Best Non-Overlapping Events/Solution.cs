// Two Best Non-Overlapping Events

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TwoBestNonOverlappingEvents
{
    public class Solution
    {
        private int FindNextEventIndex(int[][] events, int endTime)
        {
            int left = 0;
            int right = events.Length;

            while (right - left > 1)
            {
                int middle = left + (right - left) / 2;

                if (events[middle][0] > endTime)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
            }

            return right;
        }

        public int MaxTwoEvents(int[][] events)
        {
            int numberOfEvents = events.Length;
            Array.Sort(events, (int[] eventA, int[] eventB) => eventA[0].CompareTo(eventB[0]));

            int[] maxValueFromSuffix = new int[numberOfEvents + 1];

            for (int i = numberOfEvents - 1; i >= 0; i--)
            {
                maxValueFromSuffix[i] = Math.Max(maxValueFromSuffix[i + 1], events[i][2]);
            }

            int maxTotalValue = 0;

            for (int i = 0; i < numberOfEvents; i++)
            {
                int nextEventIndex = FindNextEventIndex(events, events[i][1]);
                maxTotalValue = Math.Max(maxTotalValue, events[i][2] + maxValueFromSuffix[nextEventIndex]);
            }

            return maxTotalValue;
        }
    }

    public class Test
    {
        public static int[][] GenerateRandomEvents(int numberOfEvents)
        {
            Random random = new Random();
            int[][] events = new int[numberOfEvents][];

            for (int i = 0; i < numberOfEvents; i++)
            {
                int startTime = random.Next(1, 1000);
                int endTime = random.Next(startTime, startTime + random.Next(1, 50));
                int value = random.Next(1, 1000);

                events[i] = new int[] { startTime, endTime, value };
            }

            return events;
        }
        
        public static bool[] TestCases()
        {
            Solution solution = new();

            int[][] events1 = new int[][]
            {
                new int[] { 1, 3, 2 },
                new int[] { 4, 5, 2 },
                new int[] { 2, 4, 3 }
            };

            int[][] events2 = new int[][]
            {
                new int[] { 1, 3, 2 },
                new int[] { 4, 5, 2 },
                new int[] { 1, 5, 5 }
            };

            int[][] events3 = new int[][]
            {
                new int[] { 1, 5, 3 },
                new int[] { 1, 5, 1 },
                new int[] { 6, 6, 5 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MaxTwoEvents(events1), 4),
                ResultTester.CheckResult<int>(solution.MaxTwoEvents(events2), 5),
                ResultTester.CheckResult<int>(solution.MaxTwoEvents(events3), 8)
            };

            List<int[][]> tests = new();
            for(int i = 3; i < 503; i++)
            {
                tests.Add(GenerateRandomEvents(i));
            }
            foreach(int[][] values in tests)
            {
                results.Append(ResultTester.CheckResult<int>(solution.MaxTwoEvents(values),solution.MaxTwoEvents(values)));
            }

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two Best Non-Overlapping Events");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}