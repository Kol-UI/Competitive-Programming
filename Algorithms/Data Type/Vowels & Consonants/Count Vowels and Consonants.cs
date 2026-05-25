namespace CompetitiveProgramming.Algorithms;

// Loop Approach
public class CountVowelsandConsonants
{
    public (int vowels, int consonants) CountVowelsAndConsonants(string input)
    {
        if (string.IsNullOrEmpty(input))
            return (0, 0);

        string vowels = "aeiouAEIOU";
        int vowelCount = 0;
        int consonantCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (!char.IsLetter(c))
                continue;

            bool isVowel = false;
            for (int j = 0; j < vowels.Length; j++)
            {
                if (c == vowels[j])
                {
                    isVowel = true;
                    break;
                }
            }

            if (isVowel)
                vowelCount++;
            else
                consonantCount++;
        }

        return (vowelCount, consonantCount);
    }
}

// Linq Approach
public class CountVowelsandConsonantsLinq
{
    public (int vowels, int consonants) CountVowelsAndConsonants(string input)
    {
        if (string.IsNullOrEmpty(input))
            return (0, 0);

        string vowels = "aeiouAEIOU";
        
        int vowelCount = input.Count(c => vowels.Contains(c));
        int consonantCount = input.Count(c => char.IsLetter(c) && !vowels.Contains(c));

        return (vowelCount, consonantCount);
    }
}