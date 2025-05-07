// cAPS lOCK
namespace CompetitiveProgramming.CodeForces.cAPSlOCK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    static string Print(string str)
    {
        if (char.IsLower(str[0]))
        {
            if (str.Skip(1).All(c => char.IsUpper(c)))
            {
                return char.ToUpper(str[0]) + str.Substring(1).ToLower();
            }
            return str;
        }

        if (str.All(c => char.IsUpper(c)))
        {
            return str.ToLower();
        }
        return str;
    }

    //static void Main()
    public static void MainSolution()
    {
        string str = Console.ReadLine()!;
        Console.WriteLine(Print(str));
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("cAPS lOCK");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}