// Letter Tile Possibilities
namespace CompetitiveProgramming.LeetCode.LetterTilePossibilities;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumTilePossibilities(string tiles)
    {
        if(string.IsNullOrEmpty(tiles))
            return 0;

        HashSet<string> set = new HashSet<string>();
        HashSet<int> visited = new HashSet<int>();
        Backtracking(tiles, new StringBuilder(), visited, set);
        return set.Count;
    }

    public void Backtracking(string tiles, StringBuilder sb, HashSet<int> visited, HashSet<string> set)
    {
        for(int i = 0; i < tiles.Length; i++)
        {
            if(!visited.Contains(i))
            {
                sb.Append(tiles[i]);
                set.Add(sb.ToString());
                visited.Add(i);
                Backtracking(tiles, sb, visited, set);
                sb.Length--;
                visited.Remove(i);
            }
        }
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.NumTilePossibilities("AAB"), 8),
            ResultTester.CheckResult<int>(solution.NumTilePossibilities("V"), 1),
            ResultTester.CheckResult<int>(solution.NumTilePossibilities("AAABBC"), 188)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Letter Tile Possibilities");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}