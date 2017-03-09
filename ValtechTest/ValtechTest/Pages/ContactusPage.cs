using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Diagnostics;
using System.Collections.Generic;
using ValtechTest.Pages.Base;
using ValtechTest.Extensions;

namespace ValtechTest.Pages
{
    public class ContactusPage : BasePageNavigation
    {

        [FindsBy(How = How.ClassName, Using = "contactpage")]
        private IWebElement bodyContact { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".office__heading")]
        private IList<IWebElement> lstOffices { get; set; }

        public void countValtechOffices()
        {
            bodyContact.WaitForElement();
            var officeCount = lstOffices.Count;
            Debug.WriteLine($"There are {officeCount} offices on the valtech contact us page.");
        }

    }
}
