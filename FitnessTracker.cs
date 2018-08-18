/*This will eventually become a command-type class that lets the BaymaxBot track daily minutes spent exercising.
I want to set it up so that the data is stored until the command is used again. The encouragement needs to be 
changed to sound more like Baymax. This was mostly an exercise to learn some C# until I can find a better way to
integrate with discord it in the future.*/

/*As long as you write "using System;", you don't have to write, say, System.Console.Write every time. 
You can just do Console.Write so long as you don't have 2 console classes in the same namespace.*/
using System;
        
namespace Treehouse.FitnessFrog
{
  class Program
  {
     static void Main()
     { 
       var total = 0.0;
       
       while (true) 
       {
           //Prompt the user for minutes exercised
           Console.WriteLine("Enter how many minutes you exercised, or type \"quit\" to exit: ");
           
           /*you can use var in place of string, int, or double so long as the content to the right of the equal sign makes
           clear sense for that variable. ReadLine is, of course, going to give back a string. that means you can use var 
           instead of string :)*/
           var entry = Console.ReadLine();
         
           if (entry.ToLower() == "quit")
           {
             Console.WriteLine("Goodbye.");
             
             /*use break; to quit a loop. use continue; to return to the beginning of a loop. 
             Be careful where you use breaks and continues.*/
             break;
           }
            
           //any code that may come across a program-breaking exception can go between the try brackets
           try
           {
             //if you want the program to know that 0 is initially a double instead of an int, be sure to use 0.0
             /*the .Parse can be used for both ints and doubles. it converts strings into either int or double.
             .ToLower can be used to convert all upper case letters in a string to lowercase.*/
             var minutes = double.Parse(entry);
             
             if (minutes <= 0)
             {
               Console.WriteLine(minutes + " is not an acceptable value.");
               continue;
             }

             else if (minutes <= 10) 
             {
               //Display total minutes exercised to the screen
               Console.WriteLine("Better than nothing, am I right?");
             }

             else if (minutes <= 30) 
             {
               Console.WriteLine("Way to go, hot stuff!");
             }

             else if (minutes <= 60) 
             {
               Console.WriteLine("You must be a ninja warrior in training!");
             }

             else 
             {
               Console.WriteLine("Okay, now you're just showing off.");
             }

             //Add minutes exercised to total
             //total += minutes can be used instead of total = total + minutes. this is an example of synctactic sugar.
             total += minutes;

             Console.WriteLine("You have exercised for " + total + " minutes.");
           }
          
           //put the name of the exception in the (), then tell the program what you want it to do when it meets the exception.
           catch(FormatException)
           {
            Console.WriteLine("That is not valid input.");
            continue;
           }     
       }  
     }     
  }
}
