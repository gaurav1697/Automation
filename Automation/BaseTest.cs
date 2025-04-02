
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Automation
{
    namespace SeleniumAutomation
    {
        public class BaseTest
        {
            protected IWebDriver driver;

            [SetUp]
            public void SetUp()
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com");
            }

            [TearDown]
            public void TearDown()
            {
                driver.Quit();
            }
        }
    }

}
