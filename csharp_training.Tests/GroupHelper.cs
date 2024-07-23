using OpenQA.Selenium;

namespace  WebAddressbookTests;

public class GroupHelper:HelperBase
{
    private IWebDriver driver;

    public GroupHelper(IWebDriver driver) :base(driver)
    {
    }
    
    
    public void FillGroupForm(GroupData groupData)
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

    public void InitNewGroupCreation()
    {
        driver.FindElement(By.Name("new")).Click();
    }
    
    public void SubmitContactCreation()
    {
        driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
    }
    
    public void SelectGroup()
    {
        driver.FindElement(By.XPath("//div[@id='content']/form/span[6]/input")).Click();
    }
    
    public void RemoveGroupPage(int index)
    {
        driver.FindElement(By.XPath("//div[@id='content']/form/input[" +index+ "]")).Click();
    }
    
    
    public void SubmitGroupCreation()
    {
        driver.FindElement(By.Name("submit")).Click();
    }
    public void ReturnToGroupsPage()
    {
        driver.FindElement(By.LinkText("group page")).Click();
    }
}