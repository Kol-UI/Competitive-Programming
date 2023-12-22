using CompetitiveProgramming.Helpers.Outputs;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;
using CompetitiveProgramming.Helpers.Delegates;

namespace CompetitiveProgramming.Services.Providers
{
    public class HackerRankServices : IHackerRankServices
    {
        public int GetHackerRankEasyProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(hackerRankEasyList);
        }

        public int GetHackerRankMediumProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(hackerRankMediumList);
        }

        public int GetHackerRankHardProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(hackerRankHardList);
        }

        // Delegates
        private static readonly Delegate[] hackerRankEasyList = new Delegate[]
        {
            SimpleArraySumFunc, SolveMeFirstFunc, AVeryBigSumFunc, CompareTheTripletsFunc, DiagonalDifferenceFunc, PlusMinusFunc, StaircaseFunc, MiniMaxSumFunc, BirthdayCakeCandlesFunc, TimeConversionFunc, GradientStudentsFunc,
        };

        private static readonly Delegate[] hackerRankMediumList = new Delegate[]
        {
            
        };

        private static readonly Delegate[] hackerRankHardList = new Delegate[]
        {
            FormingaMagicSquareFunc, AshtonandStringFunc,
        };

        // Functions
        private static void SimpleArraySumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Simple Array Sum");
            ResultTester.CheckSolution(ProblemOrigin.HackerRank, HackerRank.SimpleArraySum.Test.TestSimpleArraySum());
        }

        private static void SolveMeFirstFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Solve Me First");
            ResultTester.CheckSolution(ProblemOrigin.HackerRank, HackerRank.SolveMeFirst.Test.TestSolveMeFirst());
        }

        private static void AVeryBigSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("A Very Big Sum");
            ResultTester.CheckSolution(ProblemOrigin.HackerRank, HackerRank.AVeryBigSum.Test.TestCases());
        }

        private static void CompareTheTripletsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Compare The Triplets");
            ResultTester.CheckSolution(ProblemOrigin.HackerRank, HackerRank.CompareTheTriplets.Test.TestCompareTriplets());
        }

        private static void DiagonalDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Diagonal Difference");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerRank);
        }

        private static void PlusMinusFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Plus Minus");
            ResultTester.CheckSolution(ProblemOrigin.HackerRank, HackerRank.PlusMinus.Test.TestPlusMinus());
        }

        private static void StaircaseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Staircase");
            ResultTester.CheckSolution(ProblemOrigin.HackerRank, HackerRank.Staircase.Test.TestCases());
        }

        private static void FormingaMagicSquareFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Forming a Magic Square");
            ResultTester.CheckSolution(ProblemOrigin.HackerRank, HackerRank.FormingaMagicSquare.Test.TestCases());
        }

        private static void AshtonandStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ashton and String");
            ResultTester.CheckSolution(ProblemOrigin.HackerRank, HackerRank.AshtonandString.Test.TestCases());
        }

        private static void MiniMaxSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Mini-Max Sum");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerRank);
        }

        private static void BirthdayCakeCandlesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Birthday Cake Candles");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerRank);
        }

        private static void TimeConversionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Time Conversion");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerRank);
        }

        private static void GradientStudentsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Gradient Students");
            ResultTester.CheckSolution(ProblemOrigin.HackerRank, HackerRank.GradientStudents.Test.TestCases());
        }
    }
}