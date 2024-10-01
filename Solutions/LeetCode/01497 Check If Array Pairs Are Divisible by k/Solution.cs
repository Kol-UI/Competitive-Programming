// Check If Array Pairs Are Divisible by k

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CheckIfArrayPairsAreDivisiblebyk
{
    public class Solution
    {
        public bool CanArrange(int[] arr, int k) {
            var modDict = new Dictionary<int, int>();
            foreach (var v in arr) {
                var mod = (v % k + k) % k;
                if (!modDict.ContainsKey(mod)) {
                    modDict.Add(mod, 0);
                }

                modDict[mod]++;
            }

            if (modDict.ContainsKey(0) && modDict[0] % 2 != 0) {
                return false;
            }

            foreach (var kvp in modDict) {
                var mod = kvp.Key;
                var count = kvp.Value;

                if (mod == 0) {
                    continue;
                }

                var complement = k - mod;            
                if (!modDict.ContainsKey(complement)) {
                    return false;
                }

                if (count != modDict[complement]) {
                    return false;
                }
            }

            return true;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check If Array Pairs Are Divisible by k");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}