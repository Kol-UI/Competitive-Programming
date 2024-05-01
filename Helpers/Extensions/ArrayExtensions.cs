namespace CompetitiveProgramming.Helpers
{
    public class ArrayExtensions
    {
        public static int GetAverage(int[] results)
        {
            return (int)results.Average();
        }

        public static int GetSum(int[] results)
        {
            return results.Sum();
        }

        // Product : 1 * 2 * 3 * 4 * 5 = 120
        public static int GetProduct(int[] array)
        {
            int product = 1;
            foreach (int num in array)
            {
                product *= num;
            }
            return product;
        }

        // Take multiple Arrays and Merge then into one
        // Number of Arrays and Type are Unknown but must be the same
        public static T[] MergeArrays<T>(params T[][] arrays)
        {
            if (arrays == null || arrays.Length == 0)
            {
                return Array.Empty<T>();
            }

            List<T> merged = new();

            foreach (T[] array in arrays)
            {
                if (array != null)
                {
                    foreach (T element in array)
                    {
                        if (element != null)
                        {
                            merged.Add(element);
                        }
                    }
                }
            }

            return merged.ToArray();
        }

        // Input: words = ["a","b","c","ab","bc","abc"], s = "abc" return 3
        // The strings in words which are a prefix of s = "abc" are: "a", "ab", and "abc".
        public static int CountPrefixes(string[] words, string s)
        {
            return words.Count(i => s.StartsWith(i));
        }
    }
}