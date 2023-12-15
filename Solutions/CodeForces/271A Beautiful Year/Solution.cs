// Beautiful Year

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.BeautifulYear;


using System;

class Program
{
    //static void Main(string[] args)
    static void Solution()
    {
        int year = int.Parse(Console.ReadLine()!);
        while (true)
        {
            year++;
            int a = year / 1000;
            int b = year / 100 % 10;
            int c = year / 10 % 10;
            int d = year % 10;
            if (a != b && a != c && a != d && b != c && b != d && c != d)
            {
                break;
            }
        }
        Console.WriteLine(year);
    }
}

public class Test
{
    public static int FindBeautifulYear(int year)
    {
        while (true)
        {
            year++;
            int a = year / 1000;
            int b = year / 100 % 10;
            int c = year / 10 % 10;
            int d = year % 10;
            if (a != b && a != c && a != d && b != c && b != d && c != d)
            {
                break;
            }
        }
        return year;
    }

    public static bool[] TestCases()
    {
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(Test.FindBeautifulYear(1980), 1982),
            ResultTester.CheckResult<int>(Test.FindBeautifulYear(2021), 2031),
            ResultTester.CheckResult<int>(Test.FindBeautifulYear(1234), 1235),
            ResultTester.CheckResult<int>(Test.FindBeautifulYear(9999), 10012),
            ResultTester.CheckResult<int>(Test.FindBeautifulYear(2030), 2031),
            ResultTester.CheckResult<int>(Test.FindBeautifulYear(5432), 5436),
            ResultTester.CheckResult<int>(Test.FindBeautifulYear(9876), 10012),
            ResultTester.CheckResult<int>(Test.FindBeautifulYear(1010), 1023),
        };
        return results;
    }
}