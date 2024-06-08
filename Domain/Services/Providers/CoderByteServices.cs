using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Services.Providers
{
    public class CoderByteServices : ICoderByteServices
    {
        public int GetCoderByteEasyProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(coderByteEasyList);
        }

        public int GetCoderByteMediumProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(coderByteMediumList);
        }

        public int GetCoderByteHardProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(coderByteHardList);
        }

        // Delegates

        private static readonly Delegate[] coderByteEasyList = new Delegate[]
        {
            FirstFactorialFunc, FirstReverseFunc, CodelandUsernameValidationFunc, FindIntersectionFunc, QuestionsMarksFunc, LongestWordFunc,
        };

        private static readonly Delegate[] coderByteMediumList = new Delegate[]
        {
            MinWindowSubstringFunc, TreeConstructorFunc, BracketMatcherFunc,
        };

        private static readonly Delegate[] coderByteHardList = new Delegate[]
        {
            BracketCombinationsFunc,
        };

        // Functions

        private static void BracketMatcherFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bracket Matcher");
            ResultTester.CheckSolution(ProblemOrigin.CoderByte, CoderByte.BracketMatcher.Test.TestCases());
        }

        private static void TreeConstructorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Tree Constructor");
            ResultTester.CheckSolution(ProblemOrigin.CoderByte, CoderByte.TreeConstructor.Test.TestCases());
        }

        private static void MinWindowSubstringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Window Substring");
            ResultTester.CheckSolution(ProblemOrigin.CoderByte, CoderByte.MinWindowSubstring.Test.TestCases());
        }

        private static void LongestWordFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Word");
            ResultTester.CheckSolution(ProblemOrigin.CoderByte, CoderByte.LongestWord.Test.TestCases());
        }

        private static void QuestionsMarksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Questions Marks");
            ResultTester.CheckSolution(ProblemOrigin.CoderByte, CoderByte.QuestionsMarks.Test.TestCases());
        }

        private static void FindIntersectionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Intersection");
            ResultTester.CheckSolution(ProblemOrigin.CoderByte, CoderByte.FindIntersection.Test.TestCases());
        }

        private static void CodelandUsernameValidationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Codeland Username Validation");
            ResultTester.CheckSolution(ProblemOrigin.CoderByte, CoderByte.CodelandUsernameValidation.Test.TestCases());
        }

        private static void BracketCombinationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bracket Combinations");
            ResultTester.CheckSolution(ProblemOrigin.CoderByte, CoderByte.BracketCombinations.Test.TestCases());
        }

        private static void FirstFactorialFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("First Factorial");
            ResultTester.CheckSolution(ProblemOrigin.CoderByte, CoderByte.FirstFactorial.Test.TestFirstFactorial());
        }

        private static void FirstReverseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("First Reverse");
            ResultTester.CheckSolution(ProblemOrigin.CoderByte, CoderByte.FirstReverse.Test.TestFirstReverse());
        }
    }
}
