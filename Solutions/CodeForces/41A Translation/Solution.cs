// 41A Translation



using System;
using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Translation
{

    class Program
    {
        //static void Main()
        static void Solution()
        {
            string s = Console.ReadLine()!;
            string t = Console.ReadLine()!;

            if (IsTranslation(s, t))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        static bool IsTranslation(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[t.Length - 1 - i])
                    return false;
            }

            return true;
        }
    }


    public class Test
    {
        public static string CheckTranslation(string s, string t)
        {
            if (s.Length != t.Length)
                return "NO";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[t.Length - 1 - i])
                    return "NO";
            }

            return "YES";
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Test.CheckTranslation("code", "edoc"), "YES"),
                ResultTester.CheckResult<string>(Test.CheckTranslation("hello", "olleh"), "YES"),
                ResultTester.CheckResult<string>(Test.CheckTranslation("abc", "def"), "NO"),
                ResultTester.CheckResult<string>(Test.CheckTranslation("programming", "gnimmargorp"), "YES"),
                ResultTester.CheckResult<string>(Test.CheckTranslation("world", "dlrow"), "YES"),
            };
            return results;
        }
    }

}