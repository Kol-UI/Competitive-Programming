// Finding 3-Digit Even Numbers
namespace CompetitiveProgramming.LeetCode.Finding3DigitEvenNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] FindEvenNumbers(int[] digits)
    {
        var uniqueEvenNumbers = new HashSet<int>();
        int n = digits.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (i != j && j != k && i != k)
                    {
                        int num = digits[i] * 100 + digits[j] * 10 + digits[k];
                        if (digits[i] != 0 && digits[k] % 2 == 0)
                        {
                            uniqueEvenNumbers.Add(num);
                        }
                    }
                }
            }
        }

        return uniqueEvenNumbers.OrderBy(x => x).ToArray();
    }

}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Finding 3-Digit Even Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}