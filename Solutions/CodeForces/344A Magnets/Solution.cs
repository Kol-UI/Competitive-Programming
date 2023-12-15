// Magnets


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Magnets;

using System;

class Program
{
    //public static void Main()
    public static void Solution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int groups = 1;
        string prevMagnet = Console.ReadLine()!;

        for(int i = 1; i < n; i++)
        {
            string currentMagnet = Console.ReadLine()!;

            if(prevMagnet != currentMagnet)
            {
                groups++;
            }

            prevMagnet = currentMagnet;
        }

        Console.WriteLine(groups);
    }
}

public class Test
{
    public static int MagnetsSolution(string[] magnets)
    {
        int n = magnets.Length;
        int groups = 1;
        string prevMagnet = magnets[0];

        for (int i = 1; i < n; i++)
        {
            string currentMagnet = magnets[i];

            if (prevMagnet != currentMagnet)
            {
                groups++;
            }

            prevMagnet = currentMagnet;
        }

        return groups;
    }

    public static bool[] TestCases()
    {
        string[] test1 = { "10", "10", "10", "10" };
        string[] test2 = { "10", "01", "10", "01", "10" };
        string[] test3 = { "11" };

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(Test.MagnetsSolution(test1), 1),
            ResultTester.CheckResult<int>(Test.MagnetsSolution(test2), 5),
            ResultTester.CheckResult<int>(Test.MagnetsSolution(test3), 1),
        };
        return results;
    }
}