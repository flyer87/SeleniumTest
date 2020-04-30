using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            var urlToGo = "https:www.google.com";
            driver.Navigate().GoToUrl(urlToGo);

            IWebElement el = driver.FindElement(By.Name("q"));
            el.SendKeys("netcompany dk");
            el.SendKeys(Keys.Enter);

            Thread.Sleep(1000);
            Console.WriteLine("Test done");

            driver.Close();
        }
    }
}
