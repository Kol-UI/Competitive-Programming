// Lexicographical Numbers

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LexicographicalNumbers
{
    public class Solution
    {
        public IList<int> LexicalOrder(int n)
        {
            List<int> result = new List<int>();
            GenerateLexicalOrder(result, n);
            return result;
        }

        private void GenerateLexicalOrder(List<int> result, int n)
        {
            for (int i = 1; i <= 9; i++)
            {
                if (i > n) break;
                DFS(result, i, n);
            }
        }

        private void DFS(List<int> result, int current, int n)
        {
            if (current > n) return;
            result.Add(current);
            for (int i = 0; i <= 9; i++)
            {
                int next = current * 10 + i;
                if (next > n) break;
                DFS(result, next, n);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lexicographical Numbers");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}