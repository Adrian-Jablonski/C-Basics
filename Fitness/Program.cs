using System; // replaces need for writing System in System.Console.Write and System.Console.ReadLine()

namespace Treehouse.Fitness
{
  class Program
  {
      static void Main()
      {
          int runningTotal = 0;
          bool keepGoing = true;
        
          // Prompt user for minutes exercised 
          while(keepGoing) {
            Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
        
            string entry = Console.ReadLine();
            
            if (entry == "quit")
            {
              keepGoing = false;
            }
            else {
              int minutes = int.Parse(entry);
            
              // Add minutes exercised to total
              runningTotal = runningTotal + minutes;
            
              // Display total minutes exercised to the screen 
              Console.WriteLine("You've entered " + runningTotal + " minutes");
            }
            // Repeat until user quits    
          }
          Console.WriteLine("Goodbye");
      }
  }

}