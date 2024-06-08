// Tree Constructor

/*
Have the function TreeConstructor(strArr) take the array of strings stored in strArr, which will contain pairs of integers in the following format: (i1,i2), where i1 represents a child node in a tree and the second integer i2 signifies that it is the parent of i1. For example: if strArr is ["(1,2)", "(2,4)", "(7,2)"], then this forms the following tree:
which you can see forms a proper binary tree. Your program should, in this case, return the string true because a valid binary tree can be formed. If a proper binary tree cannot be formed with the integer pairs, then return the string false. All of the integers within the tree will be unique, which means there can only be one node in the tree with the given integer value.
Examples
Input: new string[] {"(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)"}
Output: true
Input: new string[] {"(1,2)", "(3,2)", "(2,12)", "(5,2)"}
Output: false
*/

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CoderByte.TreeConstructor;

class MainClass
{
    public static string TreeConstructor(string[] strArr)
    {
        Dictionary<int, int> parentCount = new Dictionary<int, int>();
        Dictionary<int, int> childCount = new Dictionary<int, int>();

        foreach (string pair in strArr)
        {
            string[] nodes = pair.Trim('(', ')').Split(',');
            int child = int.Parse(nodes[0]);
            int parent = int.Parse(nodes[1]);

            if (!parentCount.ContainsKey(parent))
            {
                parentCount[parent] = 1;
            }
            else
            {
                parentCount[parent]++;
            }

            if (!childCount.ContainsKey(child))
            {
                childCount[child] = 1;
            }
            else
            {
                childCount[child]++;
            }
        }

        foreach (var kvp in childCount)
        {
            int child = kvp.Key;
            int count = kvp.Value;

            if (count > 2)
            {
                return "false";
            }

            if (parentCount.ContainsKey(child))
            {
                int parent = parentCount[child];
                if (parent > 2)
                {
                    return "false";
                }
            }
        }

        return "true";
    }

    /*
    static void Main()
    {  
        Console.WriteLine(TreeConstructor(Console.ReadLine()));  
    }
    */

    }


public class Test
{
    public static bool[] TestCases()
    {
        string[] testCase1 = new string[] {"(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)"};
        string[] testCase2 = new string[] {"(1,2)", "(3,2)", "(2,12)", "(5,2)"};
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(MainClass.TreeConstructor(testCase1), "true"),
            ResultTester.CheckResult<string>(MainClass.TreeConstructor(testCase2), "false"),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Tree Constructor");
        ResultTester.CheckCurrentSolution(ProblemOrigin.CoderByte, ProblemCategory.MediumCBy, Test.TestCases());
    }
}