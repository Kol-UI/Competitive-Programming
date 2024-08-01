// Excel Sheet Column Number


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ExcelSheetColumnNumber
{
    public class Solution
    {
        public static int TitleToNumber(string columnTitle)
        {
            int result = 0;

            for (int i = 0; i < columnTitle.Length; i++)
            {
                int current = columnTitle[i] - 'A' + 1;
                result = result * 26 + current;
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.TitleToNumber("A"), 1),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("AB"), 28),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("ZY"), 701),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("A"), 1),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("B"), 2),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("Z"), 26),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("AA"), 27),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("AZ"), 52),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("BA"), 53),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("ZZ"), 702),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("AAA"), 703),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("AAZ"), 728),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("ABA"), 729),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("ZZZ"), 18278),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("AAAA"), 18279),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("FHDJ"), 110978),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("ZYXW"), 474523),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("BBB"), 1406),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("C"), 3),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("D"), 4),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("M"), 13),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("T"), 20),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("AG"), 33),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("BB"), 54),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("CD"), 82),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("FG"), 163),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("KL"), 298),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("MN"), 352),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("UV"), 568),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("XYZ"), 16900),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("ABCDE"), 494265),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("ZXYWV"), 12320720),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("HJKL"), 147666),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("NOPQ"), 256637),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("E"), 5),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("G"), 7),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("J"), 10),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("P"), 16),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("AH"), 34),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("BC"), 55),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("CE"), 83),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("FK"), 167),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("LM"), 325),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("NO"), 379),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("WX"), 622),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("XZZ"), 16926),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("ABCDE"), 494265),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("ZYXWV"), 12337620),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("HJKL"), 147666),
                ResultTester.CheckResult<int>(Solution.TitleToNumber("QRST"), 311474)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Excel Sheet Column Number");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}