using System.Text;

namespace CompetitiveProgramming.Algorithms;

public class CamelCaseConverter
{
    public static string ToCamelCase(string[] inputs)
    {
        if (inputs == null || inputs.Length == 0)
        {
            return string.Empty;
        }

        StringBuilder sb = new();
        bool isFirstWordFound = false;

        foreach (string word in inputs)
        {
            if (string.IsNullOrWhiteSpace(word)) continue;

            string cleanWord = word.Trim();

            if (!isFirstWordFound)
            {
                // first word in lower
                sb.Append(cleanWord.ToLowerInvariant());
                isFirstWordFound = true;
            }
            else
            {
                // next words : start upper then lower
                sb.Append(char.ToUpperInvariant(cleanWord[0]));
                if (cleanWord.Length > 1)
                {
                    sb.Append(cleanWord.Substring(1).ToLowerInvariant());
                }
            }
        }

        return sb.ToString();
    }
}