// Secret Message




using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.Kattis.SecretMessage;

public class Encryption
{
    //public static void Main(string[] args)
    public static void Solution()
    {
        int messageCount = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < messageCount; i++)
        {
            string message = Console.ReadLine()!.Trim();
            int messageLength = message.Length;
            int tableSide = (int)Math.Ceiling(Math.Sqrt(messageLength));
            int paddingLength = tableSide * tableSide - messageLength;

            message = message.PadRight(messageLength + paddingLength, '*');

            char[,] encryptionTable = new char[tableSide, tableSide];
            int index = 0;

            for (int row = 0; row < tableSide; row++)
            {
                for (int col = 0; col < tableSide; col++)
                {
                    if (index < messageLength)
                    {
                        encryptionTable[row, col] = message[index++];
                    }
                    else
                    {
                        encryptionTable[row, col] = '*';
                    }
                }
            }

            char[,] rotatedTable = new char[tableSide, tableSide];

            for (int col = 0; col < tableSide; col++)
            {
                for (int row = tableSide - 1; row >= 0; row--)
                {
                    rotatedTable[col, tableSide - 1 - row] = encryptionTable[row, col];
                }
            }

            string encryptedMessage = "";

            for (int row = 0; row < tableSide; row++)
            {
                for (int col = 0; col < tableSide; col++)
                {
                    if (rotatedTable[row, col] != '*')
                    {
                        encryptedMessage += rotatedTable[row, col];
                    }
                }
            }

            Console.WriteLine(encryptedMessage);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Secret Message");
            ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
        }
    }
}