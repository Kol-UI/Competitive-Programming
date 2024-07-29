// Long Pressed Name

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongPressedName
{
    public class Solution
    {
        public bool IsLongPressedName(string name, string typed)
        {
            int nameIndex = 0;

            for (int typedIndex = 0; typedIndex < typed.Length; typedIndex++)
            {
                if (nameIndex < name.Length && name[nameIndex] == typed[typedIndex])
                {
                    nameIndex++;
                }
                else if (nameIndex == 0 || name[nameIndex - 1] != typed[typedIndex])
                {
                    return false;
                }
            }

            return nameIndex == name.Length;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Long Pressed Name");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }

}