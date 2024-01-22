using System.Threading.Tasks.Dataflow;
using System;

namespace magicnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //spacing
            Console.WriteLine("");

            //Intro / Explaination
            Console.WriteLine("   Welcome to the MAGIC number guessing game!       ");
            Console.WriteLine("  To win you must guess numbers between 1 & 50.     ");
            Console.WriteLine(" I will tell you if your guess is higher or lower!  ");
            Console.WriteLine("                Good Luck!                          ");

            //🔽🔽Not used anymore. First part of the lesson🔽🔽
            //Asking for a magic number and converting it from string to int
            // Console.Write("What is the magic number?  ");
            // string choosennumber = Console.ReadLine();
            // int magicnumber = int.Parse(choosennumber);

            Random randomGenerator = new Random();
            int magicnumber = randomGenerator.Next(1, 50);

            //spacing
            Console.WriteLine("");

            //🔽🔽Not used anymore. First part of the lesson🔽🔽
            ////Asking for a guess and converting it from string to int
            // Console.Write("What is your guess?");
            // string stringguess = Console.ReadLine();
            // int guess = int.Parse(stringguess);

            int guess = 0;
            
            while (guess != magicnumber)
            {
                Console.Write("What is your guess? ");
                string stringguess = Console.ReadLine();
                guess = int.Parse(stringguess);
                
                //❌❌Counting the number of guesses❌❌
                //not working
                int numberofguesses = 0;
                numberofguesses = numberofguesses + 1;

                if (guess >= (magicnumber + 1))
                {
                    Console.WriteLine("Lower");
                    //spacing
                    Console.WriteLine("");
                }

                else if (guess <= (magicnumber - 1))
                {
                    Console.WriteLine("Higher");
                    //spacing
                    Console.WriteLine("");
                }
                else
                {
                    //spacing
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.WriteLine("     Congrats you guessed it!  ");
                    Console.WriteLine($"   It only took you {numberofguesses} guesses!   ");
                }

            }



            //tidyness
            //spacing
            Console.WriteLine("");

            

        }
    }
}