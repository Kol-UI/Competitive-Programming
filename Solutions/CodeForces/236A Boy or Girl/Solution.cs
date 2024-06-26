// Boy or Girl

/*
Those days, many boys use beautiful girls' photos as avatars in forums. So it is pretty hard to tell the gender of a user at the first glance. Last year, our hero went to a forum and had a nice chat with a beauty (he thought so). After that they talked very often and eventually they became a couple in the network.

But yesterday, he came to see "her" in the real world and found out "she" is actually a very strong man! Our hero is very sad and he is too tired to love again now. So he came up with a way to recognize users' genders by their user names.

This is his method: if the number of distinct characters in one's user name is odd, then he is a male, otherwise she is a female. You are given the string that denotes the user name, please help our hero to determine the gender of this user by his method.

Input
The first line contains a non-empty string, that contains only lowercase English letters — the user name. This string contains at most 100 letters.

Output
If it is a female by our hero's method, print "CHAT WITH HER!" (without the quotes), otherwise, print "IGNORE HIM!" (without the quotes).
*/

using System;
    using System.Linq;
using CompetitiveProgramming.AtCoder.ADisjointSetUnion;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.BoyorGirl
{
    // Solution
    /*
    class Program
    {
        static void Main()
        {
            string userName = Console.ReadLine();
            bool isMale = IsMale(userName);
            string result = isMale ? "IGNORE HIM!" : "CHAT WITH HER!";
            Console.WriteLine(result);
        }

        static bool IsMale(string userName)
        {
            int distinctCharacterCount = userName.Distinct().Count();
            return distinctCharacterCount % 2 == 1;
        }
    }
    */

    // Test Solution
    public class Solution
    {
        public static bool IsMale(string userName)
        {
            int distinctCharacterCount = userName.Distinct().Count();
            return distinctCharacterCount % 2 == 1;
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsMale("wjmzbmr"), false),
                ResultTester.CheckResult<bool>(Solution.IsMale("xiaodao"), true),
                ResultTester.CheckResult<bool>(Solution.IsMale("sevenkplus"), false),
                ResultTester.CheckResult<bool>(Solution.IsMale("pezu"), false),
                ResultTester.CheckResult<bool>(Solution.IsMale("wnemlgppy"), false),
                ResultTester.CheckResult<bool>(Solution.IsMale("sevenkplus"), false),
                ResultTester.CheckResult<bool>(Solution.IsMale("zcinitufxoldnokacdvtmdohsfdjepyfioyvclhmujiqwvmudbfjzxjfqqxjmoiyxrfsbvseawwoyynn"), true),
                ResultTester.CheckResult<bool>(Solution.IsMale("qsxxuoynwtebujwpxwpajitiwxaxwgbcylxneqiebzfphugwkftpaikixmumkhfbjiswmvzbtiyifbx"), false),
                ResultTester.CheckResult<bool>(Solution.IsMale("qwbdfzfylckctudyjlyrtmvbidfatdoqfmrfshsqqmhzohhsczscvwzpwyoyswhktjlykumhvaounpzwpxcspxwlgt"), true),
                ResultTester.CheckResult<bool>(Solution.IsMale("nuezoadauueermoeaabjrkxttkatspjsjegjcjcdmcxgodowzbwuqncfbeqlhkk"), true),
                ResultTester.CheckResult<bool>(Solution.IsMale("lggvdmulrsvtuagoavstuyufhypdxfomjlzpnduulukszqnnwfvxbvxyzmleocmofwclmzz"), true),
                ResultTester.CheckResult<bool>(Solution.IsMale("tgcdptnkc"), true),
                ResultTester.CheckResult<bool>(Solution.IsMale("wvfgnfrzabgibzxhzsojskmnlmrokydjoexnvi"), true),
                ResultTester.CheckResult<bool>(Solution.IsMale("sxtburpzskucowowebgrbovhadrrayamuwypmmxhscrujkmcgvyinp"), true),
                ResultTester.CheckResult<bool>(Solution.IsMale("pjqxhvxkyeqqvyuujxhmbspatvrckhhkfloottuybjivkkhpyivcighxumavrxzxslfpggnwbtalmhysyfllznphzia"), true),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Boy or Girl");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
        }
    }
}