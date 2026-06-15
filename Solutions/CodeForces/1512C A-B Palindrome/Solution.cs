// A-B Palindrome
namespace CompetitiveProgramming.CodeForces.ABPalindrome;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            long a = long.Parse(firstLine[0]);
            long b = long.Parse(firstLine[1]);
            string s = Console.ReadLine();
            
            long n = s.Length;
            bool possible = true;
            long z = 0, d = 0;
            char[] arr = s.ToCharArray();
            
            for (long p = 0; 2 * p < n; p++)
            {
                if (arr[p] != '?' && arr[n - 1 - p] != '?' && arr[p] != arr[n - 1 - p])
                {
                    possible = false;
                    break;
                }
                else if (arr[p] == arr[n - 1 - p] && arr[p] != '?')
                {
                    z += (1 + (p != n - 1 - p ? 1 : 0)) * (arr[p] == '0' ? 1 : 0);
                    d += (1 + (p != n - 1 - p ? 1 : 0)) * (arr[p] == '1' ? 1 : 0);
                }
                else if (arr[p] == '?' && arr[n - 1 - p] != '?')
                {
                    arr[p] = arr[n - 1 - p];
                    z += (1 + (p != n - 1 - p ? 1 : 0)) * (arr[p] == '0' ? 1 : 0);
                    d += (1 + (p != n - 1 - p ? 1 : 0)) * (arr[p] == '1' ? 1 : 0);
                }
                else if (arr[n - 1 - p] == '?' && arr[p] != '?')
                {
                    arr[n - 1 - p] = arr[p];
                    z += (1 + (p != n - 1 - p ? 1 : 0)) * (arr[p] == '0' ? 1 : 0);
                    d += (1 + (p != n - 1 - p ? 1 : 0)) * (arr[p] == '1' ? 1 : 0);
                }
            }
            
            for (long p = 0; 2 * p < n; p++)
            {
                if (arr[p] == '?' && arr[n - 1 - p] == '?' && p != n - 1 - p)
                {
                    if (z <= a - 2)
                    {
                        arr[p] = arr[n - 1 - p] = '0';
                        z += 2;
                    }
                    else if (d <= b - 2)
                    {
                        arr[p] = arr[n - 1 - p] = '1';
                        d += 2;
                    }
                }
                else if (arr[p] == '?' && arr[n - 1 - p] == '?' && p == n - 1 - p)
                {
                    if (z <= a - 1)
                    {
                        arr[p] = '0';
                        z++;
                    }
                    else if (d <= b - 1)
                    {
                        arr[p] = '1';
                        d++;
                    }
                }
            }
            
            if (z != a) possible = false;
            if (d != b) possible = false;
            
            Console.WriteLine(possible ? new string(arr) : "-1");
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
        StyleHelper.Title("A-B Palindrome");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}