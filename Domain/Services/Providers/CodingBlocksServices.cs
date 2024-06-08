using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Services.Providers
{
    public class CodingBlocksServices : ICodingBlocksServices
    {
        public int GetCodingBlocksProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(codingBlocksEasyList);
        }

        // Delegates
        private static readonly Delegate[] codingBlocksEasyList = new Delegate[]
        {
            UltraFastMathematiciansFunc, PushzeroestoendFunc,
        };

        // Functions 

        private static void PushzeroestoendFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Push zeroes to end");
            ResultTester.SpecialTestCase(ProblemOrigin.CodingBlocks);
        }

        private static void UltraFastMathematiciansFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ultra Fast Mathematicians");
            ResultTester.SpecialTestCase(ProblemOrigin.CodingBlocks);
        }
    }
}