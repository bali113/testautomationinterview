using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DoclerTestAutomation
{
    [Binding]
    public class Hooks
    {

        private readonly IObjectContainer _objectContainer;

        private IWebDriver _driver;


        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]

        public void Initialize()
        {
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void TearDownScenario()
        {
            _driver.Quit();
        }
    }
}
