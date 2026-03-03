using System;

class Program
{
    static void Main(string[] args)
    {
        Job myFirstJob = new Job();
        myFirstJob._companyName = "Team Rocket";
        myFirstJob._jobTitle = "Meowth";
        myFirstJob._startYear = 1964;
        myFirstJob._endYear = 2064; 
        //myFirstJob.DisplayJob();
        
        Job mySecondJob = new Job();
        mySecondJob._companyName = "the dungeon";
        mySecondJob._jobTitle = "burden slave";
        mySecondJob._startYear = 2026;
        mySecondJob._endYear = 2026;
        //mySecondJob.DisplayJob();

        Resume myResume = new Resume(); //Resume is class, myResume is object
        myResume._name = "Taako Taaco";
        myResume._jobs = new List<Job>();
        myResume._jobs.Add(myFirstJob);
        myResume._jobs.Add(mySecondJob);
        myResume.DisplayResume();
    }
}