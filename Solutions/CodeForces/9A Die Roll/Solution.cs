// Die Roll

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.DieRoll
{
    public class TestSolution : BaseSolution
    {
        //public static void Main(string[] args)
        public static void SolutionMain()
        {
            int[] yw = ReadInts();
            int Y = yw[0];
            int W = yw[1];
            
            int maxRoll = Math.Max(Y, W);
            
            int favorableOutcomes = 6 - maxRoll + 1;
            
            int totalOutcomes = 6;
            
            int gcd = GCD(favorableOutcomes, totalOutcomes);
            int numerator = favorableOutcomes / gcd;
            int denominator = totalOutcomes / gcd;
            
            Console.WriteLine($"{numerator}/{denominator}");
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static int[] ReadInts() => ReadLn().Split(' ').Select(int.Parse).ToArray();
        
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Die Roll");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}