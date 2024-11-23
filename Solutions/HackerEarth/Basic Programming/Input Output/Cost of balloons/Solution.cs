// Cost of balloons
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.Costofballoons
{
    class Solution
    {
        //static void Main()
        static void MainSolution()
        {
            int testCases = int.Parse(Console.ReadLine()!);

            for (int t = 0; t < testCases; t++)
            {
                var inputs = Console.ReadLine()!.Split(' ');
                int p = int.Parse(inputs[0]);
                int g = int.Parse(inputs[1]);

                int n = int.Parse(Console.ReadLine()!);

                int cost = 0;

                int lower = Math.Min(p, g);
                int maximum = Math.Max(p, g);

                int p1Total = 0;
                int p2Total = 0;

                for (int i = 0; i < n; i++)
                {
                    var pair = Console.ReadLine()!.Split(' ');
                    int p1 = int.Parse(pair[0]);
                    int p2 = int.Parse(pair[1]);

                    p1Total += p1;
                    p2Total += p2;
                }

                if (p1Total >= p2Total)
                {
                    cost += p1Total * lower;
                    cost += p2Total * maximum;
                }
                else
                {
                    cost += p2Total * lower;
                    cost += p1Total * maximum;
                }

                Console.WriteLine(cost);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Cost of balloons");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}