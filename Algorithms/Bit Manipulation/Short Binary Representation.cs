namespace CompetitiveProgramming.Algorithms;
public class ShortBinaryRepresentation
{
    // Short Binary Representation

	// 1010 => (int) 10
	public static int ShortBinaryToInt(string binary) => Convert.ToInt32(binary, 2);

	// (int) 10 => 1010
	public static string IntToShortBinary(int value) => Convert.ToString(value, 2);

	// (long) 10 => 1010
	public static string LongToShortBinary(long value) => Convert.ToString(value, 2);

	// 1010 => (long) 10
	public static long ShortBinaryToLong(string binary) => Convert.ToInt64(binary, 2);

	// Returns true if the binary string can be represented as a long (does not check length, as short binaries can represent both int and long)
	public static bool CanBeLongBinary(string binary) { return long.TryParse(binary, System.Globalization.NumberStyles.Integer, null, out _); }

	// Convert short binary string to value (int or long) as a string
	public static string ShortBinaryToValue(string bitsValue) => CanBeLongBinary(bitsValue) ? ShortBinaryToLong(bitsValue).ToString() : ShortBinaryToInt(bitsValue).ToString();

	// Convert value (int or long) to short binary string
	public static string ValueToShortBinary(long value) => LongToShortBinary(value);

}