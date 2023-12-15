// Leggja saman



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.Kattis.Leggjasaman
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            int arnarCars = Convert.ToInt32(Console.ReadLine());
            int hannesCars = Convert.ToInt32(Console.ReadLine());

            int totalCars = arnarCars + hannesCars;

            Console.WriteLine(totalCars);
        }
    }
}