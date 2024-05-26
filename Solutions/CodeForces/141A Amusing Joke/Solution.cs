// Amusing Joke




using System;
using System.Linq;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.AmusingJoke
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string guest = Console.ReadLine()!;
            string host = Console.ReadLine()!;
            string pile = Console.ReadLine()!;

            string combined = guest + host;
            char[] combinedArray = combined.ToCharArray();
            char[] pileArray = pile.ToCharArray();

            Array.Sort(combinedArray);
            Array.Sort(pileArray);

            bool isValid = Enumerable.SequenceEqual(combinedArray, pileArray);

            if (isValid)
            {
                Console.WriteLine("YES");
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
            StyleHelper.Title("Amusing Joke");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}