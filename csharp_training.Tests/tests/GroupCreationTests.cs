using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests;

    [TestFixture]
    public class GroupCreationTestsCase : BaseTest
    {
        [Test]
        public void GroupCreationTestCaseTest()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.InitNewGroupCreation();
            GroupData group = new GroupData("group");
            group.Header = "description";
            group.Footer = "test";
            groupHelper.FillGroupForm(group);
            groupHelper.SubmitGroupCreation();
            groupHelper.ReturnToGroupsPage();
        }
        
    }

