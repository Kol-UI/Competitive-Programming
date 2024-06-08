using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Services.Providers
{
    public class ProjectEulerServices : IProjectEulerServices
    {
        public int GetProjectEulerProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(projectEulerList);
        }

        // Delegates
        private static readonly Delegate[] projectEulerList = new Delegate[]
        {
            Multiplesof3or5Func, EvenFibonacciNumbersFunc, LargestPrimeFactorFunc, LargestPalindromeProductFunc,
        };

        // Functions
        private static void Multiplesof3or5Func()
        {
            StyleHelper.Space();
            StyleHelper.Title("Multiple of 3 or 5");
            ResultTester.CheckSolution(ProblemOrigin.ProjectEuler, ProjectEuler.Multiplesof3or5.Test.TestCases());
        }

        private static void LargestPalindromeProductFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Palindrome Product");
            ResultTester.CheckSolution(ProblemOrigin.ProjectEuler, ProjectEuler.LargestPalindromeProduct.Test.TestCases());
        }

        private static void EvenFibonacciNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Even Fibonacci Numbers");
            ResultTester.CheckSolution(ProblemOrigin.ProjectEuler, ProjectEuler.EvenFibonacciNumbers.Test.TestCases());
        }

        private static void LargestPrimeFactorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Prime Factor");
            ResultTester.CheckSolution(ProblemOrigin.ProjectEuler, ProjectEuler.LargestPrimeFactor.Test.TestCases());
        }
    }
}