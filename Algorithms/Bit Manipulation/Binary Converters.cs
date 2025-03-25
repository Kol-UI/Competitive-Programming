namespace CompetitiveProgramming.Algorithms;
public class BinaryConverters
{
    // Binary to value (chooses Full or Short based on binary length)
	public static string BinaryToValue(string bitsValue) => FullBinaryRepresentation.IsLongBinary(bitsValue) ? FullBinaryRepresentation.FullBinaryToValue(bitsValue) : ShortBinaryRepresentation.ShortBinaryToValue(bitsValue);

	// Value to binary (chooses Full or Short based on value range)
	public static string ValueToBinary(long value) => FullBinaryRepresentation.IsLongValue(value) ? FullBinaryRepresentation.ValueToFullBinary(value) : ShortBinaryRepresentation.ValueToShortBinary(value);

	// "00000000000000000000000000010111" => 0b_00000000_00000000_00000000_00010111
	public static uint BinaryStringToUint32(string binary) => Convert.ToUInt32(binary, 2);
}