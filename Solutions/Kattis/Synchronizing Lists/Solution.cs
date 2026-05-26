// Synchronizing Lists
namespace CompetitiveProgramming.Kattis.SynchronizingLists;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            if (n == 0) break;
            
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();
            
            for (int i = 0; i < n; i++)
            {
                l1.Add(int.Parse(Console.ReadLine()));
            }
            
            for (int i = 0; i < n; i++)
            {
                l2.Add(int.Parse(Console.ReadLine()));
            }
            
            List<int> l1Sorted = new List<int>(l1);
            l1Sorted.Sort();
            l2.Sort();
            
            // Pour gérer les doublons, on utilise une file d'attente pour chaque valeur
            Dictionary<int, Queue<int>> valueMap = new Dictionary<int, Queue<int>>();
            
            for (int i = 0; i < n; i++)
            {
                if (!valueMap.ContainsKey(l1Sorted[i]))
                {
                    valueMap[l1Sorted[i]] = new Queue<int>();
                }
                valueMap[l1Sorted[i]].Enqueue(l2[i]);
            }
            
            List<int> ret = new List<int>();
            for (int i = 0; i < n; i++)
            {
                ret.Add(valueMap[l1[i]].Dequeue());
            }
            
            foreach (int val in ret)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Synchronizing Lists");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}