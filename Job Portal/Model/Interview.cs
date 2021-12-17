using System;
using System.Collections.Generic;
using System.Text;

namespace Job_Portal.Model
{
    public class Interview : Job
    {
        private int idinterview;
        private int jobid;
        private string date;
        private string title;


        public Interview(int idinterview,int jobid,string date,string title,int id, int employeeid,string name,string description,string type) : base(id, employeeid, name, description, "Interview")
        {
            this.idinterview = idinterview;
            this.jobid = jobid;
            this.date = date;
            this.title = title;
        }

        public Interview(string props) :base(props)
        {
            string[] prop = props.Split(",");

            this.idinterview = Int32.Parse(prop[5]);
            this.jobid = Int32.Parse(prop[6]);
            this.date = prop[7];
            this.title = prop[8];

        }

        public int IdInterview
        {
            get { return this.idinterview; }
            set { this.idinterview = value; }
        }

        public int JobId
        {
            get { return this.jobid; }
            set { this.jobid = value; }
        }

        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.idinterview + "," + this.jobid + "," + this.date + "," + this.title;
        }

    }

}
