using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerTutorials
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chefm makes salad");
        }

        public virtual void MakeSpecialDish()   // virtual means this method can always be overriden
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
