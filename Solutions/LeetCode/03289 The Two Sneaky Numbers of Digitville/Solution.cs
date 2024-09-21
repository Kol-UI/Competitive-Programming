// The Two Sneaky Numbers of Digitville

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TheTwoSneakyNumbersofDigitville
{
    public class Solution
    {
        public int[] GetSneakyNumbers(int[] nums)
        {
            Dictionary<int, int> numFrequency = CalculateFrequency(nums);
            return FindDuplicates(numFrequency);
        }

        private Dictionary<int, int> CalculateFrequency(int[] nums)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            
            foreach (int num in nums)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }
            
            return frequency;
        }

        private int[] FindDuplicates(Dictionary<int, int> frequency)
        {
            List<int> duplicates = new List<int>();

            foreach (var entry in frequency)
            {
                if (entry.Value > 1)
                {
                    duplicates.Add(entry.Key);
                }
            }
            
            return duplicates.ToArray();
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("The Two Sneaky Numbers of Digitville");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}