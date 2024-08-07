// Integer to English Words

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.IntegertoEnglishWords
{
    public class Solution
    {
        public string NumberToWords(int num)
        {
            return Convert(num);
        }

        private static readonly string[] Units = 
        { 
            "Zero", "One", "Two", "Three", "Four", "Five", 
            "Six", "Seven", "Eight", "Nine", "Ten", 
            "Eleven", "Twelve", "Thirteen", "Fourteen", 
            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" 
        };

        private static readonly string[] Tens = 
        { 
            "", "", "Twenty", "Thirty", "Forty", "Fifty", 
            "Sixty", "Seventy", "Eighty", "Ninety" 
        };

        private static readonly string[] ThousandsGroups = 
        { 
            "", "Thousand", "Million", "Billion" 
        };

        public static string Convert(int number) 
        {
            if (number == 0)
                return ConvertUnits(0);

            if (number < 0)
                return ConvertNegativeNumber(number);

            return ConvertLargeNumber(number).Trim();
        }

        private static string ConvertNegativeNumber(int number)
        {
            return "Negative " + Convert(-number);
        }

        private static string ConvertUnits(int number)
        {
            return Units[number];
        }

        private static string ConvertTens(int number)
        {
            if (number < 20)
                return Units[number];
            return Tens[number / 10] + (number % 10 > 0 ? " " + Units[number % 10] : "");
        }

        private static string ConvertHundreds(int number)
        {
            return Units[number / 100] + " Hundred" + (number % 100 > 0 ? " " + Convert(number % 100) : "");
        }

        private static string ConvertLargeNumber(int number)
        {
            if (number < 1000)
                return ConvertGroup(number);

            string words = "";
            int thousandGroupIndex = 0;

            while (number > 0)
            {
                int remainder = number % 1000;
                if (remainder > 0)
                {
                    string groupWords = ConvertGroup(remainder);
                    words = groupWords + (thousandGroupIndex > 0 ? " " + ThousandsGroups[thousandGroupIndex] : "") + " " + words;
                }
                number /= 1000;
                thousandGroupIndex++;
            }

            return words.Trim();
        }

        private static string ConvertGroup(int number)
        {
            if (number < 100)
                return ConvertTens(number);

            return ConvertHundreds(number);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.Convert(123), "One Hundred Twenty Three"),
                ResultTester.CheckResult<string>(Solution.Convert(12345), "Twelve Thousand Three Hundred Forty Five"),
                ResultTester.CheckResult<string>(Solution.Convert(1234567), "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven")
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Integer to English Words");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}