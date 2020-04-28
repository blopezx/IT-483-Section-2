//Brian Lopez IT 483 Section 2 Suboh
using System;

namespace Lab03
{
    class transactionProgram    
    {
        
        static double transaction(double currentBalance, double updateBalance )
        {
            if (updateBalance > 0)
            {
                return currentBalance + updateBalance;
            }
            else 
            {
                if(Math.Abs(updateBalance) > currentBalance)
                {
                    return currentBalance = 0;
                }
                else
                {
                    return currentBalance + updateBalance;
                }
            }
            
        }
        
        static void Main(string[] args)
        {
           Console.WriteLine(transaction(50,1000000000000)); //WE RICH
        }
    }
}
