using System;
namespace CompetitiveProgramming.CodeWars.EightKyu.EvenorOdd
{
	public class Solution
	{
        // Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
        public static string EvenOrOdd(int number)
        {
            if(number %2 == 0)
            {
                Console.WriteLine("Number {0} is even", number);
                return "Even";
            }
            else
            {
                Console.WriteLine("Number {0} is odd", number);
                return "Odd";
            }
        }
    }
}