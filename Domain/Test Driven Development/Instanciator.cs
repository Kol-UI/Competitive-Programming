using System;
using System.Collections.Generic;
using System.Reflection;
using CompetitiveProgramming.Models;

namespace CompetitiveProgramming.Services
{
    public class AutoInstantiate
    {
        public static void SetAutoInstantiate()
        {
            var namespaces = new string[]
            { 
                "AtCoder", "CodeChef", "CodeForces", "CoderByte",
                "CodeWars.EightKyu", "CodeWars.SevenKyu", "CodeWars.SixKyu",
                "CodinGame", "CodingBlocks", "CSAcademy",
                "GeeksForGeeks.School", "GeeksForGeeks.Basic", "GeeksForGeeks.Easy", "GeeksForGeeks.Medium", "GeeksForGeeks.Hard",
                "HackerRank", "Kattis", "ProjectEuler", "SphereOnlineJudge",
                "LeetCode"
            };

            for(int i = 0; i < namespaces.Length; i++)
            {
                namespaces[i] = "CompetitiveProgramming." + namespaces[i];
            }

            var types = GetTypesInNamespaces(namespaces);

            foreach (Type type in types)
            {
                if (typeof(BaseSolution).IsAssignableFrom(type) && type != typeof(BaseSolution) && type.IsClass && !type.IsAbstract)
                {
                    object instance = Activator.CreateInstance(type)!;
                    DelegateLists.solutionList.Add((BaseSolution)instance);
                }
            }
        }

        public static IEnumerable<Type> GetTypesInNamespaces(string[] namespaces)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.GetTypes().Where(t => namespaces.Any(ns => t.Namespace?.StartsWith(ns) == true));
        }
    }

    public class DelegateLists
    {
        public static readonly List<BaseSolution> solutionList = new List<BaseSolution>();

        public static void ExecuteDelegates()
        {
            foreach (var solution in solutionList)
            {
                solution.GetResult();
            }
        }
    }
}