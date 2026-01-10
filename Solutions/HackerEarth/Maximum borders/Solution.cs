// Maximum borders

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.Maximumborders
{
    class MaximumBorders
    {
        // static void Main()
        static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine()!);
            List<int> results = new List<int>();

            for (int testCase = 0; testCase < t; testCase++)
            {
                var dimensions = Console.ReadLine()!.Split();
                int n = int.Parse(dimensions[0]);
                int m = int.Parse(dimensions[1]);

                char[,] grid = new char[n, m];

                for (int i = 0; i < n; i++)
                {
                    string line = Console.ReadLine()!;
                    for (int j = 0; j < m; j++)
                    {
                        grid[i, j] = line[j];
                    }
                }

                int maxBorder = 0;

                for (int i = 0; i < n; i++)
                {
                    int currentBorder = 0;
                    for (int j = 0; j < m; j++)
                    {
                        if (grid[i, j] == '#')
                        {
                            currentBorder++;
                            if (currentBorder > maxBorder)
                            {
                                maxBorder = currentBorder;
                            }
                        }
                        else
                        {
                            currentBorder = 0;
                        }
                    }
                }

                for (int j = 0; j < m; j++)
                {
                    int currentBorder = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (grid[i, j] == '#')
                        {
                            currentBorder++;
                            if (currentBorder > maxBorder)
                            {
                                maxBorder = currentBorder;
                            }
                        }
                        else
                        {
                            currentBorder = 0;
                        }
                    }
                }

                results.Add(maxBorder);
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
            StyleHelper.Title("Maximum borders");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}