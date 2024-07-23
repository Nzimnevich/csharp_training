using NUnit.Framework;
using OpenQA.Selenium;


namespace WebAddressbookTests;
[TestFixture]
public class ContactCreationTests:BaseTest
{
        
        [Test]
        public void ContactCreationTestCaseTest()
        {
            OpenHomePage();
            Login(new AccountData("admin","secret"));
            ClickAddNewButton();
            ContactData contactData = new ContactData ("Nika", "Zima");
            FillContactForm(contactData);
            SubmitContactCreation();
            ReturnHomePage();
        }

        private void ClickAddNewButton()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void FillContactForm(ContactData contactData)
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook/edit.php");
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).SendKeys(contactData.Name);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).SendKeys(contactData.Lastname);
        }
        
        
    
    }


