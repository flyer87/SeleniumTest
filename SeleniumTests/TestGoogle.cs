using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTests
{
    class TestGoogle
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Intialize()
        {
            var urlToGo = "https:www.google.com";
            driver.Navigate().GoToUrl(urlToGo);
        }

        [Test]
        public void TestSearch()
        {
            IWebElement el = driver.FindElement(By.Name("q"));
            el.SendKeys("netcompany dk");
            el.SendKeys(Keys.Enter);

            Thread.Sleep(1000);
            Console.WriteLine("Test done");
        }

        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
    }
}
