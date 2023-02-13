using System;
namespace CompetitiveProgramming.Codeforces.WayTooLongWords
{
	public class Solution
	{
        public static void MainWayTooLongWords(string[] args)
        {
            var number = int.Parse(Console.ReadLine() ?? string.Empty);
            while (number-- > 0)
            {
                var word = Console.ReadLine() ?? string.Empty;
                Console.WriteLine(word.Length > 10 ? $"{word[0]}{word.Length - 2}{word[word.Length - 1]}" : word);
            }
        }
    }
}