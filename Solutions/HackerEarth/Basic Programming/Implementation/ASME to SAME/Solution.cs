// ASME to SAME
#nullable disable
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.HackerEarth.ASMEtoSAME
{
    using System;

    class Solution
    {
        //public static void Main()
        public static void MainSolution()
        {
            int testCases = int.Parse(Console.ReadLine());

            while (testCases-- > 0)
            {
                int size = int.Parse(Console.ReadLine());
                string S = Console.ReadLine();
                string T = Console.ReadLine();

                int[] frequency = new int[256];
                foreach (char ch in T)
                {
                    frequency[ch]++;
                }

                string result = "Yes";

                for (int i = 0; i < size; i++)
                {
                    if (S[i] != '?')
                    {
                        if (frequency[S[i]] > 0)
                        {
                            frequency[S[i]]--;
                        }
                        else
                        {
                            result = "No";
                            break;
                        }
                    }
                }

                Console.WriteLine(result);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("ASME to SAME");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}
#nullable enable