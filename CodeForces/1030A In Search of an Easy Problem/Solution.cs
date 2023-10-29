// In Search of an Easy Problem



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.InSearchofanEasyProblem
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] responses = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            if (Array.Exists(responses, x => x == 1))
            {
                Console.WriteLine("HARD");
            }
            else
            {
                Console.WriteLine("EASY");
            }
        }
    }

    public class Test
    {
        public static string DetermineDifficulty(int n, int[] responses)
        {
            if (Array.Exists(responses, x => x == 1))
            {
                return "HARD";
            }
            else
            {
                return "EASY";
            }
        }

        public static bool[] TestCases()
        {
            int[] responses1 = { 0, 1, 0, 0, 0 };
            int[] responses2 = { 0, 0, 0, 0, 0 };
            int[] responses3 = { 1 };
            int[] responses4 = { };
            int[] responses5 = { 0, 1, 0, 1, 0, 1 };
            int[] responses6 = new int[100];

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Test.DetermineDifficulty(5, responses1), "HARD"),
                ResultTester.CheckResult<string>(Test.DetermineDifficulty(5, responses2), "EASY"),
                ResultTester.CheckResult<string>(Test.DetermineDifficulty(1, responses3), "HARD"),
                ResultTester.CheckResult<string>(Test.DetermineDifficulty(5, responses4), "EASY"),
                ResultTester.CheckResult<string>(Test.DetermineDifficulty(6, responses5), "HARD"),
                ResultTester.CheckResult<string>(Test.DetermineDifficulty(100, responses6), "EASY"),
            };
            return results;
        }
    }
}