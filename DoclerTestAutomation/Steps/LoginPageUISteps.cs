using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DoclerTestAutomation
{
    [Binding]
    public class LoginPageUISteps
    {

        private IWebDriver _driver;

        public LoginPageUISteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I am on the Home page")]
        public void GivenIAmOnTheHomePage()
        {
            _driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }

        [When(@"I clicks on Form button")]
        public void WhenIClicksOnFormButton()
        {
            _driver.FindElement(By.Id("form")).Click();
        }

        [Then(@"I should land on form page")]
        public void ThenIShouldLandOnFormPage()
        {
            _driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
        }
        
        [Then(@"Input box wit button appears")]
        public void ThenInputBoxWitButtonAppears()
        {
            _driver.FindElement(By.Id("hello-input"));
            _driver.FindElement(By.Id("hello-submit"));
        }
    }
}
