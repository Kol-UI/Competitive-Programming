// Champagne Tower

/*
We stack glasses in a pyramid, where the first row has 1 glass, the second row has 2 glasses, and so on until the 100th row.  Each glass holds one cup of champagne.

Then, some champagne is poured into the first glass at the top.  When the topmost glass is full, any excess liquid poured will fall equally to the glass immediately to the left and right of it.  When those glasses become full, any excess champagne will fall equally to the left and right of those glasses, and so on.  (A glass at the bottom row has its excess champagne fall on the floor.)

For example, after one cup of champagne is poured, the top most glass is full.  After two cups of champagne are poured, the two glasses on the second row are half full.  After three cups of champagne are poured, those two cups become full - there are 3 full glasses total now.  After four cups of champagne are poured, the third row has the middle glass half full, and the two outside glasses are a quarter full, as pictured below.



Now after pouring some non-negative integer cups of champagne, return how full the jth glass in the ith row is (both i and j are 0-indexed.)

 

Example 1:

Input: poured = 1, query_row = 1, query_glass = 1
Output: 0.00000
Explanation: We poured 1 cup of champange to the top glass of the tower (which is indexed as (0, 0)). There will be no excess liquid so all the glasses under the top glass will remain empty.

Example 2:

Input: poured = 2, query_row = 1, query_glass = 1
Output: 0.50000
Explanation: We poured 2 cups of champange to the top glass of the tower (which is indexed as (0, 0)). There is one cup of excess liquid. The glass indexed as (1, 0) and the glass indexed as (1, 1) will share the excess liquid equally, and each will get half cup of champange.

Example 3:

Input: poured = 100000009, query_row = 33, query_glass = 17
Output: 1.00000
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ChampagneTower
{
    public class Solution
    {
        public static double ChampagneTower(int poured, int query_row, int query_glass)
        {
            double[,] T = new double[query_row + 1, query_row + 1];

            T[0, 0] = poured;
            
            for (int i = 1; i <= query_row; i++)
            {
                if (T[i-1, 0] > 1)
                {
                    T[i, 0] = (T[i-1, 0] - 1) / 2;
                }
                if (T[i-1, i-1] > 1)
                {
                    T[i, i] = (T[i-1, i-1] - 1) / 2;
                }
            }

            for (int i = 2; i <= query_row; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    for (int k = 0; k <= 1; k++)
                    {
                        if (T[i-1, j-k] > 1)
                        {
                            T[i, j] += (T[i-1, j-k] - 1) / 2;
                        }
                    }
                }
            }
            return Math.Min(1, T[query_row, query_glass]);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(Solution.ChampagneTower(1, 1, 1), 0.00000),
                ResultTester.CheckResult<double>(Solution.ChampagneTower(2, 1, 1), 0.50000),
                ResultTester.CheckResult<double>(Solution.ChampagneTower(100000009, 33, 17), 1.00000),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Champagne Tower");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}