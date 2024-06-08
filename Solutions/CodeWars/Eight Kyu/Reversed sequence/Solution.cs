// Reversed sequence

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.Reversedsequence
{
    public static class Kata
    {
        public static int[] ReverseSeq(int n)
        {
            var list = new List<int>();
            for(int i = n; i > 0; i--)
                list.Add(i);
            return list.ToArray();
        }

        public static int[] ReverseSeqLinq(int n) => Enumerable.Range(1,n).Reverse().ToArray();
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Kata.ReverseSeq(5), new int[] {5,4,3,2,1}),
                ResultTester.CheckResult<int[]>(Kata.ReverseSeqLinq(5), new int[] {5,4,3,2,1}),
                ResultTester.CheckResult<int[]>(Kata.ReverseSeq(6), new int[] {6,5,4,3,2,1}),
                ResultTester.CheckResult<int[]>(Kata.ReverseSeqLinq(6), new int[] {6,5,4,3,2,1}),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reversed sequence");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestCases());
        }
    }
}