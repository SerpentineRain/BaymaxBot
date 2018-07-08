//This will be a command that lets the BaymaxBot track daily minutes spent exercising.
//There are only 1440 minutes in a day.

namespace Baymax.FitnessTracker
{
  class Program
  {
      static void Main()
      { 
        int total = 0;
        
        int x = 2;
        
        while (total < 1440) 
        {
          
          if (x % 2 <= 0)
          {  
            //Prompt the user for minutes exercised
            Console.WriteLine("Enter how many minutes you exercised: ");
            
            string entry =  System.Console.ReadLine();
            
            int minutes = int.Parse(entry);
            
            //Add minutes exercised to total
            total = total + minutes;
            
            //Display total minutes exercised to the screen
            Console.WriteLine("You have exercised " + total + " minutes.");
          }
          
          if (x % 2 > 0)
          {
            Console.WriteLine("Feeling the burn? How long have you been sweating, champ?");
          
            string entry =  Console.ReadLine();
            
            int minutes = int.Parse(entry);
            
            //Add minutes exercised to total
            total = total + minutes;
            
            Console.WriteLine("Keep it up! " + total + " minutes already!");
          }
          
         x = x + 1;
          
        }  
        //Repeat until the user quits(loop), or limit is reached.      
      }
  }
}

//Things I've learned from this:
//As long as you write "using System;", then you don't have to write System.Console.Write every time.
//You can just do Console.(write, Read, etc) so long as you don't have 2 console classes in the same namespace. 
