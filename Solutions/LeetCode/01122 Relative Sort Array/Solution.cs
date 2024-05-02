// Relative Sort Array

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RelativeSortArray
{
    public class Solution
    {
        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> indexMap = new Dictionary<int, int>();
            
            for (int i = 0; i < arr2.Length; i++)
            {
                indexMap[arr2[i]] = i;
            }
            
            Array.Sort(arr1, (x, y) => 
            {
                if (indexMap.ContainsKey(x) && indexMap.ContainsKey(y))
                {
                    return indexMap[x].CompareTo(indexMap[y]);
                }
                else if (indexMap.ContainsKey(x))
                {
                    return -1;
                }
                else if (indexMap.ContainsKey(y))
                {
                    return 1;
                }
                else
                {
                    return x.CompareTo(y);
                }
            });
            
            return arr1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.RelativeSortArray(new int[]{2,3,1,3,2,4,6,7,9,2,19}, new int[]{2,1,4,3,9,6}), new int[]{2,2,2,1,4,3,3,9,6,7,19}),
                ResultTester.CheckResult<int[]>(Solution.RelativeSortArray(new int[]{28,6,22,8,44,17}, new int[]{22,28,8,6}), new int[]{22,28,8,6,17,44}),
            };
            return results;
        }
    }
}