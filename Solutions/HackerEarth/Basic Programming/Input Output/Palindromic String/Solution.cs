// Palindromic String
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.PalindromicString
{
    class Program
    {
        //static void Main()
        static void MainSolution()
        {
            string name = Console.ReadLine()!;
            string reversedName = ReverseString(name);

            if (name == reversedName)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Palindromic String");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}