namespace CompetitiveProgramming.Algorithms.Training
{
    public class CheckIfDoubleExist
    {
        // Double Loops
        public bool CheckIfExist(int[] arr)
        {
            if (arr is null || arr.Length < 2)
            {
                return false;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == 2 * arr[j] && i != j)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Improved HashSet
        public bool CheckIfExist2(int[] arr)
        {
            var hashSet = new HashSet<int>();
            foreach (var n in arr)
            {
                if (hashSet.Contains(n * 2) || ( (n % 2) == 0 && hashSet.Contains(n / 2)))
                {
                    return true;
                }
                hashSet.Add(n);
            }
            return false;
        }
    }
}