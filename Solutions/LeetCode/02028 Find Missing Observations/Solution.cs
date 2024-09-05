// Find Missing Observations

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindMissingObservations
{
    public class Solution
    {
        public int[] MissingRolls(int[] rolls, int mean, int n)
        {
            int m = rolls.Length;
            int totalObservations = n + m;
            
            int totalSum = CalculateTotalSum(mean, totalObservations);

            int currentSum = CalculateCurrentSum(rolls);

            int missingSum = CalculateMissingSum(totalSum, currentSum);

            if (!IsValidMissingSum(missingSum, n)) return new int[] { };

            return GenerateMissingObservations(missingSum, n);
        }
        
        private int CalculateTotalSum(int mean, int totalObservations)
        {
            return mean * totalObservations;
        }
        
        private int CalculateCurrentSum(int[] rolls)
        {
            return rolls.Sum();
        }
        
        private int CalculateMissingSum(int totalSum, int currentSum)
        {
            return totalSum - currentSum;
        }

        private bool IsValidMissingSum(int missingSum, int n)
        {
            return missingSum >= n && missingSum <= 6 * n;
        }

        private int[] GenerateMissingObservations(int missingSum, int n)
        {
            int[] missingObservations = new int[n];
            int baseValue = missingSum / n;
            int remainingSum = missingSum % n;

            for (int i = 0; i < n; i++)
            {
                missingObservations[i] = baseValue;
            }

            for (int i = 0; i < remainingSum; i++)
            {
                missingObservations[i]++;
            }

            return missingObservations;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Missing Observations");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}