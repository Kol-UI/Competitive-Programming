using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Services.Providers
{
    public class GeeksForGeeksServices : IGeeksForGeeksServices
    {
        public int GetGeeksForGeeksSchoolProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(geeksForGeeksSchoolList);
        }

        public int GetGeeksForGeeksBasicProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(geeksForGeeksBasicList);
        }

        public int GetGeeksForGeeksEasyProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(geeksForGeeksEasyList);
        }

        public int GetGeeksForGeeksMediumProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(geeksForGeeksMediumList);
        }

        public int GetGeeksForGeeksHardProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(geeksForGeeksHardList);
        }

        // Delegates
        private static readonly Delegate[] geeksForGeeksSchoolList = new Delegate[]
        {
            SumofSeriesFunc, PrintSecondLargestFunc, Print1ToNWithoutLoopFunc,
        };

        private static readonly Delegate[] geeksForGeeksBasicList = new Delegate[]
        {
            PrintfirstnFibonacciNumbersFunc, ReversearrayingroupsFunc,
        };

        private static readonly Delegate[] geeksForGeeksEasyList = new Delegate[]
        {
            CounttheSubstringsFunc, MinimumIntegerFunc, Remainderondividingby11Func, MakeArrayElementsEqualFunc, EqualLeftandRightSubarraySumFunc, BFSofgraphFunc, MakeTheArrayBeautifulFunc, FrogsAndJumpFunc, DominantPairsFunc, DFSofGraphFunc,
            StringPermutationsFunc, FindfirstsetbitFunc, SumofupperandlowertrianglesFunc, DetermineifTwoTreesareIdenticalFunc, EquilibriumPointFunc, DeterminantofaMatrixFunc,
        };

        private static readonly Delegate[] geeksForGeeksMediumList = new Delegate[]
        {
            StringrporprFunc, EvenSwapFunc, MinimumStepsRequiredFunc, AddMinimumCharactersFunc, MaximumLengthFunc, RemoveandReverseFunc, ShyGeek, MaximumIntersectingLinesFunc, KnightInGeeklandFunc, CountSpecialNumbersFunc, BTSMaximumDifferenceFunc,
            ReverseaStackFunc, SticklerThiefFunc, BinaryTreetoCDLLFunc,
        };

        private static readonly Delegate[] geeksForGeeksHardList = new Delegate[]
        {
            SpecialDigitsFunc, DivideInIncrementialGroupsFunc, SolvetheSudokuFunc, CandyGFGFunc,
        };

        // Functions 

        private static void DeterminantofaMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Determinant of a Matrix");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Easy.DeterminantofaMatrix.Test.TestCases());
        }

        private static void DFSofGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("DFS of Graph");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Easy.DFSofGraph.Test.TestDFSofGraph());
        }

        private static void CandyGFGFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Candy");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Hard.Candy.Test.TestCases());
        }

        private static void DetermineifTwoTreesareIdenticalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Determine if Two Trees are Identical");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void PrintfirstnFibonacciNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Print first n Fibonacci Numbers");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Basic.PrintfirstnFibonacciNumbers.Test.TestCases());
        }

        private static void ReversearrayingroupsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse array in groups");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void SumofSeriesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Series");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.School.SumofSeries.Test.TestSumofSeries());
        }

        private static void PrintSecondLargestFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Print Second Largest");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.School.SecondLargest.Test.TestSecondLargest());
        }

        private static void StringrporprFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String rp or pr");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Medium.Stringrporpr.Test.TestStringrporpr());
        }

        private static void ReverseaStackFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse a Stack");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void CounttheSubstringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count the Substrings");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Easy.CounttheSubstrings.Test.TestCounttheSubstrings());
        }

        private static void MinimumIntegerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Integer");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Easy.MinimumInteger.Test.TestMinimumInteger());
        }

        private static void EvenSwapFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Even Swap");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Medium.EvenSwap.Test.TestEvenSwap());
        }

        private static void RemoveandReverseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove and Reverse");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void ShyGeek()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shy Geek");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void Remainderondividingby11Func()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remainder on dividing by 11");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Easy.Remainderondividingby11.Test.TestRemainderondividingby11());
        }

        private static void MakeArrayElementsEqualFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make Array Elements Equal");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Easy.MakeArrayElementsEqual.Test.TestMakeArrayElementsEqual());
        }

        private static void MinimumStepsRequiredFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Steps Required");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Medium.MinimumStepsRequired.Test.TestMinimumStepsRequired());
        }

        private static void EqualLeftandRightSubarraySumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Equal Left and Right Subarray Sum");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Easy.EqualLeftandRightSubarraySum.Test.TestEqualLeftandRightSubarraySum());
        }

        private static void AddMinimumCharactersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Minimum Characters");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Medium.AddMinimumCharacters.Test.TestAddMinimumCharacters());
        }

        private static void DominantPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Dominant Pairs");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void SpecialDigitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Special Digits");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void DivideInIncrementialGroupsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Divide In Incremential Groups");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void BFSofgraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("BFS of graph");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void MaximumLengthFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Length");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Medium.MaximumLength.Test.TestMaximumLength());
        }

        private static void MaximumIntersectingLinesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Intersecting Lines");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void CountSpecialNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Special Numbers");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void KnightInGeeklandFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Knight In Geekland");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void BTSMaximumDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("BTS Maximum Difference");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void MakeTheArrayBeautifulFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make The Array Beautiful");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void FrogsAndJumpFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Frogs And Jump");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void StringPermutationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Permutations");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Easy.StringPermutations.Test.TestCases());
        }

        private static void SolvetheSudokuFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Solve the Sudoku");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void BinaryTreetoCDLLFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree to CDLL");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void SumofupperandlowertrianglesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of upper and lower triangles");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Easy.Sumofupperandlowertriangles.Test.TestCases());
        }

        private static void Print1ToNWithoutLoopFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Print 1 To N Without Loop");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks);
        }

        private static void FindfirstsetbitFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find first set bit");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Easy.Findfirstsetbit.Test.TestCases());
        }

        private static void EquilibriumPointFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Equilibrium Point");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Easy.EquilibriumPoint.Test.TestCases());
        }

        private static void SticklerThiefFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Stickler Thief");
            ResultTester.CheckSolution(ProblemOrigin.GeeksForGeeks, GeeksForGeeks.Medium.SticklerThief.Test.TestCases());
        }
    }
}