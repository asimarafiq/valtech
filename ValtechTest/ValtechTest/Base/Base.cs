using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ValtechTest.Base
{
    public abstract class Base
    {
            public string website = "https://www.valtech.com/";

            public static IWebDriver CurrentDriver { get; set; }

        public static BasePage CurrentPage
        {
            get
            {
                return ScenarioContext.Current.Get<BasePage>("CurrentPage");
            }
            set
            {
                ScenarioContext.Current["CurrentPage"] = value;
            }
        }
    }

}


