// Count in string
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.HackerEarth.Countinstring
{
    class Program
    {
        //public static void Main()
        public static void MainSolution()
        {
            int T = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < T; i++)
            {
                string S = Console.ReadLine()!;
                char k = Console.ReadLine()![0];
                
                int count = S.Count(c => c == k);
                
                Console.WriteLine(count);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count in string");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}