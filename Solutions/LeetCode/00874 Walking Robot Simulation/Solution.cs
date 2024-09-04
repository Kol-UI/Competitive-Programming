// Walking Robot Simulation

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.WalkingRobotSimulation
{
    public class Solution
    {
        private const int ClockwiseStep = 1;
        private const int AntiClockwiseStep = 3;

        public int RobotSim(int[] commands, int[][] obstacles)
        {
            int x = 0, y = 0, direction = 0;
            int maxDistanceSquared = 0;

            var obstacleSet = InitializeObstacles(obstacles);
            var directions = InitializeDirections();

            foreach (var command in commands)
            {
                if (command == -1)
                {
                    direction = TurnRight(direction);
                }
                else if (command == -2)
                {
                    direction = TurnLeft(direction);
                }
                else
                {
                    (x, y, maxDistanceSquared) = MoveForward(x, y, direction, command, directions, obstacleSet, maxDistanceSquared);
                }
            }

            return maxDistanceSquared;
        }

        private static HashSet<(int, int)> InitializeObstacles(int[][] obstacles)
        {
            var obstacleSet = new HashSet<(int, int)>();
            foreach (var obstacle in obstacles)
            {
                obstacleSet.Add((obstacle[0], obstacle[1]));
            }
            return obstacleSet;
        }

        private static (int, int)[] InitializeDirections()
        {
            return new (int, int)[]
            {
                (0, 1),
                (1, 0),
                (0, -1),
                (-1, 0)
            };
        }

        private static int TurnRight(int currentDirection)
        {
            return (currentDirection + ClockwiseStep) % 4;
        }

        private static int TurnLeft(int currentDirection)
        {
            return (currentDirection + AntiClockwiseStep) % 4;
        }

        private (int, int, int) MoveForward(int x, int y, int direction, int steps, (int, int)[] directions, HashSet<(int, int)> obstacleSet, int maxDistanceSquared)
        {
            for (int i = 0; i < steps; i++)
            {
                int newX = x + directions[direction].Item1;
                int newY = y + directions[direction].Item2;

                if (obstacleSet.Contains((newX, newY)))
                {
                    break;
                }

                x = newX;
                y = newY;
                maxDistanceSquared = CalculateMaxDistance(x, y, maxDistanceSquared);
            }

            return (x, y, maxDistanceSquared);
        }

        private static int CalculateMaxDistance(int x, int y, int currentMaxDistanceSquared)
        {
            int distanceSquared = x * x + y * y;
            return Math.Max(currentMaxDistanceSquared, distanceSquared);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Walking Robot Simulation");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}