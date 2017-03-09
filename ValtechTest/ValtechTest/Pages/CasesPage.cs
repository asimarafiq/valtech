using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ValtechTest.Extensions;
using ValtechTest.Pages.Base;

namespace ValtechTest.Pages
{
    public class CasesPage : BasePageNavigation
    {
        [FindsBy(How = How.TagName, Using = "h1")]
        private IWebElement headerWork { get; set; }

        public void checkHeaderWork(string headerText)
        {
            Assert.IsTrue(headerWork.WaitForElement(), "The Work header is not displayed");
            Assert.AreEqual(headerWork.Text, headerText);
        }

    }
}
