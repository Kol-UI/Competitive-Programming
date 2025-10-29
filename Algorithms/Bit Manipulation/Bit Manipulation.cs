using System.Numerics;

namespace CompetitiveProgramming.Algorithms
{
    public class BitManipulation
    {
        static void Samples()
        {
            Console.WriteLine(CountSetBits(00000000000000000000000000010111));
            uint n = 0b_00000000_00000000_00000000_00010111;
            Console.WriteLine(CountSetBits(n));
            Console.WriteLine(CountSetBits(Convert.ToUInt32("00000000000000000000000000010111", 2)));
            Console.WriteLine(CountSetBits(BinaryConverters.BinaryStringToUint32("00000000000000000000000000010111")));

            CountBits(4);
            CountBits(15);
        }

        // & : Result is 1 if both bits are 1, else 0
        // 1010 & 1100 = 1000 (10 & 12 = 8)
        public static int BitwiseAnd(int a, int b) => a & b;

        // | : Result is 1 if at least one bit is 1, else 0
        // Exemple : 1010 | 1100 = 1110 (10 | 12 = 14)
        public static int BitwiseOr(int a, int b) => a | b;

        // ^ : Result is 1 if bits are differents, else 0
        // Exemple : 1010 ^ 1100 = 0110 (10 ^ 12 = 6)
        public static int BitwiseXor(int a, int b) => a ^ b;

        // ~ : Reverse all bits
        // Exemple : ~1010 = 0101 (~10 = -11)
        public static int BitwiseNot(int a) => ~a;

        // << : Move bit to left
        // Exemple : 1010 << 1 = 10100 (10 << 1 = 20)
        public static int BitwiseLeftShift(int a, int shift) => a << shift;

        // >> : Move bit to right
        // Exemple : 1010 >> 1 = 0101 (10 >> 1 = 5)
        public static int BitwiseRightShift(int a, int shift) => a >> shift;

        public static int CountSetBits(uint value) => BitOperations.PopCount(value);
        public static int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                result[i] = Convert.ToString(i, 2).Count(c => c == '1');
            }
            return result;
        }

        #region LC 2220
        private static int GetXorResult(int start, int goal)
        {
            return start ^ goal;
        }

        private static int CountSetBitsToOne(int xorResult)
        {
            int count = 0;
            int isDifferent = 1;
            int notDifferent = 0;
            while (xorResult > notDifferent)
            {
                count += xorResult & isDifferent;
                xorResult >>= isDifferent;
            }
            return count;
        }
        #endregion

        #region LC3370
        // Simple arithmetic to generate the next number with all bits set to 1.
        // (e.g., 3 -> 7, 7 -> 15).
        private static int NextAllSetBitsNumber(int x) => x * 2 + 1;

        // Efficiently shifts all bits left (multiplies by 2) and sets the new rightmost bit to 1.
        // This is the bitwise equivalent of the arithmetic version above.
        private static int NextAllSetBitsNumber_BitManipulation(int x) => (x << 1) | 1;

        // Checks if a number consists only of '1' bits (e.g., 1, 3, 7, 15).
        // The key operation '& (x + 1)' clears the rightmost '1' bit, so the result is zero only if there was no '0' bit.
        private static bool IsAllSetBits(int x) => x > 0 && (x & (x + 1)) == 0;
        #endregion
    }
}