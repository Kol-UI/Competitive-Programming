// Knight Probability in Chessboard

/*
On an n x n chessboard, a knight starts at the cell (row, column) and attempts to make exactly k moves. The rows and columns are 0-indexed, so the top-left cell is (0, 0), and the bottom-right cell is (n - 1, n - 1).

A chess knight has eight possible moves it can make, as illustrated below. Each move is two cells in a cardinal direction, then one cell in an orthogonal direction.


Each time the knight is to move, it chooses one of eight possible moves uniformly at random (even if the piece would go off the chessboard) and moves there.

The knight continues moving until it has made exactly k moves or has moved off the chessboard.

Return the probability that the knight remains on the board after it has stopped moving.

 

Example 1:

Input: n = 3, k = 2, row = 0, column = 0
Output: 0.06250
Explanation: There are two moves (to (1,2), (2,1)) that will keep the knight on the board.
From each of those positions, there are also two moves that will keep the knight on the board.
The total probability the knight stays on the board is 0.0625.


Example 2:

Input: n = 1, k = 0, row = 0, column = 0
Output: 1.00000
*/

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KnightProbabilityinChessboard
{
    public class Solution
    {
        private static (int, int)[] knightMove = new (int, int)[] {(-2, -1), (-2, 1), (-1, -2), (-1, 2), (1, -2), (1, 2), (2, -1), (2, 1)};

        public static double KnightProbability(int n, int k, int row, int column)
        {
            double[,] current = new double[n, n];
            current[row, column] = 1;

            for (int move = 0; move < k; move++)
            {
                current = NextMove(current, n);
            }
            
            return SumProbability(current);
        }

        private static double[,] NextMove(double[,] previous, int n)
        {
            double[,] current = new double[n, n];
            int newR;
            int newC;

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (previous[r, c] == 0)
                    {
                        continue;
                    }

                    foreach ((int R, int C) move in knightMove)
                    {
                        newR = r + move.R;
                        newC = c + move.C;

                        if (CheckValidMove(n, newR, newC))
                        {
                            current[newR, newC] += previous[r, c] / 8;
                        }
                    }
                }
            }
            return current;
        }

        private static bool CheckValidMove(int n, int r, int c)
        {
            if (r >= 0 && r < n && c >= 0 && c < n)
            {
                return true;
            }
            return false;
        }

        private static double SumProbability(double[,] arr)
        {
            double sum = 0;
            foreach (double num in arr)
            {
                sum += num;
            }
            return sum;
        }
    }

    public class Test
    {
        public static bool[] TestKnightProbabilityinChessboard()
        {
            int n1 = 3;
            int k1 = 2;
            int row1 = 0;
            int column1 = 0;
            int n2 = 1;
            int k2 = 0;
            int row2 = 0;
            int column2 = 0;

            double result1 = Solution.KnightProbability(n1, k1, row1, column1);
            double result2 = Solution.KnightProbability(n2, k2, row2, column2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(result1, 0.06250),
                ResultTester.CheckResult<double>(result2, 1.00000)
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Knight Probability in Chessboard");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestKnightProbabilityinChessboard());
        }
    }
}