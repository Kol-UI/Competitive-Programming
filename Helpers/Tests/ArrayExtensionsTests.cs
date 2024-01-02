using CompetitiveProgramming.Helpers;
namespace CompetitiveProgramming.Helpers
{
    public class ArrayExtensionTests
    {
        public static bool ProductArrayTest()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int expectedProduct = 120;
            int product = ArrayExtensions.GetProduct(numbers);
            Console.WriteLine($"Product: {product}");

            if(product == expectedProduct)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool MergeArraysTest()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] array3 = { 7, 8, 9 };
            
            string[] array4 = {"Test", "C#", "Program"};
            string[] array5 = {"Code", "Method", "Array"};

            int[] mergedArray = ArrayExtensions.MergeArrays(array1, array2, array3);
            PrintHelper.PrintArray(mergedArray);

            string[] mergedArray2 = ArrayExtensions.MergeArrays(array4, array5);
            PrintHelper.PrintStringArray(mergedArray2);

            int[] expected1 = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] expected2 = {"Test", "C#", "Program", "Code", "Method", "Array"};

            if (mergedArray.SequenceEqual(expected1) && mergedArray2.SequenceEqual(expected2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}