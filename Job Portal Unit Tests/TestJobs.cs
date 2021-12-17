using Job_Portal.Controller;
using Job_Portal.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Job_Portal_Unit_Tests
{

    
    public class TestJobs
    {

        private ControllerJob control;

        private readonly ITestOutputHelper output;


        public TestJobs(ITestOutputHelper output)
        {
            this.output = output;
            control = new ControllerJob();
        }

        [Fact]

        public void testLoad()
        {
            control.load();

            ControllerJob c = new ControllerJob();

            output.WriteLine(c.ToString());
        }
        [Fact]
        public void testAdd()
        {
            

            Interview i = new Interview("3,2,empname2,description2,Interview,3,3,date3,title3");

            control.addJob(i);

            Assert.Equal("empname2", control.returnJobById(3).Name);

            
        }
        [Fact]
        public void testSave()
        {

            Interview i = new Interview("4,2,empname2,description2,Interview,3,3,date3,title3");

            control.addJob(i);

            control.Save();

            ControllerJob c = new ControllerJob();

            output.WriteLine(c.ToString());
        }
        [Fact]
        public void testUpdateName()
        {
            control.load();
            control.updateName(3, "newname");

            Assert.Equal("newname", control.returnJobById(3).Name);
        }
        [Fact]
        public void testUpdateDescription()
        {
            control.load();

            control.updateDescription(3, "newdescription");

            Assert.Equal("newdescription", control.returnJobById(3).Description);

        }
        [Fact]
        public void testUpdateInterviewTitle()
        {
            control.load();

            Job j = control.returnJobById(3);

            if(j is Interview interview)
            {
                control.updateInterviewTitle(3, "newtitle");

                Assert.Equal("newtitle", interview.Title);
            }
        }
    }
}
