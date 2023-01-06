using System;

namespace CompetitiveProgramming.LeetCode.IsomorphicStrings
{
    public class Solution
    {
        //Given two strings s and t, determine if they are isomorphic.

        //Two strings s and t are isomorphic if the characters in s can be replaced to get t.

        //All occurrences of a character must be replaced with another character while preserving the order of characters.
        //No two characters may map to the same character, but a character may map to itself.

        public static bool IsIsomorphic(string s, string t)
        {
            var dict = new Dictionary<char, char>();
            var hash = new HashSet<char>();

            for (int i = 0; i < s.Length; ++i)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] != t[i])
                        return false;
                }
                else
                {
                    if (hash.Contains(t[i]))
                        return false;

                    dict.Add(s[i], t[i]);
                    hash.Add(t[i]);
                }
            }
            return true;
        }
    }
}

