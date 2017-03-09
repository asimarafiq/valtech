using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ValtechTest.Base;

namespace ValtechTest.Pages.Base
{
    public class BasePageNavigation : BasePage
    {

        [FindsBy(How = How.LinkText, Using = "Work")]
        private IWebElement lnkCasesPage { get; set; }

        [FindsBy(How = How.LinkText, Using = "About")]
        private IWebElement lnkAboutPage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Valtech")]
        private IWebElement lnkHomePage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Careers")]
        private IWebElement lnkJobsPage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Services")]
        private IWebElement lnkServicesPage { get; set; }


        public CasesPage clickCasesPagelnk()
        {
            lnkCasesPage.Click();
            return new CasesPage();
        }

        public AboutPage clickAboutPagelnk()
        {
            lnkAboutPage.Click();
            return new AboutPage();
        }

        public HomePage clickHomePagelnk()
        {
            lnkHomePage.Click();
            return new HomePage();
        }

        public JobsPage clickJobsPagelnk()
        {
            lnkJobsPage.Click();
            return new JobsPage();
        }

        public ServicesPage clickServicesPagelnk()
        {
            lnkServicesPage.Click();
            return new ServicesPage();
        }

    }
}
