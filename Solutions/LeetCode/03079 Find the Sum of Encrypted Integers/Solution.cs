// Find the Sum of Encrypted Integers


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheSumofEncryptedIntegers
{
    public class Solution
    {

        static int Decrypt(int x)
        {
            string xStr = x.ToString();
            if (xStr.Length == 1)
            {
                return x;
            }
            char max = xStr[0];
            for (int i = 1; i < xStr.Length; i++)
            {
                max = (xStr[i] > max) ? xStr[i] : max;
            }
            return int.Parse(new string(max, xStr.Length));
        }




        public static int SumOfEncryptedInt(int[] nums)
        {
            int num = 0;
            foreach(int i in nums)
            {
                int x = Decrypt(i);
                num += x;
            }
            return num;
        }
    }
}