// Little Nikita

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.LittleNikita
{
    public class Program
    {
        //Main(string[] args)
        public static void Solution()
        {
            int t = int.Parse(Console.ReadLine()!);
            var results = new List<string>();

            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);

                if (n >= m && (n - m) % 2 == 0)
                {
                    results.Add("Yes");
                }
                else
                {
                    results.Add("No");
                }
            }

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Little Nikita");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}