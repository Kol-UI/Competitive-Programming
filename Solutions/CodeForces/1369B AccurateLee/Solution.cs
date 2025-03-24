// AccurateLee
namespace CompetitiveProgramming.CodeForces.AccurateLee;
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
            long n = long.Parse(Console.ReadLine()!);
            string str = Console.ReadLine()!;
            if (n == 1)
            {
                Console.WriteLine(str);
                continue;
            }
            long cnt = n;
            for (int i = 0; i < n; i++)
            {
                if (str[i] == '0')
                {
                    Console.Write('0');
                    cnt--;
                }
                else break;
            }
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            string s = "";
            for (int i = 0; i < n; i++)
            {
                if (reversedStr[i] == '1')
                {
                    s += '1';
                    cnt--;
                }
                else break;
            }
            if (cnt != 0)
                s = '0' + s;
            Console.WriteLine(s);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("AccurateLee");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}