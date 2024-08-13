// Count Square Sum Triples

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountSquareSumTriples
{
    public class Solution
    {
        public int CountTriples(int n)
        {
            int[] squares = new int[n + 1];
            int tripleCount = 0;

            for (int i = 0; i <= n; i++)
            {
                squares[i] = i * i;
            }

            HashSet<int> squaresSet = new(squares);

            for (int i = 1; i <= n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    int sumOfSquares = squares[i] + squares[j];
                    
                    if (squaresSet.Contains(sumOfSquares))
                    {
                        tripleCount += 2;
                    }
                }
            }

            return tripleCount;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Square Sum Triples");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}