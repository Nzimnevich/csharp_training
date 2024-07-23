using NUnit.Framework;
using OpenQA.Selenium;


namespace WebAddressbookTests;
[TestFixture]
public class ContactCreationTests:BaseTest
{
        [Test]
        public void ContactCreationTestCaseTest()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData("admin","secret"));
            contactHelper.ClickAddNewButton();
            ContactData contactData = new ContactData ("Nika", "Zima");
            contactHelper.FillContactForm(contactData);
            groupHelper.SubmitContactCreation();
            navigationHelper.ReturnHomePage();
        }
    }


