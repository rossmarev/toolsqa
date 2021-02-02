using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

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

      public void LoginAccount()
      {
          UserName.SendKeys("ross");
          Password.SendKeys("pass");
          Submit.Click();
      }
    }
}
