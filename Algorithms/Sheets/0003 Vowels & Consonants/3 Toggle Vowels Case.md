Reverse case for all vowels in a given string

```cs

public class ToggleVowelsCase
{
    static string vowels = "aeiouAEIOU";

    public static string Toggle(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        char[] result = new char[input.Length];

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

            result[i] = isVowel ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c;
        }

        return new string(result);
    }

    // LINQ Approach
    public static string ToggleLinq(string input) =>
        new string(input.Select(c => vowels.Contains(c)
            ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c))
            : c).ToArray());
}
```