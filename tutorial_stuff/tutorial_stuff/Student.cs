using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerTutorials
{
    class Student       // Lesson 24    - class methods
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string name, string major, double gpa)   // bro visual studio literally made this whole constructor for me
        {
            this.name = name;
            this.major = major;
            this.gpa = gpa;
        }

        public bool HasHonors()     // since objects of a class are essentially variables with their own "commands" you implement
        {                           // as methods, you can make a method like this and it will only use the gpa of the object
            if (gpa > 3.5)          // that called it
                return true;
            else
                return false;
        }

    }
}
