using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int waitingTime = 1000;
            By searchIcon = By.Id("PFsearchIcon");
            By searchBar = By.Id("PFsearchBox");
            By result = By.XPath(".//h4//span[text()='Ether 12:30']");

            IWebDriver webDriver = new ChromeDriver();
            
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);

            //webDriver.Navigate().GoToUrl("https://www.churchofjesuschrist.org/study/scriptures?lang=eng&platform=web");
            webDriver.Navigate().GoToUrl("https://www.churchofjesuschrist.org/search?lang=eng&platform=web&query=zerin&facet=scriptures&highlight=true&page=1");
            
            //webDriver.FindElement(searchIcon).Click();
            Thread.Sleep(waitingTime);

            webDriver.FindElement(searchBar).SendKeys("Zerin");
            Thread.Sleep(waitingTime);

            var findResult = webDriver.FindElement(result);
            Assert.IsTrue(findResult.Text.Equals("Ether 12:30"));

        }
    }
}
