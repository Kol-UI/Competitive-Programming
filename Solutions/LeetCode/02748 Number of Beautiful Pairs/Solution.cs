// Number of Beautiful Pairs


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.NumberofBeautifulPairs
{
    public class Solution
    {
        public static int CountBeautifulPairs(int[] nums) 
        {
            var firstAndLasts = nums.Select(GetFirstLast).ToArray();

            var counter = 0;

            for(var i = 0; i < nums.Length; i++)
            {
                for(var j = i + 1; j < nums.Length; j++)
                {
                    if(1 == Gcd(
                        firstAndLasts[i].first, firstAndLasts[j].last))
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        private static (int first, int last) GetFirstLast(int n)
        {
            var l = n % 10;

            while(n > 9) n /= 10;

            return (n, l);
        }

        private static int Gcd(int a, int b)
        {
            if(b == 0) return a;

            return Gcd(b, a % b);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountBeautifulPairs(new int[]{2,5,1,4}), 5),
                ResultTester.CheckResult<int>(Solution.CountBeautifulPairs(new int[]{11,21,12}), 2),
            };
            return results;
        }
    }
}