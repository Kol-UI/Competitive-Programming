// Minimize Cost
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.MinimizeCost
{
    class Program
    {
        //static void Main()
        static void MainSolution()
        {
            //string[] input = Console.ReadLine().Split();
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            //long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
            long result = 0;
            int step = 1;

            for (int i = 0; i < n; i += step)
            {
                step = 1;
                result += Math.Abs(arr[i]);

                if (arr[i] > 0)
                {
                    for (step = 1; step <= k && i + step < n; step++)
                    {
                        if (arr[i + step] < 0)
                        {
                            result += arr[i + step];
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(Math.Abs(result));
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimize Cost");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.MediumHE);
        }
    }
}