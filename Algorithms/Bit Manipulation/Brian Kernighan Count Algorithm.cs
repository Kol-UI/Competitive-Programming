namespace CompetitiveProgramming.Algorithms;

public class BrianKernighanCount
{
    // Brian Kernighan's algorithm to count set bits in an integer
    // CountSetBits(10);
    // 1010 -> Result : 2
    // CountSetBits(42);
    // 101010 -> Result : 3
    // CountSetBits(7);
    // 0111 -> Result : 3
    public int CountSetBits(int number)
    {
        if (number == 0) return 0;
        int count = 0;
        uint x = (uint)number;
        // Continue as long as there is at least one bit set to 1
        while (x != 0)
        {
            // Desable the rightmost set bit
            x = x & (x - 1);
            // Increment the count for each disabled bit
            count++;
        }
        return count;
    }
    
    // Count O by using the total bit size minus the count of set bits
    // 10 (1010) has 4 bits set. Zeros = 32 - 2 = 30
    // 42 (101010) has 3 bits set. Zeros = 32 - 3 = 29
    // 7 (0111) has 3 bits set. Zeros = 32 - 3 = 29
    public int CountUnsetBits(int number)
    {
        // Determine the total size of the type (here, int = 32 bits)
        const int totalBits = sizeof(int) * 8; // int do 4 octets * 8 bits/octet = 32 bits
        // Count bits set to 1 using Brian Kernighan's algorithm
        int countOfOnes = CountSetBits(number);
        return totalBits - countOfOnes;
    }
}