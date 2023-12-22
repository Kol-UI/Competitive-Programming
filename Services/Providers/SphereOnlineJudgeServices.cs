using CompetitiveProgramming.Helpers.Outputs;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;
using CompetitiveProgramming.Helpers.Delegates;

namespace CompetitiveProgramming.Services.Providers
{
    public class SphereOnlineJudgeServices : ISphereOnlineJudgeServices
    {
        public int GetSphereOnlineJudgeProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(sphereOnlineJudgeList);
        }

        // Delegates
        private static readonly Delegate[] sphereOnlineJudgeList = new Delegate[]
        {
            LifetheUniverseandEverythingFunc, PrimeGeneratorFunc, TransformtheExpressionFunc,
        };

        // Functions
        private static void LifetheUniverseandEverythingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Life the Universe and Everything");
            ResultTester.SpecialTestCase(ProblemOrigin.SphereOnlineJudge);
        }

        private static void TransformtheExpressionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Transform the Expression");
            ResultTester.SpecialTestCase(ProblemOrigin.SphereOnlineJudge);
        }

        private static void PrimeGeneratorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Prime Generator");
            ResultTester.SpecialTestCase(ProblemOrigin.SphereOnlineJudge);
        }
    }
}