using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace ToolsQA.PageObjects
{
    public class HomePage
    {       
        public HomePage(IWebDriver driver)
        {
           PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.Id, Using = "login")]
        [CacheLookup]
        private IWebElement Login;

        public void ClickOnLogin()
        {
            Login.Click();
        }


    }
}
