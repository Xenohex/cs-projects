using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerTutorials
{
    static class UsefulTools   // Lesson 27 -  static methods and classes
    {
        public static void SayHi(string name)   // when the class is not static you could still make an instance of it
        {                                       // there are times where you would want to use both static and nonstatic methods
            Console.WriteLine("Hi " + name);    // its up to you
        }
        // tip, ctrl+enter moves the current line down and creates a new line where the cursor is
        
    }
}
