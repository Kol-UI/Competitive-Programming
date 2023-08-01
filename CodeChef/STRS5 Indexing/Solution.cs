// Indexing

/*
We use the concept of indexing to find the position of a character in a string, which means every character in a string corresponds to a number/position called the index number.

"C o d e C h e f" - String (Ignore spaces inbetween)
 0 1 2 3 4 5 6 7  - Corresponding index number
We use the IndexOf() method which returns the index (the position) of the first occurrence of a specified text in a string, this also includes whitespaces:

Note: Indexing always starts from 0 when going left to right.

Try running the code given and observe the output
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.Indexing
{
    public class Solution
    {
        public static void Answer()
        {
            string txt = "Please find chef";
            Console.WriteLine(txt.IndexOf("ease") );
            Console.WriteLine(txt.IndexOf("chef"));
        }
    }

    public class Test
    {
        public static int AnswerTest1(string txt)
        {
            int input = txt.IndexOf("ease");
            return input;
        }

        public static int AnswerTest2(string txt)
        {
            int input = txt.IndexOf("chef");
            return input;
        }
        
        public static bool[] TestIndexing()
        {
            string txt = "Please find chef";

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(AnswerTest1(txt), 2),
                ResultTester.CheckResult<int>(AnswerTest2(txt), 12)
            };

            return results;
        }
    }
}