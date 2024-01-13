// Haiku


using System;
using System.Linq;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.Haiku
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string[] phrases = new string[3];

            for (int i = 0; i < 3; i++)
            {
                phrases[i] = Console.ReadLine()!;
            }

            if (IsHaiku(phrases))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool IsHaiku(string[] phrases)
        {
            int[] syllables = new int[3];

            for (int i = 0; i < 3; i++)
            {
                syllables[i] = phrases[i].Count(c => "aeiou".Contains(char.ToLower(c)));
            }

            return syllables[0] == 5 && syllables[1] == 7 && syllables[2] == 5;
        }
    }

    public class Test
    {
        public static bool IsHaiku(string[] phrases)
        {
            int[] syllables = new int[3];

            for (int i = 0; i < 3; i++)
            {
                syllables[i] = phrases[i].Count(c => "aeiou".Contains(char.ToLower(c)));
            }

            return syllables[0] == 5 && syllables[1] == 7 && syllables[2] == 5;
        }

        public static bool[] TestCases()
        {
            string[] phrases1 = { "on codeforces", "beta round is running", "a rustling of keys" };
            string[] phrases2 = { "how many gallons", "of edo s rain did you drink", "cuckoo" };
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(IsHaiku(phrases1), true),
                ResultTester.CheckResult<bool>(IsHaiku(phrases2), false),
            };
            return results;
        }
    }
}