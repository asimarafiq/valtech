using TechTalk.SpecFlow;
using ValtechTest.Pages;

namespace ValtechTest.Steps
{
    [Binding]
    public class ValtechNavigationSteps : Base.BasePage
    {
        [Given(@"I have navigated to the valtech Homepage")]
        public void GivenThatIHaveNavigatedToTheValtechHomepage()
        {
            CurrentDriver.Navigate().GoToUrl(website);
            CurrentPage = new HomePage();

        }
        
        [When(@"I view the Homepage")]
        public void WhenIViewTheHomepage()
        {
            //This step is here for readability.
        }
        
        [Then(@"the latest news section is displayed")]
        public void ThenTheLatestNewsSectionIsDisplayed()
        {
            CurrentPage.As<HomePage>().checklatestNews();
        }

        [Given(@"I have navigated to the valtech Cases Page")]
        public void GivenIHaveNavigatedToTheValtechCasesPage()
        {
            CurrentPage = CurrentPage.As<HomePage>().clickCasesPagelnk();            
        }

        [When(@"I view the Cases Page")]
        public void WhenIViewTheCasesPage()
        {
            //This step is here for readability.
        }

        [Then(@"the Work header '(.*)' is displayed")]
        public void ThenTheWorkHeaderIsDisplayed(string headerText)
        {
            CurrentPage.As<CasesPage>().checkHeaderWork(headerText);
        }

        [Given(@"I have navigated to the valtech Services Page")]
        public void GivenIHaveNavigatedToTheValtechServicesPage()
        {
            CurrentPage = CurrentPage.As<HomePage>().clickServicesPagelnk();
        }

        [When(@"I view the Services Page")]
        public void WhenIViewTheServicesPage()
        {
            //This step is here for readability.
        }

        [Then(@"the Services header '(.*)' is displayed")]
        public void ThenTheServicesHeaderIsDisplayed(string headerText)
        {
            CurrentPage.As<ServicesPage>().checkHeaderServices(headerText);
        }

        [Given(@"I have navigated to the valtech Job Page")]
        public void GivenIHaveNavigatedToTheValtechJobPage()
        {
            CurrentPage = CurrentPage.As<HomePage>().clickJobsPagelnk();
        }

        [When(@"I view the Job Page")]
        public void WhenIViewTheJobPage()
        {
            //This step is here for readability.
        }

        [Then(@"the Careers header '(.*)' is displayed")]
        public void ThenTheCareersHeaderIsDisplayed(string headerText)
        {
            CurrentPage.As<JobsPage>().checkHeaderCareer(headerText);
        }

        [Given(@"I have navigated to the valtech (.*) Us Page")]
        public void GivenIHaveNavigatedToTheValtechAboutUsPage(string headerText)
        {
            CurrentPage = CurrentPage.As<HomePage>().clickAboutPagelnk();
            CurrentPage.As<AboutPage>().checkHeaderAbout(headerText);
        }

        [When(@"I click on the Valtech Offices link to view the Contact Us page")]
        public void WhenIClickOnTheValtechOfficesLink()
        {
            CurrentPage = CurrentPage.As<AboutPage>().clickValtechOfficeslnk();
        }

        [Then(@"I can count and output the number of valtech offices")]
        public void ThenICanCountAndOutputTheNumberOfValtechOffices()
        {
            CurrentPage.As<ContactusPage>().countValtechOffices();
        }

    }
}
