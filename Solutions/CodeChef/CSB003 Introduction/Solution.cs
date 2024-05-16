// CSB003 Introduction


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.CSB003Introduction
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("I love C#");
        }
    }
    */

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB003 Introduction");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}