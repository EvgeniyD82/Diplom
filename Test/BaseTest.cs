using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Diploma.Test
{
    public class BaseTest
    {
        public WebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Navigate().GoToUrl("https://qase.io/");
        }




        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
