namespace CompetitiveProgramming.Algorithms;
public class CheckIfItsaVowelHeavyWord
{
    public static bool IsVowelHeavy(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;

        HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

        int letterCount = 0;
        int vowelCount = 0;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                letterCount++;
                if (vowels.Contains(c))
                    vowelCount++;
            }
        }

        if (letterCount == 0) return false;

        return (double)vowelCount / letterCount >= 0.5;
    }
}