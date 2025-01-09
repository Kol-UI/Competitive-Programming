
```cs

public class Test
{
    public static bool[] TestCases()
    {
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(Solution, 1),
            ResultTester.CheckResult<int>(Solution, 2)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Title");
        ResultTester.CheckCurrentSolution(ProblemOrigin, ProblemCategory, Test.TestCases());
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Title");
        ResultTester.SpecialTestCase(ProblemOrigin, ProblemCategory);
    }
}

```

CodeForces :

```cs
using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public static void Main(string[] args)
    {
        int numberOfTestCases = ReadInt();
        
        List<int> results = new List<int>();
        
        for (int i = 0; i < numberOfTestCases; i++)
        {
            int[] lr = ReadInts();
        }
        
        PrintResults(results);
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static long ReadLong() => long.Parse(ReadLn());
    private static double ReadDouble() => double.Parse(ReadLn());
    private static string[] ReadStrings() => ReadLn().Split(' ');
    private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
    private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
    private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
    private static void PrintDouble(double value, int decimals) => Console.WriteLine(value.ToString($"F{decimals}"));
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}
```