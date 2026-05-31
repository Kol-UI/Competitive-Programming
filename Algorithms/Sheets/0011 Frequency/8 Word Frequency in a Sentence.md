Given a sentence as a string, separate each word and returns a dictionary/map containing each word's frequency
```cs
public class WordFrequencyinaSentence
{
    // LINQ Approach : Uses Split and GroupBy
    public static Dictionary<string, int> GetWordFrequencyLinq(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence))
            return new Dictionary<string, int>();

        return sentence
            .ToLower()
            // Split by common delimiters and remove empty results (multiple spaces)
            .Split(new[] { ' ', '.', ',', ';', '!', '?', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .GroupBy(word => word)
            .ToDictionary(group => group.Key, group => group.Count());
    }

    // Manual Approach : One-pass character processing (No Split, No LINQ)
    public static Dictionary<string, int> GetWordFrequencyManual(string sentence)
    {
        var frequencyMap = new Dictionary<string, int>();
        if (string.IsNullOrWhiteSpace(sentence)) return frequencyMap;

        StringBuilder currentWord = new StringBuilder();

        foreach (char c in sentence)
        {
            // Check if the character is a letter or digit (ignores punctuation)
            if (char.IsLetterOrDigit(c))
            {
                currentWord.Append(char.ToLower(c));
            }
            else if (currentWord.Length > 0)
            {
                // We hit a delimiter, save the completed word
                string word = currentWord.ToString();
                if (frequencyMap.ContainsKey(word)) frequencyMap[word]++;
                else frequencyMap[word] = 1;
                
                currentWord.Clear();
            }
        }

        // Handle the last word if the sentence doesn't end with punctuation
        if (currentWord.Length > 0)
        {
            string word = currentWord.ToString();
            if (frequencyMap.ContainsKey(word)) frequencyMap[word]++;
            else frequencyMap[word] = 1;
        }

        return frequencyMap;
    }
}```