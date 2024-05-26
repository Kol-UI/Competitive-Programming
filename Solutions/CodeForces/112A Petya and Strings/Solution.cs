// Petya and Strings


/*
Little Petya loves presents. His mum bought him two strings of the same size for his birthday. The strings consist of uppercase and lowercase Latin letters. Now Petya wants to compare those two strings lexicographically. The letters' case does not matter, that is an uppercase letter is considered equivalent to the corresponding lowercase letter. Help Petya perform the comparison.

Input
Each of the first two lines contains a bought string. The strings' lengths range from 1 to 100 inclusive. It is guaranteed that the strings are of the same length and also consist of uppercase and lowercase Latin letters.

Output
If the first string is less than the second one, print "-1". If the second string is less than the first one, print "1". If the strings are equal, print "0". Note that the letters' case is not taken into consideration when the strings are compared.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.PetyaandStrings
{
    // Solution
    /*
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
    
            int result = CompareStringsIgnoreCase(string1, string2);
            Console.WriteLine(result);
        }
    
        static int CompareStringsIgnoreCase(string str1, string str2)
        {
            int length = str1.Length;
    
            for (int i = 0; i < length; i++)
            {
                char char1 = char.ToLower(str1[i]);
                char char2 = char.ToLower(str2[i]);
    
                if (char1 < char2)
                    return -1;
                else if (char1 > char2)
                    return 1;
            }
    
            return 0;
        }
    }
    */

    // Test
    public class Test
    {
        public static int CompareStringsIgnoreCase(string str1, string str2)
        {
            int length = str1.Length;
    
            for (int i = 0; i < length; i++)
            {
                char char1 = char.ToLower(str1[i]);
                char char2 = char.ToLower(str2[i]);
    
                if (char1 < char2)
                    return -1;
                else if (char1 > char2)
                    return 1;
            }
    
            return 0;
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("aaaa", "aaaA"), 0),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("abs", "Abz"), -1),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("abcdefg", "AbCdEfF"), 1),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("Hello", "hello"), 0),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("abc", "ABC"), 0),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("abcdefg", "AbCdEfF"), 1),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("asadasdasd", "asdwasdawd"), -1),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("aslkjlkasdd", "asdlkjdajwi"), 1),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"), 0),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("aAaaaAAaAaaAzZsssSsdDfeEaeqZlpP", "AaaaAaaAaaAaZzSSSSsDdFeeAeQZLpp"), 0),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("bwuEhEveouaTECagLZiqmUdxEmhRSOzMauJRWLQMppZOumxhAmwuGeDIkvkBLvMXwUoFmpAfDprBcFtEwOULcZWRQhcTbTbX", "HhoDWbcxwiMnCNexOsKsujLiSGcLllXOkRSbnOzThAjnnliLYFFmsYkOfpTxRNEfBsoUHfoLTiqAINRPxWRqrTJhgfkKcDOH"), -1),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("kGWUuguKzcvxqKTNpxeDWXpXkrXDvGMFGoXKDfPBZvWSDUyIYBynbKOUonHvmZaKeirUhfmVRKtGhAdBfKMWXDUoqvbfpfHYcg", "cvOULleuIIiYVVxcLZmHVpNGXuEpzcWZZWyMOwIwbpkKPwCfkVbKkUuosvxYCKjqfVmHfJKbdrsAcatPYgrCABaFcoBuOmMfFt"), 1),
                ResultTester.CheckResult<int>(Test.CompareStringsIgnoreCase("nCeNVIzHqPceNhjHeHvJvgBsNFiXBATRrjSTXJzhLMDMxiJztphxBRlDlqwDFImWeEPkggZCXSRwelOdpNrYnTepiOqpvkr", "HJbjJFtlvNxIbkKlxQUwmZHJFVNMwPAPDRslIoXISBYHHfymyIaQHLgECPxAmqnOCizwXnIUBRmpYUBVPenoUKhCobKdOjL"), 1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Petya and Strings");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
        }
    }
}