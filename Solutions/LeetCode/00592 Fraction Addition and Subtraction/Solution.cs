// Fraction Addition and Subtraction

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FractionAdditionandSubtraction
{
    public class Solution
    {
        public string FractionAddition(string expression)
        {
            var numerators = new List<int>();
            var denominators = new List<int>();

            for (int i = 0; i < expression.Length;)
            {
                int sign = expression[i] == '-' ? -1 : 1;
                if (expression[i] == '-' || expression[i] == '+') i++;

                int numerator = ParseInteger(expression, ref i);
                i++;
                int denominator = ParseInteger(expression, ref i);

                numerators.Add(sign * numerator);
                denominators.Add(denominator);
            }

            int commonDenominator = denominators.Aggregate(1, (acc, denom) => Lcm(acc, denom));
            int totalNumerator = numerators.Select((num, index) => num * (commonDenominator / denominators[index])).Sum();

            int gcdValue = Gcd(Math.Abs(totalNumerator), commonDenominator);
            return $"{totalNumerator / gcdValue}/{commonDenominator / gcdValue}";
        }

        private int ParseInteger(string expression, ref int index)
        {
            int number = 0;
            while (index < expression.Length && char.IsDigit(expression[index]))
            {
                number = number * 10 + (expression[index] - '0');
                index++;
            }
            return number;
        }

        private int Gcd(int a, int b) => b == 0 ? a : Gcd(b, a % b);

        private int Lcm(int a, int b) => a / Gcd(a, b) * b;
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fraction Addition and Subtraction");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}