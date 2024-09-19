// Different Ways to Add Parentheses

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DifferentWaystoAddParentheses
{
    public class Solution
    {
        public IList<int> DiffWaysToCompute(string expression)
        {
            return ComputeWays(expression);
        }

        private IList<int> ComputeWays(string expression)
        {
            IList<int> results = new List<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (IsOperator(c))
                {
                    IList<int> leftResults = ComputeWays(expression.Substring(0, i));
                    IList<int> rightResults = ComputeWays(expression.Substring(i + 1));

                    foreach (int left in leftResults)
                    {
                        foreach (int right in rightResults)
                        {
                            results.Add(ApplyOperation(left, right, c));
                        }
                    }
                }
            }

            if (results.Count == 0)
            {
                results.Add(int.Parse(expression));
            }

            return results;
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*';
        }

        private int ApplyOperation(int left, int right, char op)
        {
            switch (op)
            {
                case '+': return left + right;
                case '-': return left - right;
                case '*': return left * right;
                default: throw new InvalidOperationException("Not valid");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Different Ways to Add Parentheses");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}