// Calculate Amount Paid in Taxes

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CalculateAmountPaidinTaxes
{
    public class Solution
    {
        public double CalculateTax(int[][] brackets, int income)
        {
            var bracketsWithBase = brackets.Prepend(new[] { 0, 0 });
            double totalTax = 0;

            foreach (var (previousBracket, currentBracket) in bracketsWithBase.Zip(brackets))
            {
                int lowerLimit = previousBracket[0];
                int upperLimit = currentBracket[0];
                int taxRate = currentBracket[1];

                int taxableIncome = Math.Max(0, Math.Min(income, upperLimit) - lowerLimit);
                totalTax += taxableIncome * (taxRate / 100.0);
            }

            return totalTax;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculate Amount Paid in Taxes");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}