// Letter Case Permutation

/*
Given a string s, you can transform every letter individually to be lowercase or uppercase to create another string.

Return a list of all possible strings we could create. Return the output in any order.

 

Example 1:

Input: s = "a1b2"
Output: ["a1b2","a1B2","A1b2","A1B2"]

Example 2:

Input: s = "3z4"
Output: ["3z4","3Z4"]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LetterCasePermutation
{
    public class Solution
    {
        public static IList<string> LetterCasePermutation(string s)
        {
            int n = s.Length;
            char[] ch = new char[s.Length];
            HashSet<string>map = new HashSet<string>();    
            for (int i = 0; i < (1 << n); i++)
            {
                for (int k = 0; k < s.Length; k++)
                {
                    ch[k] = s[k];
                }
                for (int j = 0; j < n; j++)
                {
                    int checkSet = i & (1 << j);
                    if (checkSet != 0)
                    {
                        char c = s[s.Length - j - 1];
                        char lowerCase = 'a';
                        char upperCase = 'A';
                        int toggleCase = 'A' - 'a';
                        if (c >= lowerCase && c <= lowerCase + 25)
                        {
                            ch[s.Length - j - 1] = (char)(c + toggleCase);
                        }
                        else if (c >= upperCase && c <= upperCase + 25)
                        {
                            ch[s.Length - j - 1] = (char)(c - toggleCase);
                        }
                    }
                }
                string em = new string(ch);
                if (!map.Contains(em)) map.Add(em);
            }

            return map.ToList();
        }
    }

    public class Test
    {
        public static bool[] TestLetterCasePermutation()
        {
            string[] array1 = new string[] { "a1b2", "a1B2", "A1b2", "A1B2" };
            string[] array2 = new string[] { "3z4", "3Z4" };
            IList<string> list1 = array1.ToList();
            IList<string> list2 = array2.ToList();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<string>>(Solution.LetterCasePermutation("a1b2"), list1),
                ResultTester.CheckResult<IList<string>>(Solution.LetterCasePermutation("3z4"), list2)
            };
            
            return results;
        }
    }
}