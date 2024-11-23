// Rotating the Box

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RotatingtheBox
{
    public class Solution
    {
        public char[][] RotateTheBox(char[][] box)
        {
            int rows = box.Length;
            int cols = box[0].Length;

            ApplyGravity(box);
            char[][] rotatedBox = InitializeRotatedBox(rows, cols);
            PerformRotation(box, rotatedBox);

            return rotatedBox;
        }

        private char[][] InitializeRotatedBox(int rows, int cols)
        {
            char[][] rotatedBox = new char[cols][];
            for (int i = 0; i < cols; i++)
            {
                rotatedBox[i] = new char[rows];
            }
            return rotatedBox;
        }

        private void ApplyGravity(char[][] box)
        {
            int rows = box.Length;
            int cols = box[0].Length;

            for (int i = 0; i < rows; i++)
            {
                int emptyIndex = cols - 1;
                for (int j = cols - 1; j >= 0; j--)
                {
                    if (box[i][j] == '#')
                    {
                        box[i][j] = '.';
                        box[i][emptyIndex] = '#';
                        emptyIndex--;
                    }
                    else if (box[i][j] == '*')
                    {
                        emptyIndex = j - 1;
                    }
                }
            }
        }

        private void PerformRotation(char[][] box, char[][] rotatedBox)
        {
            int rows = box.Length;
            int cols = box[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    rotatedBox[j][rows - 1 - i] = box[i][j];
                }
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            char[][] box1 = new char[][]
            {
                new char[] { '#', '.', '#' }
            };

            char[][] expected1 = new char[][]
            {
                new char[] { '.' },
                new char[] { '#' },
                new char[] { '#' }
            };

            char[][] box2 = new char[][]
            {
                new char[] { '#', '.', '*', '.' },
                new char[] { '#', '#', '*', '.' }
            };

            char[][] expected2 = new char[][]
            {
                new char[] { '#', '.' },
                new char[] { '#', '#' },
                new char[] { '*', '*' },
                new char[] { '.', '.' }
            };

            char[][] box3 = new char[][]
            {
                new char[] { '#', '#', '*', '.', '*', '.' },
                new char[] { '#', '#', '#', '*', '.', '.' },
                new char[] { '#', '#', '#', '.', '#', '.' }
            };

            char[][] expected3 = new char[][]
            {
                new char[] { '.', '#', '#' },
                new char[] { '.', '#', '#' },
                new char[] { '#', '#', '*' },
                new char[] { '#', '*', '.' },
                new char[] { '#', '.', '*' },
                new char[] { '#', '.', '.' }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<char[][]>(solution.RotateTheBox(box1), expected1),
                ResultTester.CheckResult<char[][]>(solution.RotateTheBox(box2), expected2),
                ResultTester.CheckResult<char[][]>(solution.RotateTheBox(box3), expected3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rotating the Box");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}