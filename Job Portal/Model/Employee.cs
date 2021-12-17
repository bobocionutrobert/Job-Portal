using System;
using System.Collections.Generic;
using System.Text;

namespace Job_Portal.Model
{
    public class Employee : User
    {
        private int idemployee;
        private string mobile;
        private string username;
        private string password;

        public Employee(int idemployee, string mobile,string username,string password,int id,string role,string name,string email,int age,string address): base(id, "Employee", name, email, age, address)
        {
            this.idemployee = idemployee;
            this.mobile = mobile;
            this.username = username;
            this.password = password;
        }
        //userid,role,name,email,age,address,employeeid,mobile,username,password
        public Employee(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.idemployee = Int32.Parse(prop[6]);
            this.mobile = prop[7];
            this.username = prop[8];
            this.password = prop[9];
        }

        public int IdEmployee
        {
            get { return this.idemployee; }
            set { this.idemployee = value; }
        }

        public string Mobile
        {
            get { return this.mobile; }
            set { this.mobile = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.idemployee + "," + this.mobile + "," + this.username + "," + this.password;
        }
    }
}
