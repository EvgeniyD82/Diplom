using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace TestProject1.Diploma.Test
{

    public class StartPage : BaseTest
    {

        [Test]
        public void AddRemoveButton()
        {
            var expectedUrl = "https://app.qase.io/signup";
            //   var driver = new ChromeDriver(@"D:\CD");
            // WebDriver driver = new ChromeDriver();
            //   WebDriver driver = new InternetExplorerDriver();

            //  driver.Quit();

            //  By by = By.LinkText("Add/Remove Elements");
            driver.FindElement(By.LinkText("Start for free")).Click();
            Assert.That(driver.Url, Is.EqualTo(expectedUrl));

            //driver.FindElement(By.TagName("button")).Click();
            //var addedButton = driver.FindElement(By.ClassName("added-manually"));
            //Assert.IsNotNull(addedButton);
            //addedButton.Click();

            //  Assert.That(driver.FindElement(By.ClassName("added-manually")),Is.Empty);

        }
        //[Test]
        //public void OpenGoogleWindow()
        //{
        //    driver.Navigate().GoToUrl("https://google.com/");
        //}

    }
}
