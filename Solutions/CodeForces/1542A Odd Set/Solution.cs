// Odd Set

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.OddSet
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine()!);
            
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine()!);
                int c = 0;
                string[] inputs = Console.ReadLine()!.Split();
                for (int i = 0; i < 2 * n; i++)
                {
                    int x = int.Parse(inputs[i]);
                    c += (x % 2);
                }
                Console.WriteLine(c == n ? "Yes" : "No");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Odd Set");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}