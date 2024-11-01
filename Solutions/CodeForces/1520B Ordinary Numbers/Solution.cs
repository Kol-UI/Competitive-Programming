// Ordinary Numbers
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.OrdinaryNumbers
{
    public class OrdinaryNumbers
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int testCases = int.Parse(Console.ReadLine()!);

            while (testCases-- > 0)
            {
                long n = long.Parse(Console.ReadLine()!);
                int baseNumber = 1;
                int result = 0;

                for (long i = 10; i <= n; i *= 10)
                {
                    int target = (int)(i - 1);
                    result += target / baseNumber;
                    baseNumber = baseNumber * 10 + 1;
                }

                result += (int)(n / baseNumber);
                Console.WriteLine(result);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ordinary Numbers");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}