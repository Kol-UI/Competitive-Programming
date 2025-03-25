namespace CompetitiveProgramming.Algorithms;
public class FullBinaryRepresentation
{
    // Full Binary Representation (int 32 bits, long 64 bits)

	// 11001001000000000000000000010001 => (int) 3237945361
	public static int FullBinaryToInt(string binary) => Convert.ToInt32(binary, 2);

	// (int) 3237945361 => 11001001000000000000000000010001
	public static string IntToFullBinary(int value) => Convert.ToString(value, 2).PadLeft(32, '0');
	public static string LongToFullBinary(long value) => Convert.ToString(value, 2).PadLeft(64, '0');
	public static long FullBinaryToLong(string binary) => Convert.ToInt64(binary, 2);
	public static bool IsLongBinary(string binary) => binary.Length > 32;
	public static bool IsLongValue(long value) => value < int.MinValue || value > int.MaxValue;
	public static string FullBinaryToValue(string bitsValue) => IsLongBinary(bitsValue) ? FullBinaryToLong(bitsValue).ToString() : FullBinaryToInt(bitsValue).ToString();
	public static string ValueToFullBinary(long value) => IsLongValue(value) ? LongToFullBinary(value) : IntToFullBinary((int)value);
}