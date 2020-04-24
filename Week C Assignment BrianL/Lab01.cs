//Brian Lopez IT 483 Section 2 Suboh
using System;

namespace Lab01
{
  class resturantGuide
  {
    static void Main(string[] args)
    {
        Console.WriteLine("CS 201 Restaurant Guide\n");
        bool spicy, fancy;
        Console.WriteLine("Do you like spicy food? (y / n) : ");
        string userResponse = Console.ReadLine();
        char userLetter = userResponse[0];
        if(userLetter == Convert.ToChar("y") || userLetter == Convert.ToChar("Y"))
        {
            spicy = true;
        }
        else
        {
            spicy = false;
        }
        Console.WriteLine("Do you want to go to a fancy restaurant? (y / n) : ");
        string userResponse2 = Console.ReadLine();
        char userLetter2 = userResponse2[0];
        fancy = (userLetter2 == Convert.ToChar("y") || userLetter2 == Convert.ToChar("Y"));
        // These are equal because the first one sets the spicy to true or false based on the user input of y
        // The second one initalizes on false and changes based on the users input which similar to the one 
        //above but done differently
        if(spicy)
        {
            if (fancy)
            {
                Console.WriteLine("I suggest you go to Thai Garden Palace."); 
            }
            else 
            {
                Console.WriteLine("I suggest you go to Alberto's Tacqueria.");
            }
        }
        else
        {
           if(fancy)
           {
               Console.WriteLine("I suggest you go to Chez Paris.");
           } 
           else
           {
               Console.WriteLine("I suggest you go to Joe's Diner.");
           }
        }

    }
  }
}