namespace CompetitiveProgramming.Helpers
{
    public class IntUtils
    {
        // 5 => 1 + 2 + 3 + 4 + 5 = 15
        public static int SumOfFirstNIntegers(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}