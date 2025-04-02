using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;

namespace Automation
{
    public class CreateAccountPage
    {

        public By CreateButton = By.XPath("(//li/a[normalize-space(text())='Create an Account'])[1]");
        public By FirstName = By.XPath("[id = firstname]");
        public By LastName = By.XPath("[id = lastname]");
        public By Email = By.XPath("[id = email_address]");
        public By Password = By.XPath("[id = password]");
        public By PasswordConfirm = By.XPath("[id = password-confirmation]");
        public By CreateAnAccountButton = By.XPath("//button[@title = 'Create an Account']");

    }
}
