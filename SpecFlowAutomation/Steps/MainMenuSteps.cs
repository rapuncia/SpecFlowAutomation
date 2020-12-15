using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.Steps
{
    [Binding]
    public sealed class MainMenuSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public MainMenuSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"customer opens Sportchek site")]
        public void CustomerOpensSportchekSite()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"customer navigates to Women category on navbar")]
        public void CustomerNavigatesToWomenCategoryOnNavbar(string menuItem)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"customer clicks Running subcategory")]
        public void CustomerClicksRunningSubcategory(string option)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Running subcategory page is opened")]
        public void RunningSubcategoryPageIsOpened(string title)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
