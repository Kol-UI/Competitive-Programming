namespace CompetitiveProgramming.Algorithms;
public class WordCounterinString
{
    // Split Approach
    public static int CountWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return 0;

        return input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    // Manual Approach
    public static int CountWordsManual(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return 0;

        int count = 0;
        bool inWord = false;

        foreach (char c in input)
        {
            if (char.IsWhiteSpace(c))
            {
                inWord = false;
            }
            else
            {
                if (!inWord)
                {
                    count++;
                    inWord = true;
                }
            }
        }

        return count;
    }
}