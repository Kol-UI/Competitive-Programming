using System;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services.Providers;
using CompetitiveProgramming.Services;
using CompetitiveProgramming.CodeForces.BuyaShovel;

namespace CompetitiveProgramming.TestDrivenDevelopment
{
    public class CSharpTDD
    {
        public static void StartAllTDD()
        {
            if (TestHelpers() == true)
            {
                Console.WriteLine("Helpers Are Ready");
                TestSolutions();

                ResultTester.InitializeCounters();// dictionaries count
                AutoInstantiate.SetAutoInstantiate();
                DelegateLists.ExecuteDelegates();
                int pb = ResultTester.GetCounterOrigin(ProblemOrigin.AtCoder);
                int AtCoder = ResultTester.GetCounterDifficulty(ProblemCategory.BeginnerAC);
                Console.WriteLine("AtCoder " + pb + " BeginnerAC " + AtCoder);
                
                int pb2 = ResultTester.GetCounterOrigin(ProblemOrigin.CodeChef);
                int ccLearn = ResultTester.GetCounterDifficulty(ProblemCategory.LearnCC);
                int ccBeginner = ResultTester.GetCounterDifficulty(ProblemCategory.BeginnerCC);
                Console.WriteLine("CodeChef " + pb2 + " learn " + ccLearn + " beginner " + ccBeginner);

                int pb3 = ResultTester.GetCounterOrigin(ProblemOrigin.CodeForces);
                int CF800 = ResultTester.GetCounterDifficulty(ProblemCategory.CF800);
                Console.WriteLine("CodeForces " + pb3 + " 800 " + CF800);

                int pb4 = ResultTester.GetCounterOrigin(ProblemOrigin.CoderByte);
                int CByHard = ResultTester.GetCounterDifficulty(ProblemCategory.HardCBy);
                int CByMedium = ResultTester.GetCounterDifficulty(ProblemCategory.MediumCBy);
                int CByEasy = ResultTester.GetCounterDifficulty(ProblemCategory.EasyCBy);
                Console.WriteLine("CoderByte " + pb4 + " Hard " + CByHard + " Medium " + CByMedium + " Easy " + CByEasy);

                int pb5 = ResultTester.GetCounterOrigin(ProblemOrigin.CodeWars);
                int kyu8 = ResultTester.GetCounterDifficulty(ProblemCategory.EightKyu);
                int kyu7 = ResultTester.GetCounterDifficulty(ProblemCategory.SevenKyu);
                int kyu6 = ResultTester.GetCounterDifficulty(ProblemCategory.SixKyu);
                Console.WriteLine("CodeWars " + pb5 + " EightKyu " + kyu8 + " SevenKyu " + kyu7 + " SixKyu " + kyu6);

                int pb6 = ResultTester.GetCounterOrigin(ProblemOrigin.CodinGame);
                Console.WriteLine("CodinGame " + pb6);

                int pb7 = ResultTester.GetCounterOrigin(ProblemOrigin.CodingBlocks);
                int CBlEasy = ResultTester.GetCounterDifficulty(ProblemCategory.EasyCBl);
                Console.WriteLine("CodingBlocks " + pb7 + " Easy " + CBlEasy);

                int pb8 = ResultTester.GetCounterOrigin(ProblemOrigin.CSAcademy);
                int CSATuto = ResultTester.GetCounterDifficulty(ProblemCategory.TutorialCSA);
                int CSAEasy = ResultTester.GetCounterDifficulty(ProblemCategory.EasyCSA);
                Console.WriteLine("CSAcademy " + pb8 + " Tuto " + CSATuto + " Easy " + CSAEasy);
            }
            else
            {
                Console.WriteLine("Helpers Must Be Ready");
            }
            // Current Testing Solution
            CurrentTest();
        }

