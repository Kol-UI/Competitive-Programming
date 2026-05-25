namespace CompetitiveProgramming.Algorithms;
public class EvenOddJump
{
    public static void JumpSort(int[] numbers)
    {
        if (numbers == null || numbers.Length <= 1) return;

        int writeIndex = 0;

        // all even jumps to front
        for (int i = 0; i < numbers.Length; i++)
        {
            if ((numbers[i] & 1) == 0) // if even (Bitwise)
            {
                // if even element is not already in the correct position
                if (i != writeIndex)
                {
                    (numbers[writeIndex], numbers[i]) = (numbers[i], numbers[writeIndex]); // tuple swap (jump)
                }
                writeIndex++;
            }
        }
        // odd numbers are naturaly at the end after even numbers jumps
    }
}