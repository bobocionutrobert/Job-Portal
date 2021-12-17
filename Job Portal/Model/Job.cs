using System;
using System.Collections.Generic;
using System.Text;

namespace Job_Portal.Model
{
    public class Job
    {

        private int id;
        private int employeeid;
        private string name;
        private string description;
        private string type;
        //id,emplyeeid,name,description,type,idjob,title
        public Job(int id, int employeeid,string name,string description,string type)
        {
            this.id = id;
            this.employeeid = employeeid;
            this.name = name;
            this.description = description;
            this.type = type;
        }

        public Job(string props)
        {
            string[] prop = props.Split(",");
            this.id = Int32.Parse(prop[0]);
            this.employeeid = Int32.Parse(prop[1]);
            this.name = prop[2];
            this.description = prop[3];
            this.type = prop[4];
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int EmployeeId
        {
            get { return this.employeeid; }
            set { this.employeeid = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public override string ToString()
        {
            return this.id + "," + this.employeeid + "," + this.name + "," + this.description + "," + this.type;
        }

        public override bool Equals(object obj)
        {
            Job job = obj as Job;

            return this.id == job.id;
        }
    }
}
