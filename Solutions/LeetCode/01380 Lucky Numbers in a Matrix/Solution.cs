// Lucky Numbers in a Matrix


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LuckyNumbersinaMatrix
{
    public class Solution
    {
        public static IList<int> LuckyNumbers(int[][] matrix)
        {
            var minQ = from row in matrix select row.Min();
            var minS = minQ.ToHashSet();

            var result =
                from j in Enumerable.Range(0, matrix[0].Length)
                let column = from row in matrix select row[j]
                let max = column.Max()
                where minS.Contains(max)
                select max;

            return result.ToList();
        }
    }
    
    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1380");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}