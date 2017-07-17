using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DoclerTestAutomation.Steps
{
    [Binding]
    public class BrowseToFormPageSteps
    {

        private IWebDriver _driver;

        public BrowseToFormPageSteps(IWebDriver driver)
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
        
        [When(@"I clicks on Form button")]
        public void WhenIClicksOnFormButton()
        {
            _driver.FindElement(By.Id("form")).Click();
        }
        
        [Then(@"I should land on From page")]
        public void ThenIShouldLandOnFromPage()
        {
            _driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
        }
        
        [Then(@"From button should turn to active status")]
        public void ThenFromButtonShouldTurnToActiveStatus()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
