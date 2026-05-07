// Unique 3-Digit Even Numbers
namespace CompetitiveProgramming.LeetCode.Unique3DigitEvenNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int TotalNumbers(int[] digits)
    {
        var set = new HashSet<int>();

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0)
                continue;

            for (int j = 0; j < digits.Length; j++)
            {
                if (j == i)
                    continue;

                for (int k = 0; k < digits.Length; k++)
                {
                    if (k == j || k == i || digits[k] % 2 != 0)
                        continue;

                    var num = digits[i] * 100 + digits[j] * 10 + digits[k];
                    set.Add(num);
                }
            }
        }

        return set.Count();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.TotalNumbers([1,2,3,4]), 12),
            ResultTester.CheckResult<int>(solution.TotalNumbers([0,2,2]), 2),
            ResultTester.CheckResult<int>(solution.TotalNumbers([6,6,6]), 1),
            ResultTester.CheckResult<int>(solution.TotalNumbers([1,3,5]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Unique 3-Digit Even Numbers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}