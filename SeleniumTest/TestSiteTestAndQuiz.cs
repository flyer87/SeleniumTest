using NUnit.Framework;
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
    class TestSiteTestAndQuiz
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Intialize()
        {
            driver.Navigate().GoToUrl("https://www.testandquiz.com/user-login");                    
            Thread.Sleep(3000);
        }

        [Test]
        public void TestLogin()
        {
            //perform browser operations  
            IWebElement emailEl = driver.FindElement(By.Name("email_id"));
            emailEl.SendKeys("y.yumer@gmail.com");          

            IWebElement passEl = driver.FindElement(By.Name("password"));
            passEl.SendKeys("Citi2016");
            Thread.Sleep(2000);

            IWebElement loginBtn = driver.FindElement(By.ClassName("btn-primary"));
            loginBtn.Click();
            Thread.Sleep(2000);

            Assert.AreEqual("Quiz Show | Test And Quiz", driver.Title);            
        }

        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();            
        }
    }
}
