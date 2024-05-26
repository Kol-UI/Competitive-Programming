using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.NextRound
{
    // Solution Part
    /*
    public Solution
    {
        public static void Main()
        {
            string[] nk = Console.ReadLine().Split();
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
    
            string[] scores = Console.ReadLine().Split();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(scores[i]);
            }
    
            int advancingParticipants = 0;
            int kthPlaceScore = a[k - 1];
    
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= kthPlaceScore && a[i] > 0)
                {
                    advancingParticipants++;
                }
                else
                {
                    break;
                }
            }
    
            Console.WriteLine(advancingParticipants);
        }
    }
    */


    // Test Part 
    public class Test
    {
        public static int NextRoundTestCase(string[] nk, string[] scores)
        {
            int n = int.Parse(nk[0].Split()[0]);
            int k = int.Parse(nk[0].Split()[1]);

            string[] scoreValues = scores[0].Split();

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(scoreValues[i]);
            }

            int advancingParticipants = 0;
            int kthPlaceScore = a[k - 1];

            for (int i = 0; i < n; i++)
            {
                if (a[i] >= kthPlaceScore && a[i] > 0)
                {
                    advancingParticipants++;
                }
                else
                {
                    break;
                }
            }
    
            return advancingParticipants;
        }

        public static bool[] TestCases()
        {
            string[] nk1 = new string[]
            {
                "8 5",
            };

            string[] scores1 = new string[]
            {
                "10 9 8 7 7 7 5 5",
            };

            string[] nk2 = new string[]
            {
                "4 2",
            };

            string[] scores2 = new string[]
            {
                "0 0 0 0",
            };
            

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Test.NextRoundTestCase(nk1, scores1), 6),
                ResultTester.CheckResult<int>(Test.NextRoundTestCase(nk2, scores2), 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Round");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
        }
    }
}