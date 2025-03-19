// Insert Digit
namespace CompetitiveProgramming.CodeForces.InsertDigit;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Text;

public class Program
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] line1 = Console.ReadLine()!.Split(' ');
            int n = int.Parse(line1[0]);
            char d = line1[1][0];
            string str = Console.ReadLine()!;

            bool ok = false;
            StringBuilder sb = new StringBuilder(str);

            for (int i = 0; i < n; i++)
            {
                if (sb[i] < d)
                {
                    sb.Insert(i, d);
                    ok = true;
                    break;
                }
            }

            if (!ok)
            {
                sb.Append(d);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Insert Digit");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}