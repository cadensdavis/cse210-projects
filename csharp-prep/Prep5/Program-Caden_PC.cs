using System;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spacing
            Console.WriteLine("");

            //Running all functions
            DisplayWelcome();

            string username = PromptUserName();

            int usernumber = PromptUserNumber();

            int squarednumber = SquareNumber(usernumber);

            DisplayResults(username, squarednumber);


            //Print Welcome
            void DisplayWelcome()
            {
                Console.WriteLine("Welcome to the Program!");
            }

            //Asking for name and returning
            static string PromptUserName()
            {
                Console.Write("What is your name? ");
                string username = Console.ReadLine();
                return username;
            }

            //Asking for number and returning
            static int PromptUserNumber()
            {
                Console.Write("What is your favorite number? ");
                string number = Console.ReadLine();
                int usernumber = int.Parse(number);
                return usernumber;
            }

            //Taking number and squaring it
            static int SquareNumber(int number)
            {
                int squarednumber = number * number;
                return squarednumber;
            }

            //Pulling it all together and taking username and usernumber as parameters
            void DisplayResults(string username ,int usernumber)
            {
                Console.WriteLine($"{username}, the square of your number is {usernumber}");
            }
        }
    }
}