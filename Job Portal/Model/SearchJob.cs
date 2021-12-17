using System;
using System.Collections.Generic;
using System.Text;

namespace Job_Portal.Model
{
    public class SearchJob : Job
    {
        private int idj;
        private string title;

        public SearchJob(int idj, string title, int id, int employeeid, string name, string description,string type) : base(id, employeeid, name, description, "Job")
        {
            this.idj = idj;
            this.title = title;
        }

        public SearchJob(string props) : base(props)
        {
            string[] prop = props.Split(",");

            this.idj = Int32.Parse(prop[5]);
            this.title = prop[6];
        }

        public int Idj
        {
            get { return this.idj; }
            set { this.idj = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.idj + "," + this.title;
        }



    }
}
