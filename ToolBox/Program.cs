using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    class Program
    {
        static void Main(string[] args) // Main method is the .exe file
            //Functions are Methods written OUTSIDE of a custom class
            //Methods are Functions written INSIDE of a custom class
            //Methods have the access modifier (static void main)
        {
            Console.WriteLine("Welcome to your toolbox!");
            Console.WriteLine("You can hit \"Y\" then ENTER to contiue, " +
                "or hit \"N\" then ENTER to clear the console and not continue");

            string userResponse = Console.ReadLine();
            if(userResponse =="Y")
            {
                KeyToContinue();
            }

            else if(userResponse == "N")
            {
                 KeyToContinueWithClearConsole();
            }
            else
            {
                Console.WriteLine("I'm not really sure what to do here, buddy");
            }
          

            Console.ReadLine();


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
            }

        }
    }
}
