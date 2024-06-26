// The New Year Meeting Friends



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.TheNewYearMeetingFriends
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string[] input = Console.ReadLine()!.Split(' ');
            int[] positions = Array.ConvertAll(input, int.Parse);

            int min = Math.Min(positions[0], Math.Min(positions[1], positions[2]));
            int max = Math.Max(positions[0], Math.Max(positions[1], positions[2]));

            int distance = max - min;

            Console.WriteLine(distance);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("The New Year Meeting Friends");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}