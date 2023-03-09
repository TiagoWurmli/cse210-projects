using System;

public class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");

        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.DisplayJobDetails();
        }
    }
}