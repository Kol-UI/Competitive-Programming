// Accessing characters of a String

/*
Write a program that does the following

Declare a string variable txt and initialize it to the value "Programming"
Print the 3rd and 5th Characters from txt in separate lines.
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.AccessingcharactersofaString
{
    public class Solution
    {
        static void Anwser()
        {
            string txt = "Programming";
            Console.WriteLine(txt[2]);
            Console.WriteLine(txt[4]);
        }
    }

    public class Test
    {
        private static char AnwserTest1(string txt)
        {
            return txt[2];
        }

        private static char AnwserTest2(string txt)
        {
            return txt[4];
        }

        public static bool[] TestAccessingcharactersofaString()
        {
            string txt = "Programming";
            char result1 = AnwserTest1(txt);
            char result2 = AnwserTest2(txt);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 'o'),
                ResultTester.CheckResult<int>(result2, 'r')
            };
            return results;
        }
    }
}