using NUnit.Framework;
using System;
using System.Text;
using csharp_training.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace WebAddressbookTests;

public class ApplicationManager
{
        
    protected IWebDriver driver;
    protected string baseURL;
    protected LoginHelper loginHelper;
    protected NavigationHelper navigationHelper;
    protected GroupHelper groupHelper;
    protected ContactHelper contactHelper;
        
    public ApplicationManager()
    {
    
        loginHelper = new LoginHelper(driver);
        navigationHelper = new NavigationHelper(driver, baseURL);
        groupHelper = new GroupHelper(driver);
        contactHelper = new ContactHelper(driver);
    }


 public void Stop(){
    try
        {
            driver.Quit();
        }
        catch (Exception)
        {
            // Ignore errors if unable to close the browser
        }
 }
    public LoginHelper Auth 
    {
        get
        {
            return loginHelper;
        }

    }
public NavigationHelper Navigator
    {
        get
        {
            return navigationHelper;
        }

    }

    public GroupHelper Group
    {
        get
        {
            return groupHelper;
        }

    }

    public ContactHelper Contact
    {
        get
        {
            return contactHelper;
        }

    }

    }