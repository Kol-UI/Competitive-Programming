// Minimum Steps Required


class Solution
{
	int minSteps(String str)
    {
	    int Count = 0;
        for(int i = 1; i < str.length(); i++)
        {
            if(str.charAt(i-1) != str.charAt(i))
            {
                Count++;
            }
        }
        if(Count%2!=0)
        {
            return (Count+1)/2 +1;
        }
        return Count/2 +1;
    }
}