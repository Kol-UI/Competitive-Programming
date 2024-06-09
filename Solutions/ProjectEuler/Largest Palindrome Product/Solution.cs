// Largest Palindrome Product


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.ProjectEuler.LargestPalindromeProduct
{
    public class Solution
    {
        public static int LargestPalindrome()
        {
            int maxPalindrome = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int product = i * j;

                    if (IsPalindrome(product) && product > maxPalindrome)
                    {
                        maxPalindrome = product;
                    }
                }
            }

            return maxPalindrome;
        }

        private static bool IsPalindrome(int num)
        {
            string str = num.ToString();
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left++] != str[right--])
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LargestPalindrome(), Solution.LargestPalindrome())
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Palindrome Product");
            ResultTester.CheckCurrentSolution(ProblemOrigin.ProjectEuler, ProblemCategory.OtherEuler, Test.TestCases());
        }
    }

}