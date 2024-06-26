// Panoramix's Prediction

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.PanoramixsPrediction
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int[] inputs = ReadInts();
            int n = inputs[0];
            int m = inputs[1];
            
            int nextPrime = NextPrime(n);
            
            if (nextPrime == m)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        
        public static int NextPrime(int n)
        {
            int next = n + 1;
            while (!IsPrime(next))
            {
                next++;
            }
            return next;
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int[] ReadInts() => ReadLn().Split(' ').Select(int.Parse).ToArray();
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Panoramix's Prediction");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}