using NUnit.Framework;

namespace WebAddressbookTests;

public class GroupRemovalTest:BaseTest
{
        
        [Test]
        public void GroupRemovalCaseTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin","secret"));
            app.Navigator.GoToGroupsPage();
            app.Group.SelectGroup();
            app.Group.RemoveGroupPage(1);
            app.Group.ReturnToGroupsPage();
        }
    }


