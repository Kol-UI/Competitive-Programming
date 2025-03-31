// XOR Sequences
namespace CompetitiveProgramming.CodeForces.XORSequences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int tc = int.Parse(Console.ReadLine()!);
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine()!.Split();
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);
            long Xor = a ^ b;
            int i = 0;
            while (Xor != 0)
            {
                if ((Xor & 1) != 0)
                {
                    Console.WriteLine(1 << i);
                    break;
                }
                Xor >>= 1;
                i++;
            }
        }
    }
}

public class TestSolution : Models.BaseSolution
{
    public override void GetResult()
    {
        Helpers.StyleHelper.Space();
        Helpers.StyleHelper.Title("XOR Sequences");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}