using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Data Analyst";
        job1._company = "Rocky Mountain Reserve";
        job1._startYear = 2022;
        job1._endYear = 2040;
        job1._Salary = 40000;

        Job job2 = new Job();
        job2._jobTitle = "Physical Therapist";
        job2._company = "Wasatch Peak";
        job2._startYear = 2020;
        job2._endYear = 2021;

        Job job3 = new Job();
        job3._company = "Google";
        job3._jobTitle = "Programmer";
        job3._startYear = 2026;
        job3._Salary = 1000;

        Job job4 = new Job();
        job4._company = "Freelance of America";
        job4._jobTitle = "Developer";
        job4._startYear = 2018;
        job4._Salary = 120000;

        Job job5 = new Job();
        job5._company = "Forever Jedi Dad";
        job5._jobTitle = "Grand Master";
        job5._endYear = 0/1;
        job5._Salary = 1000000000;


        Resume newResume = new Resume();
        newResume._personName = "Scott Phil";

        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);
        newResume._jobs.Add(job3);
        newResume._jobs.Add(job4);
        newResume._jobs.Add(job5);

        newResume.Display();

    }
    
}