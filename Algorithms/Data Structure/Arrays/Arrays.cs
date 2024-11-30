namespace CompetitiveProgramming.Algorithms
{
    public class Arrays
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var hash = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (hash.TryGetValue(diff, out int value))
                    return new int[] { value, i };
                else
                {
                    if(!hash.ContainsKey(nums[i]))
                        hash.Add(nums[i], i);
                }
            }

            return new int[]{};
        }

        private static int CountOddNumbers(int[] array)
        {
            return array.Count(x => x % 2 != 0);
        }

        private static int CountEvenNumbers(int[] array)
        {
            return array.Count(x => x % 2 == 0);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            // For sorted arrays
            if (nums is null || nums.Length < 2)
            { 
                return 1;
            }

            int left = 1;
            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] != nums[left - 1])
                {
                    nums[left] = nums[right];
                    left++;
                }
            }

            return left;
        }
    }
}