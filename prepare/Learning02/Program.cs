using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2020;
        job1._endYear = 2022;
        
        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Hardware Consultant";
        job2._startYear = 2015;
        job2._endYear = 2017;
        
        Resume resume1 = new Resume();
        resume1._name = "Stephen Skiles";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
    
        resume1.Display();

        
    }
}