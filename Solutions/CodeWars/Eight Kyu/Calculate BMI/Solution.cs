// Calculate BMI

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.CalculateBMI
{
    public class Kata
    {
        public static string Bmi(double weight, double height)
        {
            double bmi = weight / (height*height);
            switch(bmi)
            {
                case  <= 18.5: return "Underweight";

                case <= 25.0: return "Normal";

                case <= 30.0: return "Overweight";

                default :return "Obese";
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculate BMI");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeWars, ProblemCategory.EightKyu);
        }
    }
}