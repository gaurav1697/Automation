using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.SeleniumAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using OpenQA.Selenium.Support.UI;

namespace Automation
{
    public class CreateAccountPage : BaseTest
    {
        public By CreateButton = By.XPath("(//li/a[normalize-space(text())='Create an Account'])[1]");
        public By FirstName = By.XPath("//input[@id = 'firstname']");
        public By LastName = By.XPath("//input[@id = 'lastname']");
        public By Email = By.XPath("//input[@id = 'email_address']");
        public By Password = By.XPath("//input[@id = 'password']");
        public By PasswordConfirm = By.XPath("//input[@id = 'password-confirmation']");
        public By CreateAnAccountButton = By.XPath("//button[@title = 'Create an Account']");

    }
}


