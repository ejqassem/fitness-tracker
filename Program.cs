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
          runningTotal += int.Parse(entry); 
        
          // Display total minutes exercised to screen 
          Console.WriteLine($"You've entered {entry} minutes"); 
          Console.WriteLine($"Your total running time is: {runningTotal} minutes"); 

          // Repeat until user quits 
        }  
        Console.WriteLine("Goodbye"); 
      }
    }
  }
}
