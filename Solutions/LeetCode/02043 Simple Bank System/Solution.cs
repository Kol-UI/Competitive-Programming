// Simple Bank System
namespace CompetitiveProgramming.LeetCode.SimpleBankSystem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Bank
{
    long[] balance;
    
    public Bank(long[] balance)
    {
        this.balance = balance;
    }
    
    public bool Transfer(int account1, int account2, long money)
    {
        if (account1 >= 1 && account1 <= balance.Length && account2 >= 1 && account2 <= balance.Length)
        {
            if (balance[account1 - 1] >= money){
                balance[account1 - 1] -= money;
                balance[account2 - 1] += money;
                return true;
            }
        }
        return false;
    }
    
    public bool Deposit(int account, long money)
    {
        if (account >= 1 && account <= balance.Length && money >= 0)
        {
            balance[account - 1] += money;
            return true;
        }
        return false;
    }
    
    public bool Withdraw(int account, long money)
    {
        if (account >= 1 && account <= balance.Length && balance[account - 1] >= money)
        {
            balance[account - 1] -= money;
            return true;
        }
        return false;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Simple Bank System");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}