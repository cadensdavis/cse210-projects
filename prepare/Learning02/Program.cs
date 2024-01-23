using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Del Taco";
        job1._jobTitle = "Fry Cooker";
        job1._startYear = 1706;
        job1._endYear = 1000;

        //job1.Display();

        Job job2 = new Job();
        job2._company = "Taco Bell";
        job2._jobTitle = "Manager";
        job2._startYear = 2000;
        job2._endYear = 2020;

        //job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Caden S. Davis";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}