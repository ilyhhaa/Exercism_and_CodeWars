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
          if (balance == 0m)
            {
                return 0.5f;
            }
          if (balance > 0)
            {
                while (balance < 1000) 
                {
                    return 0.5f;
                }
                while (balance >=1000 && balance<5000) 
                {
                    return 1.621f;
                }

            }
          if(balance >= 5000)
            {
                return 2.475f;
            }
            return 3.213f;

        }

        public static decimal Interest(decimal balance)
        {
            decimal InterestRateResult = (decimal)InterestRate(balance);

            return (balance*(decimal)InterestRate(balance))/100;
        }

        public static decimal AnnualBalanceUpdate(decimal balance)
        {
            decimal InterestResult = Interest(balance);

            return balance += InterestResult;
        }

        public static int YearsBeforeDesiredBalance(decimal balance = 200, decimal targetBalance = 400)
        {
           

            decimal prom = 0;

            int years = 0;

            while (balance!=targetBalance)
            {
                prom = balance+=AnnualBalanceUpdate(balance);
                years++;
            }
            return years;
            
        }


        
    }

   
}
