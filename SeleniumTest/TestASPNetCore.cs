using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    class TestASPNetCore
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Intialize()
        {            
            driver.Navigate().GoToUrl("https://localhost:44316");                        
        }

        [Test]
        public void ExecuteTest()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Privacy")).Click();
            Thread.Sleep(2000);
            return;
        }

        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
    }
}
