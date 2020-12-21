using NUnit.Framework;
using SpecFlowAutomation.Base;
using SpecFlowAutomation.Pages;
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
            HomePage.Instance.OpenSportchekHomePage();
        }

        [When(@"customer navigates to Women category on navbar")]
        public void CustomerNavigatesToWomenCategoryOnNavbar(string menuItem)
        {
            HomePage.Instance.HoverMainMenuItem(menuItem);
        }

        [When(@"customer clicks Running subcategory")]
        public void CustomerClicksRunningSubcategory(string option)
        {
            HomePage.Instance.ClickSubMenuItem(option);
        }

        [Then(@"Running subcategory page is opened")]
        public void RunningSubcategoryPageIsOpened(string title)
        {
            Assert.IsTrue(RunningPage.Instance.IsPageTitleDisplayed(), "Page Title Is Not Displayed");
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
