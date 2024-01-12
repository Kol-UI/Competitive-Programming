// Determine if String Halves Are Alike


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DetermineifStringHalvesAreAlike
{
    public class Solution
    {
        public static bool HalvesAreAlike(string s)
        {
            HashSet<char> vowels = new("aeiouAEIOU");
            
            int mid = s.Length / 2;
            int a = s[..mid].Count(c => vowels.Contains(c));
            int b = s[mid..].Count(c => vowels.Contains(c));

            return a == b;
        }
    }
}