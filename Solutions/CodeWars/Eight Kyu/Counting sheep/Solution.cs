using System;
using System.Linq;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.Countingsheep
{
    /*
        Consider an array/list of sheep where some sheep may be missing from their place.
        We need a function that counts the number of sheep present in the array (true means present).

        For example,

        [true,  true,  true,  false,
        true,  true,  true,  true ,
        true,  false, true,  false,
        true,  false, false, true ,
        true,  true,  true,  true ,
        false, false, true,  true]
        The correct answer would be 17.
    */

    public static class Kata
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(s => s);
        }
    }

    public class Test
    {
        public static bool[] TestCountingsheep()
        {
            // Case 1
            bool[] sheepsCase1 =
            {
                true,  true,  true,  false,
                true,  true,  true,  true ,
                true,  false, true,  false,
                true,  false, false, true ,
                true,  true,  true,  true ,
                false, false, true,  true
            };
            int Case1_Sheeps = CodeWars.EightKyu.Countingsheep.Kata.CountSheeps(sheepsCase1);

            // Case 2
            bool[] sheepsCase2 = { true,  false,  true };
            int Case2_Sheeps = CodeWars.EightKyu.Countingsheep.Kata.CountSheeps(sheepsCase2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_Sheeps, 17),
                ResultTester.CheckResult<int>(Case2_Sheeps, 2),
            };
            return results;
        }
    }
}