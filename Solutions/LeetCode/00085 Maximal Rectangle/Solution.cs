// Maximal Rectangle


using System;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximalRectangle
{
    public class Solution
    {
        public static int MaximalRectangle(char[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int result = 0;
            int[] heights = new int[cols];

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if(matrix[i][j] == '0')
                        heights[j] = 0;
                    else
                        heights[j]++;
                }

                result = Math.Max(result, FindRect(heights));
            }
            
            return result;
        }

        public static int FindRect(int[] heights)
        {
            int len = heights.Length;
            int result = 0;
            Stack<(int, int)> pillarIndex=new Stack<(int, int)>();

            for(int i = 0; i < len; i++)
            {
                int start = i;
                while(pillarIndex.Count > 0 && pillarIndex.Peek().Item1 > heights[i])
                {
                    var pillar = pillarIndex.Pop();
                    start = pillar.Item2;
                    result = Math.Max(result, pillar.Item1 * (i - pillar.Item2));
                }

                pillarIndex.Push((heights[i], start));
            }

            while(pillarIndex.Count > 0)
            {
                var pillar = pillarIndex.Pop();
                result = Math.Max(result, pillar.Item1 * (len - pillar.Item2));
            }

            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximal Rectangle");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}