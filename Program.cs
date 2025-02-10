using System;

namespace MyApp
{
    internal class Hangman
    {
        static void Main(string[] args)
        {
            bool game = true, gameExiting, wordGuessed, charCorrect, myGfWantedThis;
            int lives, charLeft;
            char charLast;
            string wordSelected;
            string[] words = ["Undertale", "Runescape", "Trojan", "TheCriticallyAcclaimedMMORPGFFXIV", 
                "Celeste", "Minecraft", "Herobrine", "PirateSoftware", "RNGesus", "Fuck", "UnusAnnus", 
                "MementoMori", "Jerma", "Markiplier", "Fishing", "Hangman", "Jazz", "Blender", "Python",
                "Balatro", "Ubuntu"];



            while (game)
            {
                // Difficulty selection
                Console.WriteLine("Ladies and gentlemen, welcome... TO THE HANGMAN! \n(Gaming Edition (Ultra Deluxe (Nobody QA'd the list of words, good luck!)))");
                Console.Write("How many lives do you wanna have? (number): ");
                while (!(int.TryParse(Console.ReadLine(), out lives) && lives > 0)) { Console.Write("\nInvalid input. Try again:"); }
                if (lives == 1)
                {
                    Console.WriteLine("What a chad we got here!");
                }
                else if (2 <= lives && lives <= 5)
                {
                    Console.WriteLine("Let's see what you're worth!");
                }
                else if (lives == 69)
                {
                    Console.WriteLine("Nice!");
                }
                else
                {
                    Console.WriteLine("Taking it easy this time around, huh?");
                }
                Thread.Sleep(1500);
                Console.Clear();
                Console.WriteLine("Let's start!");



                // Setting up characters and words
                Random rnd = new Random();
                wordSelected = words[rnd.Next(0, words.Length)];
                //wordSelected = words[3];  // For testing
                List<char> charsRemaining = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
                char[] wordFull = wordSelected.ToUpper().ToCharArray();
                char[] wordHidden = new char[wordFull.Length];
                for (int i = 0; i < wordHidden.Length; i++)
                {
                    wordHidden[i] = '*';
                }
                charLeft = wordFull.Length;
                myGfWantedThis = true;   // false if any letters were found



                // Game
                wordGuessed = false;
                while (!wordGuessed && lives > 0)
                {
                    Console.Write("Your word is ");
                    Console.WriteLine(wordHidden);
                    Console.WriteLine($"Lives - {lives}");
                    Console.Write("Remaining characters: ");
                    charsRemaining.ForEach(i => Console.Write("{0} ", i));
                    Console.WriteLine();


                    Console.Write("Please choose a character: ");
                    while (!char.TryParse(Console.ReadLine().ToUpper(), out charLast) || !charsRemaining.Contains(charLast)) { Console.Write("Invalid input. Try again:"); };
                    charsRemaining.Remove(charLast);
                    charCorrect = false;
                    for (int i = 0; i < wordFull.Length; i++)
                    {
                        if (wordFull[i] == charLast)
                        {
                            wordHidden[i] = charLast;
                            charCorrect = true;
                            charLeft--;
                        }
                    }
                    Console.Clear();
                    switch (charCorrect) 
                    {
                        case (true):
                            Console.WriteLine("New character found!");
                            myGfWantedThis = false;
                            if (charLeft == 0) { wordGuessed = true; }
                            break;
                        case (false):
                            Console.WriteLine("Incorrect character!");
                            lives--;
                            break;
                    }
                }



                // Check if victory or defeat
                Console.Clear();
                if (wordGuessed)
                {
                    Console.WriteLine($"CO-O-ONGRATULATIONS! \nYou guessed the word {wordSelected}!");
                }
                else if (myGfWantedThis) // No letters found
                {
                    Console.WriteLine("\n\n\n   L M A O    S K I L L    I S S U E\n\n\n");
                }
                else
                {
                    Console.WriteLine("\n\n\n   Y O U    D I E D\n\n\n");
                }



                // Game repeat
                gameExiting = true;
                Console.Write("Do you wanna play another round? (yes/no): ");
                while (gameExiting)
                {
                    switch (Console.ReadLine())
                    {
                        case "yes":
                            gameExiting = false;
                            Console.Clear();
                            break;
                        case "no":
                            gameExiting = false;
                            game = false;
                            Console.WriteLine("K, byyyyye...");
                            Thread.Sleep(2000);
                            break;
                        default:
                            Console.Write("Invalid input. Try again:");
                            break;
                    }
                }
            }
        }
    }
}