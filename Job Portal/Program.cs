using Job_Portal.Controller;
using Job_Portal.Model;
using System;

namespace Job_Portal
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerJob c = new ControllerJob();

            Interview i = new Interview("3,2,empname2,description2,Interview,3,3,date3,title3");

            c.addJob(i);

            c.Save();

           
        }
    }
}
