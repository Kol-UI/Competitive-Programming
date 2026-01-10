// Largest Number
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#nullable disable
namespace CompetitiveProgramming.HackerEarth.LargestNumber
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        //public static void Main()
        public static void MainSolution()
        {
            string[] inputs = Console.ReadLine().Split();
            string num = inputs[0];
            int k = int.Parse(inputs[1]);
            
            string result = LargestNumberAfterRemovingKDigits(num, k);
            Console.WriteLine(result);
        }

        public static string LargestNumberAfterRemovingKDigits(string num, int k)
        {
            int n = num.Length;
            Stack<char> stack = new Stack<char>();
            
            for (int i = 0; i < n; i++)
            {
                char current = num[i];
                
                while (stack.Count > 0 && k > 0 && stack.Peek() < current)
                {
                    stack.Pop();
                    k--;
                }
                
                stack.Push(current);
            }
            
            while (k > 0 && stack.Count > 0)
            {
                stack.Pop();
                k--;
            }
            
            char[] resultArray = stack.ToArray();
            Array.Reverse(resultArray);
            return new string(resultArray);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Number");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}
#nullable enable