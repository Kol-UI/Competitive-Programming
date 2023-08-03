﻿using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.SevenKyu.Isograms
{
	public class Solution
	{
        // It is an Isogram ?
        public static bool IsIsogram(string str)
        {
            int strLen = str.Length;
            return str.ToLower().Distinct().Count() == strLen;
        }
    }

    public class Test
    {
        public static bool[] TestIsograms()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsIsogram("test"), false),
                ResultTester.CheckResult<bool>(Solution.IsIsogram("machine"), true),
                ResultTester.CheckResult<bool>(Solution.IsIsogram("moose"), false),
                ResultTester.CheckResult<bool>(Solution.IsIsogram("aba"), false),
                ResultTester.CheckResult<bool>(Solution.IsIsogram("csharp"), true),
            };
            return results;
        }
    }
}

