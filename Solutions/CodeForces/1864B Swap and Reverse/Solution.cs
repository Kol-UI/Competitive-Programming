// Swap and Reverse
namespace CompetitiveProgramming.CodeForces.SwapandReverse;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Text;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]);
            int k = int.Parse(firstLine[1]);
            string s = Console.ReadLine();

            if (k % 2 == 0)
            {
                char[] arr = s.ToCharArray();
                Array.Sort(arr);
                Console.WriteLine(new string(arr));
            }
            else
            {
                char[] odd = new char[(n + 1) / 2];
                char[] even = new char[n / 2];
                int oi = 0, ei = 0;

                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                        odd[oi++] = s[i];
                    else
                        even[ei++] = s[i];
                }

                Array.Sort(odd);
                Array.Sort(even);

                StringBuilder result = new StringBuilder(n);
                oi = 0; ei = 0;

                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                        result.Append(odd[oi++]);
                    else
                        result.Append(even[ei++]);
                }

                Console.WriteLine(result.ToString());
            }
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Swap and Reverse");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
