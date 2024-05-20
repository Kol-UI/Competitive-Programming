// Mile to Kilometer Convertor

/*
Write a program that does the following

Create a Convertor that converts miles into kilometers.(1 Mile = 1.60 KM)
Declare an integer variable mile
Accept user input and store it in mile
Declare a double variable km
Compute and output distance in kilometers console
*/
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.MiletoKilometerConvertor
{
    /*
    class Problem
    {
        static void Main(string[] args)
        {
            int mile = Convert.ToInt32(Console.ReadLine());
            double kilometer = 1.60 * mile;
            Console.WriteLine(kilometer + "km");
        }
    }
    */

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Mile to Kilometer Convertor");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}