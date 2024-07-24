using NUnit.Framework;

namespace WebAddressbookTests;

public class GroupRemovalTest:BaseTest
{
        
        [Test]
        public void GroupRemovalCaseTest()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData("admin","secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.SelectGroup();
            groupHelper.RemoveGroupPage(1);
            groupHelper.ReturnToGroupsPage();
        }
    }


