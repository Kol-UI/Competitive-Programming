namespace CompetitiveProgramming.Algorithms
{
    public class HashTable
    {
        #region LC 884
        public static Dictionary<string, int> CountWordOccurrences(List<string> words1, List<string> words2)
        {
            var wordCount = new Dictionary<string, int>();

            AddWordsToDictionary(wordCount, words1);
            AddWordsToDictionary(wordCount, words2);

            return wordCount;
        }

        public static void AddWordsToDictionary(Dictionary<string, int> wordCount, List<string> words)
        {
            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }
        }

        public static List<string> FindWordsWithSingleOccurrence(Dictionary<string, int> wordCount)
        {
            return wordCount.Where(pair => pair.Value == 1).Select(pair => pair.Key).ToList();
        }
        #endregion
    }
}