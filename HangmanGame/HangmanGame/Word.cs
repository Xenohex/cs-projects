using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class Word
    {
        private string answer;
        private char[] answerLetters;
        private static int maxMistakes = 7;
        public int mistakesRemaining;
        public List<char> alphabetRemaining = new List<char>();
        public List<char> lettersGuessed = new List<char>();

        public Word()
        {
            answer = WordChooser();
            mistakesRemaining = maxMistakes;   // total guesses
            answerLetters = answer.ToCharArray();
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach (char c in letters) {
                alphabetRemaining.Add(c);
            }
        }

        public Word(string w)
        {
            answer = w;
            mistakesRemaining = maxMistakes;   // total guesses
            answerLetters = answer.ToCharArray();
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach (char c in letters)
            {
                alphabetRemaining.Add(c);
            }
        }

        public string Answer { get { return answer; } }

        public char[] AnswerLetters { get { return answerLetters; } }

        public List<char> LettersGuessed { get { return lettersGuessed; } }

        public List<char> AlphabetRemaining { get { return alphabetRemaining; } }

        public int MaxMistakes { get { return maxMistakes; } }

        private static string WordChooser()
        {
            string[] wordList = 
            { 
                "swop", "hallway", "acceptable", "parking",
                "philosophy", "ethnic", "timetable", "crusade",
                "flourish", "adoption", "effort", "collection",
                "rate", "hesitate", "grow", "attic", "referee",
                "bond", "apple", "pity", "compensation", "stream",
                "therapist", "conductor", "persist", "reign",
                "hardware", "driver", "solid", "conspiracy",
                "assumption", "matter", "swipe", "quotation",
                "announcement", "palm", "set", "exposure", "shed",
                "angel", "vague", "continuous", "survey", "produce",
                "shame", "rotten", "affect", "species", "slow", "liver"
            };

            Random random = new Random();

            /*// Generate and display 5 random integers from 50 to 100.
                Console.WriteLine("Five random integers between 50 and 100:");
                for (int ctr = 0; ctr <= 4; ctr++)
                    Console.Write("{0,8:N0}", rand.Next(50, 101), 1);
                Console.WriteLine();*/

            return wordList[random.Next(wordList.Length)];
        }

        public bool IsGuessed(char c)
        {
            bool isGuessed = false; // thr problem with pr8nting known letters of word is likely here
            for (int i = 0; i < lettersGuessed.Count; i++) { if (lettersGuessed.Contains(c)) { return true; } }
            return isGuessed;
        }

    }
}
