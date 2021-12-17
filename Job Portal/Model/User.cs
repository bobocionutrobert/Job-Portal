using System;
using System.Collections.Generic;
using System.Text;

namespace Job_Portal.Model
{
    public class User 
    {
        private int id;
        private string role;
        private string name;
        private string email;
        private int age;
        private string address;

        public User(int id,string role,string name,string email,int age,string address)
        {
            this.id = id;
            this.role = role;
            this.name = name;
            this.email = email;
            this.age = age;
            this.address = address;
        }

        public User(string props)
        {
            string[] prop = props.Split(",");
            this.id = Int32.Parse(prop[0]);
            this.role = prop[1];
            this.name = prop[2];
            this.email = prop[3];
            this.age = Int32.Parse(prop[4]);
            this.address = prop[5];
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Role
        {
            get { return this.role; }
            set
            {
                this.role = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public override string ToString()
        {
            return this.id + "," + this.role + "," + this.name + "," + this.email + "," + this.age + "," + this.address;
        }

        public override bool Equals(object obj)
        {
            User user = obj as User;

            return this.id == user.id;
        }
    }
}
