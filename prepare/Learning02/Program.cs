using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._compname = "google";
        job1._title = "data engineer jr";
        job1._starty = 2023;
        job1._endy = 2026;
        job1.Display();
        job job2 = new job();
        job2._compname = "tesla";
        job2._title = "data chief manager";
        job2._starty = 2026;
        job2._endy = 2035;
        job2.Display();

        Resume resume = new Resume();
        resume._personName = "joão Paulo Alves";
        resume.jobs.Add(job1);
        resume.jobs.Add(job2);
        resume.Display();     
    }    
}