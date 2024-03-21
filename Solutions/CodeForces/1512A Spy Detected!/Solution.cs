// Spy Detected!

using System;
using System.Collections.Generic;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.SpyDetected
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void Solution()
        {
            int t = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine()!);
                int[] nums = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                
                Console.WriteLine(FindSpy(nums));
            }
        }
        
        public static int FindSpy(int[] nums)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (!count.ContainsKey(nums[i]))
                {
                    count[nums[i]] = 1;
                }
                else
                {
                    count[nums[i]]++;
                }
            }
            
            foreach (var kvp in count)
            {
                if (kvp.Value == 1)
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] == kvp.Key)
                        {
                            return i + 1;
                        }
                    }
                }
            }
            
            return -1;
        }
    }
}