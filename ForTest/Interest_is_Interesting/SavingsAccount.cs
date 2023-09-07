using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.Interest_is_Interesting
{
    static class SavingsAccount
    {
        public static float InterestRate(decimal balance)
        {

            if (balance <= 0)
            {
                return 3.213f;
            }
            if (balance > 0 && balance <= 1000)
            {
                return 0.5f;
            }
            if (balance > 1000 && balance <= 500)
            {
                return 1.621f;
            }
            if (balance > 5000)
            {
                return 2.475f;
            }
            return 3.213f;

        }

        public static decimal Interest(decimal balance)
        {
            return 1.006m;
        }

        public static decimal AnnualBalanceUpdate(decimal balance)
        {
            return 1.0m;
        }

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            return 1;
        }
    }
}
