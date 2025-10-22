// Sum of Unique Elements
namespace CompetitiveProgramming.LeetCode.SumofUniqueElements;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SumOfUnique(int[] nums)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
                dic[nums[i]]++;
            else
                dic.Add(nums[i], 1);
        }

        int count = 0;
        foreach (var item in dic)
            if (item.Value == 1)
                count += item.Key;

        return count;
    }
}

public class SolutionHashSet
{
    public int SumOfUnique(int[] nums)
    {
        HashSet<int> unique = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();
        
        foreach (int num in nums)
        {
            if (unique.Contains(num))
            {
                unique.Remove(num);
                duplicates.Add(num);
            }
            else if (!duplicates.Contains(num))
            {
                unique.Add(num);
            }
        }
        
        int sum = 0;
        foreach (int num in unique)
        {
            sum += num;
        }
        
        return sum;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        SolutionHashSet set = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.SumOfUnique([1,2,3,2]), 4),
            ResultTester.CheckResult<int>(solution.SumOfUnique([1,1,1,1,1]), 0),
            ResultTester.CheckResult<int>(solution.SumOfUnique([1,2,3,4,5]), 15),
            ResultTester.CheckResult<int>(set.SumOfUnique([1,2,3,2]), 4),
            ResultTester.CheckResult<int>(set.SumOfUnique([1,1,1,1,1]), 0),
            ResultTester.CheckResult<int>(set.SumOfUnique([1,2,3,4,5]), 15),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Unique Elements");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}