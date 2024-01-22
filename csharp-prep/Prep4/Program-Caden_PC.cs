using System;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //spacing
            Console.WriteLine("");
            
            //Creating the list
            List<int> numberlist= new List<int>();

            //Intro / Explaination
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            //spacing
            Console.WriteLine("");

            //Initating the varible
            int numberadd = -1;
            while (numberadd != 0)
            {
                
                Console.Write("Enter number: ");

                string number = Console.ReadLine();
                numberadd = int.Parse(number);

                if (numberadd != 0)
                {
                    numberlist.Add(numberadd);

                    //Test to see if numbers were being added
                    //Console.WriteLine(numberlist.Count);
                }
            }
            
                         //Calculations

            //Variable declarations
            float totalsum = 0;
            float totalavg = 0;
            int largestnum = 0;
            int smallestnum = 10000;

            //Sum 
            foreach (int sumnumber in numberlist)
            {
                totalsum = totalsum + sumnumber;
            }

            //Average
            totalavg = totalsum / numberlist.Count;

            //Largest Number
            foreach (int i in numberlist)
            {
                if (i > largestnum)
                {
                    largestnum = i;
                }
            }

            //Smallest Number
            foreach (int i in numberlist)
            {
                if (i < smallestnum && i > 0)
                {
                    smallestnum = i;
                }
            }

            //Totals
            Console.WriteLine($"The sum is: {totalsum}");
            Console.WriteLine($"The average is: {totalavg}");
            Console.WriteLine($"The largest number is: {largestnum}");
            Console.WriteLine($"The smallest positive number is: {smallestnum}");

            //spacing
            Console.WriteLine("");

            //Iterating through the list
            numberlist.Sort();
            foreach (int number in numberlist)
            {
                Console.WriteLine(number);
            }

            //spacing
            Console.WriteLine("");

            

            
        }
    }
}