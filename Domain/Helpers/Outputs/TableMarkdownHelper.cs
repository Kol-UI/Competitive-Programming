using System;
using CompetitiveProgramming.Models;

namespace CompetitiveProgramming.Helpers
{
    public class TableMarkdownHelper
    {
        public static void GenerateMarkdownTable(List<TableData> tableRows)
        {
            StyleHelper.Space();

            int padValues = 8;
            int padSource = 18;

            ConsoleColor otherColor = ConsoleColor.Cyan;
            ConsoleColor easyColor = ConsoleColor.Green;
            ConsoleColor mediumColor = ConsoleColor.Yellow;
            ConsoleColor hardColor = ConsoleColor.Red;
            ConsoleColor totalColor = ConsoleColor.Magenta;

            int otherTotal = 0;
            int easyTotal = 0;
            int mediumTotal = 0;
            int hardTotal = 0;

            Console.WriteLine("| Source             | Other    | Easy     | Medium   | Hard     | Total    |");
            Console.WriteLine("| ------------------ | -------- | -------- | -------- | -------- | -------- |");

            foreach (var row in tableRows)
            {
                Console.Write($"| {row.Source.PadRight(padSource)} | ");

                Console.ForegroundColor = otherColor;
                Console.Write(row.Other.HasValue ? row.Other.ToString()!.PadRight(padValues) : "x".PadRight(padValues));
                otherTotal += row.Other ?? 0;
                Console.ResetColor();

                Console.Write(" | ");

                if (row.Easy.HasValue)
                {
                    Console.ForegroundColor = easyColor;
                    Console.Write(row.Easy.ToString()!.PadRight(padValues));
                    easyTotal += row.Easy ?? 0;
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("x".PadRight(padValues));
                }

                Console.Write(" | ");

                if (row.Medium.HasValue)
                {
                    Console.ForegroundColor = mediumColor;
                    Console.Write(row.Medium.ToString()!.PadRight(padValues));
                    mediumTotal += row.Medium ?? 0;
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("x".PadRight(padValues));
                }

                Console.Write(" | ");

                if (row.Hard.HasValue)
                {
                    Console.ForegroundColor = hardColor;
                    Console.Write(row.Hard.ToString()!.PadRight(padValues));
                    hardTotal += row.Hard ?? 0;
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("x".PadRight(padValues));
                }

                Console.Write(" | ");
                Console.ForegroundColor = totalColor;
                Console.Write($"{row.GetTotal().ToString().PadRight(padValues)}");
                Console.ResetColor();
                Console.WriteLine(" |");
            }

            Console.Write($"| { "Total".PadRight(padSource) }");

            Console.Write(" | ");
            Console.ForegroundColor = otherColor;
            Console.Write(otherTotal.ToString().PadRight(padValues));
            Console.ResetColor();

            Console.Write(" | ");
            Console.ForegroundColor = easyColor;
            Console.Write(easyTotal.ToString().PadRight(padValues));
            Console.ResetColor();

            Console.Write(" | ");
            Console.ForegroundColor = mediumColor;
            Console.Write(mediumTotal.ToString().PadRight(padValues));
            Console.ResetColor();

            Console.Write(" | ");
            Console.ForegroundColor = hardColor;
            Console.Write(hardTotal.ToString().PadRight(padValues));
            Console.ResetColor();

            Console.Write(" | ");
            Console.ForegroundColor = totalColor;
            int total = otherTotal + easyTotal + mediumTotal + hardTotal;
            Console.Write(total.ToString().PadRight(padValues));
            Console.ResetColor();
            Console.WriteLine(" | ");

            StyleHelper.Space();
        }
    }
}