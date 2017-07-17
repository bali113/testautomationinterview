using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DoclerTestAutomation
{
    [Binding]
    public class ClicksToUITestingButtonOnFormPageSteps
    {
        private IWebDriver _driver;

        public ClicksToUITestingButtonOnFormPageSteps(IWebDriver driver)
        {
            _driver = driver;
        }


        [Given(@"I am on the Form page")]
        public void GivenIAmOnTheFormPage()
        {
            _driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
        }

        [Given(@"Form button active")]
        public void GivenFormButtonActive()
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
