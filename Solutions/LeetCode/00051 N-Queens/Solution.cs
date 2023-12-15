// N-Queens

/*
The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.

Given an integer n, return all distinct solutions to the n-queens puzzle. You may return the answer in any order.

Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space, respectively.

 

Example 1:


Input: n = 4
Output: [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]
Explanation: There exist two distinct solutions to the 4-queens puzzle as shown above
Example 2:

Input: n = 1
Output: [["Q"]]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NQueens
{
    public class Solution
    {
        public static IList<IList<string>> SolveNQueens(int n)
        {
            string str = new string('.', n);
            Console.WriteLine(str);
            List<IList<string>> ls = new List<IList<string>>();
            List<string> board = new List<string>();

            for(int i = 0; i < n; i++)
            {
                board.Add(str);
            }

            Solve(0, ls, n, board);
            return ls;          

        }
        private static bool Issafe(int r,int c,List<string> board,int n)
        {
            int dc = c;
            int dr = r;

            while(r >= 0 && c >= 0)
            {
                if(board[r][c]=='Q') return false;
                r--;
                c--;
            }

            c = dc;
            r = dr;

            while(c >= 0)
            {
                if(board[r][c]=='Q') return false;
                c--;
            }

            c = dc;
            r = dr;

            while(r < n && c >= 0)
            {
                if(board[r][c]=='Q') return false;
                r++;
                c--;
            }

            return true;
        }

        public static void Solve(int col, List<IList<string>> ls,int n,List<string> b)
        {
            if(col == n)
            {
                ls.Add(new List<string>(b)); return ;
            }

            for(int row = 0; row < n; row++)
            {
                if(Issafe(row,col,b,n))
                {
                        var chars= b[row].ToCharArray();
                        chars[col]='Q';
                        b[row] = new string(chars);
                        Solve(col + 1, ls, n, b);
                        chars[col]='.';
                        b[row] = new string(chars);
                }
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            IList<IList<string>> expected1 = new List<IList<string>>
            {
                new List<string> { "..Q.", "Q...", "...Q", ".Q.." },
                new List<string> { ".Q..", "...Q", "Q...", "..Q." }
            };

            List<IList<string>> expected2 = new List<IList<string>>
            {
                new List<string> { "Q" }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<string>>>(Solution.SolveNQueens(4), expected1),
                ResultTester.CheckResult<IList<IList<string>>>(Solution.SolveNQueens(1), expected2),
            };
            return results;
        }
    }
}