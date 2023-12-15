/*
    Given a string S which consists of only lowercase English alphabets,
    you have to perform the below operations:
    If the string S contains any repeating character,
    remove the first repeating character and reverse the string
    and again perform the above operation on the modified string, otherwise, you stop.
    You have to find the final string.

    Example 1:
    Input: S = "abab"
    Output: ba
    Explanation:
    In 1st operation: The first repeating 
    character is a. After Removing the first 
    character, S = "bab". After Reversing the 
    string, S = "bab".
    In 2nd operation: The first non repeating 
    character is b. After Removing the first 
    character, S = "ab". After Reversing the 
    string, S = "ba".
    Now the string S does not contain any 
    repeating character.
    
    Example 2:
    Input: S = "dddd"
    Output: d
    Your Task:  
    You don't need to read input or print anything.
    Your task is to complete the function removeReverse( ) which accepts a string S input parameter and returns the modified string.
*/

//User function Template for Java

class Solution 
{ 
    String removeReverse(String S) 
    { 
        StringBuffer s = new StringBuffer(S);
        int freq[] = new int[26];
        for(int i = 0; i < s.length(); i++)
        {
            char ch = s.charAt(i);
            freq[ch-'a']++;
        }
        
        int flag = 0;
        int st = 0;
        int end = s.length() - 1; 
        while(st <= end)
        {
            if(flag == 0)
            {
                if(freq[s.charAt(st) - 'a'] == 1)
                st++;
                
                else
                {
                    freq[s.charAt(st)-'a']--;
                    s.replace(st, st + 1, "#");
                    st++;
                    flag = 1;
                }
                
            }
            else
            {
                if(freq[s.charAt(end) - 'a'] == 1)
                end--;
                
                else
                {
                    freq[s.charAt(end) - 'a']--;
                    s.replace(end, end + 1,"#");
                    end--;
                    flag = 0;
                }
            }
        }
        
        if(flag == 1)
        {
            s.reverse();
        }

        String ans="";
        for(int i = 0;i < s.length(); i++)
        {
            if(s.charAt(i)!='#')
            {
                ans += s.charAt(i);
            }
        }
        return ans;
        
    }
} 