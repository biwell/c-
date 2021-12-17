using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods // Note: actual namespace depends on the project name.
{
    class Program
    { 
        static void Main(string[] args) //is also a method but is called right as the program starts
        {
            /*
            methods allow us to group code that does specific task 
            we give it a name and what we want it to do 
            needs to be outside of main (doesnt matter if b4 or after)
            methods are the same as functions
            */

            MeetAlien();


            //pause before end
            Console.ReadKey();
        }
        //example of method 
        static void MeetAlien()
        {
            Random numberGen = new Random();

            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi i'm " + name);
            Console.WriteLine("I'm " + age + " years old.");
            Console.WriteLine("And I'm an alien.");


        }
    }
}