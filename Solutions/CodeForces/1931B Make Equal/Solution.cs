// Make Equal


using System;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.MakeEqual
{

    class Program
    {
        //static void Main()
        static void Solution()
        {
            int T = int.Parse(Console.ReadLine()!);
            while (T-- > 0)
            {
                Solve();
            }
        }

        static void Solve()
        {
            int n = int.Parse(Console.ReadLine()!);
            long[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);

            long sum = 0;
            foreach (long num in arr)
            {
                sum += num;
            }

            long avg = sum / n;

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] < avg)
                {
                    Console.WriteLine("NO");
                    return;
                }

                arr[i + 1] += arr[i] - avg;
                arr[i] = avg;
            }

            Console.WriteLine("YES");
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make Equal");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}