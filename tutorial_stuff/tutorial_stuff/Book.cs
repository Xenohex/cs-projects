using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerTutorials
{
    /*
     * Just like java, a class is essentially a complex data type that you define using existing data types.
     * "Objects" of these classes can be used to basically create an instance of that type to make an interactable entity
     * in your program
     */

    class Book      // Lesson 23    - classes
    {
        public string title;    // classes need attributes
        public string author;
        public int pages;
        // were this a real program, an ISBN attribute would also be helpful

        // Constructors

        public Book()
        {
            Console.WriteLine("Creating Book..");
        }

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle; // just found out shift + delete deletes current line and moves following lines up
            author = aAuthor;
            pages = aPages;
            Console.WriteLine("Book " + title + " has been created.");
        }
    }
}
