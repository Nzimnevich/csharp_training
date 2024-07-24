using System;
using OpenQA.Selenium;

namespace WebAddressbookTests;

public class NavigationHelper:HelperBase
{
    private IWebDriver driver;
    private string baseURL;
    
    public NavigationHelper(IWebDriver driver, string baseUrl)
        :base(driver)
    {
        this.baseURL = baseUrl;
    }
    
    public void GoToHomePage()
    {
        driver.Navigate().GoToUrl(baseURL + "addressbook/");
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);;
            
    }
    
    public void GoToGroupsPage()
    {
        driver.FindElement(By.LinkText("groups")).Click();
    }
    
    public void ReturnHomePage()
    {
        driver.FindElement(By.LinkText("home page")).Click();
    }
}