using NUnit.Framework;

namespace WebAddressbookTests;

public class GroupRemovalTest:BaseTest
{
        
        [Test]
        public void GroupRemovalCaseTest()
        {
            OpenHomePage();
            Login(new AccountData("admin","secret"));
            GoToGroupsPage();
            SelectGroup();
            RemoveGroupPage(1);
            ReturnToGroupsPage();
        }
    }


