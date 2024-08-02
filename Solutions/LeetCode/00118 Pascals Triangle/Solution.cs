using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PascalsTriangle
{
    // Given an integer numRows, return the first numRows of Pascal's triangle.
    // Example 1:

    // Input: numRows = 5
    // Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
    
    // Example 2:

    // Input: numRows = 1
    // Output: [[1]]
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var rs = new List<IList<int>>{new List<int>{1}};
            for (int i = 2; i <= numRows; i++)
            {
                var list = new List<int>{1};
                for (int j = 1; j < i - 1; j++)
                {
                    list.Add(rs[rs.Count - 1][j - 1] + rs[rs.Count - 1][j]);
                }
                list.Add(1);
                rs.Add(list);
            }
            return rs;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pascals Triangle");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}