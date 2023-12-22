using System;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.Helpers.Outputs;
using CompetitiveProgramming.Services.Providers;

namespace CompetitiveProgramming.TestDrivenDevelopment
{
    public class CSharpTDD
    {
        public static void StartAllTDD()
        {
            // Current Testing Solution
            CurrentTests();
        }

        // CURRENT TESTS
        private static void CurrentTests()
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
    }
}