using CompetitiveProgramming.Helpers.Outputs;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;
using CompetitiveProgramming.Helpers.Delegates;

namespace CompetitiveProgramming.Services.Providers
{
    public class CodinGameServices : ICodinGameServices
    {
        public int GetCodinGameProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(codinGameList);
        }

        // Delegates
        private static readonly Delegate[] codinGameList = new Delegate[]
        {
            TheDescentFunc, OnboardingFunc,
        };

        // Functions
        private static void TheDescentFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("The Descent");
            ResultTester.SpecialTestCase(ProblemOrigin.CodinGame);
        }

        private static void OnboardingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Onboarding");
            ResultTester.SpecialTestCase(ProblemOrigin.CodinGame);
        }
    }
}