using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace ValtechTest.Hooks
{
    [Binding]
    public sealed class Hooks1: Base.Base
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
             CurrentDriver = new FirefoxDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CurrentDriver.Quit();
        }
    }
}
