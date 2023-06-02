using System;

namespace HangmanGame
{
    class Hangman
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman, press enter to start.");
            Console.ReadLine();            

            Word word;
            string contPlayIO;
            
            bool contPlay = true;
            while (contPlay)
            {
                word = new Word();
                GameDisplay.Start(word);

                Console.Write("\nPlay again? (y/n): ");
                contPlayIO = Console.ReadLine().ToLower();
                if (contPlayIO == "n")
                    contPlay = false;
            }

            Console.WriteLine("Thanks for playing!\nPress Enter to close.");
            Console.ReadLine();
        }
    }
}