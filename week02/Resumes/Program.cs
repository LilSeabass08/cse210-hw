using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Material Handler";
        job1._company = "ICU Medical";
        job1._startYear = 2023;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Car Detailer";
        job2._company = "Enterprise";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Sebastian Ethington";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}