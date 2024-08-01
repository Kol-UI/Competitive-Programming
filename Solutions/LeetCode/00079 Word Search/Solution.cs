// Word Search

/*
Given an m x n grid of characters board and a string word, return true if word exists in the grid.

The word can be constructed from letters of sequentially adjacent cells, where adjacent cells are horizontally or vertically neighboring. The same letter cell may not be used more than once.

 

Example 1:


Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
Output: true


Example 2:


Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "SEE"
Output: true


Example 3:


Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCB"
Output: false
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.WordSearch
{
    public class Solution 
    {
        public static bool Exist(char[][] board, string word)
        {
            int m = board.Length;
            int n = board[0].Length;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (Dfs(i, j, 0))
                        return true;
            return false;

            bool Dfs(int i, int j, int start)
            {
                if (start == word.Length)
                    return true;
                if (i < 0 || i >= m || j < 0 || j >= n || board[i][j] != word[start])
                    return false;

                char c = board[i][j];
                board[i][j] = '~';

                bool result = Dfs(i + 1, j, start + 1) || Dfs(i - 1, j, start + 1) || Dfs(i, j + 1, start + 1) || Dfs(i, j - 1, start + 1);
                
                board[i][j] = c;
                return result;
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            char[][] board = new char[][]
            {
                new char[] {'A', 'B', 'C', 'E'},
                new char[] {'S', 'F', 'C', 'S'},
                new char[] {'A', 'D', 'E', 'E'}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.Exist(board, "ABCCED"), true),
                ResultTester.CheckResult<bool>(Solution.Exist(board, "SEE"), true),
                ResultTester.CheckResult<bool>(Solution.Exist(board, "ABCB"), false),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Search");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}