using System;

namespace CompetitiveProgramming.Helpers
{
    public class InvokeDelegateHelper
    {
        public static int InvokeDelegateIfNotNull(Delegate[] delegatesToInvoke)
        {
            int invokedDelegateCount = 0;

            if (delegatesToInvoke != null && delegatesToInvoke.Length > 0)
            {
                foreach (Delegate del in delegatesToInvoke)
                {
                    del.DynamicInvoke();
                    invokedDelegateCount++;
                }
            }

            return invokedDelegateCount;
        }
    }
}