using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle = "Website Developer";
        job1._companyName = "Windowds";
        job1._startYear = 2006;
        job1._endyear = 2012;
        

        Job job2 = new Job();
        job2._jobTitle = "Database";
        job2._companyName = "Amazon";
        job2._startYear = 2013;
        job2._endyear = 2016;
        
        Resume theResume = new Resume();
        theResume._firstNameOfImployer = "Porter";

        theResume._job.Add(job1);
        theResume._job.Add(job2);

        theResume.Display();
    }
        



        
}