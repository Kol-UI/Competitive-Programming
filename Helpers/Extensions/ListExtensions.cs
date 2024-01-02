namespace CompetitiveProgramming.Helpers
{
    public class ListExtensions
    {
        public static int GetAverage(List<int> results)
        {
            return (int)results.Average();
        }

        public static int GetSum(List<int> results)
        {
            return results.Sum();
        }

        // Product : 1 * 2 * 3 * 4 * 5 = 120
        public static int GetProduct(List<int> list)
        {
            int product = 1;
            foreach (int num in list)
            {
                product *= num;
            }
            return product;
        }


        // Take multiple Lists and Merge then into one
        // Number of Lists and Type are Unknown but must be the same
        public static List<T> MergeLists<T>(params List<T>[] lists)
        {
            if (lists == null || lists.Length == 0)
            {
                return new List<T>();
            }

            List<T> merged = new();

            foreach (List<T> list in lists)
            {
                if (list != null)
                {
                    foreach (T element in list)
                    {
                        if (element != null)
                        {
                            merged.Add(element);
                        }
                    }
                }
            }

            return merged;
        }

    }
}