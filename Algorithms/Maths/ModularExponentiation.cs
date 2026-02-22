namespace CompetitiveProgramming.Algorithms.Maths;
using System.Numerics;
// Reminder of a very high power
public class ModularExponentiation
{
    public long CalculateModularPow(long baseNum, long exponent, long modulus)
    {
        BigInteger b = new BigInteger(baseNum);
        BigInteger e = new BigInteger(exponent);
        BigInteger m = new BigInteger(modulus);

        BigInteger result = BigInteger.ModPow(b, e, m);

        return (long)result;
    }
}