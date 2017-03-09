using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace ValtechTest.Extensions
{
    public static class WebElementExtensions
    {

        public static bool WaitForElement(this IWebElement element, double timeoutInSeconds = 15)
        {
            try
            {
                var wait = new WebDriverWait(Base.Base.CurrentDriver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(d => element.Displayed);
                return element.Displayed;
            }
            catch(NoSuchElementException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            catch (TimeoutException)
            {
                return false;
            }
        }



    }
}
