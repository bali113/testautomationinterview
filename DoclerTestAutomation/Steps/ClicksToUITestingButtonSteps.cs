using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DoclerTestAutomation.Steps
{
    [Binding]
    public class ClicksToUITestingButtonSteps
    {
        private IWebDriver _driver;

        public ClicksToUITestingButtonSteps(IWebDriver driver)
        {
            _driver = driver;
        }


        [Given(@"I am on the Home page")]
        public void GivenIAmOnTheHomePage()
        {
            _driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }

        [Given(@"Home button active")]
        public void GivenHomeButtonActive()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I clicks on UI Testing button")]
        public void WhenIClicksOnUITestingButton()
        {
            _driver.FindElement(By.Id("site")).Click();
        }

        [Then(@"I should land on Home page")]
        public void ThenIShouldLandOnHomePage()
        {
            _driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }

        [Then(@"Home button should turn to active status")]
        public void ThenHomeButtonShouldTurnToActiveStatus()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
