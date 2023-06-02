using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerTutorials
{
    internal class Movie    // Lesson 25    - getters and setters
    {
        private string title;
        private string director;
        private string rating;
        //private int number;

        public Movie(string title, string director, string rating)
        {
            this.title = title;
            this.director = director;
            this.rating = rating;
        }

        public string Title     // proper getter setter documentation for C#, visual studio will pretty much do it for you
        {
            get { return title; }
            set { title = value; }
        }

        public string Director  // basically, C# detects if you are trying to read a value or write to a value, 
        {                       // and chooses between get or set accordingly
            get { return director; }
            set { director = value; }
        }

        public string Rating
        {
            get { return rating; }
            set
            {   // movie ratings can only be set to G, PG, PG-13, R, or NR
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                    rating = value;
                else
                    rating = "NR";
            }
        }

        /*  // this is the bad ugly java way
        public int getNumber()
        {
            return number;
        }
        public void setNumber(int value)
        {
            number = value;
        }
        */

    }
}
