using System;

class Program
{
    static void Main(string[] args)
    {
        //Initialize scripture reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        //Define text of the scripture
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.";
        //Create scripture object
        Scripture scripture = new Scripture(reference, text);
        //Continue until the user types quit or all the words are hidden
        while (true)
        {
            Console.Clear();//Clear terminal
            //Mix visible words and underscores
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");
            // Capture user response
            string input = Console.ReadLine();
            //Exit program if quit is typed (case insensitive)
            if (input.ToLower() == "quit")
                break;
            //Pick and hide 3 random visible words
            scripture.HideRandomWords(3);
            //Check if the scripture is completely hidden
            if (scripture.IsCompletelyHidden())
            {
                //Show fully hidden scripture
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}