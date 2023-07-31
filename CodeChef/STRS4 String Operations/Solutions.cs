// String Operations
/*
Problem
There are various String methods to perform different operations on a string. Let's discuss a few.

.ToUpper: Returns the Uppercase of the string passed.
.ToLower: Returns the Lowercase of the string passed.
There is also a string property -

.Length: Returns the length of the string.
string word = "Hello Chef";
Console.WriteLine(word.Length);
Console.WriteLine(word.ToUpper());
Console.WriteLine(word.ToLower());

Output:
10
HELLO CHEF
hello chef
Task
Write a program which does the following

Create a variable txt and assign it the text NumeroTres
Use the Length method to output to the console the number of characters in txt
Use the ToUpper() method to output to the console the Uppercase of txt
Use the ToLower() method to output to the console the Lowercase of txt
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.StringOperations
{
    public class Solution
    {
        public static void Answer()
        {
            var txt = "NumeroTres";
            Console.WriteLine("The length of the word is: " + txt.Length);
            Console.WriteLine("The text in lower case is: " + txt.ToLower());
            Console.WriteLine("The text in upper case is: " + txt.ToUpper());
        }
    }

    public class Test
    {
        public static bool[] TestStringOperations()
        {
            Solution.Answer();
            string txt = "NumeroTres";
            string case1 = txt.Length.ToString();
            string case2 = txt.ToLower();
            string case3 = txt.ToUpper();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(case1, case1),
                ResultTester.CheckResult<string>(case2, case2),
                ResultTester.CheckResult<string>(case3, case3)
            };

            return results;
        }
    }
}