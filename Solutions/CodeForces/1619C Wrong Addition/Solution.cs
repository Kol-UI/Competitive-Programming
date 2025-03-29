// Wrong Addition
namespace CompetitiveProgramming.CodeForces.WrongAddition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] input = Console.ReadLine()!.Split(' ');
            string a = input[0];
            string s = input[1];
            string b = "";
            int i = a.Length - 1;
            int j = s.Length - 1;
            
            while (i >= 0 && j >= 0)
            {
                if (s[j] >= a[i])
                {
                    b += (char)((s[j] - a[i]) + '0');
                    i--;
                    j--;
                }
                else if (j - 1 >= 0 && s[j - 1] == '1')
                {
                    b += (char)(((10 + (s[j] - '0')) - (a[i] - '0')) + '0');
                    i--;
                    j -= 2;
                }
                else break;
            }
            
            if (i >= 0)
            {
                Console.WriteLine("-1");
                continue;
            }
            
            while (j >= 0) b += s[j--];
            
            char[] charArray = b.ToCharArray();
            Array.Reverse(charArray);
            b = new string(charArray);
            
            int x;
            for (x = 0; x < b.Length && b[x] == '0'; x++);
            
            if (x >= b.Length)
                Console.WriteLine("0");
            else
                Console.WriteLine(b.Substring(x));
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Wrong Addition");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}