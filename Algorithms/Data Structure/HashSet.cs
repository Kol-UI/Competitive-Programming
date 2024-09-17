namespace CompetitiveProgramming.Algorithms
{
    public class HashSet
    {
        public static bool ContainsDuplicate(int[] nums) 
        {
            HashSet<int> set = new HashSet<int>(nums);
            return nums.Length != set.Count;
        }
    }
}