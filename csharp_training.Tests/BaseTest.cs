using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests;

public class BaseTest
{
    protected IWebDriver driver;
    protected string baseURL;
        
    [SetUp]
    public void SetupTest()
    {
        driver = new FirefoxDriver();
        baseURL = "http://localhost/";
    }
        
    [TearDown]
    public void TeardownTest()
    {
        try
        {
            driver.Quit();
        }
        catch (Exception)
        {
            // Ignore errors if unable to close the browser
        }
        //  Assert.AreEqual("", verificationErrors.ToString());
    }
    
    protected void OpenHomePage()
    {
        driver.Navigate().GoToUrl(baseURL + "addressbook/");
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);;
            
    }
    
    protected void Login(AccountData accountData)
    {
        driver.FindElement(By.Name("user")).Click();
        driver.FindElement(By.Name("user")).Clear();
        driver.FindElement(By.Name("user")).SendKeys(accountData.Username);
        driver.FindElement(By.Name("pass")).Click();
        driver.FindElement(By.Name("pass")).Clear();
        driver.FindElement(By.Name("pass")).SendKeys(accountData.Password);
        driver.FindElement(By.XPath("//input[@value='Login']")).Click();
    }
    
    protected void GoToGroupsPage()
    {
        driver.FindElement(By.LinkText("groups")).Click();
    }
    
    protected void ReturnToGroupsPage()
    {
        driver.FindElement(By.LinkText("group page")).Click();
    }
    protected void ReturnHomePage()
    {
        driver.FindElement(By.LinkText("home page")).Click();
    }
    
    protected void FillGroupForm(GroupData groupData)
    {
        driver.FindElement(By.Name("group_name")).Click();
        driver.FindElement(By.Name("group_name")).Clear();
        driver.FindElement(By.Name("group_name")).SendKeys(groupData.Name);
        driver.FindElement(By.Name("group_header")).Click();
        driver.FindElement(By.Name("group_header")).Clear();
        driver.FindElement(By.Name("group_header")).SendKeys(groupData.Header);
        driver.FindElement(By.Name("group_footer")).Click();
        driver.FindElement(By.Name("group_footer")).Clear();
        driver.FindElement(By.Name("group_footer")).SendKeys(groupData.Footer);
    }

    protected void InitNewGroupCreation()
    {
        driver.FindElement(By.Name("new")).Click();
    }
    
    protected void SubmitContactCreation()
    {
        driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
    }
    
    protected void RemoveGroupPage(int index)
    {
        driver.FindElement(By.XPath("//div[@id='content']/form/input[" +index+ "]")).Click();
    }

    protected void SelectGroup()
    {
        driver.FindElement(By.XPath("//div[@id='content']/form/span[6]/input")).Click();
    }
}