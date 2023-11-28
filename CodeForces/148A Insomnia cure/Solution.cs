// 148A - Insomnia cure



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.Insomniacure
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void Solution()
        {
            int factor1 = int.Parse(Console.ReadLine()!);
            int factor2 = int.Parse(Console.ReadLine()!);
            int factor3 = int.Parse(Console.ReadLine()!);
            int factor4 = int.Parse(Console.ReadLine()!);
            int totalDragons = int.Parse(Console.ReadLine()!);

            int damagedDragons = 0;

            for (int i = 1; i <= totalDragons; i++)
            {
                if (i % factor1 == 0 || i % factor2 == 0 || i % factor3 == 0 || i % factor4 == 0)
                {
                    damagedDragons++;
                }
            }

            Console.WriteLine(damagedDragons);
        }
    }

}