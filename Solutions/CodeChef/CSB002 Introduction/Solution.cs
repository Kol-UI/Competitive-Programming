// CSB002 Introduction


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.CSB002Introduction
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            Console.Write(12);
        }
        */
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB002 Introduction");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}