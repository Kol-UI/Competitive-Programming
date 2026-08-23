// Minimum Index Sum of Two Lists
namespace CompetitiveProgramming.LeetCode.MinimumIndexSumofTwoLists;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        Dictionary<string,int> dict = new Dictionary<string,int>();
        Dictionary<string,int> dict2 = new Dictionary<string,int>();

        for (int i = 0;i < list1.Length; i++)
        {
            if (!dict.ContainsKey(list1[i]))
            {
                dict[list1[i]] = i;
            }
        }
        for (int i = 0;i < list2.Length; i++)
        {
            if (dict.ContainsKey(list2[i]))
            {
                dict2[list2[i]] = dict[list2[i]] + i;
            }
        }

        var k = dict2.Values.Min();
        return dict2.Where(kv => kv.Value == k).ToDictionary().Keys.ToList().ToArray();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string[]>(solution.FindRestaurant(["Shogun","Tapioca Express","Burger King","KFC"], ["Piatti","The Grill at Torrey Pines","Hungry Hunter Steakhouse","Shogun"]), ["Shogun"]),
            ResultTester.CheckResult<string[]>(solution.FindRestaurant(["Shogun","Tapioca Express","Burger King","KFC"], ["KFC","Shogun","Burger King"]), ["Shogun"]),
            ResultTester.CheckResult<string[]>(solution.FindRestaurant(["happy","sad","good"], ["sad","happy","good"]), ["sad","happy"]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Index Sum of Two Lists");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}