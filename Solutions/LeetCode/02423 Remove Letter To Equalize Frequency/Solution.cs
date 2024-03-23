// Remove Letter To Equalize Frequency


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemoveLetterToEqualizeFrequency
{
    public class Solution
    {
        public static bool EqualFrequency(string word)
        {
            Dictionary<char,int> charCount = new Dictionary<char,int>();

            for(int i = 0; i < word.Length; i++)
            {
                if(charCount.ContainsKey(word[i]))
                    charCount[word[i]]++;
                else 
                    charCount.Add(word[i],1);
            }

            for(int i = 0; i < charCount.Count; i++)
            {
                var key = charCount.Keys.ElementAt(i);
                charCount[key]--;
                if(charCount[key] == 0)
                    charCount.Remove(key);
                if(charCount.Values.Distinct().Count() == 1)
                    return true;
                if(charCount.ContainsKey(key))
                    charCount[key]++;
                else
                    charCount.Add(key, 1);
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
                ResultTester.CheckResult<bool>(Solution.EqualFrequency("abcc"), true),
                ResultTester.CheckResult<bool>(Solution.EqualFrequency("aazz"), false),
            };
            return results;
        }
    }
}