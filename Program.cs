using System; 

namespace FitnessTracker
{
  class Program 
  {
    static void Main() 
    {
      int runningTotal = 0; 
      bool keepGoing = true; 
      while (keepGoing)
      {
        // Prompt the user for minutes exercised 
        Console.Write("Enter how many minutes you exercised or write \"quit\" to exit: "); 
        string entry = Console.ReadLine(); 

        if (entry == "quit")
        {
          keepGoing = false; 
        }
        else 
        {
          // Add minutes exercised to total 
          int minutes = int.Parse(entry); 
          if (minutes <= 0)
          {
            Console.WriteLine($"{minutes} is not an acceptable value."); 
            continue; 
          }
          else {
            
            if (minutes <= 10) 
            {
              Console.WriteLine("Better than nothing, am I right?"); 
            }
            else if (minutes <= 30) 
            {
              Console.WriteLine("Look at you!"); 
            }
            else if (minutes <= 60) 
            {
              Console.WriteLine("You must be a Ninja Warrior in training"); 
            }
            else 
            {
              Console.WriteLine("Now you're just showing off"); 
            }

            runningTotal = runningTotal + minutes; 

            // Display total minutes exercised to screen 
            Console.WriteLine($"You've entered {entry} minutes"); 
            Console.WriteLine($"Your total running time is: {runningTotal} minutes"); 
            // Repeat until user quits 
          }
        }  
      }
       Console.WriteLine("Goodbye"); 
    }
  }
}
