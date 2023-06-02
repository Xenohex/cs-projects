using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Lesson7();
        }

        static void Lesson29()  // Lists (this is not a video tutorial im doing this myself)
        {   // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0

            int i = 0;
            List<int> ints = new List<int>();
            ints.Add(17);
            Console.WriteLine(ints.Count());
            ints.Reverse();
        }

        // Lesson 28 - Inheritance

        static void Lesson28()  // see class chef for more info
        {   // note, this one might be hard
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef ichef = new ItalianChef();
            ichef.MakeChicken();
            ichef.MakePasta();
            //  chef.MakePasta();   throws error because regular chef cannot make pasta

            chef.MakeSpecialDish();
            ichef.MakeSpecialDish();    // notice how they are different
        }

        // Lesson 27 - static methods and classes

        static void Lesson27()  // see UsefulTools class for more info
        {
            
            Console.WriteLine(Math.Sqrt(144));
            // notice an object of the Math class was not created to use this, meaning Math is static
            // in fact, you are unable to create an object of a math class at all, meaning it is a static class

            // Math myMath = new Math(); => produces error

            UsefulTools.SayHi("bob");   // no object required
            // UsefulTools tools = new UsefulTools();  // now that its static, this no longer works
        }

        // Lesson 26 - static class attributes

        static void Lesson26()  // See Song class for more info
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(holiday.artist);
            Console.WriteLine(kashmir.artist);

            Console.WriteLine(Song.songCount);  // this means the attribute belongs to the class
            //Console.WriteLine(Song.title);
            //Console.WriteLine(holiday.songCount);
            // Notice, you can't say holiday.SongCount or Song.title

            Song dioma = new Song("Dioma", "JNathyn", 240);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(dioma.getSongCount());
            Console.WriteLine(dioma.SongCount);
        }

        // Lesson 25 - getters and setters

        static void Lesson25()  // see Movie class for more info
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // Ratings should be G, PG, PG-13, R, NR
            Console.WriteLine(avengers.Title);
            avengers.Title = "poop";
            avengers.Rating = "R";
            Console.WriteLine(avengers.Title);
            shrek.Rating = "dook";
            Console.WriteLine(shrek.Rating);    // this is actually rad


        }

        // Lesson 24 - Object Methods

        static void Lesson24()
        {
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.name + " has honors? : " + student1.HasHonors());
            Console.WriteLine(student2.name + " has honors? : " + student2.HasHonors());

        }

        // Lesson 23 - Classes and Objects

        static void Lesson23()  // see class Book.cs for explanations
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "J.K. Rowling";
            book1.pages = 400;
            Console.WriteLine(book1.title + ", " + book1.author + ", " + book1.pages);

            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);
            Console.WriteLine(book2.title + ", " + book2.author + ", " + book2.pages);
        }

        // Lesson 22 - Exception Handling

        static void Lesson22()
        {
            // you can easily break this program by entering 0 for the second number or a non-integer for either 
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException ex)    // using different catch blocks allows for different possibilities on error
            {
                Console.WriteLine("Error, cannot divide by zero.");
            }
            catch (FormatException ex)  // for example, allowing a user to try again or changing course on a specific error
            {
                Console.WriteLine("Error, integers only.");
            }
            catch (Exception ex)
            {
                /* 
                 * Could also just write catch with no exception
                 * catch
                 * {
                 *      Console.WriteLine("Error");
                 * }
                 * The program will catch any exception that occurs here and always run the catch block
                 * 
                 * There is also a finally block but it seems kinda useless no cap
                */
                Console.WriteLine(ex.Message);
            }
            
        }

        // Lesson 21 - comments...

        static void Lesson21()
        {
            // Single Line comment
            /*
            Multi-line comment
            */ 
            // This lesson is kind of pointless for me because I know how to use comments.
            // but basically you can use it to remove stuff temporarily or whatever
        }

        // Lesson 20 - 2d arrays

        static void Lesson20()
        {
            int[,] numberGrid =
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            int[,,] numberGrid2 =   // more commas == more dimensions
            {
                {
                    { 1, 2 },
                    { 3, 4 }
                },
                {
                    { 5, 6 },
                    { 7, 8 }
                },
                {
                    { 9, 10 },
                    { 11, 12 }
                },

            };

            Console.WriteLine(numberGrid[1,1]);
            Console.WriteLine(numberGrid2[1,1,1]);
        }

        // Lesson 19 - Building an Exponent Method

        static void Lesson19()
        {
            double baised;
            int exp;

            Console.Write("Enter base: ");
            baised = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter exponent: ");
            exp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Exponent(baised, exp));
        }

        static double Exponent(double baised, int exponent)
        {
            double result = 1;

            while (exponent > 0)
            {
                result *= baised;
                exponent--;
            }
            return result;
        }

        // Lesson 18 - for loops

        static void Lesson18()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] luckyNumbers = { 1, 2, 3, 4, 5, 6 };

            for (i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }

        // Lesson 17 - Building a guessing game

        static void Lesson17()
        {
            GuessingGame();
            //GuessingGameMine();
        }

        static void GuessingGame()
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("You win!");
            }

        }

        static void GuessingGameMine()
        {
            string secretWord = "giraffe";
            string guess = "";

            int totalGuesses = 5;
            int guessesRemaining = 5;

            Console.WriteLine("Welcome to the guessing game. Enter guesses in all lowercase.");
            Console.WriteLine("The secret word has " + secretWord.Length + " letters. Good luck!");
            while (guess != secretWord && guessesRemaining != 0)
            {
                Console.WriteLine("Guesses Remaining: " + guessesRemaining);
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guessesRemaining--;
            }
            if (guess == secretWord)
            {
                Console.WriteLine("\nYou win! The secret word was: " + secretWord);
                Console.WriteLine("\nYou guessed the word in " + (totalGuesses - guessesRemaining) + " attempts.");
            }
            else
                Console.WriteLine("You did not guess the word. It was " + secretWord);
        }

        // Lesson 16 - While Loops

        static void Lesson16()
        {
            int index = 0;
            while (index < 10)
            {
                if (index == 9)
                    Console.WriteLine(index + " ");
                else
                    Console.Write(index + " ");
                index++;
            }

            index = 0;
            do
            {
                Console.Write(index + " ");
                index++;
            } while (index < 10);
        }

        // Lesson 15 - switch statements
        static void Lesson15()
        {
            int dayNum = 6;
            Console.WriteLine(GetDay(dayNum));
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";

                return dayName;
            }

            return dayName;
        }

        // Lesson 14 - better calculator        if statement stuff
        static void Lesson14()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Operator (+,-,*,/): ");
            string op = Console.ReadLine();
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Error, invalid operator");
            }
        }

        // Lesson 13 - if statements part 2
        static void Lesson13()
        {
            Console.WriteLine(GetMax(12, 10, 4));
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
            return result;
        }

        // Lesson 12 - if statements
        static void Lesson12()
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            } else if (!isMale && isTall)
            {
                System.Console.WriteLine("You are tall but not male");
            } else
            {
                Console.WriteLine("You are not male and/or tall");
            }

            if (isMale || isTall)
            {
                Console.WriteLine("You are either tall or male");
            } else
            {
                Console.WriteLine("You are not tall or male");
            }


        }

        // Lesson 11  -  returns
        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
            // Console.WriteLine(cube(3));
        }

        // Lesson 10  -  Methods
        static void SayHi(string name, int age)  // In C#, naming convention for methods is camel case with a capital first letter.
        {
            // SayHi takes a string name as a parameter to print hello to that name, also takes their age
            Console.WriteLine("Hello " + name + " you are " + age + " years old.");
            /*
            SayHi("poop", 975);
            SayHi("senior", 34);
            SayHi("dook", 12);
            */
        }

        static void Lesson9()   // arrays
        {
            // Just like other languages, there are different ways to complete an array.
            // Method 1
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };   // these are all elements in the array
            string[] friends = new string[5];    // If the array is incomplete or you don't know what values will be in it,
                                                 // you can make an empty array but assign its length up front;
                                                 // in this case, the "friends" array can hold 5 strings
            friends[0] = "John";
            friends[1] = "Joe";

            // Accessing the elements
            Console.WriteLine(luckyNumbers[0]);   // prints 4
            Console.WriteLine(luckyNumbers[4]);   // prints 23
            Console.WriteLine(friends[0]);

            // Updating the elements
            luckyNumbers[1] = 90000;    // makes the element at index 1 9000 regardless of its previous value
            Console.WriteLine(luckyNumbers[1]);
        }

        static void Lesson8()   // mad lib game
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("\nRoses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
        }

        static void Lesson7()   // getting integers from input
        {
            int num = Convert.ToInt32("45");    // the text must entirely be a number, no spaces or text
            Console.WriteLine("num = " + num);

            // "calculator" that I changed to a bmi calculator
            Console.Write("Enter your weight in pounds: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height in inches: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = (weight * 703) / (height * height);
            Console.WriteLine("bmi = " + bmi);
        }

        static void Lesson6()   // user input
        {
            //Console.WriteLine(Console.ReadLine());  // so ReadLine is actually user input and now I feel lied to
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " why are you " + age + " years old..");
        }

        static void Lesson5()   // numbers
        {
            int num = 6;
            num++;  // increments by one
            num += 2;   // num = num + 2
            Console.WriteLine(5 + 8);   // prints 13
            Console.WriteLine(5 + 3 / 8 * 2);   // probably prints 2 | also have modular division % just like java and haskell
            Console.WriteLine(Math.Abs(-1));    // absolute value
            // the math statement adds a bunch of math stuff believe it or not
            Console.WriteLine(Math.Sqrt(num) + ", " + Math.Max(num, 90) + ", " + Math.Round(.75));
        }

        static void Lesson4()   // strings
        {
            string phrase = "POop";
            Console.WriteLine("New\nLine character.\nBasically \\ is still the \t escape character.\nAlso " + phrase + ".");
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("poop"));
            Console.WriteLine(phrase.Contains("pee"));
            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase.IndexOf("poo"));
            Console.WriteLine(phrase.IndexOf('o'));     // first index of a certain character
            Console.WriteLine(phrase.Substring(3));     // starts at substring of a string variable
            Console.WriteLine(phrase.Substring(3, 4));   // ends at the second index
            Console.WriteLine(phrase.Reverse());

            string numberButItsAString = "873";
            int number = int.Parse(numberButItsAString);
        }

        static void Lesson3()
        {
            string phrase = "skibbideeboobop"; // double for string
            char grade = 'a'; // single for character
            int positive = 982374;  // can be positive or negative
            float shortdecimals = .0908F;   // basically used for decimals that arent too long, but just use a double
            double mediumdecimals = .12987498;  // pretty much just use this one all the time
            decimal longdecimals = .9876902987135M; // mainly for like super precise numbers
            bool isMale = true; // boolean
        }   // variable types

        static void Lesson2()
        {
            string characterName = "John";
            int characterAge;   // mostly just like java
            characterAge = 35;

            Console.WriteLine("There was once a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "mike";
            characterAge = 734;

            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
        }   // variables

        static void Lesson1()
        {
            Console.WriteLine("Hello World."); // Basic Console print statement.
            Console.WriteLine("    /|\\");
            Console.WriteLine("   / | \\");
            Console.WriteLine("  /  |  \\");
            Console.WriteLine(" /   |   \\");
            Console.WriteLine("/____|____\\");

            Console.ReadLine(); // Keeps the console open until user closes it.
            // Visual Studio has a setting currently enabled to keep the debugger open when the program stops, 
            //  so this is not currently necessary.
        }   // hello world
    }
}