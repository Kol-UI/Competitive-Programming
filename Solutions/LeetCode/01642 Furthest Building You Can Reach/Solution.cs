// Furthest Building You Can Reach


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FurthestBuildingYouCanReach
{
    public class Solution
    {
        public static int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            PriorityQueue<int, int> priorityQueue = new();
            for (int index = 0; index < heights.Length - 1; index++)
            {
                int heightDifference = heights[index + 1] - heights[index];
                if (heightDifference <= 0) continue;
                bricks -= heightDifference;
                priorityQueue.Enqueue(heightDifference, -heightDifference);

                if (bricks < 0)
                {
                    if (ladders == 0) return index;
                    bricks += priorityQueue.Dequeue();
                    ladders--;
                }
            }

            return heights.Length - 1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FurthestBuilding(new int[]{4,2,7,6,9,14,12}, 5, 1), 4),
                ResultTester.CheckResult<int>(Solution.FurthestBuilding(new int[]{4,12,2,7,3,18,20,3,19}, 10, 2), 7),
                ResultTester.CheckResult<int>(Solution.FurthestBuilding(new int[]{14,3,19,3}, 17, 0), 3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Furthest Building You Can Reach");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}