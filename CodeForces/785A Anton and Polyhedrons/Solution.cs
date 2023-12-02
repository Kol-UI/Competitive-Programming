// Anton and Polyhedrons



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.AntonandPolyhedrons
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int n = int.Parse(Console.ReadLine()!);

            int total = 0;

            for (int i = 0; i < n; i++)
            {
                string polyhedron = Console.ReadLine()!;

                switch (polyhedron)
                {
                    case "Tetrahedron":
                        total += 4;
                        break;
                    case "Cube":
                        total += 6;
                        break;
                    case "Octahedron":
                        total += 8;
                        break;
                    case "Dodecahedron":
                        total += 12;
                        break;
                    case "Icosahedron":
                        total += 20;
                        break;
                }
            }

            Console.WriteLine(total);
        }
    }
}