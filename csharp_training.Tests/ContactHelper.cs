using OpenQA.Selenium;
using WebAddressbookTests;

namespace csharp_training.Tests;

public class ContactHelper:HelperBase
{
    private IWebDriver driver;

    public ContactHelper(IWebDriver driver) :base(driver)
    {
    }
    
    public void ClickAddNewButton()
    {
        driver.FindElement(By.LinkText("add new")).Click();
    }

    public void FillContactForm(ContactData contactData)
    {
        driver.Navigate().GoToUrl("http://localhost/addressbook/edit.php");
        driver.FindElement(By.Name("firstname")).Click();
        driver.FindElement(By.Name("firstname")).SendKeys(contactData.Name);
        driver.FindElement(By.Name("lastname")).Click();
        driver.FindElement(By.Name("lastname")).SendKeys(contactData.Lastname);
    }
}