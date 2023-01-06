using System;
using System.Diagnostics.Metrics;
using System.Linq;
namespace CompetitiveProgramming.CodeWars.SixKyu.ReplaceWithAlphabetPosition
{
    public class Solution
	{
        //replace every letter with its position in the alphabet.
        //If anything in the text isn't a letter, ignore it and don't return it.
        //"a" = 1, "b" = 2, etc.

        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.Where(char.IsLetter).Select(c => c & 31));
        }
    }
}

