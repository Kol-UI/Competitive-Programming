// Accessing characters of a String

/*
Write a program that does the following

Declare a string variable txt and initialize it to the value "Programming"
Print the 3rd and 5th Characters from txt in separate lines.
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.StringOperationsStrs7
{
    public class Solution
    {
        static void Anwser()
        {
            string v = "String";
            Console.Write(v[ 0 ]);
            Console.Write(v[ 1 ]);
            Console.Write(v[ 2 ]);
        }
    }

    public class Test
    {
        private static char AnwserTest1(string v)
        {
            return v[0];
        }

        private static char AnwserTest2(string v)
        {
            return v[1];
        }

        private static char AnwserTest3(string v)
        {
            return v[2];
        }

        public static bool[] TestStringOperationsStrs7()
        {
            string v = "String";
            char result1 = AnwserTest1(v);
            char result2 = AnwserTest2(v);
            char result3 = AnwserTest3(v);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<char>(result1, 'S'),
                ResultTester.CheckResult<char>(result2, 't'),
                ResultTester.CheckResult<char>(result3, 'r')
            };
            return results;
        }
    }
}