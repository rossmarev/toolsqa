using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ToolsQA.PageObjects;
using SeleniumExtras.PageObjects;
using ToolsQA.TestCases;


namespace ToolsQA.TestCases
{
    public class LoginTest
    {

        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/books");

       
            
           var homePage = new HomePage(driver);
            homePage.ClickOnLogin();


            var loginPage = new LoginPage(driver);
            loginPage.LoginAccount();
        }



    }
}
