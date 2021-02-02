using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ToolsQAdataDriven.TestDataAccess;

namespace ToolsQA.PageObjects
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "userName")]
        [CacheLookup]
        private IWebElement UserName;

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement Password;

        [FindsBy(How = How.Id, Using = "login")]
        [CacheLookup]
        private IWebElement Submit;

        public void LoginAccount(string testName)
        {
            var userData = ExcelDataAccess.GetTestData(testName);   
            UserName.SendKeys(userData.Username);
            Password.SendKeys(userData.Password);
            Submit.Click();
        }
    }
}
