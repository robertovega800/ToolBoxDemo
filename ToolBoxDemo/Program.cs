using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxDemo
{
    class Program
    {
        //acts as our program's .exe file, aka "executable" or "entry point". This is the file we double click on to start any program
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to your Tool Box!");
            Console.WriteLine("You can either hit \"Y\" then ENTER to continue, or hot \"N\" then ENTER to Clear the Console and Continue.");

            string userResponse = Console.ReadLine();
            if (userResponse == "Y")
            {
                KeyToContinue();
            }
            else if (userResponse == "N")
            {
                KeyToContinueWithClearConsole();
            }

            else
            {
                Console.WriteLine("Not sure friend, but I'm gonna close the program when you hit ENTER");
            }
            
            Console.ReadLine();

            
            //Functions are methods written outside of a custom class
            //Methods are functions written inside of a custom class


            //Functions below this line
            void KeyToContinue()
            {
            Console.WriteLine("Hit ENTER to continue on with the code...");
            Console.ReadLine();
            }

            void ClearConsole()
            {
            Console.Clear();
            }

         void KeyToContinueWithClearConsole()
            {
                KeyToContinue();
                ClearConsole();
                Console.WriteLine("Congratulations! You cleared the program, now hit ENTER to close the console!");
                Console.ReadLine();
            } 

        }




        //write a method that asks the user how old they are and returns their age as an int.
        public int GetAge()
        {
            Console.WriteLine("How old are you?");
            string ageAsString = Console.ReadLine();

            int ageAsInt = int.Parse(ageAsString);
            return ageAsInt;
        }


        //Write a method that takes in a name and outputs a greeting to the user.
        public void TellTheUserHowOldTheyAre(string name)
        {
            int age = GetAge();
            Console.WriteLine($"Hey {name}, you are {age} years old!");
        } 
    }
}

