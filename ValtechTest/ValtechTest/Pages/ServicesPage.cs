using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ValtechTest.Extensions;
using ValtechTest.Pages.Base;

namespace ValtechTest.Pages
{
    public class ServicesPage :BasePageNavigation
    {
        [FindsBy(How = How.TagName, Using = "h1")]
        private IWebElement headerServices { get; set; }

        public void checkHeaderServices(string headerText)
        {
            Assert.IsTrue(headerServices.WaitForElement(), "The Services header is not displayed");
            Assert.AreEqual(headerServices.Text, headerText);
        }
    }
}
