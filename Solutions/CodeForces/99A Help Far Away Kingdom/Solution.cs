// 99A - Help Far Away Kingdom


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.HelpFarAwayKingdom
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string input = Console.ReadLine()!;
            string result = RoundNumber(input);
            Console.WriteLine(result);
        }

        static string RoundNumber(string input)
        {
            string[] parts = input.Split('.');
            string integerPart = parts[0];
            string fractionalPart = parts[1];

            if (integerPart[^1] != '9')
            {
                if (fractionalPart[0] < '5')
                {
                    return integerPart;
                }
                else
                {
                    int lastDigit = int.Parse(integerPart[^1].ToString()) + 1;
                    return integerPart[..^1] + lastDigit;
                }
            }
            else
            {
                return "GOTO Vasilisa.";
            }
        }
    }
}