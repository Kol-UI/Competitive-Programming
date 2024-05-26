// Tricky Template

using System.Runtime.CompilerServices;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.TrickyTemplate
{
    class Program
    {
        /*
        void YESNO(bool b) => Console.WriteLine(b ? "YES" : "NO");
 
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
 
            var program = new Program();
 
            program.Solve();
 
            Console.Out.Flush();
            Console.Read();
        }
 
        public void Solve()
        {
            int zzz = GetInt();
 
            for (int zz = 0; zz < zzz; zz++)
            {
                Multi(out int n);
 
                string a = GetStr();
                string b = GetStr();
                string c = GetStr();
 
                bool flag = false;
                for (int i = 0; i < n; i++)
                {
                    flag |= a[i] != c[i] && b[i] != c[i];
                }
 
                YESNO(flag);
            }
        }
        */
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Tricky Template");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}