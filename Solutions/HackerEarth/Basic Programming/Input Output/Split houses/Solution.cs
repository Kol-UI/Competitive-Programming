// Split houses

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.HackerEarth.Splithouses
{
    class Solution
    {
        // static void Main()
        static void MainSolution()
        {
            //int n = int.Parse(Console.ReadLine());
            //string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine()!);
            string s = Console.ReadLine()!;
            char[] arr = new char[n];
            int temp = 0;
            bool isPossible = true;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'H')
                {
                    arr[i] = 'H';
                    temp++;

                    if (temp > 1)
                    {
                        isPossible = false;
                        break;
                    }
                }
                else
                {
                    arr[i] = 'B';
                    temp = 0;
                }
            }

            if (isPossible)
            {
                Console.WriteLine("YES");
                Console.WriteLine(new string(arr));
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Split houses");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}