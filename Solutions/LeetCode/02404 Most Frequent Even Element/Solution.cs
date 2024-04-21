// Most Frequent Even Element

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MostFrequentEvenElement
{
    public class Solution
    {
        public static int MostFrequentEven(int[] nums)
        {
            Dictionary<int, int> countCollection = new Dictionary<int, int>();

            foreach (int value in nums)
            {
                if (value % 2 == 1)
                {
                    continue;
                }

                if (!countCollection.ContainsKey(value))
                {
                    countCollection.Add(value, 0);
                }
                countCollection[value]++;

            }

            if (countCollection.Count == 0)
            {
                return -1;
            }

            int maximum = countCollection.Values.Max();

            int result = (from value in countCollection
                        where value.Value == maximum
                        orderby value.Key ascending
                        select value.Key).First();

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MostFrequentEven(new int[] {0,1,2,2,4,4,1}), 2),
                ResultTester.CheckResult<int>(Solution.MostFrequentEven(new int[] {4,4,4,9,2,4}), 4),
                ResultTester.CheckResult<int>(Solution.MostFrequentEven(new int[] {29,47,21,41,13,37,25,7}), -1),

            };
            return results;
        }
    }
}