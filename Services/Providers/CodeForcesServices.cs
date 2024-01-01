using CompetitiveProgramming.Helpers.Outputs;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;
using CompetitiveProgramming.Helpers.Delegates;

namespace CompetitiveProgramming.Services.Providers
{
    public class CodeForcesServices : ICodeForcesServices
    {
        public int GetCodeForces800Problems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(codeForces800List);
        }

        // Delegates
        private static readonly Delegate[] codeForces800List = new Delegate[]
        {
            TeamFunc, WayTooLongWordsFunc, WatermelonFunc, NextRoundFunc, DominoPilingFunc, BitPPFunc, BeautifulMatrixFunc, PetyaandStringsFunc, HelpfulMathsFunc, WordCapitalizationFunc, BoyorGirlFunc, StonesontheTableFunc, BearandBigBrotherFunc, SoldierandBananasFunc, ElephantFunc, WordFunc,
            WrongSubtractionFunc, NearlyLuckyNumberFunc, AntonandDanikFunc, ATranslationFunc, ATramFunc, VanyaandFenceFunc, QueueattheSchoolFunc, BeautifulYearFunc, InSearchofanEasyProblemFunc, GeorgeandAccommodationFunc, MagnetsFunc, PresentsFunc, CalculateFunctionFunc, DrinksFunc,
            UltraFastMathematicianFunc, IsyourhorseshoeontheotherhoofFunc, HulkFunc, DivisibilityProblemFunc, IWannaBetheGuyFunc, ArrivaloftheGeneralFunc, PangramFunc, InsomniacureFunc, AntonandLettersFunc, HittheLotteryFunc, GamesFunc, AntonandPolyhedronsFunc, CandiesandTwoSistersFunc,
            AmusingJokeFunc, FoxAndSnakeFunc, PoliceRecruitsFunc, IloveusernameFunc, NewYearandHurryFunc, SumofRoundNumbers, TheNewYearMeetingFriendsFunc, VasyatheHipsterFunc, BuyaShovelFunc, RestoringThreeNumbersFunc, SoftDrinkingFunc,
        };

        // Functions 
        private static void BuyaShovelFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Buy a Shovel");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.BuyaShovel.Test.TestCases());
        }

        private static void VasyatheHipsterFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Vasya the Hipster");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.VasyatheHipster.Test.TestCases());
        }

        private static void PoliceRecruitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Police Recruits");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.PoliceRecruits.Test.TestCases());
        }

        private static void AntonandDanikFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Anton and Danik");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.AntonandDanik.Test.TestCases());
        }

        private static void InSearchofanEasyProblemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("In Search of an Easy Problem");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.InSearchofanEasyProblem.Test.TestCases());
        }

        private static void BeautifulYearFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Beautiful Year");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.BeautifulYear.Test.TestCases());
        }

        private static void VanyaandFenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Vanya and Fence");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.VanyaandFence.Test.TestCases());
        }

        private static void QueueattheSchoolFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Queue at the School");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.QueueattheSchool.Test.TestCases());
        }

        private static void DrinksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Drinks");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.Drinks.Test.TestCases());
        }

        private static void ATranslationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("41A Translation");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.Translation.Test.TestCases());
        }

        private static void ATramFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("116A Tram");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.Tram.Test.TestCases());
        }

        private static void GeorgeandAccommodationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("George and Accommodation");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.GeorgeandAccommodation.Test.TestCases());
        }

        private static void PresentsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Presents");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void CalculateFunctionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculate Function");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }
        
        private static void MagnetsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Magnets");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.Magnets.Test.TestCases());
        }

        private static void CandiesandTwoSistersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Candies and Two Sisters");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void NewYearandHurryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("New Year and Hurry");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void ArrivaloftheGeneralFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Arrival of the General");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void IloveusernameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("I love username");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void SumofRoundNumbers()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Round Numbers");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void AmusingJokeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Amusing Joke");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void TheNewYearMeetingFriendsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("The New Year Meeting Friends");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void NextRoundFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Round");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.NextRound.Test.TestCases());
        }

        private static void FoxAndSnakeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fox And Snake");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void DivisibilityProblemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Divisibility Problem");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void PangramFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pangram");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void InsomniacureFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Insomnia cure");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void AntonandLettersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Anton and Letters");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void IWannaBetheGuyFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("I Wanna Be the Guy");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void DominoPilingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarray Product Less Than K");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.DominoPiling.Test.TestCases());
        }

        private static void TeamFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Team");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.Team.Test.TestTeam());
        }

        private static void UltraFastMathematicianFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ultra Fast Mathematician");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void HittheLotteryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hit the Lottery");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void GamesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Games");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void HulkFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hulk");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void IsyourhorseshoeontheotherhoofFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Is your horseshoe on the other hoof");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void AntonandPolyhedronsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Anton and Polyhedrons");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void WayTooLongWordsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Way Too Long Words");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void WrongSubtractionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Wrong Subtraction");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void NearlyLuckyNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Nearly Lucky Number");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void WatermelonFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Watermelon");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void SoldierandBananasFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Soldier and Bananas");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void ElephantFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Elephant");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void WordFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.Word.Test.TestCases());
        }

        private static void StonesontheTableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Stones on the Table");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void BearandBigBrotherFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bear and Big Brother");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void RestoringThreeNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Restoring Three Numbers");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void SoftDrinkingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Soft Drinking");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces);
        }

        private static void WordCapitalizationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Capitalization");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.WordCapitalization.Solution.TestCases());
        }

        private static void BoyorGirlFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Boy or Girl");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.BoyorGirl.Solution.TestCases());
        }

        private static void HelpfulMathsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Helpful Maths");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.HelpfulMaths.Test.TestCases());
        }

        private static void PetyaandStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Petya and Strings");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.PetyaandStrings.Test.TestCases());
        }

        private static void BeautifulMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Beautiful Matrix");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.BeautifulMatrix.Test.TestCases());
        }

        private static void BitPPFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bit++");
            ResultTester.CheckSolution(ProblemOrigin.CodeForces, CodeForces.BitPP.Test.TestCases());
        }
    }
}