// Storing Boxes


using System;
namespace CompetitiveProgramming.CodeChef.StoringBoxes
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            int length = 11;
            int width = 13;
            Console.WriteLine(length * width);
            Console.WriteLine(2 * (length + width));
            width = 15;
            Console.WriteLine(length * width);
            Console.WriteLine(2 * (length + width));
        }
    }
}