// Divisibility
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.Divisibility
{
    class Solution
    {
        // static void Main()
        static void MainSolution()
        {
            //int N = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine()!);

            //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            int ele = arr[N - 1];

            if (ele % 10 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Divisibility");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}