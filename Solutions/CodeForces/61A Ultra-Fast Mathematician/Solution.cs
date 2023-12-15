// Ultra Fast Mathematician

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.UltraFastMathematician;

class Program
{
    //static void Main()
    static void Solution()
    {
        string num1 = Console.ReadLine()!;
        string num2 = Console.ReadLine()!;

        char[] result = new char[num1.Length];

        for (int i = 0; i < num1.Length; i++)
        {
            result[i] = (num1[i] == num2[i]) ? '0' : '1';
        }

        Console.WriteLine(new string(result));
    }
}
