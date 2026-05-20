// Veci
namespace CompetitiveProgramming.Kattis.Veci;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Linq;

class Program
{
    static void TestCase()
    {
        string x = Console.ReadLine();
        char[] arr = x.ToCharArray();
        
        if (!NextPermutation(arr))
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(new string(arr));
        }
    }
    
    static bool NextPermutation(char[] arr)
    {
        int i = arr.Length - 2;
        while (i >= 0 && arr[i] >= arr[i + 1]) i--;
        
        if (i < 0) return false;
        
        int j = arr.Length - 1;
        while (arr[j] <= arr[i]) j--;
        
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
        
        Array.Reverse(arr, i + 1, arr.Length - i - 1);
        return true;
    }
    
    static void Main()
    {
        TestCase();
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Veci");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}