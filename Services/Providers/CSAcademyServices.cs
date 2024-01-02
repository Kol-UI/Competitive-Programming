using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Services.Providers
{
    public class CSAcademyServices : ICSAcademyServices
    {
        public int GetCSAcademyTutorialProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(csacademyTutorialList);
        }

        public int GetCSAcademyEasyProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(csacademyEasyList);
        }

        // Delegates
        private static readonly Delegate[] csacademyTutorialList = new Delegate[]
        {
            AdditionFunc, GreatestCommonDivisorFunc,
        };

        private static readonly Delegate[] csacademyEasyList = new Delegate[]
        {
            MatrixExplorationFunc,
        };

        // Functions
        private static void AdditionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Addition");
            ResultTester.SpecialTestCase(ProblemOrigin.CSAcademy);
        }

        private static void GreatestCommonDivisorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Greatest Common Divisor");
            ResultTester.SpecialTestCase(ProblemOrigin.CSAcademy);
        }

        private static void MatrixExplorationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Matrix Exploration");
            ResultTester.SpecialTestCase(ProblemOrigin.CSAcademy);
        }
    }
}