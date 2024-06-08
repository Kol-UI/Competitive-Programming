// Ultra Fast Mathematicians



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodingBlocks.UltraFastMathematicians
{
    public class Test
    {
        //public static void Main()
        public static void Solution()
        {
            int t = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < t; i++)
            {
                string[] inputs = Console.ReadLine()!.Split();
                
                string number1 = inputs[0];
                string number2 = inputs[1];
                
                string result = GetXOR(number1, number2);
                
                Console.WriteLine(result);
            }
        }
        
        public static string GetXOR(string num1, string num2)
        {
            int n = num1.Length;
            char[] result = new char[n];
            
            for (int i = 0; i < n; i++)
            {
                if (num1[i] != num2[i])
                    result[i] = '1';
                else
                    result[i] = '0';
            }
            
            return new string(result);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ultra Fast Methematicians");
            ResultTester.SpecialTestCase(ProblemOrigin.CodingBlocks, ProblemCategory.EasyCBl);
        }
    }
}