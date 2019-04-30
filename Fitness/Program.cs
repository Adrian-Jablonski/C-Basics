using System; // replaces need for writing System in System.Console.Write and System.Console.ReadLine()

namespace Treehouse.Fitness
{
  class Program
  {
      static void Main()
      {
          var runningTotal = 0;
        
          // Prompt user for minutes exercised 
          while(true) {
            Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
        
            var entry = Console.ReadLine(); // Could use var to avoid using type names or could declare with String when using type
            
            if (entry.ToLower() == "quit")
            {
              break;
            }
            
            double minutes;
            
            try {
              minutes = double.Parse(entry);
            } catch(FormatException) {
              Console.WriteLine("Invalid Input");
              continue;
            }
            
            if (minutes <= 0) {
              Console.WriteLine(minutes + " is not an acceptable value.");
              continue;
            }
            else if (minutes <= 10) {
              Console.WriteLine("Better than nothing, am I right?");
            }
            else if (minutes <= 30) {
              Console.WriteLine("Way to go!");
            }
            else if (minutes <= 60) {
              Console.WriteLine("You must be a ninja warrior!");
            }
            else {
              Console.WriteLine("Okay, now you're just showing off!");
            }
          
            // Add minutes exercised to total
            runningTotal += minutes;
          
            // Display total minutes exercised to the screen 
            Console.WriteLine("You've entered " + runningTotal + " minutes");
          }
          // Repeat until user quits    
         
          Console.WriteLine("Goodbye");
      }
  }

}