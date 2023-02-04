using System;

namespace CompetitiveProgramming.LeetCode.GreatestCommonDivisorofStrings
{
    public class Solution
    {
        // For two strings s and t, we say "t divides s" if and only if s = t + ... + t (i.e., t is concatenated with itself one or more times).

        // Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

        // Example 1:

        // Input: str1 = "ABCABC", str2 = "ABC"
        // Output: "ABC"

        // Example 2:

        // Input: str1 = "ABABAB", str2 = "ABAB"
        // Output: "AB"

        // Example 3:

        // Input: str1 = "LEET", str2 = "CODE"
        // Output: ""


        public int gcd(int n1,int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }   
        }
        
        public string GcdOfStrings(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            if((str1+str2).Equals(str2+str1))
            {
                int index=gcd(len1,len2);
                return str1.Substring(0,index);
            }
            else
            {
                return "";
            }
        }
    }
}

