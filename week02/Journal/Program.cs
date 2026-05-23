using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string userOption = "";
        Console.WriteLine("Welcome to the Journal Program!");
        while (userOption != "5")
        {
            // While the userOption is different from 5 always display the following menu
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            // Read the user input
            userOption = Console.ReadLine();

            // Start the loop with the user input
            if (userOption == "1")
            {
                myJournal.AddEntry();
            }
            else if (userOption == "2")
            {
                myJournal.DisplayAll();
            }
            else if (userOption == "3")
            {
                Console.Write("What is the filename to load? ");
                string fileToLoad = Console.ReadLine();
                myJournal.LoadFromFile(fileToLoad);
            }
            else if (userOption == "4")
            {
                Console.WriteLine("Enter the filename to save: ");
                string fileToSave = Console.ReadLine();
                myJournal.SaveToFile(fileToSave);

            }
            else if (userOption == "5")
            {
                Console.WriteLine("Until the next time.");
            }
            else
            {
                Console.WriteLine("Invalid choice, you can only type numbers from 1 to 5");
            }
        }

    }
}