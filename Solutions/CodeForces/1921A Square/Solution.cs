// Square


using System;
namespace CompetitiveProgramming.CodeForces.Square
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            while (T-- > 0)
            {
                Solve();
            }
        }
        */

        static void Solve()
        {
            int[][] points = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                points[i] = new int[] { int.Parse(input[0]), int.Parse(input[1]) };
            }

            int minX = Math.Min(points[0][0], Math.Min(points[1][0], Math.Min(points[2][0], points[3][0])));
            int minY = Math.Min(points[0][1], Math.Min(points[1][1], Math.Min(points[2][1], points[3][1])));
            int maxX = Math.Max(points[0][0], Math.Max(points[1][0], Math.Max(points[2][0], points[3][0])));
            int maxY = Math.Max(points[0][1], Math.Max(points[1][1], Math.Max(points[2][1], points[3][1])));

            int width = maxX - minX;
            int height = maxY - minY;

            int area = width * height;

            Console.WriteLine(area);
        }
    }
}