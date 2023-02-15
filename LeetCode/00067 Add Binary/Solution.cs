// Given two binary strings a and b, return their sum as a binary string.

// Example 1:

// Input: a = "11", b = "1"
// Output: "100"

// Example 2:

// Input: a = "1010", b = "1011"
// Output: "10101"

using System;

namespace CompetitiveProgramming.LeetCode.AddBinary
{
    public class Solution
    {
        public static string AddBinary(string a, string b)
        {
            if(b.Length > a.Length) (a, b) = (b, a);
            bool ovr = false;
            List<char> result = new(Math.Max(a.Length, b.Length) + 1);
            for(int aP = a.Length - 1, bP = b.Length - 1; aP >= 0 && bP >= 0; --aP, --bP)
            {
                if (a[aP] != b[bP] && ovr || a[aP] == '0' && b[bP] == '0' && !ovr) result.Add('0');
                else if (a[aP] != b[bP]) result.Add('1');
                else if(a[aP] == '0' && b[bP] == '0')
                {
                    ovr = false;
                    result.Add('1');
                }
                else
                {
                    if (ovr) result.Add('1');
                    else result.Add('0');
                    ovr = true;
                }
            }

            for(int aP = a.Length - b.Length - 1; aP >= 0; --aP)
            {
                if (a[aP] == '1' && !ovr) result.Add('1');
                else if (a[aP] == '0' && !ovr || a[aP] == '1' && ovr) result.Add('0');
                else 
                {
                    ovr = false;
                    result.Add('1');
                }
            }

            if (ovr) result.Add('1');
            result.Reverse();
            return new string(result.ToArray());
        }
    }
}