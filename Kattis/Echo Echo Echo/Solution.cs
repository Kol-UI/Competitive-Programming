// Echo Echo Echo



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.Kattis.EchoEchoEcho
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void Solution()
        {
            string word = Console.ReadLine()!.Trim();

            Console.WriteLine($"{word} {word} {word}");
        }
    }
}