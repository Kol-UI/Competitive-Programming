// Addition


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CSAcademy.Addition;
class Solution
{
    //static void Main(String[] args)
    static void Function()
    {
        string[] input = Console.ReadLine()!.Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        int sum = a + b;

        Console.WriteLine(sum);
    }
}