        // HELPERS TESTS
        private static bool TestHelpers()
        {
            bool[] areHelpersReady = new bool[]
            {
                ArrayExtensionTests.MergeArraysTest(), ArrayExtensionTests.ProductArrayTest(),
                ListExtensionTests.MergeListsTest(), ListExtensionTests.ProductListTest(),
            };

            bool ready = areHelpersReady != null && areHelpersReady.Length > 0 && areHelpersReady.All(element => element);
            return ready;
        }

        // SOLUTIONS TESTS
        private static void TestSolutions()
        {
            CodingBlocksServices servicesCBL = new();
            CoderByteServices servicesCB = new();
            AtCoderServices servicesAC = new();
            CodeWarsServices servicesCW = new();
            GeeksForGeeksServices servicesGFG = new();
            CodeChefServices servicesCC = new();
            HackerRankServices servicesHR = new();
            CodeForcesServices servicesCF = new();
            SphereOnlineJudgeServices servicesSPOJ = new();
            KattisServices servicesKAT = new();
            CSAcademyServices servicesCSA = new();
            ProjectEulerServices servicesPE = new();
            CodinGameServices servicesCG = new();
            LeetCodeServices servicesLC = new();

            var tableRows = new List<TableData>
            {
                new() { Source = "CodingBlocks", Easy = servicesCBL.GetCodingBlocksProblems() },
                new() { Source = "CodeForces", Other = servicesCF.GetCodeForces800Problems() },
                new() { Source = "AtCoder", Other = servicesAC.GetAtCoderProblems() },
                new() { Source = "CoderByte", Easy = servicesCB.GetCoderByteEasyProblems(), Medium = servicesCB.GetCoderByteMediumProblems(), Hard = servicesCB.GetCoderByteHardProblems() },
                new() { Source = "CodeWars", Other = servicesCW.GetCodeWarsEightKyuProblems() + servicesCW.GetCodeWarsSevenKyuProblems() + servicesCW.GetCodeWarsSixKyuProblems() },
                new() { Source = "GeeksForGeeks", Other = servicesGFG.GetGeeksForGeeksSchoolProblems() + servicesGFG.GetGeeksForGeeksBasicProblems() , Easy = servicesGFG.GetGeeksForGeeksEasyProblems(), Medium = servicesGFG.GetGeeksForGeeksMediumProblems(), Hard = servicesGFG.GetGeeksForGeeksHardProblems() },
                new() { Source = "CodeChef", Other = servicesCC.GetCodeChefLearnProblems() + servicesCC.GetCodeChefBeginnerProblems() },
                new() { Source = "HackerRank", Easy = servicesHR.GetHackerRankEasyProblems(), Medium = servicesHR.GetHackerRankMediumProblems(), Hard = servicesHR.GetHackerRankHardProblems() },
                new() { Source = "SphereOnlineJudge", Other = servicesSPOJ.GetSphereOnlineJudgeProblems() },
                new() { Source = "Kattis", Easy = servicesKAT.GetKattisEasyProblems() },
                new() { Source = "CSAcademy", Other = servicesCSA.GetCSAcademyTutorialProblems(), Easy = servicesCSA.GetCSAcademyEasyProblems() },
                new() { Source = "ProjectEuler", Other = servicesPE.GetProjectEulerProblems() },
                new() { Source = "CodinGame", Other = servicesCG.GetCodinGameProblems() },
                new() { Source = "LeetCode", Easy = servicesLC.GetLeetCodeEasyProblems(), Medium = servicesLC.GetLeetCodeMediumProblems(), Hard = servicesLC.GetLeetCodeHardProblems() },
            };

            // ResultTester Stats
            ResultTester.GetSourceStats();
            ResultTester.GetAllStats();

            tableRows = tableRows.OrderByDescending(row => row.GetTotal()).ToList();
            TableMarkdownHelper.GenerateMarkdownTable(tableRows);
        }

        // CURRENT TEST
        private static void CurrentTest()
        {

        }
    }
}