Given a string, for each vowel, replace it with the next consonant. If there is no consonant then keep the vowel.

```cs
public class ReverseVowelstonextConsonants
{
    public static string ReverseVowelsToNextConsonants(string input)
    {
        HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' ];
        char[] result = input.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (vowels.Contains(result[i]))
            {
                // Look for next consonant after position i
                int nextConsonantIndex = -1;
                for (int j = i + 1; j < result.Length; j++)
                {
                    char c = result[j];
                    if (char.IsLetter(c) && !vowels.Contains(c))
                    {
                        nextConsonantIndex = j;
                        break;
                    }
                }

                // If there is a next consonant then replace vowel
                if (nextConsonantIndex != -1)
                {
                    result[i] = result[nextConsonantIndex];
                }
            }
        }

        return new string(result);
    }
}
```