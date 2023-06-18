// Century From Year

/*
The first century spans from the year 1 up to and including the year 100, the second century - from the year 101 up to and including the year 200, etc.

Task
Given a year, return the century it is in.

Examples
1705 --> 18
1900 --> 19
1601 --> 17
2000 --> 20
*/

using System;
namespace CompetitiveProgramming.CodeWars.EightKyu.CenturyFromYear
{
    public class Solution
	{
        public static int СenturyFromYear(int year)
        {
            return (year + 99) / 100;
        }
    }
}