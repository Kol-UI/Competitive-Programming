// Preparing for the Exam
namespace CompetitiveProgramming.CodeForces.PreparingfortheExam;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] nmk = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = nmk[0], m = nmk[1], k = nmk[2];
            
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            bool[] d = new bool[n + 1];
            Array.Fill(d, true);
            
            long[] missingInput = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in missingInput) d[x] = false;
            
            long miss = 0;
            for (long p = 1; p <= n && miss == 0; p++)
            {
                if (d[p]) miss = p;
            }
            
            for (long p = 0; p < m; p++)
            {
                char result = (k + 1 >= n && (miss == 0 || miss == a[p])) ? '1' : '0';
                Console.Write(result);
            }
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Preparing for the Exam");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}