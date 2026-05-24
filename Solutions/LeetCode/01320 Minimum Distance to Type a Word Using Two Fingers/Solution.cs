// Minimum Distance to Type a Word Using Two Fingers
namespace CompetitiveProgramming.LeetCode.MinimumDistancetoTypeaWordUsingTwoFingers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private readonly Dictionary<char, (int X, int Y)> _map = new Dictionary<char, (int X, int Y)>
    {
        { 'A', (0, 0) },
        { 'B', (0, 1) },
        { 'C', (0, 2) },
        { 'D', (0, 3) },
        { 'E', (0, 4) },
        { 'F', (0, 5) },
        { 'G', (1, 0) },
        { 'H', (1, 1) },
        { 'I', (1, 2) },
        { 'J', (1, 3) },
        { 'K', (1, 4) },
        { 'L', (1, 5) },
        { 'M', (2, 0) },
        { 'N', (2, 1) },
        { 'O', (2, 2) },
        { 'P', (2, 3) },
        { 'Q', (2, 4) },
        { 'R', (2, 5) },
        { 'S', (3, 0) },
        { 'T', (3, 1) },
        { 'U', (3, 2) },
        { 'V', (3, 3) },
        { 'W', (3, 4) },
        { 'X', (3, 5) },
        { 'Y', (4, 0) },
        { 'Z', (4, 1) },
    };

    public int MinimumDistance(string word)
    {
        var cache = new Dictionary<(int, int, int, int?, int?), int>();
        return Impl(1, _map[word[0]], null);

        int Impl(int index, (int X, int Y) left, (int X, int Y)? right)
        {
            if (index >= word.Length) return 0;

            var cacheKey = right.HasValue
                ? (index, left.X, left.Y, (int?)right.Value.X, (int?)right.Value.Y)
                : (index, left.X, left.Y, (int?)null, (int?)null);

            if (cache.TryGetValue(cacheKey, out var cacheResult)) return cacheResult;

            var letterPosition = _map[word[index]];

            var result = Math.Min(
                Impl(index + 1, letterPosition, right) + Distance(left, letterPosition),
                Impl(index + 1, left, letterPosition) + (right.HasValue ? Distance(right.Value, letterPosition) : 0)
            );

            cache.Add(cacheKey, result);

            return result;
        }
    }

    private static int Distance((int X, int Y) a, (int X, int Y) b) => Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinimumDistance("CAKE"), 3),
            ResultTester.CheckResult<int>(solution.MinimumDistance("HAPPY"), 6),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Distance to Type a Word Using Two Fingers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}