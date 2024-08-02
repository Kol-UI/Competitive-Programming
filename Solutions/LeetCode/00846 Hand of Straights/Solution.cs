// Hand of Straights


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.HandofStraights
{
    public class Solution
    {
        public static bool IsNStraightHand(int[] hand, int groupSize)
        {
            if(hand.Length % groupSize != 0)
            {
                return false;
            }

            SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
            foreach (var item in hand)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            while(dict.Count > 0)
            {
                int start = dict.First().Key;
                for (int i = 0; i < groupSize; i++)
                {
                    if (dict.ContainsKey(start + i))
                    {
                        dict[start + i]--;
                        if (dict[start + i] == 0)
                        {
                            dict.Remove(start + i);
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsNStraightHand(new int[]{1,2,3,6,2,3,4,7,8}, 3), true),
                ResultTester.CheckResult<bool>(Solution.IsNStraightHand(new int[]{1,2,3,4,5}, 4), false),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Hand of Straights");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}