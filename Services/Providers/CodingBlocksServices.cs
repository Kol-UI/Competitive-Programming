using CompetitiveProgramming.Helpers.Outputs;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;
using CompetitiveProgramming.Helpers.Delegates;

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
            UltraFastMathematiciansFunc,
        };

        // Functions
        private static void UltraFastMathematiciansFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ultra Fast Mathematicians");
            ResultTester.SpecialTestCase(ProblemOrigin.CodingBlocks);
        }
    }
}