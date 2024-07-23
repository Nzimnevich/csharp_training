using System;
using System.Text;
using csharp_training.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests;

public class BaseTest
{
    protected IWebDriver driver;
    protected string baseURL;
    protected LoginHelper loginHelper;
    protected NavigationHelper navigationHelper;
    protected GroupHelper groupHelper;
    protected ContactHelper contactHelper;
        
    [SetUp]
    public void SetupTest()
    {
        driver = new FirefoxDriver();
        baseURL = "http://localhost/";
        loginHelper = new LoginHelper(driver);
        navigationHelper = new NavigationHelper(driver, baseURL);
        groupHelper = new GroupHelper(driver);
        contactHelper = new ContactHelper(driver);
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
}