// Longest Word

/*
Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string. If there are two or more words that are the same length, return the first word from the string with that length. Ignore punctuation and assume sen will not be empty. Words may also contain numbers, for example "Hello world123 567"
Examples
Input: "fun&!! time"
Output: time
Input: "I love dogs"
Output: love
*/

using System.Text.RegularExpressions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CoderByte.LongestWord
{
    class MainClass
    {
        public static string LongestWord(string sen)
        {
            string[] words = Regex.Split(sen, @"\W+");
            
            string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault()!;
            
            return longestWord;
        }

        /*
        static void Main()
        {  

            // keep this function call here
            Console.WriteLine(LongestWord(Console.ReadLine()));
            
        }
        */

    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(MainClass.LongestWord("fun&!! time"), "time"),
                ResultTester.CheckResult<string>(MainClass.LongestWord("I love dogs"), "love"),
                ResultTester.CheckResult<string>(MainClass.LongestWord("hello world"), "hello"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Word");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CoderByte, ProblemCategory.EasyCB, Test.TestCases());
        }
    }
}