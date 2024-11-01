// DNA to RNA Conversion

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.DNAtoRNAConversion
{
    public class Converter
    {
        public string DnaToRna(string dna)
        {
            return dna.Replace('T','U');
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Converter solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(solution.DnaToRna("TTTT"), "UUUU"),
                ResultTester.CheckResult<string>(solution.DnaToRna("GCAT"), "GCAU"),
                ResultTester.CheckResult<string>(solution.DnaToRna("GACCGCCGCC"), "GACCGCCGCC"),
                ResultTester.CheckResult<string>(solution.DnaToRna("GATTCCACCGACTTCCCAAGTACCGGAAGCGCGACCAACTCGCACAGC"), "GAUUCCACCGACUUCCCAAGUACCGGAAGCGCGACCAACUCGCACAGC"),
                ResultTester.CheckResult<string>(solution.DnaToRna("CACGACATACGGAGCAGCGCACGGTTAGTACAGCTGTCGGTGAACTCCATGACA"), "CACGACAUACGGAGCAGCGCACGGUUAGUACAGCUGUCGGUGAACUCCAUGACA"),
                ResultTester.CheckResult<string>(solution.DnaToRna("CACGACATACGGAGCAGCGCACGGTTAGTACAGCTGTCGGTGAACTCCATGACA"), "CACGACAUACGGAGCAGCGCACGGUUAGUACAGCUGUCGGUGAACUCCAUGACA"),
                ResultTester.CheckResult<string>(solution.DnaToRna("AACCCTGTCCACCAGTAACGTAGGCCGACGGGAAAAATAAACGATCTGTCAATG"), "AACCCUGUCCACCAGUAACGUAGGCCGACGGGAAAAAUAAACGAUCUGUCAAUG"),
                ResultTester.CheckResult<string>(solution.DnaToRna("GAAGCTTATCCGTTCCTGAAGGCTGTGGCATCCTCTAAATCAGACTTGGCTACGCCGTTAGCCGAGGGCTTAGCGTTGAGTGTCATTATATACGCGGCCTGCGACCTGGCCACACAATGCCCTCGAAAATTTTTCTTTCGGTTATACGAGTTGCGAAACCTTTCGCGCGTAGACGAAGAATTTGAAGTGGCCTACACCGTTTGGAAAGCCGTTCTCATTAGAATGGTACCGACTACTCGGCTCGGAGTCATTGTATAGGGAGAGTGTCGTATCAACATCACACACTTTTAGCATTTAAGGTCCATGGCCGTTGACAGGTACCGA"), "GAAGCUUAUCCGUUCCUGAAGGCUGUGGCAUCCUCUAAAUCAGACUUGGCUACGCCGUUAGCCGAGGGCUUAGCGUUGAGUGUCAUUAUAUACGCGGCCUGCGACCUGGCCACACAAUGCCCUCGAAAAUUUUUCUUUCGGUUAUACGAGUUGCGAAACCUUUCGCGCGUAGACGAAGAAUUUGAAGUGGCCUACACCGUUUGGAAAGCCGUUCUCAUUAGAAUGGUACCGACUACUCGGCUCGGAGUCAUUGUAUAGGGAGAGUGUCGUAUCAACAUCACACACUUUUAGCAUUUAAGGUCCAUGGCCGUUGACAGGUACCGA"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("DNA to RNA Conversion");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestCases());
        }
    }
}