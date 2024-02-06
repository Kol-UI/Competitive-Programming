// Find the Array Concatenation Value


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindtheArrayConcatenationValue
{
    public class Solution
    {
        public static long FindTheArrayConcVal(int[] nums) 
        {
            List<string> list = nums.Select(x => x.ToString()).ToList();
            long val = 0;

            while (list.Count > 0)
            {
                if (list.Count >= 2)
                {
                    string concat = list[0] + list[list.Count - 1];

                    long n;
                    if (long.TryParse(concat, out n))
                    {
                        val += n;
                    }

                    list.RemoveAt(0);
                    list.RemoveAt(list.Count - 1);
                }
                else if (list.Count == 1)
                {
                    long k;
                    if (long.TryParse(list[0], out k))
                    {
                        val += k;
                    }

                    list.RemoveAt(list.Count - 1);
                }
            }

            return val;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Solution.FindTheArrayConcVal(new int[]{7,52,2,4}), 596),
                ResultTester.CheckResult<long>(Solution.FindTheArrayConcVal(new int[]{5,14,13,8,12}), 673),
            };

            return results;
        }
    }
}