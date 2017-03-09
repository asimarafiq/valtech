using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ValtechTest.Extensions;
using ValtechTest.Pages.Base;

namespace ValtechTest.Pages
{
    public class JobsPage : BasePageNavigation
    {

        [FindsBy(How = How.TagName, Using = "h1")]
        private IWebElement headerCareers { get; set; }

        public void checkHeaderCareer(string headerText)
        {
            Assert.IsTrue(headerCareers.WaitForElement(), "The Careers header is not displayed");
            Assert.AreEqual(headerCareers.Text, headerText);
        }

    }
}
