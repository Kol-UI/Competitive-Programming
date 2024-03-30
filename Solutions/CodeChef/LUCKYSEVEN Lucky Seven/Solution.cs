// Lucky Seven


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.LuckySeven
{
    public class Test
    {
        //public static void Main()
        public static void Solution()
        {
            string S = Console.ReadLine()!;

            char luckyLetter = S[6];
            
            Console.WriteLine(luckyLetter);
        }

        public static char TestSolution(string S)
        {
            char luckyLetter = S[6];
            return luckyLetter;
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<char>(Test.TestSolution("proceeding"), 'd'),
                ResultTester.CheckResult<char>(Test.TestSolution("outofsight"), 'i'),
            };
            return results;
        }
    }
}