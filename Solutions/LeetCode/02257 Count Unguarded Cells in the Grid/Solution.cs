// Count Unguarded Cells in the Grid
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountUnguardedCellsintheGrid
{
    public class Solution
    {
        public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
        {
            const int VISIBLE_CELL = 1;
            const int GUARD_CELL = 2;
            const int WALL_CELL = 3;
            var validCells = new HashSet<int>()
            { 
                0, VISIBLE_CELL 
            };

            var gridMatrix = new int[m][];
            for (int rowIndex = 0; rowIndex < m; rowIndex++)
                gridMatrix[rowIndex] = new int[n];

            for (int wallIndex = 0; wallIndex < walls.Length; wallIndex++)                   
                gridMatrix[walls[wallIndex][0]][walls[wallIndex][1]] = WALL_CELL;        

            for (int guardIndex = 0; guardIndex < guards.Length; guardIndex++)                    
                gridMatrix[guards[guardIndex][0]][guards[guardIndex][1]] = GUARD_CELL; 

            for (int guardIndex = 0; guardIndex < guards.Length; guardIndex++)
            {
                var guardX = guards[guardIndex][0];
                var guardY = guards[guardIndex][1];
                int distance = 1;

                while (guardY + distance < gridMatrix[0].Length && validCells.Contains(gridMatrix[guardX][guardY + distance]))
                {
                    gridMatrix[guardX][guardY + distance] = VISIBLE_CELL;
                    distance++;
                }

                distance = 1;
                while (guardX + distance < gridMatrix.Length && validCells.Contains(gridMatrix[guardX + distance][guardY]))
                {
                    gridMatrix[guardX + distance][guardY] = VISIBLE_CELL;
                    distance++;
                }

                distance = 1;
                while (guardY - distance >= 0 && validCells.Contains(gridMatrix[guardX][guardY - distance]))
                {
                    gridMatrix[guardX][guardY - distance] = VISIBLE_CELL;
                    distance++;
                }

                distance = 1;
                while (guardX - distance >= 0 && validCells.Contains(gridMatrix[guardX - distance][guardY]))
                {
                    gridMatrix[guardX - distance][guardY] = VISIBLE_CELL;
                    distance++;
                }
            }

            return gridMatrix.SelectMany(cell => cell).Count(cell => cell == 0);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            int m1 = 4;
            int n1 = 6;
            int[][] guards1 = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
                new int[] { 2, 3 }
            };
            int[][] walls1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 2, 2 },
                new int[] { 1, 4 }
            };

            int m2 = 3;
            int n2 = 3;
            int[][] guards2 = new int[][]
            {
                new int[] { 1, 1 }
            };
            int[][] walls2 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 2, 1 },
                new int[] { 1, 2 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.CountUnguarded(m1, n1, guards1, walls1), 7),
                ResultTester.CheckResult<int>(solution.CountUnguarded(m2, n2, guards2, walls2), 4)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Unguarded Cells in the Grid");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}