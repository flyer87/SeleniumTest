using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class TestGoogle
    {
        static void Main(string[] args)
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var urlToGo = "https:www.google.com";
                driver.Navigate().GoToUrl(urlToGo);

                IWebElement el = driver.FindElement(By.Name("q"));
                el.SendKeys("netcompany dk");
                el.SendKeys(Keys.Enter);

                //driver.FindElement(By.Name("btnK")).Click();
                //elSearch.Click();

                Thread.Sleep(5000);
                Console.WriteLine("Test done");
            }
        }
    }
}
