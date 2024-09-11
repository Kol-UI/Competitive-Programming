namespace CompetitiveProgramming.Algorithms
{
    public class BitManipulation
    {
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
    }
}