using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests;

    [TestFixture]
    public class GroupCreationTestsCase : BaseTest
    {
        [Test]
        public void GroupCreationTestCaseTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Group.InitNewGroupCreation();
            GroupData group = new GroupData("group");
            group.Header = "description";
            group.Footer = "test";
            app.Group.FillGroupForm(group);
            app.Group.SubmitGroupCreation();
            app.Group.ReturnToGroupsPage();
        }
        
    }

