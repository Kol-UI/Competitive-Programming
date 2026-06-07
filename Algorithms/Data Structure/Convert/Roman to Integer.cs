using System.Text;

namespace CompetitiveProgramming.Algorithms;
public class RomanIntegerConverter
{
    private static readonly Dictionary<char, int> RomanMap = new()
    {
        {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
    };

    private static readonly int[] Values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    private static readonly string[] Symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

    // Convert Roman to Integer
    public int ToInteger(string roman)
    {
        int total = 0;
        for (int i = 0; i < roman.Length; i++)
        {
            int currentVal = RomanMap[roman[i]];
            
            // If the next value is greater, the current value is subtracted (ex: IV).
            if (i + 1 < roman.Length && RomanMap[roman[i + 1]] > currentVal)
            {
                total -= currentVal;
            }
            else
            {
                total += currentVal;
            }
        }
        return total;
    }

    // Convert Integer to Roman
    public string ToRoman(int number)
    {
        StringBuilder result = new();
        for (int i = 0; i < Values.Length && number > 0; i++)
        {
            while (number >= Values[i])
            {
                number -= Values[i];
                result.Append(Symbols[i]);
            }
        }
        return result.ToString();
    }
}