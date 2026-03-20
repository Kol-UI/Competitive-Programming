// Fancy Sequence
namespace CompetitiveProgramming.LeetCode.FancySequence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Fancy
{

    private readonly List<long> _accumulator = new List<long>();

    public Fancy() { }

    public void Append(int val)
    {
        _accumulator.Add(val);
    }

    public void AddAll(int inc)
    {
        for (int i = 0; i < _accumulator.Count; i++)
            _accumulator[i] += inc;
    }

    public void MultAll(int m)
    {
        for (int i = 0; i < _accumulator.Count; i++)
        {
            _accumulator[i] = (_accumulator[i] * m) % 1_000_000_007L;
        }
    }

    public int GetIndex(int idx)
    {
        if (idx < _accumulator.Count)
        {
            return (int)_accumulator[idx];
        }

        return -1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fancy Sequence");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}