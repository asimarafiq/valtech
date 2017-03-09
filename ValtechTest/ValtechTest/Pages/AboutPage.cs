using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ValtechTest.Extensions;
using ValtechTest.Pages.Base;

namespace ValtechTest.Pages
{
    public class AboutPage : BasePageNavigation
    {
        [FindsBy(How = How.TagName, Using = "h1")]
        private IWebElement headerAbout { get; set; }

        [FindsBy(How = How.LinkText, Using = "Valtech Offices")]
        private IWebElement lnkValtechOffices { get; set; }

        public void checkHeaderAbout(string headerText)
        {
            Assert.IsTrue(headerAbout.WaitForElement(), "The header is not displayed");
            Assert.AreEqual(headerAbout.Text, headerText );
        }

        public ContactusPage clickValtechOfficeslnk()
        {
            lnkValtechOffices.Click();
            return new ContactusPage();
        }

    }
}
