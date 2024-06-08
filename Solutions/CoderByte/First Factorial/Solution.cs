using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CoderByte.FirstFactorial
{
    public class Solution
    {
        // Have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it.
        // For example: if num = 4, then your program should return (4 * 3 * 2 * 1) = 24.
        // For the test cases, the range will be between 1 and 18 and the input will always be an integer.

        // Examples
        // Input: 4
        // Output: 24
        // Input: 8
        // Output: 40320

        public static int FirstFactorial(int num)
        {
            if (num == 1)
                return 1;
            return num * FirstFactorial(--num);
        }
    }

    public class Test
    {
        public static bool[] TestFirstFactorial()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FirstFactorial(4), 24),
                ResultTester.CheckResult<int>(Solution.FirstFactorial(8), 40320),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("First Factorial");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CoderByte, ProblemCategory.EasyCBy, Test.TestFirstFactorial());
        }
    }
}