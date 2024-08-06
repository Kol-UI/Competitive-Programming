// Minimum Number of Pushes to Type Word II

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofPushestoTypeWordII
{
    public class Solution 
    {
        public int MinimumPushes(string word) 
        {
            var characterFrequency = CalculateCharacterFrequencies(word);
            var sortedFrequencies = characterFrequency.Values.OrderByDescending(f => f).ToArray();
            
            return CalculateMinimumPushes(sortedFrequencies);
        }

        private Dictionary<char, int> CalculateCharacterFrequencies(string word) 
        {
            var frequencyMap = new Dictionary<char, int>();
            foreach (var ch in word) 
            {
                if (!frequencyMap.ContainsKey(ch)) 
                {
                    frequencyMap[ch] = 0;
                }
                frequencyMap[ch]++;
            }
            return frequencyMap;
        }

        private int CalculateMinimumPushes(int[] sortedFrequencies) 
        {
            int totalPresses = 0;
            int keyPressCount = 1;
            int keysUsed = 0;

            foreach (var frequency in sortedFrequencies) 
            {
                totalPresses += frequency * keyPressCount;
                keysUsed++;
                if (keysUsed == 8) 
                {
                    keyPressCount++;
                    keysUsed = 0;
                }
            }

            return totalPresses;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Pushes to Type Word II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}