// Rook Attack
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.HackerEarth.RookAttack
{
    class Solution
    {
        //public static void Main()
        public static void MainSolution()
        {
            //string[] dimensions = Console.ReadLine()?.Split();
            string[] dimensions = Console.ReadLine()!.Split();
            int n = int.Parse(dimensions[0]);
            int m = int.Parse(dimensions[1]);

            long[,] a = new long[n, m];
            long[] row = new long[n];
            long[] col = new long[m];

            for (int i = 0; i < n; i++)
            {
                //string[] line = Console.ReadLine()?.Split();
                string[] line = Console.ReadLine()!.Split();
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = long.Parse(line[j]);
                    row[i] += a[i, j];
                    col[j] += a[i, j];
                }
            }

            int x = 0, y = 0;
            long maxi = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    long currentSum = row[i] + col[j] - 2 * a[i, j];
                    if (currentSum > maxi)
                    {
                        maxi = currentSum;
                        x = i;
                        y = j;
                    }
                }
            }

            Console.WriteLine($"{x + 1} {y + 1}");
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rook Attack");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}