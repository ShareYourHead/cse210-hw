using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Travis Newbry";

        Job job1 = new Job();
        Job job2 = new Job();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        job1._jobTitle = "Deck Swabber";
        job1._company = "The Black Pearl";
        job1._startYear = 1482;
        job1._endYear = 1483;

        job2._jobTitle = "Chronomancer";
        job2._company = "The Red Order of Orthello";
        job2._startYear = 1320;
        job2._endYear = 9999;

        myResume.Display();
    }
}
