// Life the Universe and Everything


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.SphereOnlineJudge.LifetheUniverseandEverything
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int number = int.Parse(Console.ReadLine()!);
            
            while (number != 42)
            {
                Console.WriteLine(number);

                number = int.Parse(Console.ReadLine()!);
            }
        }
    }
}