Remove vowels or consonants from a given string.

```cs
// Loop Approach
public class RemoveVowelsorConsonants
{
    public static string RemoveVowels(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        string vowels = "aeiouAEIOU";
        char[] result = new char[input.Length];
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            bool isVowel = false;

            for (int j = 0; j < vowels.Length; j++)
            {
                if (c == vowels[j])
                {
                    isVowel = true;
                    break;
                }
            }

            if (!isVowel)
                result[index++] = c;
        }

        return new string(result, 0, index);
    }

    public static string RemoveConsonants(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        string vowels = "aeiouAEIOU";
        char[] result = new char[input.Length];
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (!char.IsLetter(c))
            {
                result[index++] = c;
                continue;
            }

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
                result[index++] = c;
        }

        return new string(result, 0, index);
    }
}

// LINQ Approach
public class RemoveVowelsorConsonantsLinq
{
    static string vowels = "aeiouAEIOU";

    public static string RemoveVowels(string input) =>
        new string(input.Where(c => !vowels.Contains(c)).ToArray());

    public static string RemoveConsonants(string input) =>
        new string(input.Where(c => !char.IsLetter(c) || vowels.Contains(c)).ToArray());
}
```