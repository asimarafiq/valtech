using OpenQA.Selenium.Support.PageObjects;

namespace ValtechTest.Base
{
    public abstract class BasePage :Base
    {
            protected BasePage()
            {
                PageFactory.InitElements(CurrentDriver, this);
            }

            public TPage As<TPage>() where TPage : BasePage
            {
                return (TPage)this;
            }

        }
    }

    