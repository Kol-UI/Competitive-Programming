class Solution 
{ 
    static int xmod11(String x)
	{ 
        int cur = 0;
        int rem = 0;
	    for(int i = 0; i < x.length(); i++)
	    {
	        cur = rem*10 + x.charAt(i) - '0';
	        rem = cur%11;
	    }
	    return rem;
	}
} 