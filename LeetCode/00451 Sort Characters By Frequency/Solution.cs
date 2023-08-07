// Sort Characters By Frequency

/*
Given a string s, sort it in decreasing order based on the frequency of the characters. The frequency of a character is the number of times it appears in the string.

Return the sorted string. If there are multiple answers, return any of them.

 

Example 1:

Input: s = "tree"
Output: "eert"
Explanation: 'e' appears twice while 'r' and 't' both appear once.
So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.

Example 2:

Input: s = "cccaaa"
Output: "aaaccc"
Explanation: Both 'c' and 'a' appear three times, so both "cccaaa" and "aaaccc" are valid answers.
Note that "cacaca" is incorrect, as the same characters must be together.

Example 3:

Input: s = "Aabb"
Output: "bbAa"
Explanation: "bbaA" is also a valid answer, but "Aabb" is incorrect.
Note that 'A' and 'a' are treated as two different characters.
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SortCharactersByFrequency
{
    public class Solution
    {
        public static string FrequencySort(string s)
        {
            var heap = new PriorityQueue<char, int>();
            var dict = new Dictionary<char, int>();

            var i = 0;
            var j = 0;

            for(i = 0; i < s.Length; i++)
            {
                if(!dict.TryAdd(s[i], 1))
                {
                    dict[s[i]]++;
                }
            }

            foreach(var entry in dict)
            {
                heap.Enqueue(entry.Key, entry.Value * -1);
            }

            var result = new char[s.Length];
            
            i = 0;

            while(i < s.Length)
            {
                var el = heap.Dequeue();
                for(j = 0; j < dict[el]; j++)
                {
                    result[i + j] = el;
                }

                i += j;
            }

            return new string(result);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.FrequencySort("tree"), "eetr"),
                ResultTester.CheckResult<string>(Solution.FrequencySort("cccaaa"), "cccaaa"),
                ResultTester.CheckResult<string>(Solution.FrequencySort("Aabb"), "bbAa"),
            };
            return results;
        }
    }
}