using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests;

    [TestFixture]
    public class GroupCreationTestsCase : BaseTest
    {
        [Test]
        public void GroupCreationTestCaseTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitNewGroupCreation();
            GroupData group = new GroupData("group");
            group.Header = "description";
            group.Footer = "test";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();

        }

        private void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }
    }

