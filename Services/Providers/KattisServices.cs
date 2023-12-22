using CompetitiveProgramming.Helpers.Outputs;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;
using CompetitiveProgramming.Helpers.Delegates;

namespace CompetitiveProgramming.Services.Providers
{
    public class KattisServices : IKattisServices
    {
        public int GetKattisEasyProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(kattisEasyList);
        }

        // Delegates
        private static readonly Delegate[] kattisEasyList = new Delegate[]
        {
            VelkominFunc, HelloWorldKattisFunc, LeggjasamanFunc, SevenWondersFunc, EchoEchoEchoFunc, SecretMessageFunc,
        };

        // Functions
        private static void VelkominFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Velkomin");
            ResultTester.SpecialTestCase(ProblemOrigin.Kattis);
        }

        private static void EchoEchoEchoFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Echo Echo Echo");
            ResultTester.SpecialTestCase(ProblemOrigin.Kattis);
        }

        private static void LeggjasamanFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Leggja saman");
            ResultTester.SpecialTestCase(ProblemOrigin.Kattis);
        }

        private static void SecretMessageFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Secret Message");
            ResultTester.SpecialTestCase(ProblemOrigin.Kattis);
        }

        private static void SevenWondersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Seven Wonders");
            ResultTester.SpecialTestCase(ProblemOrigin.Kattis);
        }
        
        private static void HelloWorldKattisFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hello World");
            ResultTester.SpecialTestCase(ProblemOrigin.Kattis);
        }
    }
}