using System;
using System.Collections.Generic;
using System.Reflection;
using CompetitiveProgramming.Models;

namespace CompetitiveProgramming.Services
{
    public class AutoInstantiate
    {
        /*
        public static void SetAutoInstantiate()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(BaseDelegate).IsAssignableFrom(type) && type != typeof(BaseDelegate) && type.IsClass && !type.IsAbstract && type.Namespace == "CsharpNotes.Tempo")
                {
                    object instance = Activator.CreateInstance(type);
                    DelegateLists.objectList2.Add((BaseDelegate)instance);
                    Console.WriteLine($"Instance of {type.Name} created.");
                }
            }
        }
        */

        public static void SetAutoInstantiate()
        {
            var namespaces = new string[]
            { 
                "AtCoder", "CodeChef", "CodeForces", "CoderByte",
                "CodeWars.EightKyu", "CodeWars.SevenKyu", "CodeWars.SixKyu",
                "CodinGame", "CodingBlocks", "CSAcademy"
            };

            for(int i = 0; i < namespaces.Length; i++)
            {
                namespaces[i] = "CompetitiveProgramming." + namespaces[i];
            }

            //var ignored = new string[] { "CsharpNotes.Tests" };
            var types = GetTypesInNamespaces(namespaces);

            foreach (Type type in types)
            {
                if (typeof(BaseSolution).IsAssignableFrom(type) && type != typeof(BaseSolution) && type.IsClass && !type.IsAbstract)
                {
                    object instance = Activator.CreateInstance(type)!;
                    DelegateLists.solutionList.Add((BaseSolution)instance);
                    //Console.WriteLine($"Instance of {type.Name} created.");
                }
            }
        }

        /*
        private static IEnumerable<Type> GetTypesInNamespaces(IEnumerable<string> namespaces)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.GetTypes().Where(t => namespaces.Any(ns => t.Namespace?.StartsWith(ns) == true));
        }
        */
        public static IEnumerable<Type> GetTypesInNamespaces(string[] namespaces)
        {
            /*
            var assembly = Assembly.GetExecutingAssembly();
            foreach (var type in assembly.GetTypes())
            {
                if (IsInIncludedNamespace(type.Namespace!, includedNamespaces) && !IsInExcludedNamespace(type.Namespace!, excludedNamespaces))
                {
                    yield return type;
                }
            }
            */
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.GetTypes().Where(t => namespaces.Any(ns => t.Namespace?.StartsWith(ns) == true));
        }

        private static bool IsInIncludedNamespace(string namespaceName, string[] includedNamespaces)
        {
            return includedNamespaces.Any(ns => namespaceName.StartsWith(ns + "."));
        }

        private static bool IsInExcludedNamespace(string namespaceName, string[] excludedNamespaces)
        {
            return excludedNamespaces.Any(ns => namespaceName.StartsWith(ns + "."));
        }
    }

    public abstract class BaseDelegate
    {
        public abstract void CommonFunction();
    }

    public class SpecificClass1 : BaseDelegate
    {
        public override void CommonFunction()
        {
            Console.WriteLine("SpecificClass1.CommonFunction() executed");
        }
    }

    public class SpecificClass2 : BaseDelegate
    {
        public override void CommonFunction()
        {
            Console.WriteLine("SpecificClass2.CommonFunction() executed");
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
/*
    class Program
    {
        static void Main(string[] args)
        {
            AutoInstantiate.SetAutoInstantiate();
            DelegateLists.ExecuteDelegates();
        }
    }
    */
}