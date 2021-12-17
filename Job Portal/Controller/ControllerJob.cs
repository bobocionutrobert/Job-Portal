using Job_Portal.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Job_Portal.Controller
{
    public class ControllerJob
    {

        private List<Job> jobs;

        public ControllerJob()
        {
            jobs = new List<Job>();
            load();

        }

        public int positionbyId(int id)
        {
            for(int i = 0; i < jobs.Count; i++)
            {
                if(jobs[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public Job returnJobById(int id)
        {
            foreach(Job job in jobs)
            {
                if(job.Id == id)
                {
                    return job;
                }
            }
            return null;
        }

        public bool addJob(Job job)
        {
            int poz = positionbyId(job.Id);

            if(poz != -1)
            {
                return false;
            }
            else
            {
                jobs.Add(job);
                return true;
            }
        }

        public bool deleteJob(int id)
        {
            int poz = positionbyId(id);

            if(poz == -1)
            {
                return false;
            }
            else
            {
                jobs.RemoveAt(poz);
                return true;
            }
        }

        public void updateName(int id, string name)
        {
            foreach(Job job in jobs)
            {
                if(job.Id == id)
                {
                    job.Name = name;
                }
            }
        }

        public void updateDescription(int id,string description)
        {
            foreach(Job job in jobs)
            {
                if(job.Id == id)
                {
                    job.Description = description;
                }
            }
        }

        public void updateType(int id, string type)
        {
            foreach(Job job in jobs)
            {
                if (job.Id == id)
                {
                    job.Type = type;
                }
            }
        }

        public void updateJobSearchTitle(int id, string newtitle)
        {
            foreach(Job job in jobs)
            {
                if(job.Id == id)
                {
                    SearchJob search = job as SearchJob;
                    search.Title = newtitle;
                }
            }
        }

        public void updateInterviewDate(int id, string newdate)
        {
            foreach(Job job in jobs)
            {
                if(job.Id == id)
                {
                    Interview interview = job as Interview;

                    interview.Date = newdate;
                }
            }
        }

        public void updateInterviewTitle(int id,string newtitle)
        {
            foreach(Job job in jobs)
            {
                if(job.Id == id)
                {
                    Interview interview = job as Interview;

                    interview.Title = newtitle;
                }
            }
        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Job Portal\Job Portal\Resources\jobs.txt");

            string line = "";

            while((line =read.ReadLine()) != null&&line!="")
            {
                string[] prop = line.Split(",");

                if (prop[4].Equals("Interview"))
                {
                    this.jobs.Add(new Interview(line));
                }
                else
                {
                    this.jobs.Add(new SearchJob(line));
                }
            }
            read.Close();
        }

        public override string ToString()
        {
            string text = "";

            int i = 0;

            for(i = 0; i < jobs.Count-1; i++)
            {
                text += jobs[i].ToString() + "\n";
            }

            text += jobs[i].ToString();

            return text;

         
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Job Portal\Job Portal\Resources\jobs.txt");
            write.Write(this.ToString());
            write.Close();
        }
    }
}
