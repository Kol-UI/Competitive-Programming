// 50A Bit++

/*
The classic programming language of Bitland is Bit++. This language is so peculiar and complicated.

The language is that peculiar as it has exactly one variable, called x. Also, there are two operations:

Operation ++ increases the value of variable x by 1.
Operation -- decreases the value of variable x by 1.
A statement in language Bit++ is a sequence, consisting of exactly one operation and one variable x. The statement is written without spaces, that is, it can only contain characters "+", "-", "X". Executing a statement means applying the operation it contains.

A programme in Bit++ is a sequence of statements, each of them needs to be executed. Executing a programme means executing all the statements it contains.

You're given a programme in language Bit++. The initial value of x is 0. Execute the programme and find its final value (the value of the variable when this programme is executed).

Input
The first line contains a single integer n (1 ≤ n ≤ 150) — the number of statements in the programme.

Next n lines contain a statement each. Each statement contains exactly one operation (++ or --) and exactly one variable x (denoted as letter «X»). Thus, there are no empty statements. The operation and the variable can be written in any order.

Output
Print a single integer — the final value of x.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.BitPP;

public class Solution
{
    // Solution
    /*
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = 0;
 
        for (int i = 0; i < n; i++)
        {
            string statement = Console.ReadLine();
 
            if (statement.Contains("++"))
            {
                x++;
            }
            else if (statement.Contains("--"))
            {
                x--;
            }
        }
 
        Console.WriteLine(x);
    }
    */
}

// Test
public class Test
{
    public static int TestBitPP(int n, string[] statements)
    {
        int x = 0;

        for (int i = 0; i < n; i++)
        {
            string statement = statements[i];

            if (statement.Contains("++"))
            {
                x++;
            }
            else if (statement.Contains("--"))
            {
                x--;
            }
        }

        //Console.WriteLine(x);
        return x;
    }

    public static bool[] TestCases()
    {
        int n1 = 1;
        string[] statements1 = { "++X" };

        int n2 = 2;
        string[] statements2 = { "X++", "--X" };

        int n3 = 3;
        string[] statements3 = { "++X", "++X", "++X" };

        int n4 = 1;
        string[] statements4 = { "X--" };

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(Test.TestBitPP(n1, statements1), 1),
            ResultTester.CheckResult<int>(Test.TestBitPP(n2, statements2), 0),
            ResultTester.CheckResult<int>(Test.TestBitPP(n3, statements3), 3),
            ResultTester.CheckResult<int>(Test.TestBitPP(n4, statements4), -1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bit++");
        ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
    }
}