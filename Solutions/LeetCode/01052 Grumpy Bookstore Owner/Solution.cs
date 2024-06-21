// Grumpy Bookstore Owner

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.GrumpyBookstoreOwner
{
    public class Solution
    {
        public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {
            int n = customers.Length;
            int satisfiedCustomers = 0;
            
            for (int i = 0; i < n; i++) {
                if (grumpy[i] == 0) {
                    satisfiedCustomers += customers[i];
                }
            }

            int[] grumpyPrefixSum = new int[n + 1];
            for (int i = 0; i < n; i++) {
                grumpyPrefixSum[i + 1] = grumpyPrefixSum[i];
                if (grumpy[i] == 1) {
                    grumpyPrefixSum[i + 1] += customers[i];
                }
            }

            int maxAdditionalSatisfied = 0;
            for (int i = 0; i <= n - minutes; i++) {
                int end = i + minutes;
                int additionalSatisfied = grumpyPrefixSum[end] - grumpyPrefixSum[i];
                maxAdditionalSatisfied = Math.Max(maxAdditionalSatisfied, additionalSatisfied);
            }

            return satisfiedCustomers + maxAdditionalSatisfied;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Grumpy Bookstore Owner");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}