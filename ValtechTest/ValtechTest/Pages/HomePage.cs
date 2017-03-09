using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ValtechTest.Pages.Base;

namespace ValtechTest.Pages
{
    public class HomePage : BasePageNavigation
    {
        [FindsBy(How = How.ClassName, Using = "news-post__listing")]
        private IWebElement latestNews { get; set; }

        public void checklatestNews()
        {
            Assert.IsTrue(latestNews.Displayed, "Latest News Section is not displayed");
        }

    }
}
