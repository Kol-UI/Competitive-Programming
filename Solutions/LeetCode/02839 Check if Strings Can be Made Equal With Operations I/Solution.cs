// Check if Strings Can be Made Equal With Operations I



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CheckifStringsCanbeMadeEqualWithOperationsI
{
    public class Solution
    {
        public static bool CanBeEqual(string s1, string s2)
        {
            for (int i = 0; i < 2; i++)
            {
                if (s1[i] == s2[i] || s1[i] == s2[i + 2])
                {
                    if (s1[i] == s2[i]) 
                    {
                        continue;
                    }
                    else
                    {
                        char[] s2Chars = s2.ToCharArray();
                        char temp = s2Chars[i];
                        s2Chars[i] = s2Chars[i + 2];
                        s2Chars[i + 2] = temp;
                        s2 = new string(s2Chars);
                    }
                }
                else
                {
                    return false;
                }
            }

            if (s1[3] == s2[3] && s1[2] == s2[2])
            {
                return true;
            }
            
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.CanBeEqual("abcd", "cdab"), true),
                ResultTester.CheckResult<bool>(Solution.CanBeEqual("abcd", "dacb"), false),
            };
            return results;
        }
    }
}