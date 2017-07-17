using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DoclerTestAutomation.Steps
{
    [Binding]
    public class BrowseToErrorPageSteps
    {

        private IWebDriver _driver;

        public BrowseToErrorPageSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I am on the Form page")]
        public void GivenIAmOnTheFormPage()
        {
            _driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [When(@"I clicks on Error button")]
        public void WhenIClicksOnErrorButton()
        {
            _driver.FindElement(By.Id("error")).Click();
        }
        
        [Then(@"I should land on Error page")]
        public void ThenIShouldLandOnErrorPage()
        {
            _driver.Navigate().GoToUrl("http://uitest.duodecadits.com/error");
        }
        
        [Then(@"I should get a (.*) HTTP response code")]
        public void ThenIShouldGetAHTTPResponseCode(int p0)
        {
            var element = _driver.FindElement(By.XPath("//h1[contains(text(),'404 Error: File not found :-(')]"));
            Assert.That(element.Text, Is.Not.Null,"Header text not found!!");
        }
    }
}
