// Cells in a Range on an Excel Sheet
namespace CompetitiveProgramming.LeetCode.CellsinaRangeonanExcelSheet;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<string> CellsInRange(string s)
    {
        var list = new List<string>();
		var range = s.Split(':');
		var start = range[0];
		var end = range[1];
		for (var cStart = start[0]; cStart <= end[0]; cStart++)
		{
			for (var rStart = start[1]; rStart <= end[1]; rStart++)
			{
				list.Add($"{cStart}{rStart}");
			}
		}
		return list;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        IList<string> list1 = new List<string> { "K1", "K2", "L1", "L2" };
        IList<string> list2 = new List<string> { "A1","B1","C1","D1","E1","F1" };
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<IList<string>>(solution.CellsInRange("K1:L2"), list1),
            ResultTester.CheckResult<IList<string>>(solution.CellsInRange("A1:F1"), list2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cells in a Range on an Excel Sheet");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}