// Fraction to Recurring Decimal
namespace CompetitiveProgramming.LeetCode.FractiontoRecurringDecimal;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string FractionToDecimal(int numerator, int denominator)
    {
        var sb = new StringBuilder();

        if (numerator < 0 ^ denominator < 0 && numerator != 0) 
            sb.Append('-');

        long n = Math.Abs((long)numerator);
        long d = Math.Abs((long)denominator);            

        sb.Append(n / d);

        n = n % d;

        if (n != 0)
        {
            sb.Append('.');

            var f2Pos = new Dictionary<long, int>();

            while (n != 0 && !f2Pos.ContainsKey(n))
            {
                f2Pos.Add(n,  sb.Length);

                n = n * 10;

                sb.Append(n / d);

                n = n % d;
            }

            if (f2Pos.ContainsKey(n))
            {
                sb.Insert(f2Pos[n], '(').Append(')');
            }
        }

        return sb.ToString();
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fraction to Recurring Decimal");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}