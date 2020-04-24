//Brian Lopez IT483 Section 2 Suboh
using System;

namespace Lab02
{
    class cashRegister  
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of glasses would you like:");
            Console.Write("1 -> Prescription, 2 -> Non-Prescription : ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if(userInput == 1 || userInput == 2)
            {
                Console.WriteLine(""); 
            }  
            while(userInput != 1 && userInput != 2)
            {
                Console.Write("1 -> Prescription, 2 -> Non-Prescription : ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if(userInput == 1 || userInput == 2)
                {
                    Console.WriteLine(""); 
                }                         
            }
            
            Console.WriteLine("What kind of coating would you like:");
            Console.Write("1 -> Anti-glare, 2 -> Brown tint : ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            if(userInput2 == 1 || userInput2 == 2)
            {
                Console.WriteLine(""); 
            }          
            while(userInput2 != 1 && userInput2 != 2)
            {
                Console.Write("1 -> Anti-glare, 2 -> Brown tint : ");
                userInput2 = Convert.ToInt32(Console.ReadLine());
                if(userInput2 == 1 || userInput2 == 2)
                {
                    Console.WriteLine(""); 
                }             
            }

            double prescriptionPrice = 0, coatingPrice = 0;

            if (userInput == 1)
            {
               prescriptionPrice = 40;
            }
            else if (userInput == 2)
            {
                prescriptionPrice = 25;
            }
            if (userInput2 == 1)
            {
                coatingPrice = 12.50;
            }
            else if (userInput2 == 2)
            {
                coatingPrice = 9.99;
            }

            Console.WriteLine("Your total cost is $" + (prescriptionPrice + coatingPrice));
        }
    }
}
