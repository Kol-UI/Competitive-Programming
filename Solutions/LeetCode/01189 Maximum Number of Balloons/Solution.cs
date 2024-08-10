// Maximum Number of Balloons

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofBalloons
{
    public class Solution
    {
        private const string Balloon = "balon";

        public int MaxNumberOfBalloons(string text)
        {
            var charFrequency = GetCharacterFrequency(text);
            
            if (!IsBalloonPossible(charFrequency))
            {
                return 0;
            }

            return CalculateMaxBalloons(charFrequency);
        }

        private Dictionary<char, int> GetCharacterFrequency(string text)
        {
            var frequencyDictionary = new Dictionary<char, int>();
            
            foreach (var ch in text)
            {
                if (Balloon.Contains(ch))
                {
                    frequencyDictionary[ch] = frequencyDictionary.GetValueOrDefault(ch, 0) + 1;
                }
            }
            
            return frequencyDictionary;
        }

        private bool IsBalloonPossible(Dictionary<char, int> charFrequency)
        {
            return charFrequency.Count == Balloon.Length 
                && charFrequency.GetValueOrDefault('l', 0) >= 2 
                && charFrequency.GetValueOrDefault('o', 0) >= 2;
        }

        private int CalculateMaxBalloons(Dictionary<char, int> charFrequency)
        {
            int minBalloons = charFrequency['b'];

            foreach (var kvp in charFrequency)
            {
                int currentCount = (kvp.Key == 'l' || kvp.Key == 'o') ? kvp.Value / 2 : kvp.Value;
                minBalloons = Math.Min(minBalloons, currentCount);
            }

            return minBalloons;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Balloons");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}