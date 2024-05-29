// Min Window Substring

/*
Have the function MinWindowSubstring(strArr) take the array of strings stored in strArr, which will contain only two strings, the first parameter being the string N and the second parameter being a string K of some characters, and your goal is to determine the smallest substring of N that contains all the characters in K. For example: if strArr is ["aaabaaddae", "aed"] then the smallest substring of N that contains the characters a, e, and d is "dae" located at the end of the string. So for this example your program should return the string dae.

Another example: if strArr is ["aabdccdbcacd", "aad"] then the smallest substring of N that contains all of the characters in K is "aabd" which is located at the beginning of the string. Both parameters will be strings ranging in length from 1 to 50 characters and all of K's characters will exist somewhere in the string N. Both strings will only contains lowercase alphabetic characters.
Examples
Input: new string[] {"ahffaksfajeeubsne", "jefaa"}
Output: aksfaje
Input: new string[] {"aaffhkksemckelloe", "fhea"}
Output: affhkkse
*/
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CoderByte.MinWindowSubstring
{
    class Solution
    {
        public static string MinWindowSubstring(string[] strArr) 
        {
            string N = strArr[0];
            string K = strArr[1];
            
            int[] targetFreq = new int[26];
            int[] windowFreq = new int[26];
            
            foreach (char c in K)
            {
                targetFreq[c - 'a']++;
            }
            
            int left = 0, right = 0;
            int minLength = int.MaxValue;
            string minSubstring = "";
            int charsToMatch = K.Length;
            
            while (right < N.Length)
            {
                if (targetFreq[N[right] - 'a'] > 0)
                {
                    windowFreq[N[right] - 'a']++;
                    if (windowFreq[N[right] - 'a'] <= targetFreq[N[right] - 'a'])
                    {
                        charsToMatch--;
                    }
                }
                
                while (charsToMatch == 0)
                {
                    if (right - left + 1 < minLength)
                    {
                        minLength = right - left + 1;
                        minSubstring = N.Substring(left, minLength);
                    }
                    
                    if (targetFreq[N[left] - 'a'] > 0)
                    {
                        windowFreq[N[left] - 'a']--;
                        if (windowFreq[N[left] - 'a'] < targetFreq[N[left] - 'a'])
                        {
                            charsToMatch++;
                        }
                    }
                    
                    left++;
                }
                
                right++;
            }
            
            return minSubstring;
        }

        /*
        static void Main()
        { 
            // keep this function call here
            Console.WriteLine(MinWindowSubstring(Console.ReadLine()));
        }
        */

    }


    public class Test
    {
        public static bool[] TestCases()
        {
            string[] case1 = {"ahffaksfajeeubsne", "jefaa"};
            string result1 = "aksfaje";
            string[] case2 = {"aaffhkksemckelloe", "fhea"};
            string result2 = "affhkkse";
            string[] case3 = {"aaabaaddae", "aed"};
            string result3 = "dae";

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.MinWindowSubstring(case1), result1),
                ResultTester.CheckResult<string>(Solution.MinWindowSubstring(case2), result2),
                ResultTester.CheckResult<string>(Solution.MinWindowSubstring(case3), result3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Window Substring");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CoderByte, ProblemCategory.MediumCB, Test.TestCases());
        }
    }
}