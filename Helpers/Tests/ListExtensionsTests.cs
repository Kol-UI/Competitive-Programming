namespace CompetitiveProgramming.Helpers
{
    public class ListExtensionTests
    {
        public static bool ProductListTest()
        {
            List<int> numbers = new() { 1, 2, 3, 4, 5 };
            int expectedProduct = 120;
            int product = ListExtensions.GetProduct(numbers);
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

        public static bool MergeListsTest()
        {
            List<int> list1 = new() { 1, 2, 3 };
            List<int> list2 = new() { 4, 5, 6 };
            List<int> list3 = new() { 7, 8, 9 };
            List<string> list4 = new() {"Test", "C#", "Program"};
            List<string> list5 = new() {"Code", "Method", "List"};

            List<int> expected1 = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> expected2 = new() {"Test", "C#", "Program", "Code", "Method", "List"};
            
            List<int> mergedList = ListExtensions.MergeLists(list1, list2, list3);
            List<string> mergedList2 = ListExtensions.MergeLists(list4, list5);

            PrintHelper.PrintList(mergedList);
            PrintHelper.PrintList(mergedList2);

            if (mergedList.SequenceEqual(expected1) && mergedList2.SequenceEqual(expected2))
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