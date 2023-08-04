// Goal Parser Interpretation

/*
You own a Goal Parser that can interpret a string command. The command consists of an alphabet of "G", "()" and/or "(al)" in some order. The Goal Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" as the string "al". The interpreted strings are then concatenated in the original order.

Given the string command, return the Goal Parser's interpretation of command.

 

Example 1:

Input: command = "G()(al)"
Output: "Goal"
Explanation: The Goal Parser interprets the command as follows:
G -> G
() -> o
(al) -> al
The final concatenated result is "Goal".
Example 2:

Input: command = "G()()()()(al)"
Output: "Gooooal"

Example 3:

Input: command = "(al)G(al)()()G"
Output: "alGalooG"
*/

using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.GoalParserInterpretation
{
    public class Solution
    {
        public static string Interpret(string command) 
        {
            StringBuilder s = new StringBuilder();
            for(int i = 0; i < command.Length;)
            {
                if(command[i]=='(')
                {
                    if(command[i+1]==')')
                    {
                        s.Append('o');
                        i += 2;
                    }
                    else
                    {
                        s.Append("al");
                        i += 4;
                    }
                }
                else
                {
                    s.Append("G");
                    i++;
                }
            }
            return s.ToString();  
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string command1 = "G()(al)";
            string command2 = "G()()()()(al)";
            string command3 = "(al)G(al)()()G";

            string result1 = Solution.Interpret(command1);
            string result2 = Solution.Interpret(command2);
            string result3 = Solution.Interpret(command3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(result1, "Goal"),
                ResultTester.CheckResult<string>(result2, "Gooooal"),
                ResultTester.CheckResult<string>(result3, "alGalooG")
            };
            return results;
        }
    }
}
