using OpenQA.Selenium;
using NUnit.Framework;
using Automation.SeleniumAutomation;

namespace Automation
{
    public class Test : BaseTest
    {
        [Test]
        public void GoogleSearch()
        {
            CreateAccountPage createAccountPage = new CreateAccountPage();

            
            driver.FindElement(createAccountPage.CreateButton).Click();
            driver.FindElement(createAccountPage.FirstName).SendKeys("First Name");
            driver.FindElement(createAccountPage.LastName).SendKeys("Last Name");
            driver.FindElement(createAccountPage.FirstName).SendKeys("First Name");
            driver.FindElement(createAccountPage.FirstName).SendKeys("First Name");




            //Assert.IsTrue(driver.Title.Contains("Selenium C# tutorial"));
        }
    }
}
