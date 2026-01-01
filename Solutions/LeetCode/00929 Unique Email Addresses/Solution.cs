// Unique Email Addresses
namespace CompetitiveProgramming.LeetCode.UniqueEmailAddresses;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        HashSet<string> uniqueEmails = new HashSet<string>();
        foreach(string email in emails)
        {
            string[] emailNames = email.Split('@');
            string localName = emailNames[0];
            string domainName = emailNames[1];
            if(localName.Contains('+'))
            {
                localName = localName.Split('+')[0];  
            }
            localName = localName.Replace(".",String.Empty);
            string forwardedEmail = localName +"@"+ domainName;
            uniqueEmails.Add(forwardedEmail);   
        }
        return uniqueEmails.Count;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Unique Email Addresses");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}