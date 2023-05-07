using System;
namespace CompetitiveProgramming.LeetCode.DefanginganIPAddress
{
	public class Solution
    {
        // Given a valid (IPv4) IP address, return a defanged version of that IP address.
        // A defanged IP address replaces every period "." with "[.]".

        // Example 1:

        // Input: address = "1.1.1.1"
        // Output: "1[.]1[.]1[.]1"
        
        // Example 2:

        // Input: address = "255.100.50.0"
        // Output: "255[.]100[.]50[.]0"

        public static string DefangIPaddr(string address)
        {
            string result = "";
            for(int i = 0; i < address.Length; i++)
            {
                if(address[i] == '.')
                {
                    result += "[.]";
                    continue;
                }
                result += address[i];
            }
            return result;
        }

    }
}