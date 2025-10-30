using System.Numerics;

namespace CompetitiveProgramming.Algorithms;

public class CountSetBit
{
    // Count 1 by using C# built-in BitOperations.PopCount
    // CountSetBits(10);
    // 1010 -> Result : 2
    // CountSetBits(42);
    // 101010 -> Result : 3
    // CountSetBits(7);
    // 0111 -> Result : 3
    public int CountSetBits(int number) => BitOperations.PopCount((uint)number);


    // Count O by using C# built-in BitOperations.PopCount
    // 10 (1010) has 4 bits set. Zeros = 32 - 2 = 30
    // 42 (101010) has 3 bits set. Zeros = 32 - 3 = 29
    // 7 (0111) has 3 bits set. Zeros = 32 - 3 = 29
    public int CountUnsetBits(int number)
    {
        int TotalBits = sizeof(int) * 8; // 32
        int countOfOnes = BitOperations.PopCount((uint)number);
        return TotalBits - countOfOnes;
    }
}