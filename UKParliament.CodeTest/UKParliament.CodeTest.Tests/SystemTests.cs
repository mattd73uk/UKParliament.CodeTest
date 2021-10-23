using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace UKParliament.CodeTest.Tests
{
    public class SystemTests
    {
        [Fact]
        public void LoadFirstPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://localhost:5001/");
                string pageTitle = driver.Title;
                Assert.Equal("Person Manager", pageTitle);
            }
        }

        [Fact]
        public void NewPersonButtonExists()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://localhost:5001/");
                IWebElement newPersonButton = driver.FindElement(By.Id("NewPersonButton"));
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                Assert.Equal("Add new person", newPersonButton.Text);
            }
        }
    }
}
