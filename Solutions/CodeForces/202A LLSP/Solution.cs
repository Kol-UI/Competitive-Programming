// LLSP


using System;
using System.Linq;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.LLSP
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string a = Console.ReadLine()!;
            int len = a.Length;
            int[] al = new int[27];

            for (int i = 1; i <= 26; i++)
            {
                al[i] = 0;
            }

            for (int i = 0; i < len; i++)
            {
                al[a[i] - 96]++;
            }

            for (int i = 26; i >= 1; i--)
            {
                if (al[i] > 0)
                {
                    for (int j = 0; j < al[i]; j++)
                    {
                        Console.Write((char)(96 + i));
                    }
                    Environment.Exit(0);
                }
            }
        }
    }
    

    public class Test
    {
        static string Solution(string input)
        {
            int len = input.Length;
            int[] occurrences = new int[27];

            for (int i = 1; i <= 26; i++)
            {
                occurrences[i] = 0;
            }

            for (int i = 0; i < len; i++)
            {
                occurrences[input[i] - 96]++;
            }

            char mostFrequentChar = ' ';
            int maxOccurrences = 0;

            for (int i = 1; i <= 26; i++)
            {
                if (occurrences[i] > maxOccurrences)
                {
                    maxOccurrences = occurrences[i];
                    mostFrequentChar = (char)(96 + i);
                }
            }

            string result = new(mostFrequentChar, maxOccurrences);
            return result;
        }
        public static bool[] TestCases()
        {
            string[] phrases1 = { "on codeforces", "beta round is running", "a rustling of keys" };
            string[] phrases2 = { "how many gallons", "of edo s rain did you drink", "cuckoo" };
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Test.Solution("abracadabra"), "aaaaa"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("LLSP");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
        }
    }
}