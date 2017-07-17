using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DoclerTestAutomation.Steps
{
    [Binding]
    public class HomePageTextsSteps
    {

        private IWebDriver _driver;

        public HomePageTextsSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I am landing on Home page")]
        public void GivenIAmLandingOnHomePage()
        {
            _driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }
        
        [Then(@"the ""(.*)"" text should be visible")]
        public void ThenTheTextShouldBeVisible(string p0)
        {
            var element = _driver.FindElement(By.XPath("//h1[contains(text(),'Welcome to the Docler Holding QA Department')]"));
            Assert.That(element.Text, Is.Not.Null, "Header text not found!!");
        }

        [When(@"the page loads the ""(.*)"" text should be visible")]
        public void WhenThePageLoadsTheTextShouldBeVisible(string p0)
        {
            var element = _driver.FindElement(By.XPath("//p[contains(text(),'This site is dedicated to perform some exercises and demonstrate automated web testing.')]"));
            Assert.That(element.Text, Is.Not.Null, "P text not found!!");
        }
    }
}
