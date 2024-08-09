using System;
using CompetitiveProgramming.Models;

namespace CompetitiveProgramming.Helpers
{
    public static class TableMarkdownHelper
    {
        private const int PadValues = 8;
        private const int PadSource = 18;

        private static readonly ConsoleColor OtherColor = ConsoleColor.Cyan;
        private static readonly ConsoleColor EasyColor = ConsoleColor.Green;
        private static readonly ConsoleColor MediumColor = ConsoleColor.Yellow;
        private static readonly ConsoleColor HardColor = ConsoleColor.Red;
        private static readonly ConsoleColor TotalColor = ConsoleColor.Magenta;

        public static void GenerateMarkdownTable(List<TableData> tableRows)
        {
            StyleHelper.Space();

            Console.WriteLine("| Source             | Other    | Easy     | Medium   | Hard     | Total    |");
            Console.WriteLine("| ------------------ | -------- | -------- | -------- | -------- | -------- |");

            int otherTotal = 0, easyTotal = 0, mediumTotal = 0, hardTotal = 0;

            foreach (var row in tableRows)
            {
                Console.Write($"| {row.Source.PadRight(PadSource)} | ");
                otherTotal += WriteColoredCell(row.Other, OtherColor);
                Console.Write(" | ");
                easyTotal += WriteColoredCell(row.Easy, EasyColor);
                Console.Write(" | ");
                mediumTotal += WriteColoredCell(row.Medium, MediumColor);
                Console.Write(" | ");
                hardTotal += WriteColoredCell(row.Hard, HardColor);
                Console.Write(" | ");
                WriteColoredCell(row.GetTotal(), TotalColor);
                Console.WriteLine(" |");
            }

            Console.Write($"| {"Total".PadRight(PadSource)} | ");
            WriteColoredCell(otherTotal, OtherColor);
            Console.Write(" | ");
            WriteColoredCell(easyTotal, EasyColor);
            Console.Write(" | ");
            WriteColoredCell(mediumTotal, MediumColor);
            Console.Write(" | ");
            WriteColoredCell(hardTotal, HardColor);
            Console.Write(" | ");
            WriteColoredCell(otherTotal + easyTotal + mediumTotal + hardTotal, TotalColor);
            Console.WriteLine(" |");

            StyleHelper.Space();
        }

        private static int WriteColoredCell(int? value, ConsoleColor color)
        {
            if (value.HasValue)
            {
                Console.ForegroundColor = color;
                Console.Write(value.Value.ToString().PadRight(PadValues));
                Console.ResetColor();
                return value.Value;
            }
            else
            {
                Console.Write("x".PadRight(PadValues));
                return 0;
            }
        }
    }
}