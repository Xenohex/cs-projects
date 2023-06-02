using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal static class GameDisplay
    {
        public static void Start(Word word)
        {
            Console.WriteLine("Your word has " + word.Answer.Length + " letters in it.");
            Console.WriteLine();

            GameDisplay.Refresh(word);
        }

        public static void Refresh(Word word)
        {
            int i;
            char guess;
            bool containsGuess = false;

            Console.Clear();
            Console.WriteLine("Word: ");
            foreach (char c in word.AnswerLetters)
            {
                if (word.LettersGuessed.Contains(c))
                {
                    Console.Write(c + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }

            Console.Write("\nUnguessed letters: ");
            foreach (char c in word.AlphabetRemaining) { Console.Write(c + " "); }
            Console.Write("\nGuessed Letters: ");
            foreach (char c in word.LettersGuessed) { Console.Write(c + " "); }

            Console.WriteLine();
            switch (word.mistakesRemaining)
            {
                case 7:
                    Console.WriteLine("  _____   ");
                    Console.WriteLine(" /        ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|_________");
                    break;
                case 6:
                    Console.WriteLine("  _____   ");
                    Console.WriteLine(" /    |   ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|_________");
                    break;

                case 5:
                    Console.WriteLine("  _____   ");
                    Console.WriteLine(" /    |   ");
                    Console.WriteLine("|     o   ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|_________");
                    break;
                case 4:
                    Console.WriteLine("  _____   ");
                    Console.WriteLine(" /    |   ");
                    Console.WriteLine("|     o   ");
                    Console.WriteLine("|     |   ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|_________");
                    break;
                case 3:
                    Console.WriteLine("  _____   ");
                    Console.WriteLine(" /    |   ");
                    Console.WriteLine("|     o   ");
                    Console.WriteLine("|     |\\ ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|_________");
                    break;
                case 2:
                    Console.WriteLine("  _____   ");
                    Console.WriteLine(" /    |   ");
                    Console.WriteLine("|     o   ");
                    Console.WriteLine("|    /|\\ ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|_________");
                    break;
                case 1:
                    Console.WriteLine("  _____   ");
                    Console.WriteLine(" /    |   ");
                    Console.WriteLine("|     o   ");
                    Console.WriteLine("|    /|\\ ");
                    Console.WriteLine("|      \\ ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|_________");
                    break;
                case 0:
                    Console.WriteLine("  _____   ");
                    Console.WriteLine(" /    |   ");
                    Console.WriteLine("|     o   ");
                    Console.WriteLine("|    /|\\ ");
                    Console.WriteLine("|     /\\ ");
                    Console.WriteLine("|         ");
                    Console.WriteLine("|_________");
                    break;
            }   // all the hangman pictures

            Console.WriteLine();
            Console.WriteLine("\nEnter guess: ");
            try {
                guess = Console.ReadLine()[0];

                foreach (char c in word.AnswerLetters) { if (c == guess) { containsGuess = true; } }
                if (!containsGuess) { word.mistakesRemaining--; }
                word.alphabetRemaining.Remove(guess);
                word.LettersGuessed.Add(guess);
            }
            catch (Exception e) { e.GetBaseException(); }

            DidWin(word);
        }

        public static void DidWin(Word word)
        {
            bool didWin = true;
            foreach(char c in word.AnswerLetters)
            {
                if (word.LettersGuessed.Contains(c))
                {
                    didWin = true;
                }
                else
                {
                    didWin = false;
                    break;
                }
            }

            if (didWin)
                Win(word);
            else
            {
                if (word.mistakesRemaining > 0)
                    Refresh(word);
                else
                    Lose(word);
            }
        }

        public static void Win(Word word)
        {
            Console.WriteLine("\nYou win! The word was " + word.Answer);
            Console.WriteLine("You had " + word.mistakesRemaining + "/" + word.MaxMistakes + " mistakes remaining");
        }

        public static void Lose(Word word)
        {
            Console.Clear();
            Console.WriteLine("You lose!");
            Console.WriteLine("  _____   ");
            Console.WriteLine(" /    |   ");
            Console.WriteLine("|     O   ");
            Console.WriteLine("|    /|\\ ");
            Console.WriteLine("|     /\\ ");
            Console.WriteLine("|         ");
            Console.WriteLine("|_________");

            Console.WriteLine("The word was " + word.Answer + "\n\n");
        }
    }
}
