using NUnit.Framework;
using OpenQA.Selenium;


namespace WebAddressbookTests;
[TestFixture]
public class ContactCreationTests:BaseTest
{
        [Test]
        public void ContactCreationTestCaseTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin","secret"));
            app.Contact.ClickAddNewButton();
            ContactData contactData = new ContactData ("Nika", "Zima");
            app.Contact.FillContactForm(contactData);
            app.Group.SubmitContactCreation();
            app.Navigator.ReturnHomePage();
        }
    }


