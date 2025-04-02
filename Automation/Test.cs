using NUnit.Framework;
using Automation.SeleniumAutomation;
using NUnit.Framework.Interfaces;

namespace Automation
{
    public class Test : BaseTest
    {
        [Test]
        public void CreateAccountTest()
        {
            CreateAccountPage createAccountPage = new CreateAccountPage();

            //Create Account
            driver.FindElement(createAccountPage.CreateButton).Click();
            driver.FindElement(createAccountPage.FirstName).SendKeys("Test Username");
            driver.FindElement(createAccountPage.LastName).SendKeys("Last Name");
            driver.FindElement(createAccountPage.Email).SendKeys("yy65u@ptct.net");
            driver.FindElement(createAccountPage.Password).SendKeys("Password123");
            driver.FindElement(createAccountPage.PasswordConfirm).SendKeys("Password123");
            driver.FindElement(createAccountPage.CreateAnAccountButton).Click();
        }
    }
}
