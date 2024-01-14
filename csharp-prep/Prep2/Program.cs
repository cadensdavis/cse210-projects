using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Tidyness
        Console.WriteLine("");

        Console.Write("What is your current grade in this class? ");
        string userResponse = Console.ReadLine();
        int userGrade = int.Parse(userResponse);

        //Tidyness
        Console.WriteLine("");

        //Calculations

        int remainder = userGrade % 10;

        string letterGrade = "";

        if (userGrade >= 90)
        {
            if (remainder < 3)
            {
                letterGrade = "A-";
            }
            
            else 
            {
                letterGrade = "A";
            }
        }

        else if (userGrade >= 80 && userGrade < 90)
        {
            if (remainder >= 7)
            {
                letterGrade = "B+";
            }

            else if (remainder < 3)
            {  
                letterGrade = "B-";
            }

            else 
            {
                letterGrade = "B";
            }
        }

        else if (userGrade >= 70 && userGrade < 80)
        {
            if (remainder >= 7)
            {
                letterGrade = "C+";
            }

            else if (remainder < 3)
            {  
                letterGrade = "C-";
            }

            else 
            {
                letterGrade = "C";
            }
        }

        else if (userGrade >= 60 && userGrade < 70)
        {
            if (remainder >= 7)
            {
                letterGrade = "D+";
            }

            else if (remainder < 3)
            {  
                letterGrade = "D-";
            }

            else 
            {
                letterGrade = "D";
            }
        }

        else if (userGrade > 60)
        {
            letterGrade = "F";
        }

        
        Console.WriteLine($"Your grade for this class is {letterGrade}");

        //Tidyness
        Console.WriteLine("");

        if (userGrade > 70)
        {
            Console.WriteLine("Congrats you passed this class!!");
        }

        else
        {
            Console.WriteLine("You didn't pass.... Better luck next time!");
        }

    }
}