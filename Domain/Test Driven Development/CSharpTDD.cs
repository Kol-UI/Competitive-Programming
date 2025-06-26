using System;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services;

namespace CompetitiveProgramming.TestDrivenDevelopment
{
    public class CSharpTDD
    {
        public static void StartAllTDD()
        {
            if (TestHelpers() == true)
            {
                Console.WriteLine("Helpers Are Ready");

                ResultTester.InitializeCounters();// dictionaries count
                AutoInstantiate.SetAutoInstantiate();
                DelegateLists.ExecuteDelegates();

                var tableRows = new List<TableData>
                {
                    new() { Source = "CodingBlocks", Easy = ResultTester.GetCounterDifficulty(ProblemCategory.EasyCBl) },
                    new() { Source = "CodeForces", Other = ResultTester.GetCounterDifficulty(ProblemCategory.CF800) + ResultTester.GetCounterDifficulty(ProblemCategory.CF900) + ResultTester.GetCounterDifficulty(ProblemCategory.CF1000) + ResultTester.GetCounterDifficulty(ProblemCategory.CF1100) + ResultTester.GetCounterDifficulty(ProblemCategory.CF1200) + ResultTester.GetCounterDifficulty(ProblemCategory.CF1300) + ResultTester.GetCounterDifficulty(ProblemCategory.CF1400) + ResultTester.GetCounterDifficulty(ProblemCategory.CF1500) },
                    new() { Source = "AtCoder", Other = ResultTester.GetCounterDifficulty(ProblemCategory.BeginnerAC) },
                    new() { Source = "CoderByte", Easy = ResultTester.GetCounterDifficulty(ProblemCategory.EasyCBy), Medium = ResultTester.GetCounterDifficulty(ProblemCategory.MediumCBy), Hard = ResultTester.GetCounterDifficulty(ProblemCategory.HardCBy) },
                    new() { Source = "CodeWars", Other = ResultTester.GetCounterDifficulty(ProblemCategory.EightKyu) + ResultTester.GetCounterDifficulty(ProblemCategory.SevenKyu) + ResultTester.GetCounterDifficulty(ProblemCategory.SixKyu) },
                    new() { Source = "GeeksForGeeks", Other = ResultTester.GetCounterDifficulty(ProblemCategory.SchoolGFG) + ResultTester.GetCounterDifficulty(ProblemCategory.BasicGFG) , Easy = ResultTester.GetCounterDifficulty(ProblemCategory.EasyGFG), Medium = ResultTester.GetCounterDifficulty(ProblemCategory.MediumGFG), Hard = ResultTester.GetCounterDifficulty(ProblemCategory.HardGFG) },
                    new() { Source = "CodeChef", Other = ResultTester.GetCounterDifficulty(ProblemCategory.LearnCC) + ResultTester.GetCounterDifficulty(ProblemCategory.BeginnerCC) },
                    new() { Source = "HackerRank", Easy = ResultTester.GetCounterDifficulty(ProblemCategory.EasyHR), Medium = ResultTester.GetCounterDifficulty(ProblemCategory.MediumHR), Hard = ResultTester.GetCounterDifficulty(ProblemCategory.HardHR) },
                    new() { Source = "SphereOnlineJudge", Other = ResultTester.GetCounterDifficulty(ProblemCategory.OtherSOJ) },
                    new() { Source = "Kattis", Easy = ResultTester.GetCounterDifficulty(ProblemCategory.EasyKAT) },
                    new() { Source = "CSAcademy", Other = ResultTester.GetCounterDifficulty(ProblemCategory.TutorialCSA), Easy = ResultTester.GetCounterDifficulty(ProblemCategory.EasyCSA) },
                    new() { Source = "ProjectEuler", Other = ResultTester.GetCounterDifficulty(ProblemCategory.OtherEuler) },
                    new() { Source = "CodinGame", Other = ResultTester.GetCounterDifficulty(ProblemCategory.OtherCodinGame) },
                    new() { Source = "LeetCode", Easy = ResultTester.GetCounterDifficulty(ProblemCategory.EasyLC), Medium = ResultTester.GetCounterDifficulty(ProblemCategory.MediumLC), Hard = ResultTester.GetCounterDifficulty(ProblemCategory.HardLC) },
                    new() { Source = "HackerEarth", Easy = ResultTester.GetCounterDifficulty(ProblemCategory.EasyHE), Medium = ResultTester.GetCounterDifficulty(ProblemCategory.MediumHE), Hard = ResultTester.GetCounterDifficulty(ProblemCategory.HardHE) },
                };

                // ResultTester Stats
                //ResultTester.GetSourceStats();
                ResultTester.GetAllStats();

                tableRows = tableRows.OrderByDescending(row => row.GetTotal()).ToList();
                TableMarkdownHelper.GenerateMarkdownTable(tableRows);
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

        // CURRENT TEST
        private static void CurrentTest()
        {

        }
    }
}