// Ali and Helping innocent people
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.AliandHelpinginnocentpeople
{
    class Program
    {
        //static void Main()
        static void MainSolution()
        {
            string tag = Console.ReadLine()!;
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y' };

            int chk1 = (tag[0] - '0') + (tag[1] - '0');
            int chk2 = (tag[3] - '0') + (tag[4] - '0');
            int chk3 = (tag[4] - '0') + (tag[5] - '0');
            int chk4 = (tag[7] - '0') + (tag[8] - '0');

            if (Array.Exists(vowels, v => v == tag[2]))
            {
                Console.WriteLine("invalid");
            }
            else if (chk1 % 2 == 0 && chk2 % 2 == 0 && chk3 % 2 == 0 && chk4 % 2 == 0)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ali and Helping innocent people");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}