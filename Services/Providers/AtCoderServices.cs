using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Services.Providers
{
    public class AtCoderServices : IAtCoderServices
    {
        public int GetAtCoderProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(atCoderList);
        }

        // Delegates

        private static readonly Delegate[] atCoderList = new Delegate[]
        {
            ADisjointSetUnionFunc, BFenwickTreeFunc, CFloorSumFunc, DMaxflowFunc, EMinCostFlowFunc, FConvolutionFunc, GSCCFunc, TwoSATFunc, NumberofSubstringsFunc, SegmentTreeFunc, RangeAffineRangeSumFunc, LazySegmentTreeFunc,
        };

        // Functions
        private static void LazySegmentTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lazy Segment Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder);
        }

        private static void RangeAffineRangeSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Range Affine Range Sum");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder);
        }

        private static void SegmentTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Segment Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder);
        }
        private static void TwoSATFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two SAT");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder);
        }

        private static void NumberofSubstringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Substrings");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder);
        }
        private static void GSCCFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("SCC");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder);
        }
        private static void ADisjointSetUnionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Disjoint Set Union");
            ResultTester.CheckSolution(ProblemOrigin.AtCoder, AtCoder.ADisjointSetUnion.Test.TestCases());
        }

        private static void BFenwickTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fenwick Tree");
            ResultTester.CheckSolution(ProblemOrigin.AtCoder, AtCoder.BFenwickTree.Test.TestCases());
        }

        private static void CFloorSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Floor Sum");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder);
        }

        private static void DMaxflowFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max flow");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder);
        }

        private static void EMinCostFlowFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Cost Flow");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder);
        }

        private static void FConvolutionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convolution");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder);
        }
    }
}