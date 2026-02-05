// Kalindrome Array
namespace CompetitiveProgramming.CodeForces.KalindromeArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int left = 0, right = n - 1;
            int u = -1, v = -1;
            
            while(left < right)
            {
                if(a[left] == a[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    u = a[left];
                    v = a[right];
                    break;
                }
            }
            
            bool possibleA = true, possibleB = true;
            
            left = 0;
            right = n - 1;
            while(u > 0 && left < right)
            {
                if(a[left] == a[right])
                {
                    left++;
                    right--;
                }
                else if(a[left] == u)
                {
                    left++;
                }
                else if(a[right] == u)
                {
                    right--;
                }
                else
                {
                    possibleA = false;
                    break;
                }
            }
            
            left = 0;
            right = n - 1;
            while(v > 0 && left < right)
            {
                if(a[left] == a[right])
                {
                    left++;
                    right--;
                }
                else if(a[left] == v)
                {
                    left++;
                }
                else if(a[right] == v)
                {
                    right--;
                }
                else
                {
                    possibleB = false;
                    break;
                }
            }
            
            Console.WriteLine(possibleA || possibleB ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Kalindrome Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}