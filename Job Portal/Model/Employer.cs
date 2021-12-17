using System;
using System.Collections.Generic;
using System.Text;

namespace Job_Portal.Model
{
    public class Employer : User
    {

        private int idemployer;
        private string mobile;
        private string username;
        private string password;
        private int salary;

        public Employer(int idemployer, string mobile, string username, string password, int salary, int id, string role, string name, string email, int age, string address) : base(id, "Employee", name, email, age, address)
        {
            this.idemployer = idemployer;
            this.mobile = mobile;
            this.username = username;
            this.password = password;
            this.salary = salary;
        }
        //userid,role,name,email,age,address,employeeid,mobile,username,password,salary
        public Employer(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.idemployer = Int32.Parse(prop[6]);
            this.mobile = prop[7];
            this.username = prop[8];
            this.password = prop[9];
            this.salary = Int32.Parse(prop[10]);
        }

        public int IdEmployer
        {
            get { return this.idemployer; }
            set { this.idemployer = value; }
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
        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.idemployer + "," + this.mobile + "," + this.username + "," + this.password + "," + this.salary;
        }


    }
}
