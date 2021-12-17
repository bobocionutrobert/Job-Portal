using Job_Portal.Controller;
using Job_Portal.Model;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Job_Portal_Unit_Tests
{
    public class TestUsers
    {

        
        private ControllerUser control;

        private readonly ITestOutputHelper output;

        public TestUsers(ITestOutputHelper output)
        {

            

            control = new ControllerUser();
            this.output = output;
        }
        [Fact]
        public void TestLoad()
        {

            control.load();

            ControllerUser c = new ControllerUser();

            output.WriteLine(c.ToString());

        }
        [Fact]
        public void TestAddUser()
        {
            Employee u = new Employee("3,Employee,marcel1,marcelemail1,28,craiova,3,0837123902,username1,password1");

            control.addUser(u);

            Assert.Equal("marcel1", control.returnUserById(3).Name);
        }
        [Fact]
        public void TestUpdateName()
        {
            control.load();

            control.updateName(1, "updatedname");

            Assert.Equal("updatedname", control.returnUserById(1).Name);

        }
        [Fact]
        public void TestUpdateEmail()
        {
            control.load();

            control.updateEmail(1, "updatedemail");

            Assert.Equal("updatedemail", control.returnUserById(1).Email);

        }

        [Fact]
        public void TestUpdateAddress()
        {
            control.load();

            control.updateAddress(1, "updatedaddress");

            Assert.Equal("updatedaddress", control.returnUserById(1).Address);

        }
        [Fact]
        public void TestUpdateAge()
        {
            control.load();

            control.updateAge(1, 24);

            Assert.Equal(24, control.returnUserById(1).Age);

        }


    }
}
