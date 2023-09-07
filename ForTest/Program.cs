using System.Reflection;
using System;


internal class Program
{
    private static void Main(string[] args)
    {

        



    }

    
}
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
        if (balance > 1000 && balance <= 5000)
        {
            return 1.621f;
        }
        if (balance > 5000)
        {
            return 2.475f;
        }
        return 3.213f;

    }

}