// USRS2 Integer Input

/*
You have already seen how to read a String. Let's see how to read the integer datatype value.
The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type, such as int. The program will cause an error: error CS0029: Cannot implicitly convert type string' to int'

So we have to convert the string type, by using the Convert.To command:

for eg -  int age = Convert.ToInt32(Console.ReadLine()); //We use Int32 datatype for integers
          Console.WriteLine("Your age is: " + age);
Write a program for the following

Declare an integer variable.
Read the value from the user.
Print it's square.
Sample 1:
Input 5
Output 25
*/
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.USRS2IntegerInput
{
    // Solution
    /*
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square of the number is: " + (num * num));
        }
    }
    */

    // Test
    public class Test
    {
        public static string TestIntegerInput(int num)
        {
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Square of the number is: " + (num * num));
            return "Square of the number is: " + (num * num);
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(TestIntegerInput(2), "Square of the number is: 4")
            };
            return results;
        }
    }
}