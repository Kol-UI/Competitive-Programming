// Regex validate PIN code

using System.Linq;
using System.Text.RegularExpressions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.SevenKyu.RegexvalidatePINcode
{
    public class Kata
    {
        public static bool ValidatePin(string pin) => pin.All(char.IsDigit) && (pin.Length == 6 || pin.Length == 4) ? true : false;
    }

    public class Test
    {
        static readonly string[] EdgeCaseStrings = new string[]
        {
            "",
            "123",
            "12345",
            "1234567",
            "1234567890",
            "1234x",
            "123456x",
            "12.0",
            "1234.0",
            "123456.0",
            "123\n",
            "1234\n",
            "09876\n",
            "098765\n",
            "-111",
            "111-",
            "-44444",
            "44444-",
            "+111",
            "+88888",
            "+1111",
            "-2018",
            "+234567",
            "-234567",
            "123/",
            "456:",
            "9¾9¾",
        };

        private static readonly Random rnd = new();
    
        private static readonly string digits = "0123456789";

        public static bool[] GenerateTests()
        {
            const int Tests = 5000;
            bool[] results = Array.Empty<bool>();
        
            for (int i = 0; i < Tests; i++)
            {
                List<char> validPin = new char[rnd.Next(2, 4) * 2].Select(_ => digits[rnd.Next(0, digits.Length)]).ToList();
                if (rnd.Next(0, 2) == 0) { validPin[rnd.Next(0, validPin.Count)] = (char)rnd.Next(32, 127); }
                string pin = String.Concat(validPin);
                
                bool result = Kata.ValidatePin(pin);
                bool expected = Kata.ValidatePin(pin);
                bool testCase = ResultTester.CheckResult<bool>(result, expected);
                results.Append(testCase);
            }

            return results;
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Kata.ValidatePin("1"), false),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("12"), false),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("123"), false),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("12345"), false),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("1234567"), false),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("-1234"), false),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("1.234"), false),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("-1.234"), false),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("00000000"), false),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("a234"), false),
                ResultTester.CheckResult<bool>(Kata.ValidatePin(".234"), false),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("1234"), true),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("0000"), true),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("1111"), true),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("123456"), true),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("098765"), true),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("000000"), true),
                ResultTester.CheckResult<bool>(Kata.ValidatePin("090909"), true),
            };

            foreach(var value in EdgeCaseStrings)
            {
                bool result = Kata.ValidatePin(value);
                bool expected = Kata.ValidatePin(value);
                bool testCase = ResultTester.CheckResult<bool>(result, expected);
                results.Append(testCase);
            }
            results.Concat(GenerateTests()).ToArray();
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Regex validate PIN code");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.SevenKyu, Test.TestCases());
        }
    }
}