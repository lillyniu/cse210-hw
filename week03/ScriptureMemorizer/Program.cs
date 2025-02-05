using System;

class Program
{
    static void Main(string[] args)
    {
    List<Scripture> scripture = new List<Scripture>
        {
            new Scripture(new Reference("Genesis", 13, 15), "For all the land which thou seest, to thee will I give it, and to thy seed for ever."),
            new Scripture(new Reference("Helaman", 12, 1),"And thus we can behold how false, and also the unsteadiness of the hearts of the children of men; yea, we can see that the Lord in His great infinite goodness doth bless and prosper those who put thier trust in Him."),
            new Scripture(new Reference("Moses", 6, 1), "And Adam hearkened unto the voice of God, and called upon his sons to repent."),
            new Scripture(new Reference("Enos", 1, 17), "And I, Enos, knew it would be according to the covenant which he had made; wherefore my soul did rest.")
        };

        Console.WriteLine("Are you ready to attempt memorizing?\nA random scripture will be chosen for you.\nPress ENTER to begin.");
        Console.ReadLine();

        Random random = new Random();
        Scripture chosenScripture = scripture[random.Next(scripture.Count)];

        while (true)
        {
            chosenScripture.Display();

            if (chosenScripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden! Great job with your scripture mastery.");
                break;
            }

            Console.WriteLine("\nPress ENTER to hide words, type HINT to reveal the first letter of hidden words, or type QUIT to exit.");
            string input = Console.ReadLine();

            if (input.ToUpper() == "QUIT") 
            {
                break;
            }
            else if (input.ToUpper() == "HINT")
            {
                chosenScripture.Display(showHint: true);
                Console.WriteLine("\nPess ENTER to continue..");
                Console.ReadLine();
            }
            else
            {
            chosenScripture.HideRandomWords(3, hideOnlyVisible: true); 
            }
        }
    }
}