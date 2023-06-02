using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerTutorials
{
    class ItalianChef : Chef    // this means ItalianChef inherits all functionality from Chef
    {   // chef is superclass and italianchef is subclass
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta.");
        }

        public override void MakeSpecialDish()
        {   // this will override the functionality of the superclass chef version of the method
            // this is because the subclass had the override keyword and the superclass had the virtual keyword/modifier
            Console.WriteLine("The Chef makes chicken parm");
        }

        /* Inheritance is used for 3 key reasons:
         * 1. Inheriting all functionality from superclass
         * 2. Extending that functionality
         * 3. Overriding original functionality to meet more specific tasks
         */
    }
}
