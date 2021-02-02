using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using DocumentFormat.OpenXml.Spreadsheet;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ToolsQA.TestCases
{
    public class FirstTestCase
    {
        IWebDriver _driver;
        WebDriverWait _wait;

        [SetUp]
        public void Initialize()
        {

          _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));       
          _driver.Manage().Window.Maximize();
             _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }

        [Test]
        [Obsolete]
        public void OpenBrowser()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");
           
                
            var currentWindow = _driver.CurrentWindowHandle;
            IWebElement buttontttt = _driver.FindElement(By.Id("windowButton"));

            for (int i = 0; i < 5; i++)
            {

                buttontttt.Click();

            }

            List<string> windowsOpen = _driver.WindowHandles.ToList();

            foreach (var window in windowsOpen)
            {
                _driver.SwitchTo().Window(window);
                _driver.Close();
            }

        }
        [TearDown]
        public void EndTest()
        {
          // _driver.Quit();

        }
    }
}
    