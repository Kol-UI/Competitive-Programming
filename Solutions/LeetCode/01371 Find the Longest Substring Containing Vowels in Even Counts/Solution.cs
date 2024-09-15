// Find the Longest Substring Containing Vowels in Even Counts

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheLongestSubstringContainingVowelsinEvenCounts
{
    public class Solution
    {
        public int FindTheLongestSubstring(string s)
        {
            return GetLongestSubstringWithEvenVowels(s);
        }

        private int GetLongestSubstringWithEvenVowels(string s)
        {
            Dictionary<int, int> stateIndexMap = InitializeStateIndexMap();
            int currentState = 0;
            int maxLength = 0;
            int n = s.Length;

            for (int i = 0; i < n; i++)
            {
                currentState = UpdateStateForVowel(currentState, s[i]);
                maxLength = CalculateMaxLength(stateIndexMap, currentState, i, maxLength);
            }

            return maxLength;
        }

        private Dictionary<int, int> InitializeStateIndexMap()
        {
            var stateIndexMap = new Dictionary<int, int>();
            stateIndexMap[0] = -1;
            return stateIndexMap;
        }

        private int UpdateStateForVowel(int currentState, char ch)
        {
            int mask = GetVowelBitmask(ch);
            return currentState ^ mask;
        }

        private int GetVowelBitmask(char ch)
        {
            switch (ch)
            {
                case 'a': return 1 << 0;
                case 'e': return 1 << 1;
                case 'i': return 1 << 2;
                case 'o': return 1 << 3;
                case 'u': return 1 << 4;
                default: return 0;
            }
        }

        private int CalculateMaxLength(Dictionary<int, int> stateIndexMap, int currentState, int currentIndex, int maxLength)
        {
            if (stateIndexMap.ContainsKey(currentState))
            {
                maxLength = Math.Max(maxLength, currentIndex - stateIndexMap[currentState]);
            }
            else
            {
                stateIndexMap[currentState] = currentIndex;
            }
            return maxLength;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Longest Substring Containing Vowels in Even Counts");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}