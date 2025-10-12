// Find Sum of Array Product of Magical Sequences
namespace CompetitiveProgramming.LeetCode.FindSumofArrayProductofMagicalSequences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int MagicalSum(int MaxPower, int TargetOnes, int[] Numbers)
    {
        int Length = Numbers.Length;
        long[][] PowerTable = new long[Length][];
        for (int Index = 0; Index < Length; Index++)
        {
            PowerTable[Index] = new long[MaxPower + 1];
            PowerTable[Index][0] = 1;
            for (int Power = 1; Power <= MaxPower; Power++)
            {
                PowerTable[Index][Power] = (PowerTable[Index][Power - 1] * Numbers[Index]) % Mod;
            }
        }

        long[][] CombinationTable = new long[MaxPower + 1][];
        for (int Row = 0; Row <= MaxPower; Row++)
        {
            CombinationTable[Row] = new long[MaxPower + 1];
            CombinationTable[Row][0] = 1;
            for (int Column = 1; Column <= Row; Column++)
            {
                CombinationTable[Row][Column] = (CombinationTable[Row - 1][Column - 1] + CombinationTable[Row - 1][Column]) % Mod;
            }
        }

        long[,,] CurrentState = new long[MaxPower + 1, MaxPower + 1, TargetOnes + 1];
        CurrentState[MaxPower, 0, 0] = 1;

        for (int Index = 0; Index < Length; Index++)
        {
            long[,,] NextState = new long[MaxPower + 1, MaxPower + 1, TargetOnes + 1];
            long[] CurrentPowerTable = PowerTable[Index];

            for (int Remaining = 0; Remaining <= MaxPower; Remaining++)
            {
                for (int Carry = 0; Carry <= MaxPower; Carry++)
                {
                    for (int OnesCount = 0; OnesCount <= TargetOnes; OnesCount++)
                    {
                        long CurrentValue = CurrentState[Remaining, Carry, OnesCount];
                        if (CurrentValue == 0)
                            continue;

                        for (int Used = 0; Used <= Remaining; Used++)
                        {
                            int Total = Used + Carry;
                            int Bit = Total & 1;
                            int NewOnesCount = OnesCount + Bit;
                            if (NewOnesCount > TargetOnes)
                                continue;

                            int NewCarry = Total >> 1;
                            int NewRemaining = Remaining - Used;

                            long AddValue = (CurrentValue * CombinationTable[Remaining][Used]) % Mod;
                            AddValue = (AddValue * CurrentPowerTable[Used]) % Mod;

                            NextState[NewRemaining, NewCarry, NewOnesCount] = 
                                (NextState[NewRemaining, NewCarry, NewOnesCount] + AddValue) % Mod;
                        }
                    }
                }
            }

            CurrentState = NextState;
        }

        long Result = 0;
        for (int Carry = 0; Carry <= MaxPower; Carry++)
        {
            int ExtraOnes = CountBits(Carry);
            int NeededOnes = TargetOnes - ExtraOnes;

            if (NeededOnes >= 0 && NeededOnes <= TargetOnes)
            {
                Result = (Result + CurrentState[0, Carry, NeededOnes]) % Mod;
            }
        }

        return (int)Result;
    }

    private int CountBits(int Number)
    {
        int Count = 0;
        while (Number != 0)
        {
            Number &= (Number - 1);
            Count++;
        }
        return Count;
    }
}


public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Sum of Array Product of Magical Sequences");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}