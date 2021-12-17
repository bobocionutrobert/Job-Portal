using Job_Portal.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Job_Portal.Controller
{
    public class ControllerUser
    {

        private List<User> users;

        public ControllerUser()
        {
            users = new List<User>();

            load();

        }

        public void displayUsers()
        {
            for(int i = 0; i < users.Count; i++)
            {
                Console.WriteLine(users[i].ToString());
            }
        }

        public int positionById(int id)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public User returnUserById(int id)
        {
            foreach(User user in users)
            {
                if(user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public bool addUser(User user)
        {
            int poz = positionById(user.Id);

            if (poz != -1)
            {
                return false;
            }
            else
            {
                users.Add(user);
                return true;
            }
        }

        public bool deleteUser(int id)
        {
            int poz = positionById(id);

            if (poz == 1)
            {
                return false;
            }
            else
            {

                users.RemoveAt(poz);
                return true;
            }
        }

        //update user name,email,age,address

        public void updateName(int id, string name)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.Name = name;
                }
            }
        }

        public void updateEmail(int id, string email)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.Email = email;
                }
            }
        }

        public void updateAddress(int id, string address)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.Address = address;
                }
            }
        }

        public void updateAge(int id, int age)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.Age = age;
                }
            }
        }

        //update Employer mobile/username/password/salary

        public void updateEmployerMobile(int id, string mobile)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Employer employer = user as Employer;

                    employer.Mobile = mobile;
                }
            }
        }

        public void updateEmployerUsername(int id, string username)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Employer employer = user as Employer;

                    employer.Username = username;
                }
            }
        }

        public void updateEmployerPassword(int id, string password)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Employer employer = user as Employer;

                    employer.Password = password;
                }
            }
        }

        public void updateEmployerSalary(int id, int salary)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Employer employer = user as Employer;

                    employer.Salary = salary;
                }
            }
        }

        //update Employee mobile/username/password

        public void updateEmployeeMobile(int id, string mobile)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Employee employee = user as Employee;

                    employee.Mobile = mobile;
                }
            }
        }

        public void updateEmployeeUsername(int id, string username)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Employee employee = user as Employee;

                    employee.Username = username;
                }
            }
        }

        public void updateEmployeePassword(int id, string password)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Employee employee = user as Employee;

                    employee.Password = password;
                }
            }
        }



        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Job Portal\Job Portal\Resources\users.txt");


            string line = "";


            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                if (prop[1].Equals("Employee"))
                {
                    this.users.Add(new Employee(line));

                }
                else
                {
                    this.users.Add(new Employer(line));
                }
            }
            read.Close();
        }

        public override string ToString()
        {
            string text = "";

            this.users.ForEach((user) =>
            {

                text += user.ToString() + "\n";


            });

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Job Portal\Job Portal\Resources\users.txt");
            write.WriteLine(ToString());
            write.Close();
        }
    }
}
